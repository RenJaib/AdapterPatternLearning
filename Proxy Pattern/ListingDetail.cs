using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Pattern.Interfaces;

namespace Proxy_Pattern
{
    public class ListingDetail:IWebsiteListingDetail
    {
        private int _listingNumber { get; set; }
        private string _listingAddressStreet { get; set; }
        private string _listingVendorName { get; set; }

        public ListingDetail(int listingNumber,string listingAddressStreet, string listingVendorName)
        {
            _listingNumber = listingNumber;
            _listingAddressStreet = listingAddressStreet;
            _listingVendorName = listingVendorName;
        }

        public int GetListingNumber()
        {
            if (_listingNumber == 0)
            {
                throw new Exception("Listing number is invalid.");
            }
            return _listingNumber;
        }

        public string GetListingAddress()
        {
            if (string.IsNullOrEmpty(_listingAddressStreet))
            {
                throw new Exception("Listing AddressStreet cannot be empty or null");
            }

            if (_listingAddressStreet.Length > 25)
            {
                throw new Exception("AddressStreet exceed max length of 25");
            }

            return _listingAddressStreet;
        }

        public string GetListingVendorDetails()
        {
            return _listingVendorName;
        }
    }
}
