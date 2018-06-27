using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;


namespace WebAddressBookTests
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

        private static ThreadLocal<ApplicationManager> app = new ThreadLocal<ApplicationManager>();

        private ApplicationManager()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.BrowserExecutableLocation = @"C:\Program Files\Mozilla Firefox\Firefox.exe";
            options.UseLegacyImplementation = true;
            driver = new FirefoxDriver(options);
            baseURL = "http://localhost";

            logonHelper = new LogonHelper(this);
            navigationHelper = new NavigationHelper(this, baseURL);
            actionHelper = new ActionHelper(this);
            groupHelper = new GroupHelper(this);
            contactHelper = new ContactHelper(this);

        }

        ~ApplicationManager()
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

        public static ApplicationManager GetInstance()
        {
            if (! app.IsValueCreated)
            {
                app.Value = new ApplicationManager();
            }
            return app.Value;
        }

        public IWebDriver Driver
        {
            get
            {
                return driver;
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
