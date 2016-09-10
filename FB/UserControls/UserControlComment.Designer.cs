namespace FB.UserControls
{
    public partial class UserControlComment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlComment));
            this.PictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.commentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelBelowCommentContent = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.LabelTime = new System.Windows.Forms.Label();
            this.LabelLike = new System.Windows.Forms.Label();
            this.LabelLikeAmount = new System.Windows.Forms.Label();
            this.LabelComment = new System.Windows.Forms.Label();
            this.LabelUserName = new System.Windows.Forms.Label();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).BeginInit();
            this.panelBelowCommentContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PictureBoxProfile
            // 
            this.PictureBoxProfile.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.commentBindingSource, "From.ImageSmall", true));
            this.PictureBoxProfile.Location = new System.Drawing.Point(8, 8);
            this.PictureBoxProfile.Name = "PictureBoxProfile";
            this.PictureBoxProfile.Size = new System.Drawing.Size(32, 32);
            this.PictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfile.TabIndex = 0;
            this.PictureBoxProfile.TabStop = false;
            // 
            // commentBindingSource
            // 
            this.commentBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Comment);
            // 
            // panelBelowCommentContent
            // 
            this.panelBelowCommentContent.Controls.Add(this.pictureBox);
            this.panelBelowCommentContent.Controls.Add(this.LabelTime);
            this.panelBelowCommentContent.Controls.Add(this.LabelLike);
            this.panelBelowCommentContent.Controls.Add(this.LabelLikeAmount);
            this.panelBelowCommentContent.Location = new System.Drawing.Point(0, 7);
            this.panelBelowCommentContent.Margin = new System.Windows.Forms.Padding(0);
            this.panelBelowCommentContent.Name = "panelBelowCommentContent";
            this.panelBelowCommentContent.Size = new System.Drawing.Size(751, 20);
            this.panelBelowCommentContent.TabIndex = 7;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(84, 0);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(19, 19);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // LabelTime
            // 
            this.LabelTime.AutoSize = true;
            this.LabelTime.BackColor = System.Drawing.Color.Transparent;
            this.LabelTime.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "CreatedTime", true));
            this.LabelTime.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelTime.Location = new System.Drawing.Point(126, 0);
            this.LabelTime.Name = "LabelTime";
            this.LabelTime.Size = new System.Drawing.Size(42, 16);
            this.LabelTime.TabIndex = 6;
            this.LabelTime.Text = "label1";
            // 
            // LabelLike
            // 
            this.LabelLike.BackColor = System.Drawing.Color.Transparent;
            this.LabelLike.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelLike.Location = new System.Drawing.Point(46, 0);
            this.LabelLike.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLike.Name = "LabelLike";
            this.LabelLike.Size = new System.Drawing.Size(40, 16);
            this.LabelLike.TabIndex = 2;
            this.LabelLike.Text = "Like";
            this.LabelLike.Click += new System.EventHandler(this.LabelLike_Click);
            this.LabelLike.MouseHover += new System.EventHandler(this.LabelLike_MouseHover);
            // 
            // LabelLikeAmount
            // 
            this.LabelLikeAmount.AutoSize = true;
            this.LabelLikeAmount.BackColor = System.Drawing.Color.Transparent;
            this.LabelLikeAmount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelLikeAmount.Location = new System.Drawing.Point(105, 0);
            this.LabelLikeAmount.Margin = new System.Windows.Forms.Padding(0);
            this.LabelLikeAmount.Name = "LabelLikeAmount";
            this.LabelLikeAmount.Size = new System.Drawing.Size(39, 16);
            this.LabelLikeAmount.TabIndex = 4;
            this.LabelLikeAmount.Text = "Label";
            // 
            // LabelComment
            // 
            this.LabelComment.AutoSize = true;
            this.LabelComment.BackColor = System.Drawing.Color.Transparent;
            this.LabelComment.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "Message", true));
            this.LabelComment.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.LabelComment.Location = new System.Drawing.Point(102, 10);
            this.LabelComment.Margin = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.LabelComment.Name = "LabelComment";
            this.LabelComment.Size = new System.Drawing.Size(42, 16);
            this.LabelComment.TabIndex = 5;
            this.LabelComment.Text = "label1";
            // 
            // LabelUserName
            // 
            this.LabelUserName.AutoSize = true;
            this.LabelUserName.BackColor = System.Drawing.Color.Transparent;
            this.LabelUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.commentBindingSource, "From.Name", true));
            this.LabelUserName.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.LabelUserName.Location = new System.Drawing.Point(46, 10);
            this.LabelUserName.Name = "LabelUserName";
            this.LabelUserName.Size = new System.Drawing.Size(47, 16);
            this.LabelUserName.TabIndex = 1;
            this.LabelUserName.Text = "label1";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // UserControlComment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Controls.Add(this.PictureBoxProfile);
            this.Controls.Add(this.panelBelowCommentContent);
            this.Controls.Add(this.LabelComment);
            this.Controls.Add(this.LabelUserName);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.MinimumSize = new System.Drawing.Size(752, 47);
            this.Name = "UserControlComment";
            this.Padding = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Size = new System.Drawing.Size(752, 47);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.commentBindingSource)).EndInit();
            this.panelBelowCommentContent.ResumeLayout(false);
            this.panelBelowCommentContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox;
        public System.Windows.Forms.PictureBox PictureBoxProfile;
        public System.Windows.Forms.Label LabelUserName;
        public System.Windows.Forms.Label LabelLike;
        public System.Windows.Forms.Label LabelLikeAmount;
        public System.Windows.Forms.Label LabelComment;
        public System.Windows.Forms.Label LabelTime;
        private System.Windows.Forms.Panel panelBelowCommentContent;
        private System.Windows.Forms.BindingSource commentBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}
