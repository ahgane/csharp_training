using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    public class ContactHelper : HelperBase
    {
        private bool acceptNextAlert = true;

        public ContactHelper(ApplicationManager manager) : base (manager)
        {
        }

        public ContactHelper Create (ContactData contact)
        {
            InitAddNewContact();
            FillContactForm(contact);
            manager.Action.Submit();
            manager.Navigator.GoToHomePage();
          //  manager.Auth.Logout();
            return this;
        }

        public ContactHelper Modify(int v, ContactData newData)
        {
            manager.Navigator.GoToHomePage();
            InitContactModification(v);
            FillContactForm(newData);
            SubmitContactModification();
            manager.Navigator.GoToHomePage();
           // manager.Auth.Logout();
            return this;
        }

        public ContactHelper SubmitContactModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public ContactHelper InitContactModification(int index)
        {
            driver.FindElement(By.XPath("(//img[@alt='Edit'])[" + index + "]")).Click();
            return this;
        }

        public ContactHelper RemoveContact()
        {
            driver.FindElement(By.XPath("//input[@value='Delete']")).Click();
            Assert.IsTrue(Regex.IsMatch(CloseAlertAndGetItsText(), "^Delete 1 addresses[\\s\\S]$"));
            return this;

        }

        public ContactHelper InitAddNewContact()
        {
            // Go to and Init add new
            driver.FindElement(By.LinkText("add new")).Click();
            return this;

        }

        public string CloseAlertAndGetItsText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert)
                {
                    alert.Accept();
                }
                else
                {
                    alert.Dismiss();
                }
                return alertText;
            }
            finally
            {
                acceptNextAlert = true;
            }
        }

        public ContactHelper FillContactForm(ContactData contact)
        {
            // Fill contact form
            Type(By.Name("firstname"), contact.Name);
            Type(By.Name("lastname"), contact.Surname);
            Type(By.Name("company"), contact.Company);
            Type(By.Name("email"), contact.Email);

            return this;
        }

        public ContactHelper RemoveContact(int v)
        {
            manager.Navigator.GoToHomePage();
            manager.Action.SelectRecord(v);
            RemoveContact();
            manager.Navigator.GoToHomePage();
            //manager.Auth.Logout();
            return this;

        }
    }
}
