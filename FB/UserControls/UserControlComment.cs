using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public partial class UserControlComment : UserControlFacebook
    {
        public Comment FacebookComment { get; set; }

        public UserControlComment(Comment i_Comment)
        {
            InitializeComponent();
            this.FacebookComment = i_Comment;
        }

        private void initComment()
        {
            this.LabelLikeAmount.DataBindings.Add("Text", FacebookComment.LikedBy.Count.ToString(), string.Empty);
            this.LabelComment.Location = new Point(this.LabelUserName.Width + this.LabelUserName.Location.X + 3, this.LabelComment.Location.Y);
        }

        protected override void initialize()
        {
            this.commentBindingSource.DataSource = FacebookComment;
            this.userBindingSource.DataSource = LoggedInUser.Instance;
            initComment();

            Color facebookBlue = Color.FromArgb(54, 88, 153);

            LabelLike.ForeColor = facebookBlue;
            LabelUserName.ForeColor = facebookBlue;
            LabelLikeAmount.ForeColor = facebookBlue;

            LabelComment.ForeColor = Color.FromArgb(29, 33, 41);
            LabelTime.ForeColor = Color.FromArgb(144, 148, 156);

            this.panelBelowCommentContent.Location = new Point(0, this.LabelComment.PreferredHeight + this.panelBelowCommentContent.Location.Y);

            if (FacebookComment.IsLikedByLoggedInUser())
            {
                this.LabelLike.BackColor = Color.LightGray;
            }
            else
            {
                this.LabelLike.BackColor = Color.WhiteSmoke;
            }
        }

        private void labelLike_MouseHover(object sender, EventArgs e)
        {
            Font underline = new Font(LabelLike.Font, FontStyle.Underline);
            LabelLike.Font = underline;
        }

        private void LabelLike_Click(object sender, EventArgs e)
        {
            if (FacebookComment.IsLikedByLoggedInUser())
            {
                this.LabelLike.BackColor = Color.WhiteSmoke;
                FacebookComment.Unlike();
            }
            else
            {
                this.LabelLike.BackColor = Color.LightGray;
                FacebookComment.Like();
            }

            LoggedInUser.Instance.ReFetch();
            LabelLikeAmount.Text = FacebookComment.LikedBy.Count.ToString();
        }
    }
}
