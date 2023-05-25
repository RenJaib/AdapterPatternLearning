using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern;
using AdapterPattern.Models;

namespace AdapterPatternTests
{
    public class AddListingToWebsiteAdapteeTests
    {
        [SetUp]
        public void Setup()
        {
        }
        [Test]
        public void checkAddListingToWebsiteAdapteeWorks_ForInputthatIsNotNull()
        {
            //arrange
            var inputData = new BarfootListing
            {
                listingNumber = "121212",
                addressNumber = "34",
                addressStreet = "xx street",
                bathroomCount = 10,
                bedrooomCount = 4
            };
            var adaptee = new AddListingToWebsiteAdaptee();

            //act
            var result = adaptee.publishListingToWebsite(inputData);

            //assert
            Assert.AreEqual("121212: 34 xx street", result);
        }

        [Test]
        public void checkAddListingToWebsiteAdapteeWorks_ForInputThatIsNull()
        {
            //arrange
            var inputData = new BarfootListing
            {
                listingNumber = "",
                addressNumber = "",
                addressStreet = "",
                bathroomCount = 10,
                bedrooomCount = 4
            };
            var adaptee = new AddListingToWebsiteAdaptee();

            //act
            var result = adaptee.publishListingToWebsite(inputData);

            //assert
            Assert.AreEqual(":  ", result);
        }
    }
}
