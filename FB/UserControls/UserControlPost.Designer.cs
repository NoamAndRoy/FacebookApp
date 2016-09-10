namespace FB.UserControls
{
    public partial class UserControlPost
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlPost));
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.LabelUserName = new System.Windows.Forms.Label();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelPostContent = new System.Windows.Forms.Label();
            this.Panel2 = new System.Windows.Forms.Panel();
            this.PanelPostLikeAmount = new System.Windows.Forms.Panel();
            this.LabelLikesAmount = new System.Windows.Forms.Label();
            this.PictureBoxLikesAmount = new System.Windows.Forms.PictureBox();
            this.PanelComments = new System.Windows.Forms.Panel();
            this.PanelWriteComment = new System.Windows.Forms.Panel();
            this.panelCommentTextBox = new System.Windows.Forms.Panel();
            this.TextBoxComment = new System.Windows.Forms.TextBox();
            this.PictureBoxCommentProfile = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ButtonPostLike = new System.Windows.Forms.Button();
            this.ButtonPostComment = new System.Windows.Forms.Button();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.PanelBelowPostContent = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            this.PanelPostLikeAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLikesAmount)).BeginInit();
            this.PanelWriteComment.SuspendLayout();
            this.panelCommentTextBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCommentProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.PanelBelowPostContent.SuspendLayout();
            this.SuspendLayout();
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.postBindingSource, "From.ImageSmall", true));
            this.PictureBoxProfile.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxProfile.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(40, 40);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 2;
            this.PictureBoxProfile.TabStop = false;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "From.Name", true));
            this.LabelUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelUserName.Location = new System.Drawing.Point(62, 14);
            this.LabelUserName.Margin = new System.Windows.Forms.Padding(0);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(52, 18);
            this.LabelUserName.TabIndex = 3;
            this.LabelUserName.Text = "label1";
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "CreatedTime", true));
            this.LabelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelTime.Location = new System.Drawing.Point(62, 34);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(45, 16);
            this.LabelTime.TabIndex = 4;
            this.LabelTime.Text = "label1";
            // 
            // LabelPostContent
            // 
            this.LabelPostContent.AutoSize = true;
            this.LabelPostContent.BackColor = System.Drawing.Color.White;
            this.LabelPostContent.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.LabelPostContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelPostContent.Location = new System.Drawing.Point(10, 57);
            this.LabelPostContent.Name = "LabelPostContent";
            this.LabelPostContent.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.LabelPostContent.Size = new System.Drawing.Size(46, 38);
            this.LabelPostContent.TabIndex = 5;
            this.LabelPostContent.Text = "label1";
            // 
            // Panel2
            // 
            this.Panel2.BackColor = System.Drawing.Color.Silver;
            this.Panel2.Location = new System.Drawing.Point(0, 39);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.Name = "Panel2";
            this.Panel2.Size = new System.Drawing.Size(751, 1);
            this.Panel2.TabIndex = 14;
            // 
            // PanelPostLikeAmount
            // 
            this.PanelPostLikeAmount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelPostLikeAmount.Controls.Add(this.LabelLikesAmount);
            this.PanelPostLikeAmount.Controls.Add(this.PictureBoxLikesAmount);
            this.PanelPostLikeAmount.Location = new System.Drawing.Point(0, 40);
            this.PanelPostLikeAmount.Margin = new System.Windows.Forms.Padding(0);
            this.PanelPostLikeAmount.Name = "PanelPostLikeAmount";
            this.PanelPostLikeAmount.Size = new System.Drawing.Size(752, 38);
            this.PanelPostLikeAmount.TabIndex = 15;
            // 
            // LabelLikesAmount
            // 
            this.LabelLikesAmount.AutoSize = true;
            this.LabelLikesAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelLikesAmount.Location = new System.Drawing.Point(37, 11);
            this.LabelLikesAmount.Name = "LabelLikesAmount";
            this.LabelLikesAmount.Size = new System.Drawing.Size(45, 16);
            this.LabelLikesAmount.TabIndex = 1;
            this.LabelLikesAmount.Text = "label1";
            // 
            // PictureBoxLikesAmount
            // 
            this.PictureBoxLikesAmount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.PictureBoxLikesAmount.Image = ((System.Drawing.Image)(resources.GetObject("PictureBoxLikesAmount.Image")));
            this.PictureBoxLikesAmount.Location = new System.Drawing.Point(15, 11);
            this.PictureBoxLikesAmount.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxLikesAmount.Name = "PictureBoxLikesAmount";
            this.PictureBoxLikesAmount.Size = new System.Drawing.Size(21, 21);
            this.PictureBoxLikesAmount.TabIndex = 0;
            this.PictureBoxLikesAmount.TabStop = false;
            // 
            // PanelComments
            // 
            this.PanelComments.AutoSize = true;
            this.PanelComments.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelComments.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelComments.Location = new System.Drawing.Point(0, 78);
            this.PanelComments.Margin = new System.Windows.Forms.Padding(0);
            this.PanelComments.Name = "PanelComments";
            this.PanelComments.Size = new System.Drawing.Size(0, 0);
            this.PanelComments.TabIndex = 16;
            // 
            // PanelWriteComment
            // 
            this.PanelWriteComment.AutoScroll = true;
            this.PanelWriteComment.AutoSize = true;
            this.PanelWriteComment.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelWriteComment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.PanelWriteComment.Controls.Add(this.panelCommentTextBox);
            this.PanelWriteComment.Controls.Add(this.PictureBoxCommentProfile);
            this.PanelWriteComment.Location = new System.Drawing.Point(0, 78);
            this.PanelWriteComment.Margin = new System.Windows.Forms.Padding(0);
            this.PanelWriteComment.Name = "PanelWriteComment";
            this.PanelWriteComment.Size = new System.Drawing.Size(751, 56);
            this.PanelWriteComment.TabIndex = 17;
            // 
            // panelCommentTextBox
            // 
            this.panelCommentTextBox.AutoSize = true;
            this.panelCommentTextBox.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelCommentTextBox.BackColor = System.Drawing.Color.White;
            this.panelCommentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCommentTextBox.Controls.Add(this.TextBoxComment);
            this.panelCommentTextBox.Location = new System.Drawing.Point(51, 12);
            this.panelCommentTextBox.Margin = new System.Windows.Forms.Padding(3, 12, 12, 12);
            this.panelCommentTextBox.Name = "panelCommentTextBox";
            this.panelCommentTextBox.Size = new System.Drawing.Size(688, 32);
            this.panelCommentTextBox.TabIndex = 3;
            // 
            // TextBoxComment
            // 
            this.TextBoxComment.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.TextBoxComment.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxComment.Location = new System.Drawing.Point(10, 5);
            this.TextBoxComment.Margin = new System.Windows.Forms.Padding(0, 5, 8, 8);
            this.TextBoxComment.Multiline = true;
            this.TextBoxComment.Name = "TextBoxComment";
            this.TextBoxComment.Size = new System.Drawing.Size(668, 17);
            this.TextBoxComment.TabIndex = 2;
            this.TextBoxComment.Text = "Write a comment...";
            this.TextBoxComment.Enter += new System.EventHandler(this.textBoxComment_Enter);
            this.TextBoxComment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxComment_KeyDown);
            this.TextBoxComment.Leave += new System.EventHandler(this.textBoxComment_Leave);
            // 
            // PictureBoxCommentProfile
            // 
            this.PictureBoxCommentProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageSmall", true));
            this.PictureBoxCommentProfile.Location = new System.Drawing.Point(8, 12);
            this.PictureBoxCommentProfile.Margin = new System.Windows.Forms.Padding(8, 12, 8, 12);
            this.PictureBoxCommentProfile.Name = "PictureBoxCommentProfile";
            this.PictureBoxCommentProfile.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxCommentProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCommentProfile.TabIndex = 1;
            this.PictureBoxCommentProfile.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // ButtonPostLike
            // 
            this.ButtonPostLike.FlatAppearance.BorderSize = 0;
            this.ButtonPostLike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPostLike.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonPostLike.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPostLike.Image")));
            this.ButtonPostLike.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPostLike.Location = new System.Drawing.Point(11, 9);
            this.ButtonPostLike.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPostLike.Name = "ButtonPostLike";
            this.ButtonPostLike.Size = new System.Drawing.Size(70, 30);
            this.ButtonPostLike.TabIndex = 13;
            this.ButtonPostLike.Text = "Like";
            this.ButtonPostLike.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPostLike.UseVisualStyleBackColor = true;
            this.ButtonPostLike.Click += new System.EventHandler(this.buttonPostLike_Click);
            // 
            // ButtonPostComment
            // 
            this.ButtonPostComment.FlatAppearance.BorderSize = 0;
            this.ButtonPostComment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonPostComment.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.ButtonPostComment.Image = ((System.Drawing.Image)(resources.GetObject("ButtonPostComment.Image")));
            this.ButtonPostComment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ButtonPostComment.Location = new System.Drawing.Point(81, 9);
            this.ButtonPostComment.Margin = new System.Windows.Forms.Padding(0);
            this.ButtonPostComment.Name = "ButtonPostComment";
            this.ButtonPostComment.Size = new System.Drawing.Size(99, 30);
            this.ButtonPostComment.TabIndex = 12;
            this.ButtonPostComment.Text = "Comment";
            this.ButtonPostComment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ButtonPostComment.UseVisualStyleBackColor = true;
            this.ButtonPostComment.Click += new System.EventHandler(this.buttonPostComment_Click);
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.Silver;
            this.Panel1.Location = new System.Drawing.Point(14, 8);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(727, 1);
            this.Panel1.TabIndex = 11;
            // 
            // PanelBelowPostContent
            // 
            this.PanelBelowPostContent.AutoSize = true;
            this.PanelBelowPostContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.PanelBelowPostContent.BackColor = System.Drawing.Color.White;
            this.PanelBelowPostContent.Controls.Add(this.Panel1);
            this.PanelBelowPostContent.Controls.Add(this.ButtonPostComment);
            this.PanelBelowPostContent.Controls.Add(this.ButtonPostLike);
            this.PanelBelowPostContent.Controls.Add(this.PanelWriteComment);
            this.PanelBelowPostContent.Controls.Add(this.PanelComments);
            this.PanelBelowPostContent.Controls.Add(this.PanelPostLikeAmount);
            this.PanelBelowPostContent.Controls.Add(this.Panel2);
            this.PanelBelowPostContent.Location = new System.Drawing.Point(0, 56);
            this.PanelBelowPostContent.Margin = new System.Windows.Forms.Padding(0);
            this.PanelBelowPostContent.Name = "PanelBelowPostContent";
            this.PanelBelowPostContent.Size = new System.Drawing.Size(752, 134);
            this.PanelBelowPostContent.TabIndex = 14;
            // 
            // UserControlPost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelBelowPostContent);
            this.Controls.Add(this.LabelPostContent);
            this.Controls.Add(this.LabelTime);
            this.Controls.Add(this.LabelUserName);
            this.Controls.Add(this.PictureBoxProfile);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(751, 190);
            this.Name = "UserControlPost";
            this.Size = new System.Drawing.Size(752, 190);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            this.PanelPostLikeAmount.ResumeLayout(false);
            this.PanelPostLikeAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxLikesAmount)).EndInit();
            this.PanelWriteComment.ResumeLayout(false);
            this.PanelWriteComment.PerformLayout();
            this.panelCommentTextBox.ResumeLayout(false);
            this.panelCommentTextBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCommentProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.PanelBelowPostContent.ResumeLayout(false);
            this.PanelBelowPostContent.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.Label LabelUserName;
        public System.Windows.Forms.Label LabelTime;
        public System.Windows.Forms.Label LabelPostContent;
        private System.Windows.Forms.Panel Panel2;
        public System.Windows.Forms.Panel PanelPostLikeAmount;
        public System.Windows.Forms.Label LabelLikesAmount;
        private System.Windows.Forms.PictureBox PictureBoxLikesAmount;
        public System.Windows.Forms.Panel PanelComments;
        public System.Windows.Forms.Panel PanelWriteComment;
        private System.Windows.Forms.Panel panelCommentTextBox;
        public System.Windows.Forms.TextBox TextBoxComment;
        public System.Windows.Forms.PictureBox PictureBoxCommentProfile;
        public System.Windows.Forms.Button ButtonPostLike;
        public System.Windows.Forms.Button ButtonPostComment;
        private System.Windows.Forms.Panel Panel1;
        public System.Windows.Forms.Panel PanelBelowPostContent;
        private System.Windows.Forms.BindingSource postBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}
