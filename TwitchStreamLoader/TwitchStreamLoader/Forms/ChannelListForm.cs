using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;

using TwitchStreamLoader.API;
using System.IO;
using System.Net;

namespace TwitchStreamLoader.Forms {
    public partial class ChannelListForm : Form {
        private TwitchAPIHelper twitchAPIHelper;
        public ChannelListForm() {
            InitializeComponent();
        }

        private void ChannelListForm_Load(object sender, EventArgs e) {
            twitchAPIHelper = new TwitchAPIHelper();

            Collection<TwitchStream> streams = twitchAPIHelper.getStreams();
            if (streams != null) {
                channelList.View = View.LargeIcon;
                channelList.LargeImageList = channelImages;
                channelImages.ImageSize = new Size(160, 100);

                foreach (TwitchStream stream in streams) {
                    channelImages.Images.Add(Image.FromStream(new MemoryStream(new WebClient().DownloadData(stream.Preview))));

                    ListViewItem listItem = new ListViewItem();
                    listItem.ImageIndex = channelImages.Images.Count - 1;
                    listItem.Text = stream.ToString();
                    channelList.Items.Add(listItem);
                }
            }
        }
    }
}
