using System;

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
            userBindingSource.DataSource = FacebookUser;
            PictureBoxCoverPhoto.DataBindings.Add("ImageLocation", FacebookUser.Cover, "SourceURL");

            LabelLoggedUserName.Parent = PictureBoxCoverPhoto;
        }
    }
}
