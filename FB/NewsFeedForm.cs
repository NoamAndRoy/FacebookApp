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
        public NewsFeedForm(User i_User)
            : base(i_User)
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(233, 235, 238);

            this.MaximumSize = new Size(882, int.MaxValue);

            this.userControlStatus1.ButtonSubmitStatus.Click += ButtonSubmitStatus_Click;
        }

        private void ButtonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
            panelPosts.BeginInvoke(new Action(getPosts));
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            this.buttonNewsFeed.BackColor = Color.LightGray;

            userControlStatus1.PictureBoxProfile.LoadAsync(m_User.PictureSqaureURL);

            panelPosts.BeginInvoke(new Action(getPosts));
        }

        private void getPosts()
        {
            int y = 0;

            foreach (Post currentPost in m_User.NewsFeed)
            {
                if (currentPost.Message != null)
                {
                    UserControlPost post = new UserControlPost(currentPost, m_User);
                    post.Location = new Point(0, y);
                    
                    y += post.Height + post.LabelPostContent.Height + 30;

                    if (currentPost.Comments.Count > 0)
                    {
                        y += post.PanelComments.Height;
                    }

                    panelPosts.Controls.Add(post);
                }
            }
        }
    }
}
