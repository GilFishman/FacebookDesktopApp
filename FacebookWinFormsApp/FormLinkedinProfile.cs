using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using DesktopFacebookLogic; 

namespace DesktopFacebookUI
{
    public partial class FormLinkedinProfile : Form, IFeature
    {
        public FormLinkedinProfile(User i_LoggedInUser)
        {
            InitializeComponent();
            fetchUserData(i_LoggedInUser); 
        }

        private void fetchUserData(User i_LoggedInUser)
        {
            fetchProfilePicture(i_LoggedInUser);
            fetchLanguages(i_LoggedInUser);
            fetchEducation(i_LoggedInUser);
            fetchName(i_LoggedInUser);
            fetchAddress(i_LoggedInUser);
            fetchEmail(i_LoggedInUser);
            fetchBio(i_LoggedInUser);
            fetchLastJob(i_LoggedInUser);
        }

        private void fetchProfilePicture(User i_LoggedInUser)
        {
            AppLogic.LoadPicture(pictureBoxPictureProfile, i_LoggedInUser.PictureNormalURL);
        }

        private void fetchName(User i_LoggedInUser)
        {
            TextBoxAdapter textBoxAdapterName = TextBoxAdapter.CreateTextBoxAdapter(i_LoggedInUser, textBoxFirstName);
            
            textBoxAdapterName.TextBoxText = i_LoggedInUser.FirstName;
        }

        private void fetchAddress(User i_LoggedInUser)
        {
            TextBoxAdapter textBoxAdapterAdress = TextBoxAdapter.CreateTextBoxAdapter(i_LoggedInUser, textBoxAddress);
            
            try
            {
                textBoxAdapterAdress.TextBoxText = AppLogic.CheckValidAPI(i_LoggedInUser.Hometown.ToString());
            }
            catch(Exception)
            {
                textBoxAdapterAdress.TextBoxText = string.Empty; 
            }        
        }

        private void fetchEmail(User i_LoggedInUser)
        {
            TextBoxAdapter textBoxAdapterEmail = TextBoxAdapter.CreateTextBoxAdapter(i_LoggedInUser, textBoxEmail);
            
            textBoxAdapterEmail.TextBoxText = i_LoggedInUser.Email;
        }

        private void fetchBio(User i_LoggedInUser)
        {
            TextBoxAdapter textBoxAdapterBio = TextBoxAdapter.CreateTextBoxAdapter(i_LoggedInUser, textBoxBio);
            
            textBoxAdapterBio.TextBoxText = i_LoggedInUser.About;
        }

        private void fetchLanguages(User i_LoggedInUser)
        {
            try
            {
                foreach (Page language in i_LoggedInUser.Languages)
                {
                    listBoxLanguages.Items.Add(AppLogic.CheckValidAPI(language.Name));
                }
            }
            catch (Exception)
            {
                listBoxLanguages.Items.Add("");
            }
        }

        private void fetchEducation(User i_LoggedInUser)
        {
            try
            {
                foreach (Education education in i_LoggedInUser.Educations)
                {
                   listBoxEducation.Items.Add(education.ToString());
                }
            }
            catch(Exception)
            {
                listBoxEducation.Items.Add("");
            }
        }

        private void fetchLastJob(User i_LoggedInUser)
        {
            TextBoxAdapter textBoxAdapterLastJob = TextBoxAdapter.CreateTextBoxAdapter(i_LoggedInUser, textBoxLastJob);
            
            try
            {
                textBoxAdapterLastJob.TextBoxText = i_LoggedInUser.WorkExperiences.ToString();
            }
            catch(Exception)
            {
                textBoxAdapterLastJob.TextBoxText = string.Empty; 
            }
        }

        public void RunFeature()
        {
            this.ShowDialog();
        }
    }
}
