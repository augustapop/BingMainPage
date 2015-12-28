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
            bingMainPage.ValidateResultsCount("322,000 RESULTS");

        }
        [TestMethod]

        public void SeacrchTextInBing_Second()
        {
            BingMainPageMap bingPAge = new BingMainPageMap(this.Driver);
            bingPAge.Navigate();
            bingPAge.Search("Automate The Planet");
            bingPAge.Validate().ResultCount("322,000 RESULTS");
        }
    }
}
