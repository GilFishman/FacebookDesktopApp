using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesktopFacebookLogic;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace DesktopFacebookUI
{
    public class DefaultSorter: SortPosts
    {
        public override int GetChoosenPriority(User i_loggedInUser)
        {
            IFeature feature = FactoryMethod.Create(FactoryMethod.eFeatureTypes.DefaultSort, i_loggedInUser);
            feature.RunFeature();
            FormSelectDefaultSort formSelectDefaultSort = feature as FormSelectDefaultSort;
            FormSelectDefaultSort.ePriority priority = formSelectDefaultSort.GetPriority();

            return (int)priority;
        }
    }
}
