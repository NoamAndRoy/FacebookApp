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
    public abstract partial class UserControlFacebook : UserControl
    {
        private bool m_Initialized = false;

        public UserControlFacebook()
        {
            InitializeComponent();
        }

        private void UserControlFacebook_Load(object sender, EventArgs e)
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