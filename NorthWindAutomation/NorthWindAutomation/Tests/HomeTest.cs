using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NorthWindAutomation.Pages;

namespace NorthWindAutomation.Tests
{
    [TestClass]
    public class HomeTest : BaseTest
    {
        [TestMethod]
        public void Home()
        {
            HomePage Home = new HomePage(driver);
        }
    }
}
