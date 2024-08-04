namespace BasicFacebookFeatures
{
    partial class FormFriendMatcher
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFriendMatcher));
            this.radioButtonMale = new System.Windows.Forms.RadioButton();
            this.radioButtonFemale = new System.Windows.Forms.RadioButton();
            this.radioButtonBoth = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.comboBoxMinAge = new System.Windows.Forms.ComboBox();
            this.comboBoxMaxAge = new System.Windows.Forms.ComboBox();
            this.labelAge = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.labelLocation = new System.Windows.Forms.Label();
            this.buttonFindMyMatch = new System.Windows.Forms.Button();
            this.labelLikedPages = new System.Windows.Forms.Label();
            this.listBoxBestMatches = new System.Windows.Forms.ListBox();
            this.labelMatches = new System.Windows.Forms.Label();
            this.linkLikedPages = new System.Windows.Forms.LinkLabel();
            this.pictureBoxLikedPages = new System.Windows.Forms.PictureBox();
            this.checkedListBoxLikedPages = new System.Windows.Forms.CheckedListBox();
            this.labelWelcomeFriendMatcher = new System.Windows.Forms.Label();
            this.radioButtonTop3 = new System.Windows.Forms.RadioButton();
            this.radioButtonTop10 = new System.Windows.Forms.RadioButton();
            this.radioButtonTopAll = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkedListBoxLocation = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // radioButtonMale
            // 
            this.radioButtonMale.AutoSize = true;
            this.radioButtonMale.Location = new System.Drawing.Point(16, 87);
            this.radioButtonMale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonMale.Name = "radioButtonMale";
            this.radioButtonMale.Size = new System.Drawing.Size(58, 20);
            this.radioButtonMale.TabIndex = 0;
            this.radioButtonMale.TabStop = true;
            this.radioButtonMale.Text = "Male";
            this.radioButtonMale.UseVisualStyleBackColor = true;
            // 
            // radioButtonFemale
            // 
            this.radioButtonFemale.AutoSize = true;
            this.radioButtonFemale.Location = new System.Drawing.Point(95, 87);
            this.radioButtonFemale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonFemale.Name = "radioButtonFemale";
            this.radioButtonFemale.Size = new System.Drawing.Size(74, 20);
            this.radioButtonFemale.TabIndex = 1;
            this.radioButtonFemale.TabStop = true;
            this.radioButtonFemale.Text = "Female";
            this.radioButtonFemale.UseVisualStyleBackColor = true;
            // 
            // radioButtonBoth
            // 
            this.radioButtonBoth.AutoSize = true;
            this.radioButtonBoth.Location = new System.Drawing.Point(190, 87);
            this.radioButtonBoth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonBoth.Name = "radioButtonBoth";
            this.radioButtonBoth.Size = new System.Drawing.Size(55, 20);
            this.radioButtonBoth.TabIndex = 2;
            this.radioButtonBoth.TabStop = true;
            this.radioButtonBoth.Text = "Both";
            this.radioButtonBoth.UseVisualStyleBackColor = true;
            this.radioButtonBoth.CheckedChanged += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.Location = new System.Drawing.Point(13, 69);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(225, 16);
            this.labelGender.TabIndex = 3;
            this.labelGender.Text = "Please select your preferred gender:";
            // 
            // comboBoxMinAge
            // 
            this.comboBoxMinAge.FormattingEnabled = true;
            this.comboBoxMinAge.Location = new System.Drawing.Point(56, 135);
            this.comboBoxMinAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMinAge.Name = "comboBoxMinAge";
            this.comboBoxMinAge.Size = new System.Drawing.Size(54, 24);
            this.comboBoxMinAge.TabIndex = 4;
            // 
            // comboBoxMaxAge
            // 
            this.comboBoxMaxAge.FormattingEnabled = true;
            this.comboBoxMaxAge.Location = new System.Drawing.Point(140, 135);
            this.comboBoxMaxAge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMaxAge.Name = "comboBoxMaxAge";
            this.comboBoxMaxAge.Size = new System.Drawing.Size(50, 24);
            this.comboBoxMaxAge.TabIndex = 5;
            // 
            // labelAge
            // 
            this.labelAge.AutoSize = true;
            this.labelAge.Location = new System.Drawing.Point(12, 138);
            this.labelAge.Name = "labelAge";
            this.labelAge.Size = new System.Drawing.Size(35, 16);
            this.labelAge.TabIndex = 6;
            this.labelAge.Text = "Age:";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(115, 138);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(18, 16);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "to";
            // 
            // labelLocation
            // 
            this.labelLocation.AutoSize = true;
            this.labelLocation.Location = new System.Drawing.Point(13, 174);
            this.labelLocation.Name = "labelLocation";
            this.labelLocation.Size = new System.Drawing.Size(61, 16);
            this.labelLocation.TabIndex = 8;
            this.labelLocation.Text = "Location:";
            // 
            // buttonFindMyMatch
            // 
            this.buttonFindMyMatch.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonFindMyMatch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonFindMyMatch.Location = new System.Drawing.Point(562, 72);
            this.buttonFindMyMatch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonFindMyMatch.Name = "buttonFindMyMatch";
            this.buttonFindMyMatch.Size = new System.Drawing.Size(141, 51);
            this.buttonFindMyMatch.TabIndex = 10;
            this.buttonFindMyMatch.Text = "Find My Match";
            this.buttonFindMyMatch.UseVisualStyleBackColor = false;
            this.buttonFindMyMatch.Click += new System.EventHandler(this.buttonFindMyMatch_Click);
            // 
            // labelLikedPages
            // 
            this.labelLikedPages.AutoSize = true;
            this.labelLikedPages.Location = new System.Drawing.Point(12, 261);
            this.labelLikedPages.Name = "labelLikedPages";
            this.labelLikedPages.Size = new System.Drawing.Size(86, 16);
            this.labelLikedPages.TabIndex = 12;
            this.labelLikedPages.Text = "Liked Pages:";
            // 
            // listBoxBestMatches
            // 
            this.listBoxBestMatches.FormattingEnabled = true;
            this.listBoxBestMatches.ItemHeight = 16;
            this.listBoxBestMatches.Location = new System.Drawing.Point(129, 36);
            this.listBoxBestMatches.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxBestMatches.Name = "listBoxBestMatches";
            this.listBoxBestMatches.Size = new System.Drawing.Size(175, 100);
            this.listBoxBestMatches.TabIndex = 13;
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.Location = new System.Drawing.Point(18, 32);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(91, 16);
            this.labelMatches.TabIndex = 14;
            this.labelMatches.Text = "Best Matches:";
            // 
            // linkLikedPages
            // 
            this.linkLikedPages.AutoSize = true;
            this.linkLikedPages.LinkArea = new System.Windows.Forms.LinkArea(0, 17);
            this.linkLikedPages.Location = new System.Drawing.Point(117, 257);
            this.linkLikedPages.Name = "linkLikedPages";
            this.linkLikedPages.Size = new System.Drawing.Size(221, 35);
            this.linkLikedPages.TabIndex = 16;
            this.linkLikedPages.TabStop = true;
            this.linkLikedPages.Text = "Fetch Liked Pages\r\n(Click on a page to view it\'s picture)\r\n";
            this.linkLikedPages.UseCompatibleTextRendering = true;
            this.linkLikedPages.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLikedPages_LinkClicked);
            // 
            // pictureBoxLikedPages
            // 
            this.pictureBoxLikedPages.Location = new System.Drawing.Point(17, 293);
            this.pictureBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxLikedPages.Name = "pictureBoxLikedPages";
            this.pictureBoxLikedPages.Size = new System.Drawing.Size(97, 78);
            this.pictureBoxLikedPages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLikedPages.TabIndex = 17;
            this.pictureBoxLikedPages.TabStop = false;
            // 
            // checkedListBoxLikedPages
            // 
            this.checkedListBoxLikedPages.FormattingEnabled = true;
            this.checkedListBoxLikedPages.Location = new System.Drawing.Point(117, 294);
            this.checkedListBoxLikedPages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxLikedPages.Name = "checkedListBoxLikedPages";
            this.checkedListBoxLikedPages.Size = new System.Drawing.Size(253, 89);
            this.checkedListBoxLikedPages.TabIndex = 18;
            this.checkedListBoxLikedPages.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxLikedPages_SelectedIndexChanged);
            // 
            // labelWelcomeFriendMatcher
            // 
            this.labelWelcomeFriendMatcher.AutoSize = true;
            this.labelWelcomeFriendMatcher.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelWelcomeFriendMatcher.Location = new System.Drawing.Point(27, 4);
            this.labelWelcomeFriendMatcher.Name = "labelWelcomeFriendMatcher";
            this.labelWelcomeFriendMatcher.Size = new System.Drawing.Size(610, 54);
            this.labelWelcomeFriendMatcher.TabIndex = 19;
            this.labelWelcomeFriendMatcher.Text = resources.GetString("labelWelcomeFriendMatcher.Text");
            // 
            // radioButtonTop3
            // 
            this.radioButtonTop3.AutoSize = true;
            this.radioButtonTop3.Checked = true;
            this.radioButtonTop3.Location = new System.Drawing.Point(21, 54);
            this.radioButtonTop3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTop3.Name = "radioButtonTop3";
            this.radioButtonTop3.Size = new System.Drawing.Size(63, 20);
            this.radioButtonTop3.TabIndex = 0;
            this.radioButtonTop3.TabStop = true;
            this.radioButtonTop3.Text = "Top 3";
            this.radioButtonTop3.UseVisualStyleBackColor = true;
            this.radioButtonTop3.CheckedChanged += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            // 
            // radioButtonTop10
            // 
            this.radioButtonTop10.AutoSize = true;
            this.radioButtonTop10.Location = new System.Drawing.Point(21, 78);
            this.radioButtonTop10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTop10.Name = "radioButtonTop10";
            this.radioButtonTop10.Size = new System.Drawing.Size(70, 20);
            this.radioButtonTop10.TabIndex = 1;
            this.radioButtonTop10.Text = "Top 10";
            this.radioButtonTop10.UseVisualStyleBackColor = true;
            this.radioButtonTop10.CheckedChanged += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            this.radioButtonTop10.Click += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            // 
            // radioButtonTopAll
            // 
            this.radioButtonTopAll.AutoSize = true;
            this.radioButtonTopAll.Location = new System.Drawing.Point(21, 102);
            this.radioButtonTopAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButtonTopAll.Name = "radioButtonTopAll";
            this.radioButtonTopAll.Size = new System.Drawing.Size(43, 20);
            this.radioButtonTopAll.TabIndex = 2;
            this.radioButtonTopAll.Text = "All";
            this.radioButtonTopAll.UseVisualStyleBackColor = true;
            this.radioButtonTopAll.CheckedChanged += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            this.radioButtonTopAll.Click += new System.EventHandler(this.radioButtonTop_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radioButtonTop10);
            this.panel1.Controls.Add(this.radioButtonTop3);
            this.panel1.Controls.Add(this.radioButtonTopAll);
            this.panel1.Controls.Add(this.labelMatches);
            this.panel1.Controls.Add(this.listBoxBestMatches);
            this.panel1.Location = new System.Drawing.Point(386, 233);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(327, 146);
            this.panel1.TabIndex = 20;
            // 
            // checkedListBoxLocation
            // 
            this.checkedListBoxLocation.FormattingEnabled = true;
            this.checkedListBoxLocation.Location = new System.Drawing.Point(117, 183);
            this.checkedListBoxLocation.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkedListBoxLocation.Name = "checkedListBoxLocation";
            this.checkedListBoxLocation.Size = new System.Drawing.Size(167, 72);
            this.checkedListBoxLocation.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Please select the age range:";
            // 
            // FormFriendMatcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 391);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkedListBoxLocation);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelWelcomeFriendMatcher);
            this.Controls.Add(this.checkedListBoxLikedPages);
            this.Controls.Add(this.pictureBoxLikedPages);
            this.Controls.Add(this.linkLikedPages);
            this.Controls.Add(this.labelLikedPages);
            this.Controls.Add(this.buttonFindMyMatch);
            this.Controls.Add(this.labelLocation);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labelAge);
            this.Controls.Add(this.comboBoxMaxAge);
            this.Controls.Add(this.comboBoxMinAge);
            this.Controls.Add(this.labelGender);
            this.Controls.Add(this.radioButtonBoth);
            this.Controls.Add(this.radioButtonFemale);
            this.Controls.Add(this.radioButtonMale);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormFriendMatcher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFriendMatcher";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLikedPages)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioButtonMale;
        private System.Windows.Forms.RadioButton radioButtonFemale;
        private System.Windows.Forms.RadioButton radioButtonBoth;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.ComboBox comboBoxMinAge;
        private System.Windows.Forms.ComboBox comboBoxMaxAge;
        private System.Windows.Forms.Label labelAge;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label labelLocation;
        private System.Windows.Forms.Button buttonFindMyMatch;
        private System.Windows.Forms.Label labelLikedPages;
        private System.Windows.Forms.ListBox listBoxBestMatches;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.LinkLabel linkLikedPages;
        private System.Windows.Forms.PictureBox pictureBoxLikedPages;
        private System.Windows.Forms.CheckedListBox checkedListBoxLikedPages;
        private System.Windows.Forms.Label labelWelcomeFriendMatcher;
        private System.Windows.Forms.RadioButton radioButtonTop3;
        private System.Windows.Forms.RadioButton radioButtonTop10;
        private System.Windows.Forms.RadioButton radioButtonTopAll;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckedListBox checkedListBoxLocation;
        private System.Windows.Forms.Label label1;
    }
}