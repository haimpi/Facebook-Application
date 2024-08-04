using FacebookWrapper.ObjectModel;
using System;

namespace BasicFacebookFeatures
{
    public class CheckinInfo
    {
        public User User { get;}
        public Checkin PostedCheckin { get;}

        public CheckinInfo(User i_User, Checkin i_PostedItem)
        {
            User = i_User;
            PostedCheckin = i_PostedItem;
        }

        public DateTime GetCreatedDate()
        {
            return ((DateTime)PostedCheckin.CreatedTime).Date;
        }

        public double? GetLatitude()
        {
            return PostedCheckin.Place.Location.Latitude;
        }

        public double? GetLongitude()
        {
            return PostedCheckin.Place.Location.Longitude;
        }
    }
}