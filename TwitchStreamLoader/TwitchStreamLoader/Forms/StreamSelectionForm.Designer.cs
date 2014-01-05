namespace TwitchStreamLoader.Forms
{
    partial class StreamSelectionForm
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
            this.launchStream = new System.Windows.Forms.Button();
            this.chatButton = new System.Windows.Forms.Button();
            this.channelLabel = new System.Windows.Forms.Label();
            this.channelList = new System.Windows.Forms.ComboBox();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.viewerLabel = new System.Windows.Forms.Label();
            this.gameLabel = new System.Windows.Forms.Label();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // launchStream
            // 
            this.launchStream.BackColor = System.Drawing.SystemColors.Menu;
            this.launchStream.Location = new System.Drawing.Point(200, 10);
            this.launchStream.Name = "launchStream";
            this.launchStream.Size = new System.Drawing.Size(75, 21);
            this.launchStream.TabIndex = 0;
            this.launchStream.Text = "Launch";
            this.launchStream.UseVisualStyleBackColor = false;
            this.launchStream.Click += new System.EventHandler(this.launchStream_Click);
            // 
            // chatButton
            // 
            this.chatButton.Location = new System.Drawing.Point(285, 10);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(75, 21);
            this.chatButton.TabIndex = 4;
            this.chatButton.Text = "Open Chat";
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // channelLabel
            // 
            this.channelLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.channelLabel.Font = new System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.channelLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.channelLabel.Location = new System.Drawing.Point(88, 34);
            this.channelLabel.Name = "channelLabel";
            this.channelLabel.Size = new System.Drawing.Size(267, 27);
            this.channelLabel.TabIndex = 2;
            this.channelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // channelList
            // 
            this.channelList.FormattingEnabled = true;
            this.channelList.Location = new System.Drawing.Point(10, 10);
            this.channelList.Name = "channelList";
            this.channelList.Size = new System.Drawing.Size(180, 21);
            this.channelList.TabIndex = 5;
            this.channelList.SelectedIndexChanged += new System.EventHandler(this.channelList_SelectedIndexChanged);
            // 
            // logoPicture
            // 
            this.logoPicture.Location = new System.Drawing.Point(10, 34);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(72, 90);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 6;
            this.logoPicture.TabStop = false;
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.titleLabel.Font = new System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.titleLabel.Location = new System.Drawing.Point(88, 81);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(267, 65);
            this.titleLabel.TabIndex = 7;
            // 
            // viewerLabel
            // 
            this.viewerLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.viewerLabel.Font = new System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewerLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.viewerLabel.Location = new System.Drawing.Point(6, 127);
            this.viewerLabel.Name = "viewerLabel";
            this.viewerLabel.Size = new System.Drawing.Size(76, 19);
            this.viewerLabel.TabIndex = 8;
            this.viewerLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameLabel
            // 
            this.gameLabel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.gameLabel.Font = new System.Drawing.Font("HelveticaNeueLT Pro 55 Roman", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.gameLabel.Location = new System.Drawing.Point(88, 61);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(267, 20);
            this.gameLabel.TabIndex = 9;
            // 
            // webBrowser
            // 
            this.webBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser.Location = new System.Drawing.Point(12, 170);
            this.webBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.ScrollBarsEnabled = false;
            this.webBrowser.Size = new System.Drawing.Size(536, 355);
            this.webBrowser.TabIndex = 10;
            // 
            // StreamSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(560, 537);
            this.Controls.Add(this.webBrowser);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.viewerLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.channelList);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.channelLabel);
            this.Controls.Add(this.launchStream);
            this.Name = "StreamSelectionForm";
            this.Text = "Twitch Stream Loader";
            this.Load += new System.EventHandler(this.StreamSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchStream;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Label channelLabel;
        private System.Windows.Forms.ComboBox channelList;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label viewerLabel;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.WebBrowser webBrowser;
    }
}

