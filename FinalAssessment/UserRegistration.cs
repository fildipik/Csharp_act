using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace FinalAssessment
{
    class UserRegistration
    {
        IWebDriver driver;

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

        [FindsBy(How = How.Id, Using = "registration-submit")]
        private IWebElement SubmitButton { get; set; }

        //[FindsBy(How = How.Id, Using = "country-select")]
        //private IWebElement CountrySelect { get; set; }

        [FindsBy(How = How.Id, Using = "phoneNumber")]
        private IWebElement PhoneNum { get; set; }

        [FindsBy(How = How.Id, Using = "submitPage1")]
        private IWebElement SendCode { get; set; }


        public void Register(string first, string last , string email, string pass,string country, string phone)
        {
            FirstNameReg.SendKeys(first);
            LastNameReg.SendKeys(last);
            EMailReg.SendKeys(email);
            PasswordReg.SendKeys(pass);
            SubmitButton.Submit();
            new SelectElement(driver.FindElement(By.Name("countryCode"))).SelectByValue(country);
            PhoneNum.SendKeys(phone);
            SendCode.Submit();

        }
    }
}
