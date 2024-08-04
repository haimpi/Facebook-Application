using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public interface IFriendScoreStrategy
    {
        int CalculateFriendScore(User i_Friend, List<string> i_Criteria);
    }
}