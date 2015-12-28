using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMainPage
{
   public class BingMainPage
    {
       private readonly IWebDriver driver;
       private readonly string url = "http://www.bing.com/";

       public BingMainPage(IWebDriver browser)
       {
           this.driver = browser;
           PageFactory.InitElements(browser,this);
       }

       [FindsBy(How = How.Id, Using = "sb_form_q")]
       public IWebElement SearchBox { get; set; }

       [FindsBy(How = How.Id, Using = "sb_form_go")]
       public IWebElement GoButton { get; set; }

       [FindsBy(How = How.Id, Using = "b_tween")]
       public IWebElement ResultCountDiv { get; set;}


       public void Navigate()
       {
           this.driver.Navigate().GoToUrl(url);
       }

       public void Search(string textToType)
       {
           this.SearchBox.Clear();
           this.SearchBox.SendKeys(textToType);
           this.GoButton.Click();
       }

       public void ValidateResultsCount(string expectedCount)
       {
           Assert.IsTrue(this.ResultCountDiv.Text.Contains(expectedCount));
       }

    }
}
