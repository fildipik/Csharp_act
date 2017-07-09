using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace FinalAssessment
{
    class AddConnection
    {
        IWebDriver driver;
        
        public AddConnection(IWebDriver driver)
        {
            //driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.ClassName, Using = "ember-text-field")]
        private IWebElement SearchFunction { get; set; }

        [FindsBy(How = How.ClassName, Using = "nav-search-button")]
        private IWebElement NavigateFunction { get; set; }

        [FindsBy(How = How.PartialLinkText, Using = "Antonio Santos Ronda Jr.")]
        private IWebElement ResultFunction { get; set; }

        [FindsBy(How = How.ClassName, Using = "connect primary top-card-action ember-view")]
        private IWebElement ConnectFunction { get; set; }

        public void AddConnectionByUser(string name)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            SearchFunction.SendKeys(name);
            NavigateFunction.SendKeys(Keys.Enter);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            ResultFunction.Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(8);
            ConnectFunction.Click();


        }

    }
}
