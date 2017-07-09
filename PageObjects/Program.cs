using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;


namespace PageObjects
{
    class UserRegistration
    {
        public UserRegistration(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "reg-firstname")]
        private IWebElement FirstNameReg { get; set; }

        [FindsBy(How = How.Id, Using = "reg-lastname")]
        private IWebElement LastNameReg { get; set; }

        [FindsBy(How = How.Id, Using = "reg-email")]
        private IWebElement EMailReg { get; set; }

        [FindsBy(How = How.Id, Using = "reg-password")]
        private IWebElement PasswordReg { get; set; }

    }
}
