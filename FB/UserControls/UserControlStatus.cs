using System;
using System.Drawing;
using System.Windows.Forms;

namespace FB.UserControls
{
    public partial class UserControlStatus : UserControl
    {
        public UserControlStatus()
        {
            InitializeComponent();            
        }

        private void richTextBoxStatus_Enter(object sender, EventArgs e)
        {
            this.RichTextBoxStatus.ForeColor = Color.Black;
            this.RichTextBoxStatus.Text = string.Empty;
        }

        private void richTextBoxStatus_Leave(object sender, EventArgs e)
        {
            if(this.RichTextBoxStatus.Text == string.Empty)
            {
                this.RichTextBoxStatus.ForeColor = SystemColors.InactiveCaption;
                this.RichTextBoxStatus.Text = "What's on your mind?";
            }
        }

        private void buttonSubmitStatus_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(RichTextBoxStatus.Text))
            {
                LoggedInUser.Instance.PostStatus(RichTextBoxStatus.Text);
                LoggedInUser.Instance.ReFetch();
            }
            else
            {
                MessageBox.Show("You can not post an empty status");
            }

            this.RichTextBoxStatus.ForeColor = SystemColors.InactiveCaption;
            this.RichTextBoxStatus.Text = "What's on your mind?";
        }
    }
}
