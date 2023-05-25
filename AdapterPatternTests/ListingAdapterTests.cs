using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;

namespace AdapterPatternTests
{
    public class ListingAdapterTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestListingAdapter_validStringArray()
        {
            //arrange
            var inputdata = new String[]
            {
                "24343534",
                "211",
                "test street"
            };
            var adapter = new ListingAdapter(new AddListingToWebsiteAdaptee());

            //act
            var result = adapter.ProcessRealnexListing(inputdata);

            //assert
            Assert.AreEqual("24343534: 211 test street", result);

        }
        [Test]
        public void TestListingAdapter_emptyStringArray()
        {
            //arrange
            string[] inputdata = new string[] { "", "", "", "" };
            var adapter = new ListingAdapter(new AddListingToWebsiteAdaptee());

            //act
            var result = adapter.ProcessRealnexListing(inputdata);

            //assert
            Assert.AreEqual(":  ", result);
        }

    }
}
