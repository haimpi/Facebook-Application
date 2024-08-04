using System;
using System.Collections.Generic;
using System.Linq;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class CheckinsFinderLogic : IAggregate
    {
        private readonly User r_LoggedInUser;
        private const string k_MapUrl = "https://www.bing.com/maps";
        private string m_SearchText;
        private DateTime? m_DateFrom;
        private DateTime? m_DateTo;

        public CheckinsFinderLogic(User i_User)
        {
            r_LoggedInUser = i_User;
        }

        public void SetSearchCriteria(string i_SearchText, DateTime? i_DateFrom, DateTime? i_DateTo)
        {
            m_SearchText = i_SearchText;
            m_DateFrom = i_DateFrom;
            m_DateTo = i_DateTo;
        }

        public List<CheckinInfo> GetFilteredCheckins()
        {
            List<CheckinInfo> friendsWithCheckinsContaining = new List<CheckinInfo>();

            if (r_LoggedInUser?.Friends != null)
            {
                friendsWithCheckinsContaining = r_LoggedInUser.Friends
                    .Where(friend => friend.Checkins != null && friend.Checkins.Count > 0)
                    .SelectMany(friend => friend.Checkins, (friend, checkin) => new { friend, checkin })
                    .Where(fc => fc.checkin.Place != null && fc.checkin.Place.Name.IndexOf(m_SearchText, StringComparison.OrdinalIgnoreCase) != -1)
                    .Select(fc => new CheckinInfo(fc.friend, fc.checkin))
                    .ToList();
            }

            if (m_DateFrom.HasValue && m_DateTo.HasValue)
            {
                friendsWithCheckinsContaining = friendsWithCheckinsContaining
                    .Where(checkinInfo => isDateTimeInRange(m_DateFrom.Value, m_DateTo.Value, checkinInfo.GetCreatedDate()))
                    .ToList();
            }

            return friendsWithCheckinsContaining;
        }

        private bool isDateTimeInRange(DateTime dateFrom, DateTime dateTo, DateTime i_DateTime)
        {
            return i_DateTime.Date >= dateFrom.Date && i_DateTime.Date <= dateTo.Date;
        }

        public string GetMapUrl(double? i_Latitude, double? i_Longitude)
        {
            return $"{k_MapUrl}?cp={i_Latitude:F6}%7E{i_Longitude:F6}&lvl=16.7";
        }

        public string GetMapUrl()
        {
            return k_MapUrl;
        }

        public IIterator CreateIterator()
        {
            List<CheckinInfo> checkins = GetFilteredCheckins();

            return new CheckinInfoIterator(checkins);
        }
    }
}