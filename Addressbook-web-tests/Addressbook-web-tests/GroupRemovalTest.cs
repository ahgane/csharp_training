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
            navigationHelper.GoToLoginPage();
            logonHelper.Login(new AccountData ("admin", "secret"));
            navigationHelper.GoToGroupsPage();
            actionHelper.SelectRecord(1);
            groupHelper.RemoveGroup();
            navigationHelper.ReturnToGroupPage();
            logonHelper.Logout();
        }
        
    }
}

