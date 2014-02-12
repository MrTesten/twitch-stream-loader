using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

using TwitchStreamLoader.API;
using System.Security.Policy;
using System.ComponentModel;
using System.Threading;
using System.IO;
using System.Collections.Specialized;

namespace TwitchStreamLoader.Forms {
    public partial class StreamSelectionForm : Form {
        private TwitchAPIHelper twitchAPIHelper;
        private BackgroundWorker gameBackgroundWorker;
        private BackgroundWorker streamBackgroundWorker;
        private BackgroundWorker videoBackgroundWorker;

        public StreamSelectionForm() {
            InitializeComponent();

            gameBackgroundWorker = new BackgroundWorker();
            gameBackgroundWorker.DoWork += new DoWorkEventHandler(gameBackgroundWorker_DoWork);

            streamBackgroundWorker = new BackgroundWorker();
            streamBackgroundWorker.DoWork += new DoWorkEventHandler(streamBackgroundWorker_DoWork);

            videoBackgroundWorker = new BackgroundWorker();
            videoBackgroundWorker.DoWork += new DoWorkEventHandler(videoBackgroundWorker_DoWork);
        }

        private void StreamSelectionForm_Load(object sender, EventArgs e) {
            twitchAPIHelper = new TwitchAPIHelper();

            if (!gameBackgroundWorker.IsBusy) {
                gameBackgroundWorker.RunWorkerAsync();
            }
        }

        #region Button Click Handlers
        private void launchStream_Click(object sender, EventArgs e) {
            string quality = Properties.Resources.DefaultQuality;
            TwitchStream stream = streamList.SelectedItem as TwitchStream;
            if (stream != null) {
                BackgroundWorker streamProcessWorker = new BackgroundWorker();
                streamProcessWorker.DoWork += delegate {
                    Process streamProcess = StreamLauncher.launchStream(stream.Channel.Url, quality);
                    Console.WriteLine("Stream output:\n" + streamProcess.StandardOutput.ReadToEnd());
                };
                streamProcessWorker.RunWorkerAsync();
            }
        }

        private void chatButton_Click(object sender, EventArgs e) {
            TwitchStream stream = (TwitchStream) streamList.SelectedItem;
            if (stream != null) {
                string channel = stream.Channel.Name;
                Process.Start(Properties.Resources.TwitchChatUrl.Replace(Properties.Resources.TwitchChannelPlaceholder, channel));
            }
        }

        private void refreshButton_Click(object sender, EventArgs e) {
            if (!gameBackgroundWorker.IsBusy) {
                gameBackgroundWorker.RunWorkerAsync();
            }
        }

        private void favoriteButton_Click(object sender, EventArgs e) {
            StringCollection favoriteStreams = Properties.Settings.Default[Properties.Resources.FavoriteStreams] as StringCollection;
            TwitchStream selectedStream = streamList.SelectedItem as TwitchStream;
            if (favoriteStreams != null && selectedStream != null) {
                if (favoriteButton.Text.Equals(Properties.Resources.Favorite)) {
                    if (!favoriteStreams.Contains(selectedStream.Channel.Name)) {
                        favoriteStreams.Add(selectedStream.Channel.Name);
                        Properties.Settings.Default.Save();
                        favoriteButton.Text = Properties.Resources.Unfavorite;
                    }
                } else {
                    if (favoriteStreams.Contains(selectedStream.Channel.Name)) {
                        favoriteStreams.Remove(selectedStream.Channel.Name);
                        Properties.Settings.Default.Save();
                        favoriteButton.Text = Properties.Resources.Favorite;
                    }
                }
            }
        }

        private void vodButton_Click(object sender, EventArgs e) {
            string quality = Properties.Resources.DefaultQuality;
            string time = "000000";
            if (vodTimeText.MaskCompleted) {
                time = vodTimeText.Text;
            }
            string timeString = "?t=" + time.Substring(0, 2) + "h" + time.Substring(3, 2) + "m" + time.Substring(6, 2) + "s";

            TwitchVideo video = videoList.SelectedItem as TwitchVideo;
            if (video != null) {
                BackgroundWorker videoProcessWorker = new BackgroundWorker();
                videoProcessWorker.DoWork += delegate {
                    Process videoProcess = StreamLauncher.launchStream(video.Url + timeString, quality);
                    Console.WriteLine("Video output:\n" + videoProcess.StandardOutput.ReadToEnd());
                };
                videoProcessWorker.RunWorkerAsync();
            }
        }
        #endregion

