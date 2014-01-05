using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;

namespace TwitchStreamLoader.Forms
{
    public partial class MetroTestForm : MetroForm
    {
        public MetroTestForm()
        {
            InitializeComponent();
        }

        #region Page Buttons
        enum Page { Games, Channels, Favorites, Search, Options };
        Page currentPage = Page.Games;

        private void pictureBoxGamesButton_Click(object sender, EventArgs e)
        {
            currentPage = Page.Games;
            gotoPage(currentPage);
        }

        private void pictureBoxChannelsButton_Click(object sender, EventArgs e)
        {
            currentPage = Page.Channels;
            gotoPage(currentPage);
        }

        private void pictureBoxFavoritesButton_Click(object sender, EventArgs e)
        {
            currentPage = Page.Favorites;
            gotoPage(currentPage);
        }

        private void pictureBoxSearchButton_Click(object sender, EventArgs e)
        {
            currentPage = Page.Search;
            gotoPage(currentPage);
        }

        private void pictureBoxOptionsButton_Click(object sender, EventArgs e)
        {
            currentPage = Page.Options;
            gotoPage(currentPage);
        }

        private void gotoPage(Page currentPage)
        {
            pictureBoxGamesButton.BackColor = pictureBoxChannelsButton.BackColor = pictureBoxFavoritesButton.BackColor = pictureBoxSearchButton.BackColor = pictureBoxOptionsButton.BackColor = Color.Transparent;
            
            if (currentPage == Page.Channels)
                pictureBoxChannelsButton.BackColor = Color.Indigo;
            else if (currentPage == Page.Favorites)
                pictureBoxFavoritesButton.BackColor = Color.Indigo;
            else if (currentPage == Page.Search)
                pictureBoxSearchButton.BackColor = Color.Indigo;
            else if (currentPage == Page.Options)
                pictureBoxOptionsButton.BackColor = Color.Indigo;
            else
                pictureBoxGamesButton.BackColor = Color.Indigo;
        }
        #endregion Page Buttons

        
    }
}
