using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace BasicFacebookFeatures
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Panel panelSidebar;
            System.Windows.Forms.Label messageLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.pictureBoxProfile = new System.Windows.Forms.PictureBox();
            this.labelBasicInfo = new System.Windows.Forms.Label();
            this.listBoxBasicInfo = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelPatPosts = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.messageTextBox = new System.Windows.Forms.TextBox();
            this.postBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.labelPosts = new System.Windows.Forms.Label();
            this.listBoxPosts = new System.Windows.Forms.ListBox();
            this.postAdapterBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonCheckinsFinder = new System.Windows.Forms.Button();
            this.panelPost = new System.Windows.Forms.Panel();
            this.textBoxPost = new System.Windows.Forms.TextBox();
            this.buttonPost = new System.Windows.Forms.Button();
            this.buttonFriendMatcher = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.pictureBoxFriends = new System.Windows.Forms.PictureBox();
            this.listBoxFriends = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.listBoxLikedPages = new System.Windows.Forms.ListBox();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.pictureBoxAlbums = new System.Windows.Forms.PictureBox();
            this.listBoxAlbums = new System.Windows.Forms.ListBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listBoxFavoriteTeams = new System.Windows.Forms.ListBox();
            this.pictureBoxFavoriteTeams = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            panelSidebar = new System.Windows.Forms.Panel();
            messageLabel = new System.Windows.Forms.Label();
            panelSidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).BeginInit();
            this.panelPatPosts.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).BeginInit();
            this.panelPost.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeams)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSidebar
            // 
            panelSidebar.BackColor = System.Drawing.Color.White;
            panelSidebar.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.backColor;
            panelSidebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            panelSidebar.Controls.Add(this.buttonLogin);
            panelSidebar.Controls.Add(this.buttonLogout);
            panelSidebar.Controls.Add(this.pictureBoxProfile);
            panelSidebar.Controls.Add(this.labelBasicInfo);
            panelSidebar.Controls.Add(this.listBoxBasicInfo);
            panelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            panelSidebar.Location = new System.Drawing.Point(0, 0);
            panelSidebar.Name = "panelSidebar";
            panelSidebar.Size = new System.Drawing.Size(260, 556);
            panelSidebar.TabIndex = 87;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(3, 4);
            this.buttonLogin.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(251, 32);
            this.buttonLogin.TabIndex = 36;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogout.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonLogout.Location = new System.Drawing.Point(3, 501);
            this.buttonLogout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(88, 33);
            this.buttonLogout.TabIndex = 52;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseCompatibleTextRendering = true;
            this.buttonLogout.UseVisualStyleBackColor = false;
            this.buttonLogout.Click += new System.EventHandler(this.buttonLogout_Click);
            // 
            // pictureBoxProfile
            // 
            this.pictureBoxProfile.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxProfile.Location = new System.Drawing.Point(79, 51);
            this.pictureBoxProfile.Name = "pictureBoxProfile";
            this.pictureBoxProfile.Size = new System.Drawing.Size(110, 113);
            this.pictureBoxProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfile.TabIndex = 55;
            this.pictureBoxProfile.TabStop = false;
            // 
            // labelBasicInfo
            // 
            this.labelBasicInfo.AutoSize = true;
            this.labelBasicInfo.BackColor = System.Drawing.Color.Transparent;
            this.labelBasicInfo.ForeColor = System.Drawing.Color.White;
            this.labelBasicInfo.Location = new System.Drawing.Point(4, 195);
            this.labelBasicInfo.Name = "labelBasicInfo";
            this.labelBasicInfo.Size = new System.Drawing.Size(187, 26);
            this.labelBasicInfo.TabIndex = 74;
            this.labelBasicInfo.Text = "Basic Information:";
            // 
            // listBoxBasicInfo
            // 
            this.listBoxBasicInfo.BackColor = System.Drawing.SystemColors.Window;
            this.listBoxBasicInfo.ForeColor = System.Drawing.Color.Black;
            this.listBoxBasicInfo.FormattingEnabled = true;
            this.listBoxBasicInfo.ItemHeight = 26;
            this.listBoxBasicInfo.Location = new System.Drawing.Point(3, 224);
            this.listBoxBasicInfo.Name = "listBoxBasicInfo";
            this.listBoxBasicInfo.Size = new System.Drawing.Size(253, 134);
            this.listBoxBasicInfo.TabIndex = 73;
            // 
            // messageLabel
            // 
            messageLabel.AutoSize = true;
            messageLabel.Location = new System.Drawing.Point(27, 30);
            messageLabel.Name = "messageLabel";
            messageLabel.Size = new System.Drawing.Size(106, 26);
            messageLabel.TabIndex = 2;
            messageLabel.Text = "Message:";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(259, -54);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(4, 719);
            this.panel1.TabIndex = 92;
            // 
            // panelPatPosts
            // 
            this.panelPatPosts.BackColor = System.Drawing.Color.White;
            this.panelPatPosts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPatPosts.ContextMenuStrip = this.contextMenuStrip1;
            this.panelPatPosts.Controls.Add(this.panel2);
            this.panelPatPosts.Controls.Add(this.labelPosts);
            this.panelPatPosts.Controls.Add(this.listBoxPosts);
            this.panelPatPosts.Location = new System.Drawing.Point(788, 231);
            this.panelPatPosts.Name = "panelPatPosts";
            this.panelPatPosts.Size = new System.Drawing.Size(398, 197);
            this.panelPatPosts.TabIndex = 91;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(messageLabel);
            this.panel2.Controls.Add(this.messageTextBox);
            this.panel2.Location = new System.Drawing.Point(3, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(381, 85);
            this.panel2.TabIndex = 95;
            // 
            // messageTextBox
            // 
            this.messageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.postBindingSource, "Message", true));
            this.messageTextBox.Location = new System.Drawing.Point(139, 30);
            this.messageTextBox.Name = "messageTextBox";
            this.messageTextBox.Size = new System.Drawing.Size(209, 32);
            this.messageTextBox.TabIndex = 3;
            // 
            // postBindingSource
            // 
            this.postBindingSource.DataSource = typeof(FacebookWrapper.ObjectModel.Post);
            // 
            // labelPosts
            // 
            this.labelPosts.AutoSize = true;
            this.labelPosts.Location = new System.Drawing.Point(11, 0);
            this.labelPosts.Name = "labelPosts";
            this.labelPosts.Size = new System.Drawing.Size(73, 26);
            this.labelPosts.TabIndex = 65;
            this.labelPosts.Text = "Posts:";
            // 
            // listBoxPosts
            // 
            this.listBoxPosts.DataSource = this.postBindingSource;
            this.listBoxPosts.FormattingEnabled = true;
            this.listBoxPosts.ItemHeight = 26;
            this.listBoxPosts.Location = new System.Drawing.Point(3, 27);
            this.listBoxPosts.Name = "listBoxPosts";
            this.listBoxPosts.Size = new System.Drawing.Size(376, 82);
            this.listBoxPosts.TabIndex = 64;
            // 
            // buttonCheckinsFinder
            // 
            this.buttonCheckinsFinder.Location = new System.Drawing.Point(290, 392);
            this.buttonCheckinsFinder.Name = "buttonCheckinsFinder";
            this.buttonCheckinsFinder.Size = new System.Drawing.Size(224, 36);
            this.buttonCheckinsFinder.TabIndex = 89;
            this.buttonCheckinsFinder.Text = "Checkins Finder";
            this.buttonCheckinsFinder.UseVisualStyleBackColor = true;
            this.buttonCheckinsFinder.Click += new System.EventHandler(this.buttonCheckinsFinder_Click);
            // 
            // panelPost
            // 
            this.panelPost.BackColor = System.Drawing.Color.White;
            this.panelPost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelPost.ContextMenuStrip = this.contextMenuStrip1;
            this.panelPost.Controls.Add(this.textBoxPost);
            this.panelPost.Controls.Add(this.buttonPost);
            this.panelPost.Location = new System.Drawing.Point(788, 17);
            this.panelPost.Name = "panelPost";
            this.panelPost.Size = new System.Drawing.Size(398, 186);
            this.panelPost.TabIndex = 88;
            // 
            // textBoxPost
            // 
            this.textBoxPost.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.textBoxPost.Location = new System.Drawing.Point(7, 7);
            this.textBoxPost.Multiline = true;
            this.textBoxPost.Name = "textBoxPost";
            this.textBoxPost.Size = new System.Drawing.Size(357, 100);
            this.textBoxPost.TabIndex = 71;
            this.textBoxPost.Text = "What do you think?";
            this.textBoxPost.Enter += new System.EventHandler(this.textBoxPost_Enter);
            this.textBoxPost.Leave += new System.EventHandler(this.textBoxPost_Leave);
            // 
            // buttonPost
            // 
            this.buttonPost.BackColor = System.Drawing.Color.White;
            this.buttonPost.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPost.BackgroundImage")));
            this.buttonPost.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPost.Location = new System.Drawing.Point(281, 113);
            this.buttonPost.Name = "buttonPost";
            this.buttonPost.Size = new System.Drawing.Size(83, 49);
            this.buttonPost.TabIndex = 72;
            this.buttonPost.Text = "Post";
            this.buttonPost.UseVisualStyleBackColor = false;
            this.buttonPost.MouseClick += new System.Windows.Forms.MouseEventHandler(this.buttonPost_MouseClick);
            // 
            // buttonFriendMatcher
            // 
            this.buttonFriendMatcher.Location = new System.Drawing.Point(520, 392);
            this.buttonFriendMatcher.Name = "buttonFriendMatcher";
            this.buttonFriendMatcher.Size = new System.Drawing.Size(219, 36);
            this.buttonFriendMatcher.TabIndex = 86;
            this.buttonFriendMatcher.Text = "Friend Matcher";
            this.buttonFriendMatcher.UseVisualStyleBackColor = true;
            this.buttonFriendMatcher.Click += new System.EventHandler(this.buttonFriendMatcher_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(279, 17);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(473, 352);
            this.tabControl1.TabIndex = 94;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.pictureBoxFriends);
            this.tabPage1.Controls.Add(this.listBoxFriends);
            this.tabPage1.Location = new System.Drawing.Point(4, 35);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(465, 313);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Friends";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // pictureBoxFriends
            // 
            this.pictureBoxFriends.Location = new System.Drawing.Point(310, 82);
            this.pictureBoxFriends.Name = "pictureBoxFriends";
            this.pictureBoxFriends.Size = new System.Drawing.Size(112, 107);
            this.pictureBoxFriends.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFriends.TabIndex = 1;
            this.pictureBoxFriends.TabStop = false;
            // 
            // listBoxFriends
            // 
            this.listBoxFriends.FormattingEnabled = true;
            this.listBoxFriends.ItemHeight = 26;
            this.listBoxFriends.Location = new System.Drawing.Point(9, 23);
            this.listBoxFriends.Name = "listBoxFriends";
            this.listBoxFriends.Size = new System.Drawing.Size(288, 186);
            this.listBoxFriends.TabIndex = 0;
            this.listBoxFriends.SelectedIndexChanged += new System.EventHandler(this.listBoxFriends_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.listBoxLikedPages);
            this.tabPage2.Controls.Add(this.pictureBoxLikedPages);
            this.tabPage2.Location = new System.Drawing.Point(4, 35);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(465, 313);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Liked Pages";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // listBoxLikedPages
            // 
            this.listBoxLikedPages.FormattingEnabled = true;
            this.listBoxLikedPages.ItemHeight = 26;
            this.listBoxLikedPages.Location = new System.Drawing.Point(9, 23);
            this.listBoxLikedPages.Name = "listBoxLikedPages";
            this.listBoxLikedPages.Size = new System.Drawing.Size(288, 186);
            this.listBoxLikedPages.TabIndex = 1;
            this.listBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.listBoxLikedPages_SelectedIndexChanged);
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(310, 82);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(112, 107);
            this.pictureBoxLikedPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPages.TabIndex = 0;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.pictureBoxAlbums);
            this.tabPage3.Controls.Add(this.listBoxAlbums);
            this.tabPage3.Location = new System.Drawing.Point(4, 35);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(465, 313);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Albums";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // pictureBoxAlbums
            // 
            this.pictureBoxAlbums.Location = new System.Drawing.Point(310, 82);
            this.pictureBoxAlbums.Name = "pictureBoxAlbums";
            this.pictureBoxAlbums.Size = new System.Drawing.Size(112, 107);
            this.pictureBoxAlbums.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAlbums.TabIndex = 1;
            this.pictureBoxAlbums.TabStop = false;
            // 
            // listBoxAlbums
            // 
            this.listBoxAlbums.FormattingEnabled = true;
            this.listBoxAlbums.ItemHeight = 26;
            this.listBoxAlbums.Location = new System.Drawing.Point(9, 23);
            this.listBoxAlbums.Name = "listBoxAlbums";
            this.listBoxAlbums.Size = new System.Drawing.Size(288, 186);
            this.listBoxAlbums.TabIndex = 0;
            this.listBoxAlbums.SelectedIndexChanged += new System.EventHandler(this.listBoxAlbums_SelectedIndexChanged);
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listBoxFavoriteTeams);
            this.tabPage4.Controls.Add(this.pictureBoxFavoriteTeams);
            this.tabPage4.Location = new System.Drawing.Point(4, 35);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(465, 313);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Favorite Teams";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listBoxFavoriteTeams
            // 
            this.listBoxFavoriteTeams.FormattingEnabled = true;
            this.listBoxFavoriteTeams.ItemHeight = 26;
            this.listBoxFavoriteTeams.Location = new System.Drawing.Point(9, 23);
            this.listBoxFavoriteTeams.Name = "listBoxFavoriteTeams";
            this.listBoxFavoriteTeams.Size = new System.Drawing.Size(288, 186);
            this.listBoxFavoriteTeams.TabIndex = 1;
            this.listBoxFavoriteTeams.SelectedIndexChanged += new System.EventHandler(this.listBoxFavoriteTeams_SelectedIndexChanged);
            // 
            // pictureBoxFavoriteTeams
            // 
            this.pictureBoxFavoriteTeams.Location = new System.Drawing.Point(310, 82);
            this.pictureBoxFavoriteTeams.Name = "pictureBoxFavoriteTeams";
            this.pictureBoxFavoriteTeams.Size = new System.Drawing.Size(112, 107);
            this.pictureBoxFavoriteTeams.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFavoriteTeams.TabIndex = 0;
            this.pictureBoxFavoriteTeams.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BasicFacebookFeatures.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1197, 556);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelPatPosts);
            this.Controls.Add(this.buttonCheckinsFinder);
            this.Controls.Add(this.panelPost);
            this.Controls.Add(panelSidebar);
            this.Controls.Add(this.buttonFriendMatcher);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FacebookApp";
            panelSidebar.ResumeLayout(false);
            panelSidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfile)).EndInit();
            this.panelPatPosts.ResumeLayout(false);
            this.panelPatPosts.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAdapterBindingSource)).EndInit();
            this.panelPost.ResumeLayout(false);
            this.panelPost.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFriends)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAlbums)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFavoriteTeams)).EndInit();
            this.ResumeLayout(false);

        }

		#endregion
        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Panel panelPatPosts;
        private Label labelPosts;
        private ListBox listBoxPosts;
        private Button buttonCheckinsFinder;
        private Panel panelPost;
        private TextBox textBoxPost;
        private Button buttonPost;
        private Button buttonLogin;
        private Button buttonLogout;
        private PictureBox pictureBoxProfile;
        private Label labelBasicInfo;
        private ListBox listBoxBasicInfo;
        private Button buttonFriendMatcher;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private ListBox listBoxFriends;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private PictureBox pictureBoxFriends;
        private ListBox listBoxLikedPages;
        private PictureBox pictureBoxLikedPages;
        private PictureBox pictureBoxAlbums;
        private ListBox listBoxAlbums;
        private ListBox listBoxFavoriteTeams;
        private PictureBox pictureBoxFavoriteTeams;
        private Panel panel2;
        private BindingSource postAdapterBindingSource;
        private BindingSource postBindingSource;
        private TextBox messageTextBox;
    }
}

