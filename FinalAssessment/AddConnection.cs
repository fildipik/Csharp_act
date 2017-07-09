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
        public AddConnection(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//*[@id='nav - search - controls - wormhole']/button")]
        private IWebElement ClickHomeSearch { get; set; }

        //[FindsBy(How = How.ClassName, Using = "ember-text-field ember-view")]
        //private IWebElement ClickSearch { get; set; }
        
        [FindsBy(How = How.XPath, Using = "//*[@id='a11y - ember4969']")]
        private IWebElement SearchName { get; set; }

        [FindsBy(How = How.ClassName, Using = "submit-button button-primary-large")]
        private IWebElement SearchButton { get; set; }
        
        [FindsBy(How = How.ClassName, Using = "search-result__actions--primary button-secondary-medium m5")]
        private IWebElement ConnectButton { get; set; }

        public void AddConnectionByUser(string name)
        {
            ClickHomeSearch.Click();
            //ClickSearch.Click();
            SearchName.SendKeys(name);
            SearchButton.Submit();
            ConnectButton.Click();
        }

    }
}
