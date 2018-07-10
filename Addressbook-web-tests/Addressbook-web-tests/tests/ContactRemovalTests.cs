using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using System.Collections.Generic;
using WebAddressBookTests;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : AuthTestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            if (!app.Contacts.IsPresent())
            {
                ContactData newData = new ContactData("1Modified1", "1Modified1");
                newData.Company = "1Modified1";
                newData.Email = "1Modified1";

                app.Contacts.Create(newData);
            }
            app.Contacts.RemoveContact(0);

        }
        
    }
}
