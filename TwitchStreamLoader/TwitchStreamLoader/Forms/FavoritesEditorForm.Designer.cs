namespace TwitchStreamLoader.Forms {
    partial class FavoritesEditorForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.favoritesList = new MetroFramework.Controls.MetroTextBox();
            this.cancelButton = new MetroFramework.Controls.MetroButton();
            this.okayButton = new MetroFramework.Controls.MetroButton();
            this.SuspendLayout();
            // 
            // favoritesList
            // 
            this.favoritesList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.favoritesList.Location = new System.Drawing.Point(10, 30);
            this.favoritesList.Multiline = true;
            this.favoritesList.Name = "favoritesList";
            this.favoritesList.Size = new System.Drawing.Size(180, 230);
            this.favoritesList.TabIndex = 0;
            this.favoritesList.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // cancelButton
            // 
            this.cancelButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cancelButton.Location = new System.Drawing.Point(10, 270);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(85, 20);
            this.cancelButton.TabIndex = 1;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okayButton
            // 
            this.okayButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.okayButton.Location = new System.Drawing.Point(105, 270);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(85, 20);
            this.okayButton.TabIndex = 2;
            this.okayButton.Text = "Okay";
            this.okayButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // FavoritesEditorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 300);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.favoritesList);
            this.Name = "FavoritesEditorForm";
            this.Theme = MetroFramework.MetroThemeStyle.Light;
            this.Load += new System.EventHandler(this.FavoritesEditorForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox favoritesList;
        private MetroFramework.Controls.MetroButton cancelButton;
        private MetroFramework.Controls.MetroButton okayButton;

    }
}