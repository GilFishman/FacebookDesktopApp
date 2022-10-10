using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using FacebookWrapper.ObjectModel;
using System.Globalization;
using System.Windows.Forms;

namespace DesktopFacebookLogic
{
    public class AppLogic
    {
        public static void LoadPicture(object i_Sender, string i_PictureUrl)
        {
            PictureBox currentPictureBox = i_Sender as PictureBox;

            if (!string.IsNullOrEmpty(i_PictureUrl))
            {
                currentPictureBox.LoadAsync(i_PictureUrl);
            }
            else
            {
                currentPictureBox.Image = null;
            }
        }

        public static string CheckValidAPI(string i_APIrequest)
        {
            string checkPermission = string.Empty;

            if (!string.IsNullOrEmpty(i_APIrequest))
            {
                checkPermission = i_APIrequest;
            }

            return checkPermission;
        }

        public static string GetCoverPhotoURL(User i_LoggedInUser)
        {
            string UrlToReturn = "";

            foreach (Album album in i_LoggedInUser.Albums)
            {
                if ((album.Name.Equals("Cover Photos") || album.Name.Equals("תמונות נושא")) && album.PictureAlbumURL != null)
                {
                    UrlToReturn = album.Photos.First().PictureNormalURL;
                }
            }

            return UrlToReturn;
        }

        public static IEnumerable<Post> GetUserPost(User i_LoggedInUser)
        {
            int postCounter = i_LoggedInUser.Posts.Count();
            int postIndex = 0; 
            while (postIndex < postCounter - 1)
            {
                if (i_LoggedInUser.Posts[postIndex].Message != null)
                {
                    postIndex++;
                    yield return i_LoggedInUser.Posts[postIndex];
                }
                else
                {
                    postIndex++; 
                }
            }
        }
    }
}
