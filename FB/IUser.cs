using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using static FacebookWrapper.ObjectModel.DynamicWrapper;
using static FacebookWrapper.ObjectModel.User;

namespace FB
{
    public interface IUser
    {
        FacebookObjectCollection<Album> Albums { get; }
        string Bio { get; set; }
        string Birthday { get; }
        FacebookObjectCollection<Checkin> Checkins { get; }
        Cover Cover { get; }
        Education[] Educations { get; }
        string Email { get; }
        FacebookObjectCollection<Event> EventsCreated { get; }
        FacebookObjectCollection<Event> EventsDeclined { get; }
        FacebookObjectCollection<Event> EventsMaybe { get; }
        FacebookObjectCollection<Event> EventsNotYetReplied { get; }
        string FirstName { get; }
        FacebookObjectCollection<FriendList> FriendLists { get; }
        FacebookObjectCollection<User> Friends { get; }
        eGender? Gender { get; }
        FacebookObjectCollection<Group> Groups { get; }
        City Hometown { get; }
        FacebookObjectCollection<InboxThread> InboxThreads { get; }
        eGender[] InterestedIn { get; }
        Page[] Languages { get; }
        string LastName { get; }
        FacebookObjectCollection<Page> LikedPages { get; }
        string Link { get; }
        string Locale { get; }
        City Location { get; }
        FacebookObjectCollection<Message> MessageUpdates { get; }
        string MiddleName { get; }
        string Name { get; }
        FacebookObjectCollection<Post> NewsFeed { get; }
        eOnlineStatus? OnlineStatus { get; }
        FacebookObjectCollection<Photo> PhotosTaggedIn { get; }
        FacebookObjectCollection<Poke> Pokes { get; }
        FacebookObjectCollection<Link> PostedLinks { get; }
        FacebookObjectCollection<Post> Posts { get; }
        FacebookObjectCollection<Post> PostsTaggedIn { get; }
        string Quotes { get; }
        eRelationshipStatus? RelationshipStatus { get; }
        string Religion { get; }
        User SignificantOther { get; }
        FacebookObjectCollection<Status> Statuses { get; }
        double? TimeZone { get; }
        DateTime? UpdateTime { get; }
        string UserName { get; }
        bool? Verfied { get; set; }
        FacebookObjectCollection<Video> Videos { get; }

        Checkin Checkin(Checkin i_Checkin);
        Checkin Checkin(string i_PagePlaceID, string i_LocationCoordinates = null, string i_Message = null, string i_Link = null, string i_PictureURL = null, string i_TaggedFriendIDs = null);
        Album CreateAlbum(string i_Name, string i_Description = null, string i_Privacy = null);
        FriendList CreateFriendList(string i_Name);
        Link PostLink(string i_Url, string i_Message = null, string i_PrivacyParameterValue = null);
        Status PostStatus(string i_StatusText, string i_PaceID = null, string i_PictureURL = null, string i_TaggedFriendIDs = null, string i_Link = null, string i_PrivacyParameterValue = null);
        string ToString();


        FacebookObjectCollection<Event> Events { get; }
        Image ImageLarge { get; }
        Image ImageNormal { get; }
        Image ImageSmall { get; }
        Image ImageSquare { get; }
        string PictureLargeURL { get; }
        string PictureNormalURL { get; }
        PicturesColleciton Pictures { get; }
        string PictureSmallURL { get; }
        string PictureSqaureURL { get; }
        FacebookObjectCollection<Post> WallPosts { get; }

        Event CreateEvent_DeprecatedSinceV2(string i_Name, DateTime i_StartTime, DateTime? i_EndTime = default(DateTime?), string i_Description = null, string i_Location = null, Event.ePrivacy? i_PrivacyType = default(Event.ePrivacy?), string i_PlaceID = null);
        Post PostPhoto(string i_PictureFilePath, string i_Title = null, string i_Caption = null, string i_PrivacyParameterValue = null);
        Post PostPhoto(byte[] i_PhotoData, string i_Title = null, string i_Caption = null, string i_FileName = "photo.jpg", string i_PrivacyParameterValue = null);


        void Fetch(eLoadOptions i_LoadOption);
        void Fetch(string i_Fields);
        void ReFetch();
        void ReFetch(string i_FieldsToLoad);
        void ReFetch(eLoadOptions i_LoadOptions);
    }
}
