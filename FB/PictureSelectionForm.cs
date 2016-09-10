using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public partial class PictureSelectionForm : Form
    { 
        public List<Image> SelectedImages { get; private set; }

        public PictureSelectionForm()
        {
            InitializeComponent();
            SelectedImages = new List<Image>();
        }

        private void pictureSelectionForm_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(initSelectionForm));
            thread.Start();
        }

        private void initSelectionForm()
        {
            AlbumsPanel.Invoke(new Action(
                () =>
                {
                    int y = 0;

                    foreach (Album album in LoggedInUser.Instance.Albums)
                    {
                        if (album.Photos.Count > 0)
                        {
                            UserControlAlbum userAlbum = new UserControlAlbum(album);
                            userAlbum.Location = new Point(0, y);

                            y += userAlbum.Height + 20;

                            AlbumsPanel.Controls.Add(userAlbum);

                            userAlbum.ImagesPanel.ControlAdded += userAlbum_ControlAdded;
                        }
                    }
                }));
        }

        private void userAlbum_ControlAdded(object sender, ControlEventArgs e)
        {
            if(e.Control is PictureBox)
            {
                e.Control.Click += pictureBox_Click;
            }
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            if (!SelectedImages.Contains(picture.Image))
            {
                SelectedImages.Add(picture.Image);
                picture.BorderStyle = BorderStyle.Fixed3D;
            }
            else
            {
                SelectedImages.Remove(picture.Image);
                picture.BorderStyle = BorderStyle.None;
            }
        }

        private void oKButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}
