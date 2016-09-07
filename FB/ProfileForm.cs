using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public partial class ProfileForm : MasterForm
    {
        public ProfileForm(User i_User) 
            : base(i_User)
        {
            InitializeComponent();

            this.userControlProfile1.FacebookUser = m_User;
            this.userControlStatus1.FacebookUser = m_User;

            this.BackColor = Color.FromArgb(233, 235, 238);

            this.userControlStatus1.ButtonSubmitStatus.Click += ButtonSubmitStatus_Click;
        }

        private void ButtonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
            loadPosts();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            this.buttonProfile.BackColor = Color.LightGray;

            panelPosts.BeginInvoke(new Action(loadPosts));
        }

        private void loadPosts()
        {
            FacebookObjectCollection<Post> newsFeed = m_User.NewsFeed;
            panelPosts.Invoke(new Action(
                () =>
                {
                    foreach (Post currentPost in newsFeed)
                    {
                        if (currentPost.Message != null)
                        {
                            UserControlPost post = new UserControlPost(currentPost, m_User);
                            panelPosts.Controls.Add(post);

                            post.Margin = new Padding(0, 0, 0, 30);
                        }
                    }
                }
             ));
        }
    }
}
