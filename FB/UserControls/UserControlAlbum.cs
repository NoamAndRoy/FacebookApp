using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public partial class UserControlAlbum : UserControlFacebook
    {
        private const int k_ImageSize = 75;

        public Album FacebookAlbum { get; set; }

        public List<Image> SelectedImages { get; private set; }

        public UserControlAlbum(Album i_Album)
        {
            InitializeComponent();
            FacebookAlbum = i_Album;

            SelectedImages = new List<Image>();
        }

        private void initAlbum()
        {
            AlbumNameLabel.Text = FacebookAlbum.Name;

            int x = 0;
            int y = 0;

            foreach(Photo photo in FacebookAlbum.Photos)
            {
                PictureBox picture = new PictureBox();
                picture.LoadAsync(photo.PictureThumbURL);
                picture.Location = new Point(x, y);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Size = new Size(k_ImageSize, k_ImageSize);

                ImagesPanel.Controls.Add(picture);

                x += k_ImageSize + 10;
                if(x >= ImagesPanel.Width - k_ImageSize - 10)
                {
                    x = 0;
                    y += k_ImageSize + 10;
                }
            }
        }

        private void UserControlAlbum_Load(object sender, EventArgs e)
        {
            ImagesPanel.BeginInvoke(new Action(initAlbum));
        }
    }
}
