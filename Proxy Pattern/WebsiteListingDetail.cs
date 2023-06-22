using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proxy_Pattern.Interfaces;

namespace Proxy_Pattern
{
    public class WebsiteListingDetail
    {
        private IWebsiteListingDetail _websiteListingDetail;

        public WebsiteListingDetail(IWebsiteListingDetail websiteListingDetail)
        {
            _websiteListingDetail = websiteListingDetail;
        }

        

        public void DisplayListingNumber()
        {
            Console.WriteLine($"Lsiting number is {_websiteListingDetail.GetListingNumber()} ");
        }

        public void DisplayListingAddress()
        {
            Console.WriteLine($"Listing address is {_websiteListingDetail.GetListingAddress()}");
        }

        public void DisplayVendorDetails(bool isUserPrimaryAgent)
        {
            if (isUserPrimaryAgent)
            {
                Console.WriteLine($"Listing vendor is {_websiteListingDetail.GetListingVendorDetails()}");
            }
            else
            {
                Console.WriteLine("Access denied!!");
            }

        }

    }
}
