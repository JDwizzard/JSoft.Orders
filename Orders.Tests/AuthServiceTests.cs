using Orders.Api.Services;

namespace Orders.Tests
{
    public class AuthServiceTests
    {
        [SetUp]
        public void Setup()
        {
        }
        
        [TestCase("Wilson")]
        [TestCase("Moore")]
        [TestCase("Taylor")]
        public void Login_ShouldReturnTrue(string lastName)
        {
            //Arrange
            var AuthService = new AuthService();
            
            //Act
            var result = AuthService.Login(lastName);

            //Assert
            Assert.IsTrue(result);

        }

        [TestCase("")]
        [TestCase(null)]
        [TestCase("FalseName")]
        public void Login_ShouldReturnFalse(string lastName)
        {
            //Arrange
            var AuthService = new AuthService();

            //Act
            var result = AuthService.Login(lastName);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
