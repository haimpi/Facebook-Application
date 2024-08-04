using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;
using Facebook;

namespace BasicFacebookFeatures
{
    public partial class FormMain : Form
    {
        private FormFriendMatcher m_FriendMatcher;
        private FormCheckinsFinder m_CheckinsFinder;
        private LoginResult m_LoginResult;
        private MainService m_MainService;

        public FormMain(LoginResult i_LoginResult)
        {
            m_LoginResult = i_LoginResult;
            m_MainService = new MainService(m_LoginResult.LoggedInUser);
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 25;
        }

        protected override void OnShown(EventArgs e)
        {
            populateUiFromFacebookData();
            base.OnShown(e);
        }

        private void populateUiFromFacebookData()
        {
            buttonLogin.Text = $"Logged in as {m_LoginResult.LoggedInUser.Name}";
            buttonLogin.BackColor = Color.LightGreen;
            pictureBoxProfile.ImageLocation = m_LoginResult.LoggedInUser.PictureNormalURL;
            buttonLogin.Enabled = false;
            buttonLogout.Enabled = true;

            Thread basicInfoThread = new Thread(fetchBasicInfo);
            Thread userPostsThread = new Thread(fetchUserPosts);
            Thread fetchDataThread = new Thread(fetchData);

            basicInfoThread.Start();
            userPostsThread.Start();
            fetchDataThread.Start();
        }

        private void fetchData()
        {
            List<Thread> threads = new List<Thread>
        {
            new Thread(fetchUserLikedPage),
            //new Thread(fetchUserAlbums), Facebook disabled the option
            new Thread(fetchUserFriends),
            new Thread(fetchFavoriteTeams),
        };

            foreach (Thread thread in threads)
            {
                thread.Start();
            }
        }

        private void fetchBasicInfo()
        {
            List<string> basicInfo = m_MainService.GetBasicInfo();

            listBoxBasicInfo.Invoke(new Action(() =>
            {
                listBoxBasicInfo.Items.Clear();
                listBoxBasicInfo.Items.AddRange(basicInfo.ToArray());
            }));
        }

        private void fetchUserLikedPage()
        {
            var likedPages = m_MainService.GetUserLikedPages();

            listBoxLikedPages.Invoke(new Action(() =>
            {
                listBoxLikedPages.DisplayMember = "Name";
                listBoxLikedPages.DataSource = likedPages;
            }));
        }

        private void fetchUserFriends()
        {
            var friends = m_MainService.GetUserFriends();

            listBoxFriends.Invoke(new Action(() =>
            {
                listBoxFriends.ClearSelected();
                listBoxFriends.DataSource = friends;
            }));
        }

        private void fetchFavoriteTeams()
        {
            var favoriteTeams = m_MainService.GetFavoriteTeams();

            listBoxFavoriteTeams.Invoke(new Action(() =>
            {
                listBoxFavoriteTeams.DisplayMember = "Name";
                listBoxFavoriteTeams.DataSource = favoriteTeams;
            }));
        }

        private void fetchUserAlbums()
        {
            var albums = m_MainService.GetUserAlbums();

            listBoxAlbums.Invoke(new Action(() =>
            {
                listBoxAlbums.DisplayMember = "Name";
                listBoxAlbums.DataSource = albums;
            }));
        }

        private void fetchUserPosts()
        {
            postBindingSource.DataSource = m_MainService.GetUserPosts();
        }

        private void buttonFriendMatcher_Click(object sender, EventArgs e)
        {
            if (m_FriendMatcher == null)
            {
                m_FriendMatcher = new FormFriendMatcher(m_LoginResult.LoggedInUser);
            }

            m_FriendMatcher.ShowDialog();
        }

        private void buttonPost_MouseClick(object sender, MouseEventArgs e)
        {
            string message = textBoxPost.Text;

            if (!string.IsNullOrWhiteSpace(message))
            {
                postToFacebook(message);
            }
            else
            {
                MessageBox.Show("Please enter a message to post.");
            }
        }

        private void postToFacebook(string message)
        {
            try
            {
                m_MainService.PostStatus(message);
                MessageBox.Show("Post successfully shared on Facebook!");
            }
            catch (FacebookApiException ex)
            {
                MessageBox.Show($"Error posting to Facebook: {ex.Message}");
            }
        }

        private void textBoxPost_Enter(object sender, EventArgs e)
        {
            if (textBoxPost.Text == "What do you think?")
            {
                textBoxPost.Text = "";
                textBoxPost.ForeColor = Color.Black;
            }
        }

        private void textBoxPost_Leave(object sender, EventArgs e)
        {
            if (textBoxPost.Text == "")
            {
                textBoxPost.Text = "What do you think?";
                textBoxPost.ForeColor = Color.Silver;
            }
        }

        private void buttonCheckinsFinder_Click(object sender, EventArgs e)
        {
            if (m_CheckinsFinder == null)
            {
                m_CheckinsFinder = new FormCheckinsFinder(m_LoginResult.LoggedInUser);
            }

            m_CheckinsFinder.ShowDialog();
        }

        private void loadPictureFromSelectedItem<T>(
            ListBox i_ListBox, PictureBox i_PictureBox, Func<T, string> i_GetUrlFunc)
        {
            if (i_ListBox.SelectedItems.Count == 1 && i_ListBox.SelectedItem is T selectedItem)
            {
                string pictureUrl = i_GetUrlFunc(selectedItem);

                if (pictureUrl != null)
                {
                    i_PictureBox.LoadAsync(pictureUrl);
                }
            }
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<Album>(listBoxAlbums, pictureBoxAlbums, i_Album => i_Album.PictureAlbumURL);
        }

        private void listBoxFavoriteTeams_SelectedIndexChanged(object i_Sender, EventArgs i_)
        {
            loadPictureFromSelectedItem<OwnerObject>(listBoxFavoriteTeams, pictureBoxFavoriteTeams, i_Page => i_Page.PictureNormalURL);
        }

        private void listBoxFriends_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<OwnerObject>(listBoxFriends, pictureBoxFriends, i_Page => i_Page.PictureNormalURL);
        }

        private void listBoxLikedPages_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadPictureFromSelectedItem<OwnerObject>(listBoxLikedPages, pictureBoxLikedPages, i_Page => i_Page.PictureNormalURL);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.LogoutWithUI();
            buttonLogin.Text = "Login";
            buttonLogin.BackColor = buttonLogout.BackColor;
            m_LoginResult = null;
            buttonLogin.Enabled = true;
            this.Close();
        }
    }
}