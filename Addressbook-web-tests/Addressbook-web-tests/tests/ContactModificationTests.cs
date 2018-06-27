using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
            {
                ContactData newData = new ContactData("1Modified1","1Modified1");
                newData.Company = "1Modified1";
                newData.Email = "1Modified1";

                app.Contacts.Modify(1, newData);

            }
        

    }
}
