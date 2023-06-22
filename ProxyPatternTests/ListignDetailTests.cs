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
        public void GetListingNumber_Should_Return_ListingNumber_when_Input_is_valid()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, "2 test Avenue, Auckland", "Test vendor");

            //act
            var result = listingDetail.GetListingNumber();

            //assert
            Assert.AreEqual(121212, result);
        }

        [Test]
        public void GetListingNumber_Should_throw_exception_when_input_is_zero()
        {
            //arrange
            var listingDetail = new ListingDetail(0, "2 test Avenue, Auckland", "Test vendor");


            //act & assert
            Assert.Throws<Exception>(() => listingDetail.GetListingNumber());
        }

        [Test]
        public void GetListingAddress_Should_return_Address_When_input_is_valid()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, "2 test Avenue, Auckland", "Test vendor");
            
            // act
            var result = listingDetail.GetListingAddress();

            //assert
            Assert.AreEqual("2 test Avenue, Auckland", result);
        }

        [Test]
        public void GetListingAddress_Should_throw_Exception_When_input_is_null()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, null, "Test vendor");

            //act & assert
            Assert.Throws<Exception>(() => listingDetail.GetListingAddress());
        }

        [Test]
        public void GetListingAddress_Should_throw_Exception_Address_input_is_empty()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, "", "Test vendor");

            //act & assert
            Assert.Throws<Exception>(() => listingDetail.GetListingAddress());
        }

        [Test]

        public void GetListingAddress_Should_throw_Exception_When_addressLength_is_greater_Than25()
        {
            //arrange
            var listingDetail = new ListingDetail(121212, "This is a invalid listing address", "Test vendor");

            //act & assert
            Assert.Throws<Exception>(() => listingDetail.GetListingAddress());
        }


    }
}