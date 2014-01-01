using System;
using System.Windows.Forms;
using System.Diagnostics;

using TwitchStreamLoader.Contracts;

namespace TwitchStreamLoader.Forms
{
    public partial class StreamSelectionForm : Form
    {
        public StreamSelectionForm()
        {
            InitializeComponent();
        }

        private void launchStream_Click(object sender, EventArgs e)
        {
            string channel = "trumpsc";
            if (channelTextBox.Text != "")
            {
                channel = channelTextBox.Text;
            }

            string quality = "best";
            if (qualityTextBox.Text != "")
            {
                quality = qualityTextBox.Text;
            }

            string url = null;
            TwitchAPI twitchAPI = TwitchAPIRequester.makeRequest<TwitchAPI>(Properties.Resources.TwitchApiUrl);
            if (twitchAPI != null && channel != "")
            {
                TwitchStreamResponse response = TwitchAPIRequester.makeRequest<TwitchStreamResponse>(twitchAPI.Links.Streams + "/" + channel);
                if (response != null && response.Stream != null && response.Stream.Channel != null && response.Stream.Channel.Url != null)
                {
                    url = response.Stream.Channel.Url;
                    infoLabel.Text = response.Stream.Channel.Name;
                    infoLabel.Text += "\n" + response.Stream.Channel.Status;
                    infoLabel.Text += "\nViewers: " + response.Stream.Viewers;
                }
            }

            if (url != null)
            {
                StreamLauncher.launchStream(url, quality);
            }
        }

        private void chatButton_Click(object sender, EventArgs e)
        {
            string channel = channelTextBox.Text;
            if (channel != "")
            {
                Process.Start(Properties.Resources.TwitchChatUrl.Replace(Properties.Resources.TwitchChannelPlaceholder, channel));
            }
        }
    }
}
