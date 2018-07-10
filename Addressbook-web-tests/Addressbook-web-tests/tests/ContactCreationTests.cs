using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Jane4", "Test4");
            contact.Company = "IBM";
            contact.Email = "newcontact@gmail.com";

            List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            List<ContactData> newContacts = app.Contacts.GetContactList();
            oldContacts.Add(contact);
            oldContacts.Sort();
            newContacts.Sort();
            Assert.AreEqual(oldContacts, newContacts);


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
