using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

using TwitchStreamLoader.Contracts;
using System.Security.Policy;
using System.ComponentModel;
using System.Threading;
using System.IO;

namespace TwitchStreamLoader.Forms {
    public partial class StreamSelectionForm : Form {
        private TwitchAPIHelper twitchAPIHelper;
        private BackgroundWorker gameBackgroundWorker;
        private BackgroundWorker streamBackgroundWorker;

        public StreamSelectionForm() {
            InitializeComponent();

            gameBackgroundWorker = new BackgroundWorker();
            gameBackgroundWorker.DoWork += new DoWorkEventHandler(gameBackgroundWorker_DoWork);

            streamBackgroundWorker = new BackgroundWorker();
            streamBackgroundWorker.DoWork += new DoWorkEventHandler(streamBackgroundWorker_DoWork);
        }

        private void launchStream_Click(object sender, EventArgs e) {
            string quality = Properties.Resources.DefaultQuality;
            TwitchStream stream = (TwitchStream) streamList.SelectedItem;
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

        private void StreamSelectionForm_Load(object sender, EventArgs e) {
            twitchAPIHelper = new TwitchAPIHelper();

            gameBackgroundWorker.RunWorkerAsync();
        }

        private void gameList_SelectedIndexChanged(object sender, EventArgs e) {
            string game = Properties.Resources.AllGamesString;
            if (gameList.SelectedIndex != -1 && gameList.Items[gameList.SelectedIndex] != null) {
                game = gameList.Items[gameList.SelectedIndex].ToString();
            }

            streamBackgroundWorker.RunWorkerAsync(game);
        }

        private void streamList_SelectedIndexChanged(object sender, EventArgs e) {
            TwitchStream stream = (TwitchStream) streamList.SelectedItem;
            if (stream != null) {
                channelLabel.Text = stream.Channel.Name;
                gameLabel.Text = stream.Channel.Game;
                titleLabel.Text = stream.Channel.Status;
                viewerLabel.Text = stream.Viewers.ToString();

                if (stream.Channel.Logo != null) {
                    logoPicture.Load(stream.Channel.Logo);
                }
            }
        }

        private void gameBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            Collection<TwitchTopGame> topGames = twitchAPIHelper.getTopGames();

            Action<Collection<TwitchTopGame>> action = UpdateGamesList;
            this.Invoke(action, topGames);
        }

        private void streamBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            string game = eventArgs.Argument as string;

            Collection<TwitchStream> streams = null;
            if (game != Properties.Resources.AllGamesString) {
                streams = twitchAPIHelper.getStreams(game);
            } else {
                streams = twitchAPIHelper.getStreams();
            }
            
            Action<Collection<TwitchStream>> action = UpdateStreamList;
            this.Invoke(action, streams);
        }

        private void UpdateGamesList(Collection<TwitchTopGame> topGames) {
            gameList.Items.Clear();
            gameList.Items.Add(Properties.Resources.AllGamesString);

            if (topGames != null) {
                foreach (TwitchTopGame topGame in topGames) {
                    gameList.Items.Add(topGame.Game.Name);
                }
                gameList.SelectedIndex = 0;
            }
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
    }
}
