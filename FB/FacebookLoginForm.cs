using System;
using System.Drawing;
using System.Windows.Forms;

namespace FB
{
    public partial class FacebookLoginForm : Form
    {
        public bool RememberMe { get; set; }

        public FacebookLoginForm()
        {
            InitializeComponent();

            this.BackColor = Color.FromArgb(59, 89, 153);
            this.buttonLogin.BackColor = Color.FromArgb(87, 127, 188);
            this.buttonLogin.ForeColor = Color.FromArgb(190, 202, 222);
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (LoggedInUser.Instance != null)
            {
                RememberMe = this.checkBoxRememberMe.Checked;

                this.Close();
            }
        }
    }
}