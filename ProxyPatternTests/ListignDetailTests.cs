using Proxy_Pattern;

namespace ProxyPatternTests
{
    public class ListingDetailTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetListingNumber_ValidInput_ReturnsListingNumber()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, "", "");

            //act
            var result = listingDetail.GetListingNumber();

            //assert
            Assert.AreEqual(121212, result);
        }

        [Test]
        public void GetListingNumber_ZeroInput_ReturnsZeroListingNumber()
        {
            //arrange
            var listingDetail = new ListingDetail(0, "", "");

            //act
            var result = listingDetail.GetListingNumber();

            //assert
            Assert.AreEqual(0, result);
        }
    }
}