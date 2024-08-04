using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class LikedPagesScoreStrategy : IFriendScoreStrategy
    {
        private const int k_CommonLikeScore = 1;

        public int CalculateFriendScore(User i_Friend, List<string> i_LikedPages)
        {
            int score = 0;

            foreach (string pageName in i_LikedPages)
            {
                foreach (Page friendPage in i_Friend.LikedPages)
                {
                    if (pageName.Equals(friendPage.Name, StringComparison.OrdinalIgnoreCase))
                    {
                        score += k_CommonLikeScore;
                    }
                }
            }

            return score;
        }
    }
}