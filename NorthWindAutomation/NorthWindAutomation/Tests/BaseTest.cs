using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;

namespace NorthWindAutomation
{
    [TestClass]
    public class BaseTest

    {
        public ChromeDriver driver { get; set; }

        [TestInitialize]
        public void InitTest()
        {
            driver = new ChromeDriver(@"C:\Users\lee\Documents\GitHub\NorthWindAutomation");
            driver.Navigate().GoToUrl(Pages.BasePage.NorthWindUrl);
            driver.Manage().Window.Maximize();
        }
        [TestCleanup]
        public void FinishTest()
        {
            driver.Quit();
        }
    }
}
