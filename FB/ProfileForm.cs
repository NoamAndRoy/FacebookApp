using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FB.UserControls;

namespace FB
{
    public partial class ProfileForm : MasterForm
    {
        public ProfileForm() 
            : base()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(233, 235, 238);

            this.userControlStatus1.ButtonSubmitStatus.Click += buttonSubmitStatus_Click;
        }

        private void buttonSubmitStatus_Click(object sender, EventArgs e)
        {
            panelPosts.Controls.Clear();
            new Thread(loadPosts).Start();
        }

        protected override void initialize()
        {
            base.initialize();
            this.buttonProfile.BackColor = Color.LightGray;

            new Thread(loadPosts).Start();
        }

        private void loadPosts()
        {
            panelPosts.LoadPosts(LoggedInUser.Instance.WallPosts);
        }
    }
}