        #region Combo Box Listeners
        private void gameList_SelectedIndexChanged(object sender, EventArgs e) {
            string game = Properties.Resources.AllGamesString;
            if (gameList.SelectedIndex != -1 && gameList.Items[gameList.SelectedIndex] != null) {
                game = gameList.Items[gameList.SelectedIndex].ToString();
                Properties.Settings.Default[Properties.Resources.LastGame] = game;
                Properties.Settings.Default.Save();
            }

            if (!streamBackgroundWorker.IsBusy) {
                streamBackgroundWorker.RunWorkerAsync(game);
            }
        }

        private void streamList_SelectedIndexChanged(object sender, EventArgs e) {
            TwitchStream stream = (TwitchStream) streamList.SelectedItem;
            if (stream != null) {
                channelLabel.Text = stream.Channel.Name;
                gameLabel.Text = stream.Channel.Game;
                titleLabel.Text = stream.Channel.Status;
                viewerLabel.Text = stream.Viewers.ToString();

                StringCollection favoriteStreams = Properties.Settings.Default[Properties.Resources.FavoriteStreams] as StringCollection;
                if (favoriteStreams != null && favoriteStreams.Contains(stream.Channel.Name)) {
                    favoriteButton.Text = Properties.Resources.Unfavorite;
                } else {
                    favoriteButton.Text = Properties.Resources.Favorite;
                }

                if (stream.Channel.Logo != null) {
                    logoPicture.WaitOnLoad = false;
                    logoPicture.LoadAsync(stream.Channel.Logo);
                }

                if (!videoBackgroundWorker.IsBusy) {
                    videoBackgroundWorker.RunWorkerAsync(stream.Channel.Name);
                }
            }
        }
        #endregion

        #region Background Thread Workers
        private void gameBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            Collection<TwitchTopGame> topGames = twitchAPIHelper.getTopGames();

            Action<Collection<TwitchTopGame>> action = UpdateGamesList;
            this.Invoke(action, topGames);
        }

        private void streamBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            string game = eventArgs.Argument as string;

            Collection<TwitchStream> streams = null;
            if (game.Equals(Properties.Resources.AllGamesString)) {
                streams = twitchAPIHelper.getStreams();
            } else if (game.Equals(Properties.Resources.FavoriteGamesString)) {
                StringCollection savedFavorites = Properties.Settings.Default[Properties.Resources.FavoriteStreams] as StringCollection;
                Collection<string> favoriteStreams = new Collection<string>();
                foreach (string stream in savedFavorites) {
                    favoriteStreams.Add(stream);
                }
                streams = twitchAPIHelper.getStreams(favoriteStreams);
            } else {
                streams = twitchAPIHelper.getStreams(game);
            }
            
            Action<Collection<TwitchStream>> action = UpdateStreamList;
            this.Invoke(action, streams);
        }

        private void videoBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            string channel = eventArgs.Argument as string;
            Collection<TwitchVideo> videos = twitchAPIHelper.getVideos(channel, true);

            Action<Collection<TwitchVideo>> action = UpdateVideoList;
            this.Invoke(action, videos);
        }
        #endregion

        #region Combo Box Updaters
        private void UpdateGamesList(Collection<TwitchTopGame> topGames) {
            gameList.Items.Clear();
            gameList.Items.Add(Properties.Resources.AllGamesString);
            gameList.Items.Add(Properties.Resources.FavoriteGamesString);

            if (topGames != null) {
                foreach (TwitchTopGame topGame in topGames) {
                    gameList.Items.Add(topGame.Game.Name);
                }
            }

            int selectedGame = 0;
            string lastLoadedGame = Properties.Settings.Default[Properties.Resources.LastGame] as string;
            if (lastLoadedGame != null) {
                if (gameList.Items.Contains(lastLoadedGame)) {
                    selectedGame = gameList.Items.IndexOf(lastLoadedGame);
                }
            }
            gameList.SelectedIndex = selectedGame;
        }

        private void UpdateStreamList(Collection<TwitchStream> streams) {
            streamList.Items.Clear();

            if (streams != null) {
                foreach (TwitchStream stream in streams) {
                    streamList.Items.Add(stream);
                }
                streamList.SelectedIndex = 0;
            }
        }

        private void UpdateVideoList(Collection<TwitchVideo> videos) {
            videoList.Items.Clear();

            if (videos != null) {
                foreach (TwitchVideo video in videos) {
                    videoList.Items.Add(video);
                }
                videoList.SelectedIndex = 0;
            }
        }
        #endregion
    }
}
