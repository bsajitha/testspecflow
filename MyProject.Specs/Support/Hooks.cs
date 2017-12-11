using System;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Chrome;

namespace MyProject.Specs.Support
{
    [Binding]
    public class Hooks
    {   

        [BeforeScenario]
        public void BeforeScenario()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            ScenarioContext.Current["driver"] = driver;
        }


        [AfterScenario]
        public void AfterScenario()
        {
            IWebDriver driver = (IWebDriver)ScenarioContext.Current["driver"];
            if (driver != null)
            {
                driver.Dispose();
            }
        }
    }
}
