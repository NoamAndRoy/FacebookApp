using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public partial class UserControlComment : UserControlFacebook
    {
        public Comment FacebookComment { get; set; }

        public UserControlComment(Comment i_Comment)
        {
            InitializeComponent();
            initComment(i_Comment);
        }

        private void initComment(Comment i_Comment)
        {
            this.PictureBoxProfile.LoadAsync(i_Comment.From.PictureSqaureURL);

            this.LabelComment.Text = i_Comment.Message;
            this.LabelTime.Text = i_Comment.CreatedTime.ToString();
            this.LabelLikeAmount.Text = i_Comment.LikedBy.Count.ToString();
            this.LabelUserName.Text = i_Comment.From.Name;

            this.FacebookComment = i_Comment;

            this.LabelComment.Location = new Point(this.LabelUserName.Width + this.LabelUserName.Location.X + 3, this.LabelComment.Location.Y);
        }

        private void UserControlComment_Load(object sender, EventArgs e)
        {
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
