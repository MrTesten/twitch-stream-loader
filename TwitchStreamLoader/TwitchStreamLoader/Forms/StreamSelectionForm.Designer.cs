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
            this.infoLabel = new System.Windows.Forms.Label();
            this.channelList = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // launchStream
            // 
            this.launchStream.BackColor = System.Drawing.SystemColors.Menu;
            this.launchStream.Location = new System.Drawing.Point(12, 37);
            this.launchStream.Name = "launchStream";
            this.launchStream.Size = new System.Drawing.Size(75, 25);
            this.launchStream.TabIndex = 0;
            this.launchStream.Text = "Launch";
            this.launchStream.UseVisualStyleBackColor = false;
            this.launchStream.Click += new System.EventHandler(this.launchStream_Click);
            // 
            // chatButton
            // 
            this.chatButton.Location = new System.Drawing.Point(117, 37);
            this.chatButton.Name = "chatButton";
            this.chatButton.Size = new System.Drawing.Size(75, 25);
            this.chatButton.TabIndex = 4;
            this.chatButton.Text = "Open Chat";
            this.chatButton.UseVisualStyleBackColor = true;
            this.chatButton.Click += new System.EventHandler(this.chatButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.SystemColors.Menu;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.infoLabel.Location = new System.Drawing.Point(12, 69);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(180, 89);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // channelList
            // 
            this.channelList.FormattingEnabled = true;
            this.channelList.Location = new System.Drawing.Point(12, 10);
            this.channelList.Name = "channelList";
            this.channelList.Size = new System.Drawing.Size(180, 21);
            this.channelList.TabIndex = 5;
            // 
            // StreamSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(205, 169);
            this.Controls.Add(this.channelList);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.launchStream);
            this.Name = "StreamSelectionForm";
            this.Text = "Twitch Stream Loader";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button launchStream;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.ComboBox channelList;
    }
}

