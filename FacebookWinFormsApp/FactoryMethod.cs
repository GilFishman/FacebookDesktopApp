using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopFacebookLogic;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookUI
{
    public class FactoryMethod
    {
        public enum eFeatureTypes
        {
            Linkedin,
            PrioritySort,
            DefaultSort
        }

        public static IFeature Create(eFeatureTypes i_FeatureType, User i_LoggedInUser)
        {
            if (i_FeatureType == eFeatureTypes.PrioritySort)
            {
                return new FormSelectPriority();
            }
            else if (i_FeatureType == eFeatureTypes.DefaultSort)
            {
                return new FormSelectDefaultSort(); 
            }
            else
            {
                return new FormLinkedinProfile(i_LoggedInUser);
            }
        }
    }
}
