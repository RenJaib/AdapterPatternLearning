using Proxy_Pattern;



var listingdetail = new ListingDetail(12345, "128 Monarch Ave", "Renju");

var websiteListingDetail = new WebsiteListingDetail(listingdetail);

websiteListingDetail.DisplayListingAddress();
websiteListingDetail.DisplayListingNumber();



