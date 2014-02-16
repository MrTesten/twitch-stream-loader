using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchStreamLoader.Forms {
    public partial class FavoritesEditorForm : MetroForm {
        public FavoritesEditorForm() {
            InitializeComponent();
        }

        private void FavoritesEditorForm_Load(object sender, EventArgs e) {
            StringCollection favorites = Properties.Settings.Default[Properties.Resources.FavoriteStreams] as StringCollection;
            string[] favoritesArray = new string[favorites.Count];
            favorites.CopyTo(favoritesArray, 0);
            favoritesList.Text = string.Join(Environment.NewLine, favoritesArray);
        }

        private void cancelButton_Click(object sender, EventArgs e) {
            Close();
        }

        private void okayButton_Click(object sender, EventArgs e) {
            string[] newFavorites = favoritesList.Text.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            
            StringCollection favorites = Properties.Settings.Default[Properties.Resources.FavoriteStreams] as StringCollection;
            favorites.Clear();
            favorites.AddRange(newFavorites);
            Properties.Settings.Default.Save();

            Close();
        }
        
    }
}
