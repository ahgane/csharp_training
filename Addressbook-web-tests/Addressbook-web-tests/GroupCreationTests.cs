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
            GoToLoginPage();
            Login(new AccountData ("admin", "secret"));
            GoToGroupsPage();
            CreateNewGroup();
            GroupData group = new GroupData ("JaneTest5");
            group.Header = "Family5";
            group.Footer = "Extended5";
            FillInGroupData(group);
            Submit();
            GoToGroupsPage();
            Logout();
        }
    }
}

