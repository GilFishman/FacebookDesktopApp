using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesktopFacebookLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookUI
{
   public class PrioritySorter :SortPosts
   {
        public override int GetChoosenPriority(User i_loggedInUser)
        {
            IFeature feature = FactoryMethod.Create(FactoryMethod.eFeatureTypes.PrioritySort, i_loggedInUser);
            feature.RunFeature();
            FormSelectPriority formSelectPriority = feature as FormSelectPriority;
            FormSelectPriority.ePriority priority = formSelectPriority.GetPriority();

            return (int)priority; 
        }
    }
}
