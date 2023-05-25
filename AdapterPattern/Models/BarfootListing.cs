using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.Models
{
    public class BarfootListing
    {
        public string listingNumber { get; set; }
        public string addressNumber { get; set; }
        public string addressStreet { get; set; }
        public int bedrooomCount { get; set; }
        public int bathroomCount { get; set; }
    }
}
