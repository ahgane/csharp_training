using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            navigationHelper.GoToLoginPage();
            logonHelper.Login(new AccountData("admin", "secret"));
            contactHelper.InitAddNewContact();
            ContactData contact = new ContactData("Jane4", "Test4");
            contact.Company = "IBM";
            contact.Email = "testsubmit@gmail.com";
            contactHelper.FillContactForm(contact);
            actionHelper.Submit();
            navigationHelper.GoToHomePage();
            logonHelper.Logout();
        }
    }
}
