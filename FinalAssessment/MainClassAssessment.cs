using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using System;
using OpenQA.Selenium.Interactions;

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

        [Test] //OOP Automation
        public void RegistrationPageObject()
        {
            UserRegistration reg = new UserRegistration(_driver, "https://www.linkedin.com/start/join?trk=hb_join");
            reg.Register("zentryy", "cervvvss", "ecervito@gmail.com", "whehehwew", "915844624");
        }
        [Test] //Direct Automation
        public void RegistrationPage()
        {
            _driver.Navigate().GoToUrl("https://www.linkedin.com/start/join?trk=hb_join");
            IWebElement FirstNameReg = _driver.FindElement(By.Id("first-name"));
            FirstNameReg.SendKeys("Edzentryo");
            IWebElement LastNameReg = _driver.FindElement(By.Id("last-name"));
            LastNameReg.SendKeys("Marktryo");
            IWebElement EMailReg = _driver.FindElement(By.Id("join-email"));
            EMailReg.SendKeys("zenragnamail00tryo@gmail.com");
            IWebElement PasswordReg = _driver.FindElement(By.Id("join-password"));
            PasswordReg.SendKeys("T12iGq3r3D00Qo");
            IWebElement SubmitButton = _driver.FindElement(By.XPath("//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span"));
            SubmitButton.Submit();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            IWebElement CountryCode = _driver.FindElement(By.Id("country-select"));
            var SelectCountry = new SelectElement(CountryCode);
            SelectCountry.SelectByValue("ph");
            IWebElement PhoneNum = _driver.FindElement(By.Name("number-input"));
            PhoneNum.SendKeys("9985925947");
            IWebElement SendCode = _driver.FindElement(By.XPath("//*[@id=\"submitChallenge\"]"));
            SendCode.Submit();



        }

        [Test] //OOP Automation
        public void LogInPageObject()
        {
            LoginPage login = new LoginPage(_driver, "https://www.linkedin.com/");
            login.Login("edzencervito@gmail.com", "Ece59087");
        }


        [Test] //OOP Automation
        public void CreatePostObject()
        {
            LogInPageObject();
            CreatePost create = new CreatePost(_driver, "https://www.linkedin.com");
            create.CreatePostbyUser("Hello 1");
        }

        [Test] //OOP Automation
        public void AddConnectionObject()
        {
            LogInPageObject();
            AddConnection connect = new AddConnection(_driver);
            connect.AddConnectionByUser("Antonio Santos Ronda Jr.");
        }

        [Test] //Direct Automation
        public void AddConnection()
        {
            LogInPageObject();
            IWebElement SearchFunction = _driver.FindElement(By.ClassName("ember-text-field"));
            SearchFunction.SendKeys("Antonio Santos Ronda Jr.");
            IWebElement NavigateFunction = _driver.FindElement(By.ClassName("nav-search-button"));
            NavigateFunction.SendKeys(Keys.Enter);
            IWebElement ResultFunction = _driver.FindElement(By.PartialLinkText("Antonio Ronda"));
            ResultFunction.Click();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            IWebElement followButtonElement = _driver.FindElement(By.ClassName("pv-recent-activity-section__follow-button"));
            Actions Interact = new Actions(_driver);
            Interact.MoveToElement(followButtonElement).Click().Perform();

        }




    }
}

