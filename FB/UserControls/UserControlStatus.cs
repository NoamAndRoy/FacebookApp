using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FB.UserControls
{
    public partial class UserControlStatus : UserControlFacebook
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

        private void ButtonSubmitStatus_Click(object sender, EventArgs e)
        {
            FacebookUser.PostStatus(RichTextBoxStatus.Text);

            FacebookUser.ReFetch();

            this.RichTextBoxStatus.ForeColor = SystemColors.InactiveCaption;
            this.RichTextBoxStatus.Text = "What's on your mind?";
        }
    }
}
