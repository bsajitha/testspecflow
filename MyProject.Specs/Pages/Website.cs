
using OpenQA.Selenium;
using System;

namespace MyProject.Specs.Pages
{
    class Website
    {

        private readonly IWebDriver driver;

        public Website(IWebDriver driver)
        {
            this.driver = driver;
 
        }

        public String openURL(string url)
        {
            driver.Navigate().GoToUrl(url);
            return driver.Url;
            
        }

        public void searchItem(string item)
        {
            driver.FindElement(By.Id("site-search")).SendKeys(item);
            driver.FindElement(By.ClassName("header-search_submit")).Click();
        }

        public String getSearchedItems()
        {
            return driver.FindElement(By.ClassName("search-results")).Text;           
        }

    }
}
