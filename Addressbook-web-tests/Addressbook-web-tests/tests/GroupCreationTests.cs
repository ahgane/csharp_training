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
        public void NextGroupCreationTest()

        {
            GroupData group = new GroupData("Next");
            group.Header = "Next";
            group.Footer = "Next";

            app.Groups.Create(group);

        }

        [Test]
        public void GroupCreationTest()

        {
            GroupData group = new GroupData("JaneTest5");
            group.Header = "Family5";
            group.Footer = "Extended5";

            app.Groups.Create(group);
           
        }

        [Test]
        public void EmptyGroupCreationTest()
        {
            GroupData group = new GroupData("");
            group.Header = "";
            group.Footer = "";

            app.Groups.Create(group);
        }
    }
}

