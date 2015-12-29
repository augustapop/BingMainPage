using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;

namespace BingMainPage
{
    [TestClass]
    public class BingTest
    {
        public IWebDriver Driver { get; set; }
        public WebDriverWait Wait { get; set; }
        
        [TestInitialize]
        public void SetupTest()
        {
            this.Driver = new FirefoxDriver();
            this.Wait = new WebDriverWait(this.Driver,TimeSpan.FromSeconds(30));

        }

        [TestCleanup]
        public void TeardownTest()
        {
            this.Driver.Quit();
        }

        [TestMethod]
        public void SearchTextInBing_First()
        {
            BingMainPage bingMainPage = new BingMainPage(this.Driver);
            bingMainPage.Navigate();
            bingMainPage.Search("Automate The Planet");
            bingMainPage.ValidateResultsCount("319,000 RESULTS");

        }
        [TestMethod]

        public void SeacrchTextInBing_Second()
        {
            BingMainPageMap bingPAge = new BingMainPageMap(this.Driver);
            bingPAge.Navigate();
            bingPAge.Search("Automate The Planet");
            bingPAge.Validate().ResultCount("319,000 RESULTS");
        }
        [TestMethod]
        public void ClickEveryHrefMenu()
        {
            this.Driver.Navigate().GoToUrl(@"http://www.telerik.com/");
            // get the menu div
            var menuList = this.Driver.FindElement(By.Id("GeneralContent_T73A12E0A142_Col01"));
            // get all links from the menu div
            var menuHrefs = menuList.FindElements(By.ClassName("Bar-menu"));

            // Now start clicking and navigating back
            foreach (var currentHref in menuHrefs)
            {
                this.Driver.Navigate().GoToUrl(@"http://www.telerik.com/");
                currentHref.Click();
                string currentElementHref = currentHref.GetAttribute("href");
                Assert.IsTrue(this.Driver.Url.Contains(currentElementHref));
                // Now the same will happen for the next href
            }
        }
    }
}
