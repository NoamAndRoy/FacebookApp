namespace FB.UserControls
{
    public partial class UserControlProfile
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
            this.LabelLoggedUserName = new System.Windows.Forms.Label();
            this.panelProfileImage = new System.Windows.Forms.Panel();
            this.PictureBoxProfileImage = new System.Windows.Forms.PictureBox();
            this.panelCover = new System.Windows.Forms.Panel();
            this.PictureBoxCoverPhoto = new System.Windows.Forms.PictureBox();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelProfileImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfileImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCoverPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLoggedUserName
            // 
            this.LabelLoggedUserName.AutoSize = true;
            this.LabelLoggedUserName.BackColor = System.Drawing.Color.Transparent;
            this.LabelLoggedUserName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Name", true));
            this.LabelLoggedUserName.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.LabelLoggedUserName.ForeColor = System.Drawing.Color.White;
            this.LabelLoggedUserName.Location = new System.Drawing.Point(198, 100);
            this.LabelLoggedUserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelLoggedUserName.Name = "LabelLoggedUserName";
            this.LabelLoggedUserName.Size = new System.Drawing.Size(124, 45);
            this.LabelLoggedUserName.TabIndex = 11;
            this.LabelLoggedUserName.Text = "label1";
            // 
            // panelProfileImage
            // 
            this.panelProfileImage.BackColor = System.Drawing.Color.White;
            this.panelProfileImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProfileImage.Controls.Add(this.PictureBoxProfileImage);
            this.panelProfileImage.Location = new System.Drawing.Point(20, 13);
            this.panelProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.panelProfileImage.Name = "panelProfileImage";
            this.panelProfileImage.Size = new System.Drawing.Size(170, 170);
            this.panelProfileImage.TabIndex = 10;
            // 
            // PictureBoxProfileImage
            // 
            this.PictureBoxProfileImage.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.userBindingSource, "ImageLarge", true));
            this.PictureBoxProfileImage.Location = new System.Drawing.Point(4, 4);
            this.PictureBoxProfileImage.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxProfileImage.Name = "PictureBoxProfileImage";
            this.PictureBoxProfileImage.Size = new System.Drawing.Size(160, 160);
            this.PictureBoxProfileImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxProfileImage.TabIndex = 0;
            this.PictureBoxProfileImage.TabStop = false;
            // 
            // panelCover
            // 
            this.panelCover.BackColor = System.Drawing.Color.White;
            this.panelCover.Location = new System.Drawing.Point(0, 156);
            this.panelCover.Margin = new System.Windows.Forms.Padding(0);
            this.panelCover.Name = "panelCover";
            this.panelCover.Size = new System.Drawing.Size(851, 44);
            this.panelCover.TabIndex = 9;
            // 
            // PictureBoxCoverPhoto
            // 
            this.PictureBoxCoverPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.PictureBoxCoverPhoto.Location = new System.Drawing.Point(0, 0);
            this.PictureBoxCoverPhoto.Margin = new System.Windows.Forms.Padding(0);
            this.PictureBoxCoverPhoto.Name = "PictureBoxCoverPhoto";
            this.PictureBoxCoverPhoto.Size = new System.Drawing.Size(851, 155);
            this.PictureBoxCoverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxCoverPhoto.TabIndex = 8;
            this.PictureBoxCoverPhoto.TabStop = false;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.User);
            // 
            // UserControlProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LabelLoggedUserName);
            this.Controls.Add(this.panelProfileImage);
            this.Controls.Add(this.panelCover);
            this.Controls.Add(this.PictureBoxCoverPhoto);
            this.Name = "UserControlProfile";
            this.Size = new System.Drawing.Size(871, 611);
            this.panelProfileImage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxProfileImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxCoverPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panelProfileImage;
        private System.Windows.Forms.Panel panelCover;
        public System.Windows.Forms.Label LabelLoggedUserName;
        public System.Windows.Forms.PictureBox PictureBoxProfileImage;
        public System.Windows.Forms.PictureBox PictureBoxCoverPhoto;
        private System.Windows.Forms.BindingSource userBindingSource;
    }
}
