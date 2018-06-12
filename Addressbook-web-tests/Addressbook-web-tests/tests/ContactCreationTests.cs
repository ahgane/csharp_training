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
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Contacts.InitAddNewContact();
            ContactData contact = new ContactData("Jane4", "Test4");
            contact.Company = "IBM";
            contact.Email = "testsubmit@gmail.com";
            app.Contacts.FillContactForm(contact);
            app.Action.Submit();
            app.Navigator.GoToHomePage();
            app.Auth.Logout();
        }
    }
}
