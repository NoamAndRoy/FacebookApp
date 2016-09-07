using FacebookWrapper.ObjectModel;
using System.Windows.Forms;

namespace FB
{
    public class FormManager
    {
        private User m_loggedInUser;

        public FormManager()
        {
            m_loggedInUser = null;
        }

        public void Run()
        {
            Form formToOpen = openFacebookLoginForm();

            while (formToOpen != null)
            {
                formToOpen = openForm(formToOpen);
            } 
        }

        private Form openFacebookLoginForm()
        {
            Form newsFeedForm = null;

            if (!AppSettings.Instance.RememberMe)
            {
                FacebookLoginForm loginForm = new FacebookLoginForm();
                loginForm.ShowDialog();

                if (loginForm.UserLoginResult != null && loginForm.UserLoginResult.LoggedInUser != null)
                {
                    AppSettings.Instance.RememberMe = loginForm.RememberMe;

                    if (AppSettings.Instance.RememberMe)
                    {
                        AppSettings.Instance.UserAccessToken = loginForm.UserLoginResult.AccessToken;
                    }

                    m_loggedInUser = loginForm.UserLoginResult.LoggedInUser;
                }
            }
            else
            {
                m_loggedInUser = FacebookWrapper.FacebookService.Connect(AppSettings.Instance.UserAccessToken).LoggedInUser;
            }

            if(m_loggedInUser != null)
            {
                newsFeedForm = new ProfileForm(m_loggedInUser);
            }

            return newsFeedForm;
        }

        private Form openForm(Form i_Form)
        {
            Form formToOpen = null;
            MasterForm masterForm = i_Form as MasterForm;

            if (masterForm != null)
            {
                formToOpen = openMasterForm(masterForm);

                if (masterForm.Logout)
                {
                    formToOpen = openFacebookLoginForm();
                }
            }
            else
            {
                formToOpen = openFacebookLoginForm();
            }

            return formToOpen;
        }

        private MasterForm openMasterForm(MasterForm i_MasterForm)
        {
            loadAppSettings(i_MasterForm);

            i_MasterForm.ShowDialog();

            if (i_MasterForm.Logout)
            {
                logout();
            }

            saveAppSettings(i_MasterForm);
            AppSettings.Instance.SaveSettings();

            return i_MasterForm.FormToOpen;
        }

        private void logout()
        {
            AppSettings.Instance.UserAccessToken = string.Empty;
            AppSettings.Instance.RememberMe = false;
        }

        private void loadAppSettings(Form i_Form)
        {
            i_Form.Location = AppSettings.Instance.WindowLocation;
            i_Form.Height = AppSettings.Instance.WindowHeight;
        }

        private void saveAppSettings(Form i_Form)
        {
            AppSettings.Instance.WindowLocation = i_Form.Location;
            AppSettings.Instance.WindowHeight = i_Form.Height;
        }
    }
}