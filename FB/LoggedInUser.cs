using System;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using static FacebookWrapper.ObjectModel.User;
using static FacebookWrapper.ObjectModel.DynamicWrapper;

namespace FB
{
    public sealed class LoggedInUser : UserAdapter
    {
        private static LoggedInUser s_Instance = null;

        public static LoggedInUser Instance
        {
            get
            {
                if (s_Instance == null)
                {
                    LoginResult loginResult;
                    if (!AppSettings.Instance.RememberMe)
                    {
                        loginResult = login();
                    }
                    else
                    {
                        loginResult = FacebookService.Connect(AppSettings.Instance.UserAccessToken);
                    }

                    if (loginResult.LoggedInUser != null)
                    {
                        s_Instance = new LoggedInUser { User = loginResult.LoggedInUser };

                        if (AppSettings.Instance.RememberMe)
                        {
                            AppSettings.Instance.UserAccessToken = loginResult.AccessToken;
                        }
                    }
                }

                return s_Instance;
            }
        }

        private static LoginResult login()
        {
            return FacebookService.Login(
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
        }

        private LoggedInUser()
        {
        }

       
    }
}