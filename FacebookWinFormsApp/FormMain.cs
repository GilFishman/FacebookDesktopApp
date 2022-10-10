using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DesktopFacebookUI
{
    public partial class FormMain : Form
    {
        public FormApp m_FormApp; 

        public FormMain()
        {
            InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 100;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
            this.Hide();
            m_FormApp = new FormApp();
            m_FormApp.m_LoggedInUser = DesktopFacebookLogic.FacebookUtilsFacade.LoginInFacade(this.DialogResult);
            m_FormApp.ShowDialog();
            this.Close(); 
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            DesktopFacebookLogic.FacebookUtilsFacade.LogOutFacade(); 
            buttonLogin.Text = "Login";
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
