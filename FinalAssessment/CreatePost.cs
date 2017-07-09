using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium.Support.PageObjects;
using System.Collections.Generic;

namespace FinalAssessment
{
    class CreatePost
    {
        public CreatePost(IWebDriver driver, string url)
        {
            driver.Navigate().GoToUrl(url);
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.ClassName, Using = "Sans-17px-black-70%")]
        private IWebElement ClickPrePost { get; set; }

        [FindsBy(How = How.ClassName, Using = "sharing-textarea__autoresized-area")]
        private IWebElement PostSection { get; set; }

        [FindsBy(How = How.ClassName, Using = "sharing-share-box__post-button-container")]
        private IWebElement SubmitPost { get; set; }

        public void CreatePostbyUser(string text)
        {
            ClickPrePost.Click();
            PostSection.SendKeys(text);
            SubmitPost.Click();
        }
    }
}
