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
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData("admin", "secret"));
            app.Navigator.GoToHomePage();
            app.Action.SelectRecord(1);
            app.Contacts.RemoveContact();
            app.Navigator.GoToHomePage();
            app.Auth.Logout();
        }
        
    }
}
