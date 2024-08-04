using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class LoginService
    {
        private readonly AppSettings r_AppSettings;
        private LoginResult m_LoginResult;

        public LoginService()
        {
            r_AppSettings = AppSettings.LoadFromFile();
        }

        public bool RememberUser
        {
            get => r_AppSettings.RememberUser;
            set => r_AppSettings.RememberUser = value;
        }

        public string LastAccessToken
        {
            get => r_AppSettings.LastAccessToken;
            set => r_AppSettings.LastAccessToken = value;
        }

        public void SaveSettings()
        {
            r_AppSettings.SaveToFile();
        }

        public LoginResult Login()
        {
            m_LoginResult = FacebookService.Login(
                "1234",//add here your App ID
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos"
            );
            return m_LoginResult;
        }

        public LoginResult Connect()
        {
            m_LoginResult = FacebookService.Connect(r_AppSettings.LastAccessToken);
            return m_LoginResult;
        }

        public bool IsLoginSuccessful()
        {
            return !string.IsNullOrEmpty(m_LoginResult?.AccessToken) && string.IsNullOrEmpty(m_LoginResult?.ErrorMessage);
        }

        public User GetLoggedInUser()
        {
            return m_LoginResult?.LoggedInUser;
        }

        public string GetAccessToken()
        {
            return m_LoginResult?.AccessToken;
        }
    }
}