using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    public class LogonHelper : HelperBase
    {
        public LogonHelper (ApplicationManager manager) : base (manager)
        {

        }

        public void Login(AccountData account)
        {
            if (IsLoggedIn())
            {
                if (IsLoggedIn(account))
                {
                    return;
                }
                Logout();
            }
              Type(By.Name("user"), account.Username);
              Type(By.Name("pass"), account.Password);
              driver.FindElement(By.CssSelector("input[type=\"submit\"]")).Click();
        }

        public bool IsLoggedIn()
        {
            return IsElementPresent(By.Name("logout"));
        }

        public void Logout()
        {
            if (IsLoggedIn())
            {
                driver.FindElement(By.LinkText("logout")).Click();
            }

        }

        public bool IsLoggedIn(AccountData account)
        {
            return IsLoggedIn() 
                && driver.FindElement(By.Name("logout")).FindElement(By.TagName("b")).Text 
                == "("+ account.Username + ")";
        }


    }
}
