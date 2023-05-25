using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.Models;

namespace AdapterPattern
{
    public class AddListingToWebsiteAdaptee
    {
        public string publishListingToWebsite(BarfootListing listing)
        {
            return  $"{listing.listingNumber}: {listing.addressNumber} {listing.addressStreet}";
        }
    }
}
