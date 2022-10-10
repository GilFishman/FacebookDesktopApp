using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using DesktopFacebookLogic;

namespace DesktopFacebookUI
{
    public partial class FormApp : Form
    {
        private readonly List<Post> r_PostList = new List<Post>();
        private readonly FormLinkedinProfile r_FormLinkedinProfile;
        private readonly FormSelectPriority r_FormSelectPriority;
        private readonly List<ButtonObserver> r_ListenerList = new List<ButtonObserver>(); 

        public FormApp()
        {
            InitializeComponent();
            HandleCreated += formApp_HandleCreated;
            r_ListenerList.Add(buttonLogout);
            r_ListenerList.Add(buttonLinkedin); 
        }

        public User m_LoggedInUser { get; set; }

        private void formApp_HandleCreated(object sender, EventArgs e)
        {
            fetchUserData();
        }

        private void fetchUserData()
        {
            fetchPersonalDetails();
            new Thread(fetchFriends).Start();
            new Thread(fetchAlbums).Start();
            new Thread(fetchPosts).Start();
        }

        private void fetchPersonalDetails()
        {
            AppLogic.LoadPicture(pictureBoxPictureProfile, m_LoggedInUser.PictureNormalURL);
            AppLogic.LoadPicture(pictureBoxPictureCover, getCoverPhotoURL());
            textBoxFirstName.Text = m_LoggedInUser.FirstName;
            textBoxBirthday.Text = m_LoggedInUser.Birthday; 
        }

        private string getCoverPhotoURL()
        {
            return DesktopFacebookLogic.AppLogic.GetCoverPhotoURL(m_LoggedInUser);
        }

        private void fetchAlbums()
        {
            listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Clear()));

            foreach (Album album in m_LoggedInUser.Albums)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add(album.Name)));
            }

            if (m_LoggedInUser.Albums.Count == 0)
            {
                listBoxAlbums.Invoke(new Action(() => listBoxAlbums.Items.Add("No Albums to Show.")));
            }
        }

        private void fetchPosts()
        {
            listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Clear()));

            foreach (Post post in AppLogic.GetUserPost(m_LoggedInUser))
            {
                if (!string.IsNullOrEmpty(post.Name))
                {
                    listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add(post.Name)));
                    r_PostList.Add(post);
                }
            }

            if (m_LoggedInUser.NewsFeed.Count == 0)
            {
                listBoxPosts.Invoke(new Action(() => listBoxPosts.Items.Add("User has no posts to display.")));
            }
        }

        private void fetchFriends()
        {
            listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Clear()));

            foreach (User friend in m_LoggedInUser.Friends)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add(friend)));
            }

            if (m_LoggedInUser.Friends.Count == 0)
            {
                listBoxFriends.Invoke(new Action(() => listBoxFriends.Items.Add("User has no friends to display")));
            }
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            FacebookService.LogoutWithUI();
            this.Hide();
            FormMain newForm = new FormMain();
            newForm.ShowDialog();
            this.Close();
        }

        private void listBoxAlbums_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxAlbums.ClearSelected();
        }

        private void buttonLinkedin_Click(object sender, EventArgs e)
        {
            this.Hide();
            IFeature feature = FactoryMethod.Create(FactoryMethod.eFeatureTypes.Linkedin, m_LoggedInUser);
            feature.RunFeature();
            this.Close(); 
        }

        private void listBoxPosts_SelectedIndexChanged(object sender, EventArgs e)
        {
            FormSelectSort formSelectSort = new FormSelectSort();
            FormSelectSort.eSort chosenSort = formSelectSort.GetChosenSort();

            if (chosenSort == FormSelectSort.eSort.Priority)
            {
                PrioritySorter prioritySorter = new PrioritySorter();
                int priority = prioritySorter.GetChoosenPriority(m_LoggedInUser);

                if (priority == (int)FormSelectPriority.ePriority.Priority1)
                {
                    listBoxPriority1.Items.Add(listBoxPosts.SelectedItem);
                }
                else if (priority == (int)FormSelectPriority.ePriority.Priority2)
                {
                    listBoxPriority2.Items.Add(listBoxPosts.SelectedItem);
                }
                else
                {
                    listBoxPriority3.Items.Add(listBoxPosts.SelectedItem);
                }
            }
            else if (chosenSort == FormSelectSort.eSort.Default)
            {
                DefaultSorter defaultSorter = new DefaultSorter();
                int priority = defaultSorter.GetChoosenPriority(m_LoggedInUser);

                if (priority == (int)FormSelectDefaultSort.ePriority.Red)
                {
                    listBoxRed.Items.Add(listBoxPosts.SelectedItem);
                }
                else if (priority == (int)FormSelectDefaultSort.ePriority.Yellow)
                {
                    listBoxYellow.Items.Add(listBoxPosts.SelectedItem);
                }
                else
                {
                    listBoxGreen.Items.Add(listBoxPosts.SelectedItem);
                }
            }
        }

        private void textBoxRed_Leave(object sender, EventArgs e)
        {
            textBoxRed.Text = textBoxRed.Text;            
        }

        private void textBoxYellow_Leave(object sender, EventArgs e)
        {
            textBoxRed.Text = textBoxRed.Text;
        }

        private void textBoxGreen_Leave(object sender, EventArgs e)
        {
            textBoxRed.Text = textBoxRed.Text;
        }

        private void buttonDisableButtons_Click(object sender, EventArgs e)
        {
            foreach(ButtonObserver button in r_ListenerList)
            {
                button.Notify(true); 
            }
        }

        private void buttonEnableButtons_Click(object sender, EventArgs e)
        {
            foreach (ButtonObserver button in r_ListenerList)
            {
                button.Notify(false);
            }
        }
    }
}
