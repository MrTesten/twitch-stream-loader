using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace TwitchStreamLoader
{
    public partial class StreamSelectionForm : Form
    {
        public StreamSelectionForm()
        {
            InitializeComponent();
        }

        private void launchStream_Click(object sender, EventArgs e)
        {
            String streamName = "trumpsc";
            String quality = "best";

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
    }
}
