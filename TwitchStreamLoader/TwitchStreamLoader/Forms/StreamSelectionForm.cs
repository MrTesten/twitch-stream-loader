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
using System.Net;
using System.Runtime.Serialization.Json;

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
            try
            {
                HttpWebRequest request = WebRequest.Create(Properties.Resources.TwitchApiUrl) as HttpWebRequest;
                request.Accept = Properties.Resources.TwitchAcceptHeader;
                request.Headers["client_id"] = Properties.Resources.ClientId;
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(TwitchAPI));
                    TwitchAPI jsonResponse = jsonSerializer.ReadObject(response.GetResponseStream()) as TwitchAPI;
                    infoLabel.Text = jsonResponse.Links.Streams;
                }
            }
            catch (Exception exception)
            {
                infoLabel.Text = exception.Message;
            }
        }
    }
}
