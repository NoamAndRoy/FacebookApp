using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace FB
{
    public partial class FacebookLoginForm : Form
    {
        public bool RememberMe { get; set; }

        public LoginResult UserLoginResult { get; set; }

        public FacebookLoginForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(59, 89, 153);
            this.buttonLogin.BackColor = Color.FromArgb(87, 127, 188);
            this.buttonLogin.ForeColor = Color.FromArgb(190, 202, 222);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            UserLoginResult = FacebookWrapper.FacebookService.Login(
                "262112287500552", 
                "public_profile",
                "user_friends",
                "email",
                "user_about_me",
                "user_birthday",
                "user_education_history",
                "user_events",
                "user_games_activity",
                "user_hometown",
                "user_likes",
                "user_location",
                "user_managed_groups",
                "user_photos",
                "user_posts",
                "publish_actions",
                "user_relationships",
                "user_relationship_details",
                "user_religion_politics",
                "user_tagged_places",
                "user_videos",
                "user_website",
                "user_work_history",
                "read_custom_friendlists",
                "user_status");

            if (this.UserLoginResult.LoggedInUser != null)
            {
                RememberMe = this.checkBoxRememberMe.Checked;

                this.Close();
            }
        }
    }
}