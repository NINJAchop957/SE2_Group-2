using Microsoft.VisualStudio.TestTools.UnitTesting;
using ScholarStationUnitTests;
using Moq;
using DataClasses;

namespace ScholarStationUnitTests
{
    [TestClass]
    public class ListingTests
    {
        [TestMethod]
        public void TestListing()
        {
            //Arrange
            var listingA = new Listing();
            listingA.Author = null;
            listingA.Body = null;
            listingA.Heading = null;
            var sut = listingA;

            var listingB = new Listing();
            listingB.Author = "Bub Skebulba";
            listingB.Body = "It's Wednesday my dudes.";
            listingB.Heading = "Procrastination Station";

            listingB.AuthorVerification = "U Verified";
            listingB.ListingID = 12345;
            listingB.ListingType = 1234;
            listingB.Subject = "Mathematics";
            listingB.University = "Procastination Institute";

            var sut1 = listingB;

            //Act
            var sutResult = sut.isNull();
            var sut1Result = sut1.isNull();


            //Assert
            Assert.AreEqual(sutResult, true);
            Assert.AreNotEqual(sut1Result, true);
            Assert.AreEqual("U Verified", listingB.AuthorVerification);
            Assert.AreEqual(12345, listingB.ListingID);
            Assert.AreEqual(1234, listingB.ListingType);
            Assert.AreEqual("Mathematics", listingB.Subject);
            Assert.AreEqual("Procastination Institute", listingB.University);
            
        }
    }
}
