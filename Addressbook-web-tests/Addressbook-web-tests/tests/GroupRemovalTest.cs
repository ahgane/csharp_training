using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests  : TestBase
    {
       [Test]
        public void GroupRemovalTest()
        {
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData ("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Action.SelectRecord(1);
            app.Groups.RemoveGroup();
            app.Navigator.ReturnToGroupPage();
            app.Auth.Logout();
        }
        
    }
}

