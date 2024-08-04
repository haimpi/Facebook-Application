using FacebookWrapper.ObjectModel;
using System.Collections.Generic;
using System.Linq;

public class MainService
{
    private readonly User r_LoggedInUser;

    public MainService(User i_LoggedInUser)
    {
        r_LoggedInUser = i_LoggedInUser;
    }

    public List<string> GetBasicInfo()
    {
        return new List<string>
        {
            "Birthday: " + r_LoggedInUser.Birthday,
            "Gender: " + r_LoggedInUser.Gender,
            "Email: " + r_LoggedInUser.Email,
            "Relationship: " + r_LoggedInUser.RelationshipStatus,
            "Location: " + r_LoggedInUser.Location?.Name
        };
    }

    public FacebookObjectCollection<Page> GetUserLikedPages()
    {
        return r_LoggedInUser.LikedPages;
    }

    public FacebookObjectCollection<User> GetUserFriends()
    {
        return r_LoggedInUser.Friends;
    }

    public FacebookObjectCollection<Page> GetFavoriteTeams()
    {
        var favoriteTeams = new FacebookObjectCollection<Page>();

        r_LoggedInUser.FavofriteTeams.ToList().ForEach(favoriteTeams.Add);

        return favoriteTeams;
    }

    public FacebookObjectCollection<Album> GetUserAlbums()
    {
        return r_LoggedInUser.Albums;
    }

    public void PostStatus(string i_Message)
    {
        r_LoggedInUser.PostStatus(i_Message);
    }

    public FacebookObjectCollection<Post> GetUserPosts()
    {
        return r_LoggedInUser.Posts;
    }
}