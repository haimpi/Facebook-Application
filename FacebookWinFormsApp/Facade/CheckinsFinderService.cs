using FacebookWrapper.ObjectModel;
using System;
using System.Collections.Generic;

namespace BasicFacebookFeatures
{
    public class CheckinsFinderService
    {
        private readonly CheckinsFinderLogic r_CheckinsFinderLogic;

        public CheckinsFinderService(User i_User)
        {
            r_CheckinsFinderLogic = new CheckinsFinderLogic(i_User);
        }
        
        public void SetSearchCriteria(string i_SearchText, DateTime? i_DateFrom, DateTime? i_DateTo)
        {
            r_CheckinsFinderLogic.SetSearchCriteria(i_SearchText, i_DateFrom, i_DateTo);
        }

        public List<CheckinInfo> GetFilteredCheckins()
        {
            return r_CheckinsFinderLogic.GetFilteredCheckins();
        }

        public string GetMapUrl(double? i_Latitude, double? i_Longitude)
        {
            return r_CheckinsFinderLogic.GetMapUrl(i_Latitude, i_Longitude);
        }

        public string GetMapUrl()
        {
            return r_CheckinsFinderLogic.GetMapUrl();
        }

        public IIterator CreateIterator()
        {
            return r_CheckinsFinderLogic.CreateIterator();
        }
    }
}