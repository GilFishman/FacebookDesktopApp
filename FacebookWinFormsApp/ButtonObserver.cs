using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 

namespace DesktopFacebookUI
{
    public class ButtonObserver: Button, IButtonObserver
    {
        public void Notify(bool i_IsClicked)
        {
            this.Enabled = !i_IsClicked; 
        }
    }
}
