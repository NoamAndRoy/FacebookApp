using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public partial class NewsFeedForm : MasterForm
    {
        public NewsFeedForm()
            : base()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(233, 235, 238);

            this.MaximumSize = new Size(882, int.MaxValue);

            this.userControlStatus1.ButtonSubmitStatus.Click += buttonSubmitStatus_Click;

            this.buttonNewsFeed.BackColor = Color.LightGray;

            userControlStatus1.PictureBoxProfile.LoadAsync(LoggedInUser.Instance.PictureSqaureURL);
        }

        private void buttonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
            new Thread(loadPosts).Start();
        }

        protected override void initialize()
        {
            base.initialize();
            new Thread(loadPosts).Start();
        }

        private void loadPosts()
        {
            panelPosts.LoadPosts(LoggedInUser.Instance.NewsFeed);
        }
    }
}
