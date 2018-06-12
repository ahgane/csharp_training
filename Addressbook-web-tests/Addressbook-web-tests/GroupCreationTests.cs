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
            navigationHelper.GoToLoginPage();
            logonHelper.Login(new AccountData ("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            groupHelper.CreateNewGroup();
            GroupData group = new GroupData ("JaneTest5");
            group.Header = "Family5";
            group.Footer = "Extended5";
            groupHelper.FillInGroupData(group);
            actionHelper.Submit();
            navigationHelper.GoToGroupsPage();
            logonHelper.Logout();
        }
    }
}

