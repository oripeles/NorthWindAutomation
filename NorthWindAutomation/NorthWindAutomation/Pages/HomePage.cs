using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace NorthWindAutomation.Pages
{
    public class HomePage : BasePage
    {
        
        private IWebElement Ex => driver.FindElement(By.XPath("//*[@id='app']/div[1]/div[2]/span[5]/div[1]]"));
        private IList<IWebElement> Ex2 => driver.FindElements(By.XPath("s"));
       
        public HomePage(IWebDriver driver) : base(driver) { }
        
    }
}
