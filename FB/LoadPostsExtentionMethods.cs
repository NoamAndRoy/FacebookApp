using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public static class LoadPostsExtentionMethods
    {
        public static void LoadPosts(this Panel i_Panel, FacebookObjectCollection<Post> i_PostCollection)
        {
            i_Panel.Invoke(new Action(
                () =>
                {
                    foreach (Post currentPost in i_PostCollection)
                    {
                        if (currentPost.Message != null)
                        {
                            UserControlPost post = new UserControlPost(currentPost);
                            i_Panel.Controls.Add(post);

                            post.Margin = new Padding(0, 0, 0, 30);
                        }
                    }
                }));
        }
    }
}
