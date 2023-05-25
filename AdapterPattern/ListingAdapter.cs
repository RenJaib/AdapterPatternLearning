using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Interfaces;
using AdapterPattern.Models;

namespace AdapterPattern
{
    public class ListingAdapter: IRealnexListingTarget
    {
        private AddListingToWebsiteAdaptee _adaptee;
        private BarfootListing _barfootListing = new BarfootListing();

        public ListingAdapter(AddListingToWebsiteAdaptee addListingToWebsiteAdaptee)
        {
            _adaptee = addListingToWebsiteAdaptee;
        }

        public string ProcessRealnexListing(string[] realnexListing)
        {
            _barfootListing.listingNumber = realnexListing[0];
            _barfootListing.addressNumber = realnexListing[1];
            _barfootListing.addressStreet = realnexListing[2];

            return _adaptee.publishListingToWebsite(_barfootListing);
        }
    }
}
