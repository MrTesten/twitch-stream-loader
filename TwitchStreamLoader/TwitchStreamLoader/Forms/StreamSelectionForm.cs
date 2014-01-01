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
            string streamName = "trumpsc";
            string quality = "best";

            if (streamNameTextBox.Text != "")
            {
                streamName = streamNameTextBox.Text;
            }

            if (qualityTextBox.Text != "")
            {
                quality = qualityTextBox.Text;
            }

            try
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo();
                processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                processStartInfo.CreateNoWindow = true;
                processStartInfo.UseShellExecute = false;
                processStartInfo.RedirectStandardOutput = true;
                processStartInfo.RedirectStandardError = true;
                processStartInfo.FileName = "C:\\Program Files (x86)\\Livestreamer\\livestreamer.exe";
                processStartInfo.Arguments = "http://www.twitch.tv/" + streamName + " " + quality;

                Process livestreamerProcess = Process.Start(processStartInfo);
                infoLabel.Text = "Launching stream: " + streamName;
            }
            catch (Exception exception)
            {
                infoLabel.Text = "Error: " + exception.Message;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            TwitchAPI twitchAPI = TwitchAPIRequester.makeRequest<TwitchAPI>(Properties.Resources.TwitchApiUrl);
            if (twitchAPI != null)
            {
                infoLabel.Text = twitchAPI.Links.Streams;
            }
            else
            {
                infoLabel.Text = "Invalid request.";
            }
        }
    }
}
