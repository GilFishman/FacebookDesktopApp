using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesktopFacebookUI
{
    public interface IButtonObserver
    {
        void Notify(bool i_IsClicked);
    }
}
