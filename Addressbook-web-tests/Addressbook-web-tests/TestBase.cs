using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using System.Text.RegularExpressions;
using System.Threading;
using WebAddressbookTests;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected IWebDriver driver;
        private StringBuilder verificationErrors;
        protected string baseURL;
        
        protected LogonHelper logonHelper;
        protected NavigationHelper navigationHelper;
        protected ActionHelper actionHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        [SetUp]
        public void SetupTest()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\Firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";
            verificationErrors = new StringBuilder();

            logonHelper = new LogonHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            actionHelper = new ActionHelper(driver);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);
        }

        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }

    }
}
