﻿using System;
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
    public partial class UserControlPost : UserControlFacebook
    {
        public Post FacebookPost { get; set; }

        public UserControlPost(Post i_Post, User i_User)
        {
            InitializeComponent();
            this.FacebookUser = i_User;
            FacebookPost = i_Post;

            initPost();
        }

        private void initPost()
        {
            this.PictureBoxCommentProfile.LoadAsync(FacebookUser.PictureSqaureURL);
            this.PictureBoxProfile.LoadAsync(FacebookPost.From.PictureSqaureURL);

            this.LabelPostContent.MaximumSize = new Size(550, int.MaxValue);

            this.LabelUserName.Text = FacebookPost.From.Name;
            this.LabelTime.Text = FacebookPost.CreatedTime.ToString();
            this.LabelLikesAmount.Text = FacebookPost.LikedBy.Count.ToString();
            this.LabelPostContent.Text = FacebookPost.Message;

            getComments();
        }

        private void UserControlPost_Load(object sender, EventArgs e)
        {
            Color facebookBlue = Color.FromArgb(54, 88, 153);

            LabelUserName.ForeColor = facebookBlue;
            LabelTime.ForeColor = Color.FromArgb(144, 148, 156);
            LabelPostContent.ForeColor = Color.FromArgb(29, 33, 41);
            LabelLikesAmount.ForeColor = facebookBlue;

            if (FacebookPost.isLikedByUser(FacebookUser))
            {
                this.ButtonPostLike.BackColor = System.Drawing.SystemColors.ButtonFace;
            }
            else
            {
                this.ButtonPostLike.BackColor = Color.White;
            }

            ButtonPostComment.MouseHover += buttonPost_MouseHover;
            ButtonPostLike.MouseHover += buttonPost_MouseHover;

            this.PanelBelowPostContent.Location = new Point(0, this.LabelPostContent.PreferredHeight + this.PanelBelowPostContent.Location.Y);
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

        private void TextBoxComment_Leave(object sender, EventArgs e)
        {
            if (this.TextBoxComment.Text == string.Empty)
            {
                this.TextBoxComment.ForeColor = SystemColors.InactiveCaption;
                this.TextBoxComment.Text = "Write a comment...";
            }
        }

        private void ButtonPostComment_Click(object sender, EventArgs e)
        {
            this.TextBoxComment.Focus();
        }

        private void ButtonPostLike_Click(object sender, EventArgs e)
        {
            if(FacebookPost.isLikedByUser(FacebookUser))
            {
                this.ButtonPostLike.BackColor = Color.White;
                FacebookPost.Unlike();
            }
            else
            {
                this.ButtonPostLike.BackColor = System.Drawing.SystemColors.ButtonFace;
                FacebookPost.Like();
            }
          
            FacebookUser.ReFetch();
            LabelLikesAmount.Text = FacebookPost.LikedBy.Count.ToString();
        }

        private void TextBoxComment_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FacebookPost.Comment(TextBoxComment.Text);
                PanelComments.Controls.Clear();
                this.PanelWriteComment.Location = new Point(0, this.PanelWriteComment.Location.Y + this.PanelComments.Height - 2);

                FacebookUser.ReFetch();

                getComments();

                UserControlPost post = this;
                Control parent = this.Parent;
                int y = post.Location.Y;

                while (post != null)
                {
                    post.Location = new Point(0, y);

                    y += post.Height + 30;

                    post = parent.GetNextControl(post, true) as UserControlPost;
                }
            }
        }

        private void getComments()
        {
            int y = 0;

            foreach (Comment currentComment in FacebookPost.Comments)
            {
                UserControlComment comment = new UserControlComment(currentComment);
                comment.FacebookUser = FacebookUser;
                comment.Location = new Point(0, y);
                y += comment.Height + comment.LabelComment.Height - 20;

                PanelComments.Controls.Add(comment);
            }

            if (FacebookPost.Comments.Count > 0)
            {
                this.PanelWriteComment.Location = new Point(0, y + 69);
            }
        }
    }
}