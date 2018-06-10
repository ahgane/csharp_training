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
            GoToHomePage();
            Login(new AccountData("admin", "secret"));
            InitAddNewContact();
            ContactData contact = new ContactData("Jane4", "Test4");
            contact.Company = "IBM";
            contact.Email = "testsubmit@gmail.com";
            FillContactForm(contact);
            Submit();
            Logout();
        }
    }
}
