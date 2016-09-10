using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public partial class ProfileForm : MasterForm
    {
        public ProfileForm() 
            : base()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(233, 235, 238);

            this.userControlStatus1.ButtonSubmitStatus.Click += buttonSubmitStatus_Click;
        }

        private void buttonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
            loadPosts();
        }

        protected override void initialize()
        {
            base.initialize();
            this.buttonProfile.BackColor = Color.LightGray;

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
