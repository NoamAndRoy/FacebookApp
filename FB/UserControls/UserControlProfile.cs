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
    public partial class UserControlProfile : UserControlFacebook
    {
        public UserControlProfile()
        {
            InitializeComponent();
        }

        private void UserControlProfile_Load(object sender, EventArgs e)
        {
            LabelLoggedUserName.Parent = PictureBoxCoverPhoto;
        }
    }
}
