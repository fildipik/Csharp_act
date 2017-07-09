using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;

namespace FinalAssessment
{
    [TestFixture]
    public class MainClassAssessment
    {
        private IWebDriver _driver;

        [OneTimeSetUp]
        public void WebDriver()
        {
            _driver = new FirefoxDriver();
        }
        
        private void GoToUrl (string url)
        {
            _driver.Navigate().GoToUrl(url);
        }

        [SetUp]
        public void LogInPageObject()
        {
            LoginPage login = new LoginPage(_driver, "https://www.linkedin.com/");
            login.Login("edzencervito@gmail.com", "Ece59087");
        }

        [Test]
        public void RegistrationPageObject()
        {
            UserRegistration signUp =new UserRegistration(_driver, "https://www.linkedin.com/");
            signUp.Register("hello", "world", "sadwass@gmail.com", "helowwwworld","ph","9493471435");
        }

        [Test]
        public void CreatePostObject()
        {
            CreatePost create = new CreatePost(_driver, "https://www.linkedin.com/nhome");
            create.CreatePostbyUser("Hello 1");
        }

        [Test]
        public void AddConnectionObject()
        {
            AddConnection connect = new AddConnection(_driver, "https://www.linkedin.com/");
            connect.AddConnectionByUser("Jasmin Lisette Amolar");
        }



    }
}

