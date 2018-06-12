using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressbookTests
{
    public class ApplicationManager
    {
        protected IWebDriver driver;
        protected string baseURL;

        protected LogonHelper logonHelper;
        protected NavigationHelper navigationHelper;
        protected ActionHelper actionHelper;
        protected GroupHelper groupHelper;
        protected ContactHelper contactHelper;

        public ApplicationManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\Firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";

            logonHelper = new LogonHelper(driver);
            navigationHelper = new NavigationHelper(driver, baseURL);
            actionHelper = new ActionHelper(driver);
            groupHelper = new GroupHelper(driver);
            contactHelper = new ContactHelper(driver);

        }
    

     public void Stop ()
        {
        try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
        }
    
        public LogonHelper Auth
        {
            get
            {
                return logonHelper;
            }
        }

        public NavigationHelper Navigator
        {
            get
            {
                return navigationHelper;
            }
        }

        public ActionHelper Action
        {
            get
            {
                return actionHelper;
            }
        }

        public GroupHelper Groups
        {
            get
            {
                return groupHelper;
            }
        }

        public ContactHelper Contacts
        {
            get
            {
                return contactHelper;
            }
        }

    }
}
