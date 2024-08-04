using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormFriendMatcher : Form
    {
        private readonly FriendMatcherService r_FriendMatcherFacade;
        private Dictionary<User, int> m_TopScoringFriends;
        private const int k_Top3Friends = 3;
        private const int k_Top10Friends = 10;
        private const int k_AllFriends = int.MaxValue;

        public FormFriendMatcher(User i_User)
        {
            InitializeComponent();
            r_FriendMatcherFacade = new FriendMatcherService(i_User);
            setUpAgeComboBox();
            addCitiesToCheckedListBox();
            listBoxBestMatches.DisplayMember = "Name";
        }

        private void fetchLikedPages()
        {
            checkedListBoxLikedPages.DisplayMember = "Name";

            foreach (Page page in r_FriendMatcherFacade.GetLikedPages())
            {
                checkedListBoxLikedPages.Items.Add(page);
            }
        }

        private void addCitiesToCheckedListBox()
        {
            List<string> israeliCities = r_FriendMatcherFacade.GetCities();

            foreach (string city in israeliCities)
            {
                checkedListBoxLocation.Items.Add(city);
            }
        }

        private void setUpAgeComboBox()
        {
            for (int i = 18; i < 100; i++)
            {
                comboBoxMinAge.Items.Add(i);
                comboBoxMaxAge.Items.Add(i);
            }
        }

        private void linkLikedPages_LinkClicked(object i_Sender, LinkLabelLinkClickedEventArgs i_)
        {
            fetchLikedPages();
        }

        private bool isValidRangeAge()
        {
            return comboBoxMinAge.SelectedItem != null && comboBoxMaxAge.SelectedItem != null
                   && (int)comboBoxMinAge.SelectedItem < (int)comboBoxMaxAge.SelectedItem;
        }

        private void buttonFindMyMatch_Click(object i_Sender, EventArgs i_)
        {
            if (isValidRangeAge())
            {
                m_TopScoringFriends?.Clear();
                m_TopScoringFriends = getTopScoringFriends();
                if (m_TopScoringFriends.Count > 0)
                {
                    displayTopFriends();
                }
                else
                {
                    listBoxBestMatches.Items.Clear();
                    MessageBox.Show("Match not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select valid age!");
            }
        }

        private void radioButtonTop_CheckedChanged(object i_Sender, EventArgs i_)
        {
            displayTopFriends();
        }

        private void displayTopFriends()
        {
            listBoxBestMatches.Items.Clear();
            int counter = 1;
            int topCount = radioButtonTop3.Checked ? k_Top3Friends : (radioButtonTop10.Checked ? k_Top10Friends : k_AllFriends);

            if (m_TopScoringFriends != null)
            {
                IEnumerable<KeyValuePair<User, int>> sortedFriends = m_TopScoringFriends.OrderByDescending(pair => pair.Value).Take(topCount);

                foreach (KeyValuePair<User, int> pair in sortedFriends)
                {
                    listBoxBestMatches.Items.Add($"{counter++}. {pair.Key.Name}");
                }
            }
        }

        private Dictionary<User, int> getTopScoringFriends()
        {
            User.eGender? selectedGender = getSelectedGender();
            int minAge = (int)comboBoxMinAge.SelectedItem;
            int maxAge = (int)comboBoxMaxAge.SelectedItem;

            var criteria = new Dictionary<Type, List<string>>
            {
                { typeof(LocationScoreStrategy), getSelectedLocations() },
                { typeof(LikedPagesScoreStrategy), getSelectedLikedPages() }
            };

            return r_FriendMatcherFacade.FindTopScoringFriends(selectedGender, minAge, maxAge, criteria);
        }

        private User.eGender? getSelectedGender()
        {
            return radioButtonFemale.Checked ? User.eGender.female :
                   radioButtonMale.Checked ? User.eGender.male :
                   (User.eGender?)null;
        }

        private void checkedListBoxLikedPages_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            Page selectedPage = checkedListBoxLikedPages.SelectedItem as Page;

            pictureBoxLikedPages.ImageLocation = selectedPage?.PictureNormalURL;
        }

        private List<string> getSelectedLocations()
        {
            return checkedListBoxLocation.CheckedItems.Cast<string>().ToList();
        }

        private List<string> getSelectedLikedPages()
        {
            return checkedListBoxLikedPages.CheckedItems.Cast<Page>().Select(p => p.Name).ToList();
        }
    }
}