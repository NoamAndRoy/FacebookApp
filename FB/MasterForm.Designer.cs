namespace FB
{
    public partial class MasterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MasterForm));
            this.buttonNewsFeed = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonProfile = new System.Windows.Forms.Button();
            this.buttonTodayEvents = new System.Windows.Forms.Button();
            this.buttonMosiac = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNewsFeed
            // 
            this.buttonNewsFeed.FlatAppearance.BorderSize = 0;
            this.buttonNewsFeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNewsFeed.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.buttonNewsFeed.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonNewsFeed.Location = new System.Drawing.Point(0, 62);
            this.buttonNewsFeed.Margin = new System.Windows.Forms.Padding(0);
            this.buttonNewsFeed.Name = "buttonNewsFeed";
            this.buttonNewsFeed.Size = new System.Drawing.Size(278, 55);
            this.buttonNewsFeed.TabIndex = 10;
            this.buttonNewsFeed.Text = "News Feed";
            this.buttonNewsFeed.UseVisualStyleBackColor = true;
            this.buttonNewsFeed.Click += new System.EventHandler(this.buttonNewsFeed_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.buttonProfile);
            this.panelMenu.Controls.Add(this.buttonTodayEvents);
            this.panelMenu.Controls.Add(this.buttonMosiac);
            this.panelMenu.Controls.Add(this.buttonNewsFeed);
            this.panelMenu.Controls.Add(this.buttonLogout);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(278, 619);
            this.panelMenu.TabIndex = 11;
            // 
            // buttonProfile
            // 
            this.buttonProfile.FlatAppearance.BorderSize = 0;
            this.buttonProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProfile.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.buttonProfile.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonProfile.Location = new System.Drawing.Point(0, 117);
            this.buttonProfile.Margin = new System.Windows.Forms.Padding(0);
            this.buttonProfile.Name = "buttonProfile";
            this.buttonProfile.Size = new System.Drawing.Size(278, 55);
            this.buttonProfile.TabIndex = 11;
            this.buttonProfile.Text = "User\'s Name";
            this.buttonProfile.UseVisualStyleBackColor = true;
            this.buttonProfile.Click += new System.EventHandler(this.buttonProfile_Click);
            // 
            // buttonTodayEvents
            // 
            this.buttonTodayEvents.BackColor = System.Drawing.Color.White;
            this.buttonTodayEvents.FlatAppearance.BorderSize = 0;
            this.buttonTodayEvents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTodayEvents.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.buttonTodayEvents.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonTodayEvents.Location = new System.Drawing.Point(0, 227);
            this.buttonTodayEvents.Margin = new System.Windows.Forms.Padding(0);
            this.buttonTodayEvents.Name = "buttonTodayEvents";
            this.buttonTodayEvents.Size = new System.Drawing.Size(278, 55);
            this.buttonTodayEvents.TabIndex = 10;
            this.buttonTodayEvents.Text = "Feature II: Today Events";
            this.buttonTodayEvents.UseVisualStyleBackColor = false;
            this.buttonTodayEvents.Click += new System.EventHandler(this.buttonTodayEvents_Click);
            // 
            // buttonMosiac
            // 
            this.buttonMosiac.FlatAppearance.BorderSize = 0;
            this.buttonMosiac.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMosiac.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.buttonMosiac.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonMosiac.Location = new System.Drawing.Point(0, 172);
            this.buttonMosiac.Margin = new System.Windows.Forms.Padding(0);
            this.buttonMosiac.Name = "buttonMosiac";
            this.buttonMosiac.Size = new System.Drawing.Size(278, 55);
            this.buttonMosiac.TabIndex = 10;
            this.buttonMosiac.Text = "Feature I: Mosiac";
            this.buttonMosiac.UseVisualStyleBackColor = true;
            this.buttonMosiac.Click += new System.EventHandler(this.buttonMosiac_Click);
            // 
            // buttonLogout
            // 
            this.buttonLogout.FlatAppearance.BorderSize = 0;
            this.buttonLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogout.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(177)));
            this.buttonLogout.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.buttonLogout.Location = new System.Drawing.Point(0, 282);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(0);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(278, 55);
            this.buttonLogout.TabIndex = 9;
            this.buttonLogout.Text = "Log out";
            this.buttonLogout.UseVisualStyleBackColor = true;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.White;
            this.panelLogo.Controls.Add(this.pictureBoxFacebookLogo);
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(278, 62);
            this.panelLogo.TabIndex = 8;
            // 
            // pictureBoxFacebookLogo
            // 
            this.pictureBoxFacebookLogo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFacebookLogo.Image")));
            this.pictureBoxFacebookLogo.Location = new System.Drawing.Point(43, 0);
            this.pictureBoxFacebookLogo.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.Size = new System.Drawing.Size(192, 62);
            this.pictureBoxFacebookLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFacebookLogo.TabIndex = 0;
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(278, 619);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MasterForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Facebook";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        protected System.Windows.Forms.Button buttonNewsFeed;
        protected System.Windows.Forms.Button buttonProfile;
        protected System.Windows.Forms.Button buttonTodayEvents;
        protected System.Windows.Forms.Button buttonMosiac;
        protected System.Windows.Forms.Button buttonLogout;
    }
}