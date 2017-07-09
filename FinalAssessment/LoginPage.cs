using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;


namespace FinalAssessment
{
    class LoginPage
    {
        public LoginPage(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Id, Using = "login-email")]
        private IWebElement emailLog { get; set; }


        [FindsBy(How = How.Id, Using = "login-password")]
        private IWebElement passLog { get; set; }

        [FindsBy(How = How.Id, Using = "login-submit")]
        private IWebElement buttonLog { get; set; }

        public void Login(string email,string pass)
        {
            emailLog.SendKeys(email);
            passLog.SendKeys(pass);
            buttonLog.Submit();
        }
    }
}
