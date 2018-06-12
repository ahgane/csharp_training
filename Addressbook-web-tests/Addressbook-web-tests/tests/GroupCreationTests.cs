using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupCreationTests : TestBase
    {
        [Test]
        public void GroupCreationTest()
        {
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData ("admin", "secret"));
            app.Navigator.GoToGroupsPage();
            app.Groups.CreateNewGroup();
            GroupData group = new GroupData ("JaneTest5");
            group.Header = "Family5";
            group.Footer = "Extended5";
            app.Groups.FillInGroupData(group);
            app.Action.Submit();
            app.Navigator.GoToGroupsPage();
            app.Auth.Logout();
        }
    }
}

