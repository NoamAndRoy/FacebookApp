using System;
using System.Windows.Forms;

namespace FB.UserControls
{
    public abstract partial class UserControlFacebook : UserControl
    {
        private bool m_Initialized = false;

        public UserControlFacebook()
        {
            InitializeComponent();
        }

        private void userControlFacebook_Load(object sender, EventArgs e)
        {
            if (!m_Initialized)
            {
                initialize();
                m_Initialized = true;
            }
        }

        protected virtual void initialize()
        {
        }
    }
}