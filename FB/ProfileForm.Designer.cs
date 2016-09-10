namespace FB
{
    public partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelPosts = new System.Windows.Forms.FlowLayoutPanel();
            this.userControlStatus1 = new FB.UserControls.UserControlStatus();
            this.userControlProfile1 = new FB.UserControls.UserControlProfile();
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
            this.buttonProfile.Text = "Desig Patter";
            // 
            // buttonTodayEvents
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
            this.panelMain.Controls.Add(this.userControlProfile1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMain.Location = new System.Drawing.Point(208, 0);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(658, 832);
            this.panelMain.TabIndex = 10;
            // 
            // panelPosts
            // 
            this.panelPosts.AutoSize = true;
            this.panelPosts.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelPosts.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panelPosts.Location = new System.Drawing.Point(38, 329);
            this.panelPosts.Margin = new System.Windows.Forms.Padding(0);
            this.panelPosts.Name = "panelPosts";
            this.panelPosts.Size = new System.Drawing.Size(0, 0);
            this.panelPosts.TabIndex = 2;
            // 
            // userControlStatus1
            // 
            this.userControlStatus1.AutoSize = true;
            this.userControlStatus1.BackColor = System.Drawing.Color.White;
            this.userControlStatus1.Location = new System.Drawing.Point(38, 197);
            this.userControlStatus1.Margin = new System.Windows.Forms.Padding(0);
            this.userControlStatus1.Name = "userControlStatus1";
            this.userControlStatus1.Size = new System.Drawing.Size(563, 95);
            this.userControlStatus1.TabIndex = 1;
            // 
            // userControlProfile1
            // 
            this.userControlProfile1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userControlProfile1.AutoScroll = true;
            this.userControlProfile1.Location = new System.Drawing.Point(0, 0);
            this.userControlProfile1.Margin = new System.Windows.Forms.Padding(0);
            this.userControlProfile1.Name = "userControlProfile1";
            this.userControlProfile1.Size = new System.Drawing.Size(3349, 832);
            this.userControlProfile1.TabIndex = 0;
            // 
            // ProfileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 849);
            this.Controls.Add(this.panelMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximumSize = new System.Drawing.Size(666, 894);
            this.MinimumSize = new System.Drawing.Size(666, 547);
            this.Name = "ProfileForm";
            this.Controls.SetChildIndex(this.panelMain, 0);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.FlowLayoutPanel panelPosts;
        private UserControls.UserControlStatus userControlStatus1;
        private UserControls.UserControlProfile userControlProfile1;
    }
}