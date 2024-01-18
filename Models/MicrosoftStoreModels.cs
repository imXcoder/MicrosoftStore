using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MicrosoftStore.Models
{
    public class MicrosoftStoreDataObject
    { 
        public TopFreeAppsDataObject TopFreeApps { get; set; }
        public FeaturedGameAppDataObject FeaturedGameApp { get; set; }

        public MicrosoftStoreDataObject() 
        {
        }
    }

    public class TopFreeAppsDataObject
    {
        public string Title { get; set; }

        public string ChevronRightImageLocation { get; set; }

        public List<AppItemDataObject> ProductList { get; set; }

        public TopFreeAppsDataObject()
        {

        }
    }

    public class FeaturedGameAppDataObject
    {
        public string Title { get; set; }

        public AppItemDataObject Product { get; set; }
    }

    public class AppItemDataObject
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public string AverageRating { get; set; }

        public string AverageRatingImageLocation {  get; set; }

        public string Category { get; set; }

        public string DisplayPrice { get; set; }

        public string ProductId { get; set; }

        public string IconImageLocation { get; set; }

        public string IconImageBackground { get; set; }

        public AppItemDataObject()
        {
        }
    }
}
