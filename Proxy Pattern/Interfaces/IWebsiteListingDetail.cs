using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy_Pattern.Interfaces
{
    public interface IWebsiteListingDetail
    {
        int GetListingNumber();
        string GetListingAddress();
        string GetListingVendorDetails();
    }
}
