using System;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public partial class FormCheckinsFinder : Form
    {
        private readonly CheckinsFinderService r_CheckinsFacade;

        public FormCheckinsFinder(User i_User)
        {
            InitializeComponent();
            r_CheckinsFacade = new CheckinsFinderService(i_User);
            webBrowserGoogleMap.ScriptErrorsSuppressed = true;
            dgvCheckins.ReadOnly = true;
            dateTimePickerFrom.Enabled = false;
            dateTimePickerTo.Enabled = false;
            setUpDataGridView();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            clearDgv();
            string searchText = textBoxSearch.Text;
            DateTime? dateFrom = checkBoxSearchByDate.Checked ? (DateTime?)dateTimePickerFrom.Value : null;
            DateTime? dateTo = checkBoxSearchByDate.Checked ? (DateTime?)dateTimePickerTo.Value : null;

            r_CheckinsFacade.SetSearchCriteria(searchText, dateFrom, dateTo);
            IIterator iterator = r_CheckinsFacade.CreateIterator();

            while (iterator.MoveNext())
            {
                CheckinInfo checkinInfo = iterator.Current as CheckinInfo;

                if (checkinInfo != null && checkinInfo.PostedCheckin.Place != null)
                {
                    DataGridViewRow row = new DataGridViewRow();

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = checkinInfo.User.Name });
                    row.Cells.Add(new DataGridViewTextBoxCell { Value = checkinInfo.PostedCheckin.CreatedTime });

                    if (!string.IsNullOrEmpty(checkinInfo.PostedCheckin.Message))
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = checkinInfo.PostedCheckin.Message });
                    }
                    else if (!string.IsNullOrEmpty(checkinInfo.PostedCheckin.PictureURL))
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = "[picture]" });
                    }
                    else
                    {
                        row.Cells.Add(new DataGridViewTextBoxCell { Value = "[only checked in]" });
                    }

                    row.Cells.Add(new DataGridViewTextBoxCell { Value = checkinInfo.PostedCheckin.Place.Name });
                    row.Tag = new CheckinInfo(checkinInfo.User, checkinInfo.PostedCheckin);
                    dgvCheckins.Rows.Add(row);
                }
            }
        }

        private void dgvCheckins_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                return;
            }

            if (dgvCheckins.Rows[e.RowIndex].Tag is CheckinInfo checkinInfo)
            {
                User friend = checkinInfo.User;
                string pictureUrl = checkinInfo.PostedCheckin.PictureURL;
                string friendText = checkinInfo.PostedCheckin.Message;

                showCredentialsMapInWebBrowser(checkinInfo.GetLatitude(), checkinInfo.GetLongitude());

                if (friend != null)
                {
                    labelUserText.Text = friendText;
                    labelUserText.Visible = true;
                    pictureBoxPosterProfile.ImageLocation = friend.PictureNormalURL;
                    pictureBoxPosted.ImageLocation = !string.IsNullOrEmpty(pictureUrl) ? pictureUrl : null;
                }
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxSearch.Clear();
            clearDgv();
            clearOriginalPost();
            clearMap();
        }

        private void clearOriginalPost()
        {
            pictureBoxPosterProfile.Image = null;
            pictureBoxPosted.Image = null;
            labelUserText.Text = string.Empty;
        }

        private void clearMap()
        {
            webBrowserGoogleMap.Navigate(r_CheckinsFacade.GetMapUrl());
        }

        private void clearDgv()
        {
            dgvCheckins.Rows.Clear();
        }

        private void setUpDataGridView()
        {
            clearDgv();
            dgvCheckins.Columns.Add("Name", "Name");
            dgvCheckins.Columns.Add("CheckinDate", "Checkin Date");
            dgvCheckins.Columns.Add("Post", "Post");
            dgvCheckins.Columns.Add("CheckinPlace", "Checkin Place");
        }

        private void showCredentialsMapInWebBrowser(double? i_Latitude, double? i_Longitude)
        {
            string url = r_CheckinsFacade.GetMapUrl(i_Latitude, i_Longitude);
            webBrowserGoogleMap.Navigate(url);
        }

        private void checkBoxSearchByDate_CheckedChanged(object sender, EventArgs e)
        {
            bool isChecked = checkBoxSearchByDate.Checked;
            dateTimePickerTo.Enabled = isChecked;
            dateTimePickerFrom.Enabled = isChecked;
        }
    }
}