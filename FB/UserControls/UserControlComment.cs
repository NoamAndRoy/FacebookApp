using FacebookWrapper.ObjectModel;
using System;
using System.Drawing;

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
            this.LabelLikeAmount.DataBindings.Add("Text", FacebookComment.LikedBy.Count.ToString(), "");
            this.LabelComment.Location = new Point(this.LabelUserName.Width + this.LabelUserName.Location.X + 3, this.LabelComment.Location.Y);
        }

        private void UserControlComment_Load(object sender, EventArgs e)
        {
            this.commentBindingSource.DataSource = FacebookComment;
            this.userBindingSource.DataSource = FacebookUser;
            initComment();

            Color facebookBlue = Color.FromArgb(54, 88, 153);

            LabelLike.ForeColor = facebookBlue;
            LabelUserName.ForeColor = facebookBlue;
            LabelLikeAmount.ForeColor = facebookBlue;

            LabelComment.ForeColor = Color.FromArgb(29, 33, 41);
            LabelTime.ForeColor = Color.FromArgb(144, 148, 156);
            
            this.panelBelowCommentContent.Location = new Point(0, this.LabelComment.PreferredHeight + this.panelBelowCommentContent.Location.Y);

            if (FacebookComment.isLikedByUser(FacebookUser))
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
            if (FacebookComment.isLikedByUser(FacebookUser))
            {
                this.LabelLike.BackColor = Color.WhiteSmoke;
                FacebookComment.Unlike();
            }
            else
            {
                this.LabelLike.BackColor = Color.LightGray;
                FacebookComment.Like();
            }

            FacebookUser.ReFetch();
            LabelLikeAmount.Text = FacebookComment.LikedBy.Count.ToString();
        }
    }
}
