namespace TwitchStreamLoader
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
            this.streamNameTextBox = new System.Windows.Forms.TextBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.qualityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // launchStream
            // 
            this.launchStream.Location = new System.Drawing.Point(197, 12);
            this.launchStream.Name = "launchStream";
            this.launchStream.Size = new System.Drawing.Size(75, 46);
            this.launchStream.TabIndex = 0;
            this.launchStream.Text = "Launch";
            this.launchStream.UseVisualStyleBackColor = true;
            this.launchStream.Click += new System.EventHandler(this.launchStream_Click);
            // 
            // streamNameTextBox
            // 
            this.streamNameTextBox.Location = new System.Drawing.Point(12, 12);
            this.streamNameTextBox.Name = "streamNameTextBox";
            this.streamNameTextBox.Size = new System.Drawing.Size(179, 20);
            this.streamNameTextBox.TabIndex = 1;
            this.streamNameTextBox.Text = "trumpsc";
            // 
            // infoLabel
            // 
            this.infoLabel.Location = new System.Drawing.Point(12, 77);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(260, 31);
            this.infoLabel.TabIndex = 2;
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // qualityTextBox
            // 
            this.qualityTextBox.Location = new System.Drawing.Point(12, 38);
            this.qualityTextBox.Name = "qualityTextBox";
            this.qualityTextBox.Size = new System.Drawing.Size(179, 20);
            this.qualityTextBox.TabIndex = 2;
            this.qualityTextBox.Text = "best";
            // 
            // StreamSelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 117);
            this.Controls.Add(this.qualityTextBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.streamNameTextBox);
            this.Controls.Add(this.launchStream);
            this.Name = "StreamSelectionForm";
            this.Text = "Twitch Stream Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button launchStream;
        private System.Windows.Forms.TextBox streamNameTextBox;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox qualityTextBox;
    }
}

