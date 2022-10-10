using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookUI
{
    public abstract class SortPosts
    {
        public abstract int GetChoosenPriority(User i_loggedInUser);
    }
}
