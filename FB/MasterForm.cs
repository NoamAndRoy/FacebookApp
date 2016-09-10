using System;
using System.Drawing;
using System.Windows.Forms;
using FacebookWrapper;

namespace FB
{
    public abstract partial class MasterForm : Form
    {
        public MasterForm FormToOpen { get; private set; }

        public bool Logout { get; set; }

        private bool m_Initialized = false;

        public MasterForm()
        {
            InitializeComponent();
        }

        private void masterForm_Load(object sender, EventArgs e)
        {
            if (!m_Initialized)
            {
                initialize();
                m_Initialized = true;
            }
        }

        protected virtual void initialize()
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
            if (LoggedInUser.Instance != null)
            {
                this.buttonProfile.Text = LoggedInUser.Instance.Name;
            }

            this.MaximumSize = new Size(882, SystemInformation.MaxWindowTrackSize.Height);
            this.MinimumSize = new Size(882, 666);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.Logout(this.Close);
            Logout = true;
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            closeForm(FormsRepository.Instance[typeof(ProfileForm)]);
        }

        private void buttonNewsFeed_Click(object sender, EventArgs e)
        {
            closeForm(FormsRepository.Instance[typeof(NewsFeedForm)]);
        }

        private void buttonMosiac_Click(object sender, EventArgs e)
        {
            closeForm(FormsRepository.Instance[typeof(MosaicCreatorForm)]);
        }

        private void buttonTodayEvents_Click(object sender, EventArgs e)
        {
            closeForm(FormsRepository.Instance[typeof(TodayEventsForm)]);
        }

        private void closeForm(MasterForm i_Form)
        {
            FormToOpen = i_Form;
            this.Close();
        }

        public static MasterForm CreateForm(Type i_Type)
        {
            MasterForm form = null;
            if(i_Type.IsSubclassOf(typeof(MasterForm)) && i_Type.IsPublic)
            {
                form = Activator.CreateInstance(i_Type) as MasterForm;
            }

            return form;
        }
    }
}