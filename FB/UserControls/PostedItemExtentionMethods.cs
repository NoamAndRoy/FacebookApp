using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public static class PostedItemExtentionMethods
    {
        public static bool isLikedByUser(this PostedItem postedItem, User i_User)// out
        {
            bool isLiked = false;

            foreach (User currentUser in postedItem.LikedBy)
            {
                if (currentUser.Id == i_User.Id)
                {
                    isLiked = true;
                    break;
                }
            }

            return isLiked;
        }
    }
}
