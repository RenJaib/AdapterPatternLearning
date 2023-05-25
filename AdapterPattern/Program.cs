// See https://aka.ms/new-console-template for more information

using AdapterPattern;

var realnexlistingArray = new string[]
{
    "212121",
    "2", 
    "Test Street"
};


AddListingToWebsiteAdaptee listingToWebsiteAdaptee = new AddListingToWebsiteAdaptee();
var adapter = new ListingAdapter(listingToWebsiteAdaptee);
Console.WriteLine(adapter.ProcessRealnexListing(realnexlistingArray));
