namespace FB.UserControls
{
    public partial class UserControlProfile : UserControlFacebook
    {
        public UserControlProfile()
        {
            InitializeComponent();
        }

        protected override void initialize()
        {
            userBindingSource.DataSource = LoggedInUser.Instance;
            PictureBoxCoverPhoto.DataBindings.Add("ImageLocation", LoggedInUser.Instance.Cover, "SourceURL");

            LabelLoggedUserName.Parent = PictureBoxCoverPhoto;
        }
    }
}
