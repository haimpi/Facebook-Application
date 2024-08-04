using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FriendMatcherService
    {
        private readonly FriendMatcherLogic r_FriendMatcherLogic;
        private readonly User r_LoggedInUser;

        public FriendMatcherService(User i_User)
        {
            r_LoggedInUser = i_User;
            r_FriendMatcherLogic = new FriendMatcherLogic(i_User);
            r_FriendMatcherLogic.AddScoreStrategy(new LocationScoreStrategy());
            r_FriendMatcherLogic.AddScoreStrategy(new LikedPagesScoreStrategy());
        }

        public Dictionary<User, int> FindTopScoringFriends(User.eGender? i_Gender, int i_MinAge, int i_MaxAge, Dictionary<Type, List<string>> i_Criteria)
        {
            return r_FriendMatcherLogic.FindTopScoringFriends(i_Gender, i_MinAge, i_MaxAge, i_Criteria);
        }

        public List<string> GetCities()
        {
            HashSet<string> uniqueCities = new HashSet<string>();

            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (friend.Location != null && friend.Location.Name != null)
                {
                    uniqueCities.Add(friend.Location.Name);
                }
            }

            return new List<string>(uniqueCities);
        }

        public List<Page> GetLikedPages()
        {
            return new List<Page>(r_LoggedInUser.LikedPages);
        }
    }
}