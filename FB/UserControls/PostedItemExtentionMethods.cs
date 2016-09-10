using FacebookWrapper.ObjectModel;

namespace FB.UserControls
{
    public static class PostedItemExtentionMethods
    {
        public static bool IsLikedByLoggedInUser(this PostedItem i_PostedItem)
        {
            bool isLiked = false;

            foreach (User currentUser in i_PostedItem.LikedBy)
            {
                if (currentUser.Id == LoggedInUser.Instance.Id)
                {
                    isLiked = true;
                    break;
                }
            }

            return isLiked;
        }
    }
}
