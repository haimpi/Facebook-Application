using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class LocationScoreStrategy : IFriendScoreStrategy
    {
        private const int k_LocationScore = 3;

        public int CalculateFriendScore(User i_Friend, List<string> i_Locations)
        {
            int score = 0;

            foreach (string city in i_Locations)
            {
                if (city == i_Friend.Location?.Name)
                {
                    score += k_LocationScore;
                }
            }

            return score;
        }
    }
}