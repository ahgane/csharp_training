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
            ContactData contact = new ContactData("Jane4", "Test4");
            contact.Company = "IBM";
            contact.Email = "newcontact@gmail.com";

            app.Contacts.Create(contact);
                
        }

        [Test]
        public void NextContactCreationTest()
        {
            ContactData contact = new ContactData("JaneNext", "TestNext");
            contact.Company = "Google";
            contact.Email = "nextcontact@gmail.com";

            app.Contacts.Create(contact);

        }
    }
}
