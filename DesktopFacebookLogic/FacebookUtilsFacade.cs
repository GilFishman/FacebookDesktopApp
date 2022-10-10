using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FacebookWrapper;

namespace DesktopFacebookLogic
{
    public class FacebookUtilsFacade
    {
        public static User LoginInFacade (DialogResult i_FormMainResult)
        {
            User loggedInUser = new User();

            Clipboard.SetText("design.patterns20cc"); /// the current password for Desig Patter

            FacebookWrapper.LoginResult loginResult = FacebookService.Login(
                    "1055263885193772",
                    /// requested permissions:
                    "email",
                    "public_profile",
                    "user_posts",
                    "user_friends",
                    "user_photos"
                    );

            if (i_FormMainResult != DialogResult.Cancel)
            {
                loggedInUser = loginResult.LoggedInUser; 
            }

            return loggedInUser;
        }

        public static void LogOutFacade()
        {
            FacebookService.LogoutWithUI();
        }
    }
}
