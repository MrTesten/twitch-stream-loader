using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

using TwitchStreamLoader.Contracts;
using System.Security.Policy;
using System.ComponentModel;

namespace TwitchStreamLoader.Forms {
    public partial class StreamSelectionForm : Form {
        private TwitchAPIHelper twitchAPIHelper;
        private BackgroundWorker gameBackgroundWorker;
        private BackgroundWorker channelBackgroundWorker;

        public StreamSelectionForm() {
            InitializeComponent();

            gameBackgroundWorker = new BackgroundWorker();
            gameBackgroundWorker.DoWork += new DoWorkEventHandler(gameBackgroundWorker_DoWork);

            channelBackgroundWorker = new BackgroundWorker();
            channelBackgroundWorker.DoWork += new DoWorkEventHandler(channelBackgroundWorker_DoWork);
        }

        private void launchStream_Click(object sender, EventArgs e) {
            string quality = Properties.Resources.DefaultQuality;
            TwitchStream stream = (TwitchStream) channelList.SelectedItem;
            if (stream != null) {
                StreamLauncher.launchStream(stream.Channel.Url, quality);
            }
        }

        private void chatButton_Click(object sender, EventArgs e) {
            TwitchStream stream = (TwitchStream) channelList.SelectedItem;
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

            channelBackgroundWorker.RunWorkerAsync(game);
        }

        private void channelList_SelectedIndexChanged(object sender, EventArgs e) {
            TwitchStream stream = (TwitchStream) channelList.SelectedItem;
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

        private void channelBackgroundWorker_DoWork(object sender, DoWorkEventArgs eventArgs) {
            string game = eventArgs.Argument as string;

            Collection<TwitchStream> streams = null;
            if (game != Properties.Resources.AllGamesString) {
                streams = twitchAPIHelper.getStreams(game);
            } else {
                streams = twitchAPIHelper.getStreams();
            }

            Action<Collection<TwitchStream>> action = UpdateChannelList;
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

        private void UpdateChannelList(Collection<TwitchStream> streams) {
            channelList.Items.Clear();

            if (streams != null) {
                foreach (TwitchStream stream in streams) {
                    channelList.Items.Add(stream);
                }
                channelList.SelectedIndex = 0;
            }
        }
    }
}
