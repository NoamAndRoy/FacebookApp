using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Threading;
using FacebookWrapper.ObjectModel;
using MosaicGenerator;

namespace FB
{
    public partial class MosaicCreatorForm : MasterForm
    {
        private List<Bitmap> m_Bitmaps;
        private Mosaic m_Mosaic;

        public MosaicCreatorForm()
            : base()
        {
            InitializeComponent();
        }

        private void buttonOpenImage_Click(object sender, EventArgs e)
        {
            if(ProfileImageOpenFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxImage.Text = ProfileImageOpenFileDialog.FileName;
            }
        }

        private void buttonSelectImages_Click(object sender, EventArgs e)
        {
            PictureSelectionForm selectionForm = new PictureSelectionForm();
            if (selectionForm.ShowDialog() == DialogResult.OK)
            {
                m_Bitmaps = new List<Bitmap>(selectionForm.SelectedImages.Count);
                foreach (Image img in selectionForm.SelectedImages)
                {
                    m_Bitmaps.Add(new Bitmap(img));
                }
            }
        }

        private void buttonCreateMosaic_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxImage.Text))
            {
                MessageBox.Show("Select Profile Image");
            }
            else if (m_Bitmaps == null || m_Bitmaps.Count == 0)
            {
                MessageBox.Show("Select images to create to profile image from");
            }
            else
            {
                m_Mosaic = new Mosaic(new Bitmap(textBoxImage.Text));

                Thread mosaicGenerator = new Thread(new ThreadStart(generateMosaic));
                mosaicGenerator.Start();
            }
        }

        private void generateMosaic()
        {
            int pixelSize;
            int.TryParse(textBoxPixelSize.Text, out pixelSize);
            if (pixelSize <= 0 || pixelSize > 50)
            {
                MessageBox.Show("Image size is not in the range (1-50)");
            }
            else
            {
                m_Mosaic.GenerateMosaicFromList(m_Bitmaps, pixelSize);
                pictureBoxMosaic.Image = m_Mosaic.ImageMosaic;
            }
        }

        private void buttonUploadProfileImage_Click(object sender, EventArgs e)
        {
            m_Mosaic.ImageMosaic.Save(m_Mosaic.ImageMosaic.GetHashCode() + ".png");
            LoggedInUser.Instance.PostPhoto(m_Mosaic.ImageMosaic.GetHashCode() + ".png", textBoxTitle.Text);
            File.Delete(m_Mosaic.ImageMosaic.GetHashCode() + ".png");

            MessageBox.Show("The mosaic was uploaded");
        }

        private void textBoxTitle_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = string.Empty;
        }

        private void MosaicCreatorForm_Load(object sender, EventArgs e)
        {
            this.buttonMosiac.BackColor = Color.LightGray;
        }
    }
}