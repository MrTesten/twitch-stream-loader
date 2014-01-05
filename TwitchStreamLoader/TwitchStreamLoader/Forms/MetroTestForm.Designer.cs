namespace TwitchStreamLoader.Forms
{
    partial class MetroTestForm
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.pictureBoxRefreshButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxOptionsButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxFavoritesButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxSearchButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxChannelsButton = new System.Windows.Forms.PictureBox();
            this.pictureBoxGamesButton = new System.Windows.Forms.PictureBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptionsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoritesButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannelsButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesButton)).BeginInit();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.metroPanel1.Controls.Add(this.pictureBoxRefreshButton);
            this.metroPanel1.Controls.Add(this.pictureBoxOptionsButton);
            this.metroPanel1.Controls.Add(this.pictureBoxFavoritesButton);
            this.metroPanel1.Controls.Add(this.pictureBoxSearchButton);
            this.metroPanel1.Controls.Add(this.pictureBoxChannelsButton);
            this.metroPanel1.Controls.Add(this.pictureBoxGamesButton);
            this.metroPanel1.CustomBackground = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 5);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(50, 495);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // pictureBoxRefreshButton
            // 
            this.pictureBoxRefreshButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxRefreshButton.Image = global::TwitchStreamLoader.Properties.Resources.TempRefreshButton;
            this.pictureBoxRefreshButton.Location = new System.Drawing.Point(0, 440);
            this.pictureBoxRefreshButton.Name = "pictureBoxRefreshButton";
            this.pictureBoxRefreshButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxRefreshButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxRefreshButton.TabIndex = 6;
            this.pictureBoxRefreshButton.TabStop = false;
            // 
            // pictureBoxOptionsButton
            // 
            this.pictureBoxOptionsButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxOptionsButton.Image = global::TwitchStreamLoader.Properties.Resources.TempOptionsButton;
            this.pictureBoxOptionsButton.Location = new System.Drawing.Point(0, 325);
            this.pictureBoxOptionsButton.Name = "pictureBoxOptionsButton";
            this.pictureBoxOptionsButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxOptionsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxOptionsButton.TabIndex = 5;
            this.pictureBoxOptionsButton.TabStop = false;
            this.pictureBoxOptionsButton.Click += new System.EventHandler(this.pictureBoxOptionsButton_Click);
            // 
            // pictureBoxFavoritesButton
            // 
            this.pictureBoxFavoritesButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxFavoritesButton.Image = global::TwitchStreamLoader.Properties.Resources.TempFavoritesButton;
            this.pictureBoxFavoritesButton.Location = new System.Drawing.Point(0, 175);
            this.pictureBoxFavoritesButton.Name = "pictureBoxFavoritesButton";
            this.pictureBoxFavoritesButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxFavoritesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxFavoritesButton.TabIndex = 4;
            this.pictureBoxFavoritesButton.TabStop = false;
            this.pictureBoxFavoritesButton.Click += new System.EventHandler(this.pictureBoxFavoritesButton_Click);
            // 
            // pictureBoxSearchButton
            // 
            this.pictureBoxSearchButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxSearchButton.Image = global::TwitchStreamLoader.Properties.Resources.TempSearchButton;
            this.pictureBoxSearchButton.Location = new System.Drawing.Point(0, 250);
            this.pictureBoxSearchButton.Name = "pictureBoxSearchButton";
            this.pictureBoxSearchButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxSearchButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxSearchButton.TabIndex = 3;
            this.pictureBoxSearchButton.TabStop = false;
            this.pictureBoxSearchButton.Click += new System.EventHandler(this.pictureBoxSearchButton_Click);
            // 
            // pictureBoxChannelsButton
            // 
            this.pictureBoxChannelsButton.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxChannelsButton.Image = global::TwitchStreamLoader.Properties.Resources.TempChannelsButton;
            this.pictureBoxChannelsButton.Location = new System.Drawing.Point(0, 100);
            this.pictureBoxChannelsButton.Name = "pictureBoxChannelsButton";
            this.pictureBoxChannelsButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxChannelsButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxChannelsButton.TabIndex = 2;
            this.pictureBoxChannelsButton.TabStop = false;
            this.pictureBoxChannelsButton.Click += new System.EventHandler(this.pictureBoxChannelsButton_Click);
            // 
            // pictureBoxGamesButton
            // 
            this.pictureBoxGamesButton.BackColor = System.Drawing.Color.Indigo;
            this.pictureBoxGamesButton.Image = global::TwitchStreamLoader.Properties.Resources.TempGamesButton;
            this.pictureBoxGamesButton.Location = new System.Drawing.Point(0, 25);
            this.pictureBoxGamesButton.Name = "pictureBoxGamesButton";
            this.pictureBoxGamesButton.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxGamesButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxGamesButton.TabIndex = 1;
            this.pictureBoxGamesButton.TabStop = false;
            this.pictureBoxGamesButton.Click += new System.EventHandler(this.pictureBoxGamesButton_Click);
            // 
            // MetroTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 500);
            this.Controls.Add(this.metroPanel1);
            this.MaximizeBox = false;
            this.Name = "MetroTestForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Purple;
            this.Text = "     Twitch Desktop";
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRefreshButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxOptionsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoritesButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSearchButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxChannelsButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGamesButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.PictureBox pictureBoxGamesButton;
        private System.Windows.Forms.PictureBox pictureBoxRefreshButton;
        private System.Windows.Forms.PictureBox pictureBoxOptionsButton;
        private System.Windows.Forms.PictureBox pictureBoxFavoritesButton;
        private System.Windows.Forms.PictureBox pictureBoxSearchButton;
        private System.Windows.Forms.PictureBox pictureBoxChannelsButton;
    }
}