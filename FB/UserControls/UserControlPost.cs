using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public partial class UserControlPost : UserControlFacebook
    {
        public Post FacebookPost { get; set; }

        public UserControlPost(Post i_Post)
        {
            InitializeComponent();
            FacebookPost = i_Post;
        }

        protected override void initialize()
        {
            Color facebookBlue = Color.FromArgb(54, 88, 153);

            LabelUserName.ForeColor = facebookBlue;
            LabelTime.ForeColor = Color.FromArgb(144, 148, 156);
            LabelPostContent.ForeColor = Color.FromArgb(29, 33, 41);
            LabelLikesAmount.ForeColor = facebookBlue;

            if (FacebookPost.IsLikedByLoggedInUser())
            {
                this.ButtonPostLike.BackColor = SystemColors.ButtonFace;
            }
            else
            {
                this.ButtonPostLike.BackColor = Color.White;
            }

            ButtonPostComment.MouseHover += buttonPost_MouseHover;
            ButtonPostLike.MouseHover += buttonPost_MouseHover;

            this.PanelBelowPostContent.Location = new Point(0, this.LabelPostContent.PreferredHeight + this.PanelBelowPostContent.Location.Y);

            this.postBindingSource.DataSource = FacebookPost;
            this.userBindingSource.DataSource = LoggedInUser.Instance;
            initPost();
        }

        private void initPost()
        {
            this.LabelPostContent.MaximumSize = new Size(550, int.MaxValue);
            this.LabelLikesAmount.DataBindings.Add("Text", FacebookPost.LikedBy.Count.ToString(), string.Empty);

            Thread thread = new Thread(new ThreadStart(getComments));
            thread.Start();
        }

        private void buttonPost_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;

            if (button != null)
            {
                Font underline = new Font(button.Font, FontStyle.Underline);
            }
        }

        private void textBoxComment_Enter(object sender, EventArgs e)
        {
            this.TextBoxComment.ForeColor = Color.Black;
            this.TextBoxComment.Text = string.Empty;
        }

        private void textBoxComment_Leave(object sender, EventArgs e)
        {
            if (this.TextBoxComment.Text == string.Empty)
            {
                this.TextBoxComment.ForeColor = SystemColors.InactiveCaption;
                this.TextBoxComment.Text = "Write a comment...";
            }
        }

        private void buttonPostComment_Click(object sender, EventArgs e)
        {
            this.TextBoxComment.Focus();
        }

        private void buttonPostLike_Click(object sender, EventArgs e)
        {
            if(FacebookPost.IsLikedByLoggedInUser())
            {
                this.ButtonPostLike.BackColor = Color.White;
                FacebookPost.Unlike();
            }
            else
            {
                this.ButtonPostLike.BackColor = SystemColors.ButtonFace;
                FacebookPost.Like();
            }

            LoggedInUser.Instance.ReFetch();
            LabelLikesAmount.Text = FacebookPost.LikedBy.Count.ToString();
        }

        private void textBoxComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FacebookPost.Comment(TextBoxComment.Text);
                PanelComments.Controls.Clear();
                this.PanelWriteComment.Location = new Point(0, this.PanelWriteComment.Location.Y + this.PanelComments.Height - 2);

                LoggedInUser.Instance.ReFetch();

                getComments();

                UserControlPost post = this;
                Control parent = this.Parent;
                int y = post.Location.Y;

                while (post != null)
                {
                    post.Location = new Point(0, y);

                    y += post.Height + 300;

                    post = parent.GetNextControl(post, true) as UserControlPost;
                }
            }
        }

        private void getComments()
        {
            FacebookObjectCollection<Comment> comments = FacebookPost.Comments;
            PanelComments.Invoke(new Action(
                () =>
                    {
                        int y = 0;

                        foreach (Comment currentComment in comments)
                        {
                            UserControlComment comment = new UserControlComment(currentComment);
                            comment.Location = new Point(0, y);
                            y += comment.Height + comment.LabelComment.Height - 20;

                            PanelComments.Controls.Add(comment);
                        }

                        if (FacebookPost.Comments.Count > 0)
                        {
                            this.PanelWriteComment.Location = new Point(0, y + 69);
                        }
                }

                ));
        }
    }
}
