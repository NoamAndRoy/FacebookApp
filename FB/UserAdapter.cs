using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace FB
{
    public class UserAdapter : IUser
    {
        public User User { get; set; }

        // User
        public FacebookObjectCollection<Album> Albums
        {
            get { return User.Albums; }
        }

        public string Bio
        {
            get { return User.Bio; }
            set { User.Bio = value; }
        }

        public string Birthday
        {
            get { return User.Birthday; }
        }

        public FacebookObjectCollection<Checkin> Checkins
        {
            get { return User.Checkins; }
        }

        public Cover Cover
        {
            get { return User.Cover; }
        }

        public Education[] Educations
        {
            get { return User.Educations; }
        }

        public string Email
        {
            get { return User.Email; }
        }

        public FacebookObjectCollection<Event> EventsCreated
        {
            get { return User.EventsCreated; }
        }

        public FacebookObjectCollection<Event> EventsDeclined
        {
            get { return User.EventsDeclined; }
        }

        public FacebookObjectCollection<Event> EventsMaybe
        {
            get { return User.EventsMaybe; }
        }

        public FacebookObjectCollection<Event> EventsNotYetReplied
        {
            get { return User.EventsNotYetReplied; }
        }

        public string FirstName
        {
            get { return User.FirstName; }
        }

        public FacebookObjectCollection<FriendList> FriendLists
        {
            get { return User.FriendLists; }
        }

        public FacebookObjectCollection<User> Friends
        {
            get { return User.Friends; }
        }

        public User.eGender? Gender
        {
            get { return User.Gender; }
        }

        public FacebookObjectCollection<Group> Groups
        {
            get { return User.Groups; }
        }

        public City Hometown
        {
            get { return User.Hometown; }
        }

        public FacebookObjectCollection<InboxThread> InboxThreads
        {
            get { return User.InboxThreads; }
        }

        public User.eGender[] InterestedIn
        {
            get { return User.InterestedIn; }
        }

        public Page[] Languages
        {
            get { return User.Languages; }
        }

        public string LastName
        {
            get { return User.LastName; }
        }

        public FacebookObjectCollection<Page> LikedPages
        {
            get { return User.LikedPages; }
        }

        public string Link
        {
            get { return User.Link; }
        }

        public string Locale
        {
            get { return User.Locale; }
        }

        public City Location
        {
            get { return User.Location; }
        }

        public FacebookObjectCollection<Message> MessageUpdates
        {
            get { return User.MessageUpdates; }
        }

        public string MiddleName
        {
            get { return User.MiddleName; }
        }

        public string Name
        {
            get { return User.Name; }
        }

        public FacebookObjectCollection<Post> NewsFeed
        {
            get { return User.NewsFeed; }
        }

        public User.eOnlineStatus? OnlineStatus
        {
            get { return User.OnlineStatus; }
        }

        public FacebookObjectCollection<Photo> PhotosTaggedIn
        {
            get { return User.PhotosTaggedIn; }
        }

        public FacebookObjectCollection<Poke> Pokes
        {
            get { return User.Pokes; }
        }

        public FacebookObjectCollection<Link> PostedLinks
        {
            get { return User.PostedLinks; }
        }

        public FacebookObjectCollection<Post> Posts
        {
            get { return User.Posts; }
        }

        public FacebookObjectCollection<Post> PostsTaggedIn
        {
            get { return User.PostsTaggedIn; }
        }

        public string Quotes
        {
            get { return User.Quotes; }
        }

        public User.eRelationshipStatus? RelationshipStatus
        {
            get { return User.RelationshipStatus; }
        }

        public string Religion
        {
            get { return User.Religion; }
        }

        public User SignificantOther
        {
            get { return User.SignificantOther; }
        }

        public FacebookObjectCollection<Status> Statuses
        {
            get { return User.Statuses; }
        }

        public double? TimeZone
        {
            get { return User.TimeZone; }
        }

        public DateTime? UpdateTime
        {
            get { return User.UpdateTime; }
        }

        public string UserName
        {
            get { return User.UserName; }
        }

        public bool? Verfied
        {
            get { return User.Verfied; }
            set { User.Verfied = value; }
        }

        public FacebookObjectCollection<Video> Videos
        {
            get { return User.Videos; }
        }

        public Checkin Checkin(Checkin i_Checkin)
        {
            return User.Checkin(i_Checkin);
        }

        public Checkin Checkin(string i_PagePlaceID, string i_LocationCoordinates = null, string i_Message = null, string i_Link = null, string i_PictureURL = null, string i_TaggedFriendIDs = null)
        {
            return User.Checkin(i_PagePlaceID, i_LocationCoordinates, i_Message, i_Link, i_PictureURL, i_TaggedFriendIDs);
        }

        public Album CreateAlbum(string i_Name, string i_Description = null, string i_Privacy = null)
        {
            return User.CreateAlbum(i_Name, i_Description, i_Privacy);
        }

        public FriendList CreateFriendList(string i_Name)
        {
            return User.CreateFriendList(i_Name);
        }

        public Link PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null)
        {
            return User.PostLink(i_Url, i_Message, i_PrivacyParameterValue);
        }

        public Status PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null, string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null)
        {
            return User.PostStatus(i_StatusText, i_PaceID, i_PictureURL, i_TaggedFriendIDs, i_Link, i_PrivacyParameterValue);
        }

        public override string ToString()
        {
            return User.ToString();
        }

        // OwnerObject
        public FacebookObjectCollection<Event> Events
        {
            get { return User.Events; }
        }

        public Image ImageLarge
        {
            get { return User.ImageLarge; }
        }

        public Image ImageNormal
        {
            get { return User.ImageNormal; }
        }

        public Image ImageSmall
        {
            get { return User.ImageSmall; }
        }

        public Image ImageSquare
        {
            get { return User.ImageSquare; }
        }

        public string PictureLargeURL
        {
            get { return User.PictureLargeURL; }
        }

        public string PictureNormalURL
        {
            get { return User.PictureNormalURL; }
        }

        public PicturesColleciton Pictures
        {
            get { return User.Pictures; }
        }

        public string PictureSmallURL
        {
            get { return User.PictureSmallURL; }
        }

        public string PictureSqaureURL
        {
            get { return User.PictureSqaureURL; }
        }

        public FacebookObjectCollection<Post> WallPosts
        {
            get { return User.WallPosts; }
        }

        public Event CreateEvent_DeprecatedSinceV2(string i_Name, DateTime i_StartTime, DateTime? i_EndTime = default(DateTime?), string i_Description = null, string i_Location = null, Event.ePrivacy? i_PrivacyType = default(Event.ePrivacy?), string i_PlaceID = null)
        {
            return User.CreateEvent_DeprecatedSinceV2(i_Name, i_StartTime, i_EndTime, i_Description, i_Location, i_PrivacyType, i_PlaceID);
        }

        public Post PostPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null, string i_PrivacyParameterValue = null)
        {
            return User.PostPhoto(i_PictureFilePath, i_Title, i_Caption, i_PrivacyParameterValue);
        }

        public Post PostPhoto(byte[] i_PhotoData, string i_Title = null, string i_Caption = null, string i_FileName = "photo.jpg", string i_PrivacyParameterValue = null)
        {
            return User.PostPhoto(i_PhotoData, i_Title, i_Caption, i_FileName, i_PrivacyParameterValue);
        }

        // FacebookObject
        public string Id
        {
            get { return User.Id; }
        }

        public void Fetch(DynamicWrapper.eLoadOptions i_LoadOption)
        {
            User.Fetch(i_LoadOption);
        }

        public void Fetch(string i_Fields)
        {
            User.Fetch(i_Fields);
        }

        public void ReFetch()
        {
            User.ReFetch();
        }

        public void ReFetch(string i_FieldsToLoad)
        {
            User.ReFetch(i_FieldsToLoad);
        }

        public void ReFetch(DynamicWrapper.eLoadOptions i_LoadOptions)
        {
            User.ReFetch(i_LoadOptions);
        }
    }
}
