namespace BasicFacebookFeatures
{
    partial class FormCheckinsFinder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckinsFinder));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCheckinsWelcome = new System.Windows.Forms.Label();
            this.groupBoxDate = new System.Windows.Forms.GroupBox();
            this.labelFilterTo = new System.Windows.Forms.Label();
            this.labelFilterFrom = new System.Windows.Forms.Label();
            this.checkBoxSearchByDate = new System.Windows.Forms.CheckBox();
            this.dateTimePickerTo = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerFrom = new System.Windows.Forms.DateTimePicker();
            this.panelCheckinRow = new System.Windows.Forms.Panel();
            this.labelUserText = new System.Windows.Forms.Label();
            this.labelOriginalPost = new System.Windows.Forms.Label();
            this.pictureBoxPosted = new System.Windows.Forms.PictureBox();
            this.pictureBoxPosterProfile = new System.Windows.Forms.PictureBox();
            this.pictureBoxFacebookLogo = new System.Windows.Forms.PictureBox();
            this.dgvCheckins = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.webBrowserGoogleMap = new System.Windows.Forms.WebBrowser();
            this.process1 = new System.Diagnostics.Process();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBoxDate.SuspendLayout();
            this.panelCheckinRow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosted)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckins)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            resources.ApplyResources(this.splitContainer1, "splitContainer1");
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.labelCheckinsWelcome);
            this.splitContainer1.Panel1.Controls.Add(this.groupBoxDate);
            this.splitContainer1.Panel1.Controls.Add(this.panelCheckinRow);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBoxFacebookLogo);
            this.splitContainer1.Panel1.Controls.Add(this.dgvCheckins);
            this.splitContainer1.Panel1.Controls.Add(this.buttonSearch);
            this.splitContainer1.Panel1.Controls.Add(this.textBoxSearch);
            this.splitContainer1.Panel1.Controls.Add(this.buttonReset);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.webBrowserGoogleMap);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelCheckinsWelcome
            // 
            resources.ApplyResources(this.labelCheckinsWelcome, "labelCheckinsWelcome");
            this.labelCheckinsWelcome.Name = "labelCheckinsWelcome";
            // 
            // groupBoxDate
            // 
            this.groupBoxDate.Controls.Add(this.labelFilterTo);
            this.groupBoxDate.Controls.Add(this.labelFilterFrom);
            this.groupBoxDate.Controls.Add(this.checkBoxSearchByDate);
            this.groupBoxDate.Controls.Add(this.dateTimePickerTo);
            this.groupBoxDate.Controls.Add(this.dateTimePickerFrom);
            resources.ApplyResources(this.groupBoxDate, "groupBoxDate");
            this.groupBoxDate.Name = "groupBoxDate";
            this.groupBoxDate.TabStop = false;
            // 
            // labelFilterTo
            // 
            resources.ApplyResources(this.labelFilterTo, "labelFilterTo");
            this.labelFilterTo.Name = "labelFilterTo";
            // 
            // labelFilterFrom
            // 
            resources.ApplyResources(this.labelFilterFrom, "labelFilterFrom");
            this.labelFilterFrom.Name = "labelFilterFrom";
            // 
            // checkBoxSearchByDate
            // 
            resources.ApplyResources(this.checkBoxSearchByDate, "checkBoxSearchByDate");
            this.checkBoxSearchByDate.Name = "checkBoxSearchByDate";
            this.checkBoxSearchByDate.UseVisualStyleBackColor = true;
            this.checkBoxSearchByDate.CheckedChanged += new System.EventHandler(this.checkBoxSearchByDate_CheckedChanged);
            // 
            // dateTimePickerTo
            // 
            this.dateTimePickerTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePickerTo, "dateTimePickerTo");
            this.dateTimePickerTo.Name = "dateTimePickerTo";
            // 
            // dateTimePickerFrom
            // 
            this.dateTimePickerFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            resources.ApplyResources(this.dateTimePickerFrom, "dateTimePickerFrom");
            this.dateTimePickerFrom.Name = "dateTimePickerFrom";
            // 
            // panelCheckinRow
            // 
            this.panelCheckinRow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelCheckinRow.Controls.Add(this.labelUserText);
            this.panelCheckinRow.Controls.Add(this.labelOriginalPost);
            this.panelCheckinRow.Controls.Add(this.pictureBoxPosted);
            this.panelCheckinRow.Controls.Add(this.pictureBoxPosterProfile);
            resources.ApplyResources(this.panelCheckinRow, "panelCheckinRow");
            this.panelCheckinRow.Name = "panelCheckinRow";
            // 
            // labelUserText
            // 
            resources.ApplyResources(this.labelUserText, "labelUserText");
            this.labelUserText.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.labelUserText.Name = "labelUserText";
            // 
            // labelOriginalPost
            // 
            resources.ApplyResources(this.labelOriginalPost, "labelOriginalPost");
            this.labelOriginalPost.BackColor = System.Drawing.Color.Transparent;
            this.labelOriginalPost.Name = "labelOriginalPost";
            // 
            // pictureBoxPosted
            // 
            resources.ApplyResources(this.pictureBoxPosted, "pictureBoxPosted");
            this.pictureBoxPosted.Name = "pictureBoxPosted";
            this.pictureBoxPosted.TabStop = false;
            // 
            // pictureBoxPosterProfile
            // 
            resources.ApplyResources(this.pictureBoxPosterProfile, "pictureBoxPosterProfile");
            this.pictureBoxPosterProfile.Name = "pictureBoxPosterProfile";
            this.pictureBoxPosterProfile.TabStop = false;
            // 
            // pictureBoxFacebookLogo
            // 
            resources.ApplyResources(this.pictureBoxFacebookLogo, "pictureBoxFacebookLogo");
            this.pictureBoxFacebookLogo.Name = "pictureBoxFacebookLogo";
            this.pictureBoxFacebookLogo.TabStop = false;
            // 
            // dgvCheckins
            // 
            this.dgvCheckins.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvCheckins.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvCheckins.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCheckins.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvCheckins.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCheckins.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.dgvCheckins, "dgvCheckins");
            this.dgvCheckins.Name = "dgvCheckins";
            this.dgvCheckins.RowTemplate.Height = 24;
            this.dgvCheckins.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCheckins_CellContentClick);
            // 
            // buttonSearch
            // 
            resources.ApplyResources(this.buttonSearch, "buttonSearch");
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            resources.ApplyResources(this.textBoxSearch, "textBoxSearch");
            this.textBoxSearch.Name = "textBoxSearch";
            // 
            // buttonReset
            // 
            resources.ApplyResources(this.buttonReset, "buttonReset");
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // webBrowserGoogleMap
            // 
            resources.ApplyResources(this.webBrowserGoogleMap, "webBrowserGoogleMap");
            this.webBrowserGoogleMap.Name = "webBrowserGoogleMap";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // FormCheckinsFinder
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "FormCheckinsFinder";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBoxDate.ResumeLayout(false);
            this.groupBoxDate.PerformLayout();
            this.panelCheckinRow.ResumeLayout(false);
            this.panelCheckinRow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosted)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPosterProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFacebookLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCheckins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.WebBrowser webBrowserGoogleMap;
        private System.Windows.Forms.DataGridView dgvCheckins;
        private System.Windows.Forms.PictureBox pictureBoxFacebookLogo;
        private System.Windows.Forms.Panel panelCheckinRow;
        private System.Windows.Forms.PictureBox pictureBoxPosted;
        private System.Windows.Forms.PictureBox pictureBoxPosterProfile;
        private System.Windows.Forms.Label labelOriginalPost;
        private System.Windows.Forms.Label labelUserText;
        private System.Windows.Forms.GroupBox groupBoxDate;
        private System.Windows.Forms.DateTimePicker dateTimePickerFrom;
        private System.Windows.Forms.DateTimePicker dateTimePickerTo;
        private System.Windows.Forms.Label labelCheckinsWelcome;
        private System.Windows.Forms.Label labelFilterTo;
        private System.Windows.Forms.Label labelFilterFrom;
        private System.Windows.Forms.CheckBox checkBoxSearchByDate;
        private System.Windows.Forms.Label label1;
        private System.Diagnostics.Process process1;
    }
}