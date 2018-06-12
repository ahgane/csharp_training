using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using WebAddressBookTests;


namespace WebAddressBookTests
{
    [TestFixture]
    public class ContactRemovalTests : TestBase
    {
        [Test]
        public void ContactRemovalTest()
        {
            navigationHelper.GoToLoginPage();
            logonHelper.Login(new AccountData("admin", "secret"));
            navigationHelper.GoToHomePage();
            actionHelper.SelectRecord(1);
            contactHelper.RemoveContact();
            navigationHelper.GoToHomePage();
            logonHelper.Logout();
        }
        
    }
}
