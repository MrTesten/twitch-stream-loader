using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.ObjectModel;

using TwitchStreamLoader.Contracts;

namespace TwitchStreamLoader.Forms
{
    public partial class StreamSelectionForm : Form
    {
        private TwitchAPIHelper twitchAPIHelper;
        public StreamSelectionForm()
        {
            InitializeComponent();
        }

        private void launchStream_Click(object sender, EventArgs e)
        {
            string quality = Properties.Resources.DefaultQuality;
            TwitchStream stream = (TwitchStream) channelList.SelectedItem;
            if (stream != null)
            {
                StreamLauncher.launchStream(stream.Channel.Url, quality);
            }
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            TwitchStream stream = (TwitchStream)channelList.SelectedItem;
            if (stream != null)
            {
                string channel = stream.Channel.Name;
                Process.Start(Properties.Resources.TwitchChatUrl.Replace(Properties.Resources.TwitchChannelPlaceholder, channel));
            }
        }

        private void StreamSelectionForm_Load(object sender, EventArgs e)
        {
            twitchAPIHelper = new TwitchAPIHelper();

            Collection<TwitchStream> streams = twitchAPIHelper.getStreams();
            if (streams != null)
            {
                foreach (TwitchStream stream in streams)
                {
                    channelList.Items.Add(stream);
                }
                channelList.SelectedIndex = 0;
            }
        }

        private void channelList_SelectedIndexChanged(object sender, EventArgs e)
        {
            TwitchStream stream = (TwitchStream)channelList.SelectedItem;
            if (stream != null)
            {
                channelLabel.Text = stream.Channel.Name;
                gameLabel.Text = stream.Channel.Game;
                titleLabel.Text = stream.Channel.Status;
                viewerLabel.Text = stream.Viewers.ToString();
                
                if (stream.Channel.Logo != null)
                {
                    logoPicture.Load(stream.Channel.Logo);
                }
            }
        }
    }
}
