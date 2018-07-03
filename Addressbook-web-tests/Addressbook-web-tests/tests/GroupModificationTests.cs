using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using WebAddressBookTests;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupModificationTests : AuthTestBase
    {
        [Test]
        public void GroupModificationTest()
        {
            GroupData newData = new GroupData("NoGroupTest");
            newData.Header = "NGT";
            newData.Footer = "NGT";

            app.Groups.Modify(1, newData);
        }
    }
}
