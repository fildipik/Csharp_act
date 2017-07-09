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

        

        [FindsBy(How = How.Id, Using = "first-name")]
        private IWebElement FirstNameReg { get; set; }

        [FindsBy(How = How.Id, Using = "last-name")]
        private IWebElement LastNameReg { get; set; }

        [FindsBy(How = How.Id, Using = "join-email")]
        private IWebElement EMailReg { get; set; }

        [FindsBy(How = How.Id, Using = "join-password")]
        private IWebElement PasswordReg { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"uno-reg-join\"]/div/div/div/div[2]/div[1]/div/div/form/fieldset/button/span")]
        private IWebElement SubmitButton { get; set; }

        //[FindsBy(How = How.Id, Using = "country-select")]
        //private IWebElement CountrySelect { get; set; }

        [FindsBy(How = How.Name, Using = "number-input")]
        private IWebElement PhoneNum { get; set; }

        [FindsBy(How = How.Id, Using = "submitPage1")]
        private IWebElement SendCode { get; set; }


        public void CountryCode()
        {
            IWebElement countryCode = driver.FindElement(By.Id("country-select"));
            var selectCountry = new SelectElement(countryCode);
            selectCountry.SelectByValue("ph");
        }
        public void Register(string first, string last , string email, string pass,string phone)
        {


            FirstNameReg.SendKeys(first);
            LastNameReg.SendKeys(last);
            EMailReg.SendKeys(email);
            PasswordReg.SendKeys(pass);
            SubmitButton.Submit();
            CountryCode();
            PhoneNum.SendKeys(phone);
            SendCode.Submit();

        }
    }
}
