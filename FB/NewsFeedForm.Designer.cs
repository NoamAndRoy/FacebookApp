namespace FB
{
    public partial class NewsFeedForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewsFeedForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPosts = new System.Windows.Forms.Panel();
            this.userControlStatus1 = new FB.UserControls.UserControlStatus();
            this.panelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.FlatAppearance.BorderSize = 0;
            this.buttonNewsFeed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonMostFollowedBy
            // 
            this.buttonTodayEvents.FlatAppearance.BorderSize = 0;
            this.buttonTodayEvents.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonMosiac
            // 
            this.buttonMosiac.FlatAppearance.BorderSize = 0;
            this.buttonMosiac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(103)))), ((int)(((byte)(170)))));
            // 
            // panelMain
            // 
            this.panelMain.AutoScroll = true;
            this.panelMain.Controls.Add(this.panelPosts);
            this.panelMain.Controls.Add(this.userControlStatus1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(278, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(875, 619);
            this.panelMain.TabIndex = 10;
            // 
            // panelPosts
            // 
            this.panelPosts.AutoSize = true;
            this.panelPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPosts.Location = new System.Drawing.Point(49, 195);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Padding = new System.Windows.Forms.Padding(0, 0, 0, 30);
            this.panelPosts.Size = new System.Drawing.Size(0, 30);
            this.panelPosts.TabIndex = 2;
            // 
            // userControlStatus1
            // 
            this.userControlStatus1.AutoSize = true;
            this.userControlStatus1.BackColor = System.Drawing.Color.White;
            this.userControlStatus1.FacebookUser = null;
            this.userControlStatus1.Location = new System.Drawing.Point(49, 41);
            this.userControlStatus1.Margin = new System.Windows.Forms.Padding(0);
            this.userControlStatus1.Name = "userControlStatus1";
            this.userControlStatus1.Size = new System.Drawing.Size(751, 117);
            this.userControlStatus1.TabIndex = 1;
            // 
            // NewsFeedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 640);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1170, 1092);
            this.MinimumSize = new System.Drawing.Size(1170, 656);
            this.Name = "NewsFeedForm";
            this.Load += new System.EventHandler(this.ProfileForm_Load);
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelPosts;
        private FB.UserControls.UserControlStatus userControlStatus1;
    }
}