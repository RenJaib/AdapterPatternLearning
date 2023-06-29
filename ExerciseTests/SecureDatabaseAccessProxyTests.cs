using Exercise;
using Exercise.Interfaces;
using Moq;
using System.Runtime.CompilerServices;

namespace ExerciseTests
{
    public class SecureDatabaseAccessProxyTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Valid_User_Should_be_Granted_Access()
        {
            //arrange
            var databaseAccessMock = new Mock<IDatabaseAccess>();
            databaseAccessMock.Setup(x => x.GetUserInfo(It.Is<string>(key => key.Equals("validUser")))).Returns("User Info for validUser");

            var userPermissionServiceMock = new Mock<IUserPermissionService>();
            userPermissionServiceMock.Setup(x => x.UserHasAccess(It.Is<string>(key=>key.Equals("validUser")))).Returns((bool)true);

            var sut = new SecureDatabaseAccessProxy(databaseAccessMock.Object, userPermissionServiceMock.Object);


            //act
            var result = sut.GetUserInfo("validUser");

            //assert
            Assert.AreEqual("User Info for validUser", result);


        }


        [Test]
        public void InValid_User_Should_not_be_Granted_Access()
        {
            //arrange
            var databaseAccessMock = new Mock<IDatabaseAccess>();
            //databaseAccessMock.Setup(x => x.GetUserInfo(It.Is<string>(key => key.Equals("inValidUser")))).Returns("User Info for inValidUser");

            var userPermissionServiceMock = new Mock<IUserPermissionService>();
            userPermissionServiceMock.Setup(x => x.UserHasAccess(It.Is<string>(key => key.Equals("inValidUser")))).Returns((bool)false);

            var sut = new SecureDatabaseAccessProxy(databaseAccessMock.Object, userPermissionServiceMock.Object);


            //act and assert
            Assert.Throws<UnauthorizedAccessException>(() => sut.GetUserInfo("inValidUser"));
        }
    }
}