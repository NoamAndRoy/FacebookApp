using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace FB
{
    public partial class MasterForm : Form
    {
        public MasterForm FormToOpen { get; private set; }

        public bool Logout { get; set; }

        protected User m_User;

        private MasterForm() // For Designer View
        {
            InitializeComponent();
        }

        public MasterForm(User i_User)
        {
            InitializeComponent();

            this.m_User = i_User;
        }

        private void MasterForm_Load(object sender, EventArgs e)
        {
            Color facebookColor = Color.FromArgb(72, 103, 170);

            this.BackColor = Color.FromArgb(233, 235, 238);
            this.buttonLogout.ForeColor = facebookColor;
            this.buttonNewsFeed.ForeColor = facebookColor;
            this.buttonProfile.ForeColor = facebookColor;
            this.buttonMosiac.ForeColor = facebookColor;
            this.buttonTodayEvents.ForeColor = facebookColor;
            this.panelLogo.BackColor = facebookColor;

            // For Designer View
            if (m_User != null) 
            {
                this.buttonProfile.Text = m_User.Name;
            }

            this.MaximumSize = new Size(882, SystemInformation.MaxWindowTrackSize.Height);
            this.MinimumSize = new Size(882, 666);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookWrapper.FacebookService.Logout(this.Close);
            Logout = true;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            closeForm(new ProfileForm(m_User));
        }

        private void buttonNewsFeed_Click(object sender, EventArgs e)
        {
            closeForm(new NewsFeedForm(m_User));
        }

        private void buttonMosiac_Click(object sender, EventArgs e)
        {
            closeForm(new MosaicCreatorForm(m_User));
        }

        private void buttonTodayEvents_Click(object sender, EventArgs e)
        {
            closeForm(new TodayEventsForm(m_User));
        }

        private void closeForm(MasterForm i_Form)
        {
            FormToOpen = i_Form;
            this.Close();
        }
    }
}
