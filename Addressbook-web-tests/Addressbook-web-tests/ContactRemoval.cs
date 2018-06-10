using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            GoToLoginPage();
            Login(new AccountData("admin", "secret"));
            GoToHomePage();
            SelectRecord(1);
            RemoveContact();
            GoToHomePage();
            Logout();
        }
        
    }
}
