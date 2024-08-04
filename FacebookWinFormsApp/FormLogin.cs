using FacebookWrapper;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    public partial class FormLogin : Form
    {
        private FormMain m_FormMain;
        private readonly LoginService r_FormLoginService;

        public FormLogin()
        {
            r_FormLoginService = new LoginService();
            InitializeComponent();
            this.checkBoxRememberMe.Checked = r_FormLoginService.RememberUser;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (r_FormLoginService.RememberUser && !string.IsNullOrEmpty(r_FormLoginService.LastAccessToken))
            {
                var loginResult = r_FormLoginService.Connect();

                if (r_FormLoginService.IsLoginSuccessful())
                {
                    switchToFormMain(loginResult);
                }
                else
                {
                    MessageBox.Show(loginResult.ErrorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                login();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            r_FormLoginService.RememberUser = this.checkBoxRememberMe.Checked;
            r_FormLoginService.LastAccessToken = r_FormLoginService.RememberUser ? r_FormLoginService.GetAccessToken() : null;
            r_FormLoginService.SaveSettings();
        }

        private void login()
        {
            var loginResult = r_FormLoginService.Login();

            if (r_FormLoginService.IsLoginSuccessful())
            {
                switchToFormMain(loginResult);
            }
            else
            {
                MessageBox.Show(loginResult.ErrorMessage, "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void switchToFormMain(LoginResult i_LoginResult)
        {
            this.Hide();
            m_FormMain = new FormMain(i_LoginResult);
            m_FormMain.ShowDialog();
            this.Close();
        }
    }
}