using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Support.UI;
using MyProject.Specs.Pages;

namespace website.specs
{
    [Binding]
    public class WebsiteSteps
    {
        public static IWebDriver driver = (IWebDriver)ScenarioContext.Current["driver"];
        public WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        Website page = new Website(driver);

        [Given(@"I have entered (.*) into the browser")]
        public void GivenIHaveEnteredUrlIntoTheBrowser(String url)
        {
            page.openURL(url);
            
        }

        [When(@"I search for (.*)")]
        public void WhenISearchForItem(String item)
        {
            page.searchItem(item);
        }


        [Then(@"check (.*) items matching the (.*) are returned")]
        public void ThenItemsAreReturned(String count, String item)
        {
            String Expected = count + " results for " + item;
            String Actual = page.getSearchedItems();
                    
            Assert.AreEqual(Expected,Actual);
        }
    }
}

