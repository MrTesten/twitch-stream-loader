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
            this.channelTextBox = new System.Windows.Forms.TextBox();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.chatButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // launchStream
            // 
            this.launchStream.BackColor = System.Drawing.SystemColors.Menu;
            this.launchStream.Location = new System.Drawing.Point(117, 62);
            this.launchStream.Name = "launchStream";
            this.launchStream.Size = new System.Drawing.Size(75, 25);
            this.launchStream.TabIndex = 0;
            this.launchStream.Text = "Launch";
            this.launchStream.UseVisualStyleBackColor = false;
            this.launchStream.Click += new System.EventHandler(this.launchStream_Click);
            // 
            // channelTextBox
            // 
            this.channelTextBox.Location = new System.Drawing.Point(12, 12);
            this.channelTextBox.Name = "channelTextBox";
            this.channelTextBox.Size = new System.Drawing.Size(180, 20);
            this.channelTextBox.TabIndex = 1;
            this.channelTextBox.Text = "trumpsc";
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Location = new System.Drawing.Point(12, 38);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(180, 20);
            this.qualityTextBox.TabIndex = 2;
            this.qualityTextBox.Text = "best";
            // 
            // chatButton
            // 
            this.chatButton.Location = new System.Drawing.Point(12, 62);
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
            this.infoLabel.Location = new System.Drawing.Point(12, 95);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(180, 89);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreamSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(205, 195);
            this.Controls.Add(this.chatButton);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.channelTextBox);
            this.Controls.Add(this.launchStream);
            this.Name = "StreamSelectionForm";
            this.Text = "Twitch Stream Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchStream;
        private System.Windows.Forms.TextBox channelTextBox;
        private System.Windows.Forms.TextBox qualityTextBox;
        private System.Windows.Forms.Button chatButton;
        private System.Windows.Forms.Label infoLabel;
    }
}

