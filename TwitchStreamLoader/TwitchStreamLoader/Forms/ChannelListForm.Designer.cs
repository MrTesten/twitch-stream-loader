namespace TwitchStreamLoader.Forms
{
    partial class ChannelListForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.channelList = new System.Windows.Forms.ListView();
            this.channelImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // channelList
            // 
            this.channelList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.channelList.BackColor = System.Drawing.SystemColors.ControlDark;
            this.channelList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.channelList.LargeImageList = this.channelImages;
            this.channelList.Location = new System.Drawing.Point(12, 12);
            this.channelList.Name = "channelList";
            this.channelList.Size = new System.Drawing.Size(408, 397);
            this.channelList.SmallImageList = this.channelImages;
            this.channelList.TabIndex = 0;
            this.channelList.UseCompatibleStateImageBehavior = false;
            // 
            // channelImages
            // 
            this.channelImages.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.channelImages.ImageSize = new System.Drawing.Size(16, 16);
            this.channelImages.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // ChannelListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(432, 421);
            this.Controls.Add(this.channelList);
            this.Name = "ChannelListForm";
            this.Text = "Channel List";
            this.Load += new System.EventHandler(this.ChannelListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView channelList;
        private System.Windows.Forms.ImageList channelImages;

    }
}