using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class FriendMatcherLogic
    {
        private readonly User r_LoggedInUser;
        private readonly List<IFriendScoreStrategy> r_ScoreStrategies;

        public FriendMatcherLogic(User i_User)
        {
            r_LoggedInUser = i_User;
            r_ScoreStrategies = new List<IFriendScoreStrategy>();
        }

        public void AddScoreStrategy(IFriendScoreStrategy i_Strategy)
        {
            r_ScoreStrategies.Add(i_Strategy);
        }

        public Dictionary<User, int> FindTopScoringFriends(User.eGender? i_Gender, int i_MinAge, int i_MaxAge, Dictionary<Type, List<string>> i_Criteria)
        {
            var topFriendsWithScores = new Dictionary<User, int>();

            foreach (User friend in r_LoggedInUser.Friends)
            {
                if (isMatchingCriteria(friend, i_Gender, i_MinAge, i_MaxAge))
                {
                    int score = calculateTotalScore(friend, i_Criteria);
                    topFriendsWithScores[friend] = score;
                }
            }

            return topFriendsWithScores;
        }

        private bool isMatchingCriteria(User i_Friend, User.eGender? i_Gender, int i_MinAge, int i_MaxAge)
        {
            int friendAge = calculateAge(i_Friend.Birthday);

            return friendAge >= i_MinAge && friendAge <= i_MaxAge &&
                   (!i_Gender.HasValue || i_Gender == i_Friend.Gender);
        }

        private int calculateAge(string i_DateOfBirth)
        {
            DateTime birthDate = DateTime.Parse(i_DateOfBirth);
            DateTime today = DateTime.Today;
            int age = today.Year - birthDate.Year;

            if (birthDate.Date > today.AddYears(-age))
            {
                age--;
            }

            return age;
        }

        private int calculateTotalScore(User i_Friend, Dictionary<Type, List<string>> i_Criteria)
        {
            int totalScore = 0;

            foreach (IFriendScoreStrategy strategy in r_ScoreStrategies)
            {
                Type strategyType = strategy.GetType();

                if (i_Criteria.TryGetValue(strategyType, out List<string> strategyCriteria))//check here
                {
                    totalScore += strategy.CalculateFriendScore(i_Friend, strategyCriteria);
                }
            }

            return totalScore;
        }
    }
}