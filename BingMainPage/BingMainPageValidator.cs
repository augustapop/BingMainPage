using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BingMainPage
{
   public class BingMainPageValidator
    {
       private readonly IWebDriver browser;

       public BingMainPageValidator(IWebDriver browser)
       {
           this.browser = browser;
       }

       protected BingMainPageElementMap Map
       {
           get 
           {
               return new BingMainPageElementMap(this.browser);
           }
       }
       public void ResultCount(string expectedCount)
       {
           Assert.IsTrue(this.Map.ResultCountDiv.Text.Contains(expectedCount));
       }
    }

}
