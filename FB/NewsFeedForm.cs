using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
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

            this.userControlStatus1.ButtonSubmitStatus.Click += ButtonSubmitStatus_Click;

            this.buttonNewsFeed.BackColor = Color.LightGray;

            userControlStatus1.PictureBoxProfile.LoadAsync(LoggedInUser.Instance.PictureSqaureURL);
        }

        private void ButtonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
        }

        protected override void initialize()
        {
            base.initialize();
            Thread thread = new Thread(new ThreadStart(loadPosts));
            thread.Start();
        }

        private void loadPosts()
        {
            FacebookObjectCollection<Post> newsFeed = LoggedInUser.Instance.NewsFeed;
            panelPosts.Invoke(new Action(
                () =>
                    {
                        foreach (Post currentPost in newsFeed)
                        {
                            if (currentPost.Message != null)
                            {
                                UserControlPost post = new UserControlPost(currentPost);
                                panelPosts.Controls.Add(post);

                                post.Margin = new Padding(0, 0, 0, 30);
                            }
                        }
                    }

                ));
        }
    }
}
