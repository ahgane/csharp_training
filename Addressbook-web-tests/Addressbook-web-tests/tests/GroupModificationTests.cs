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

            //            List<GroupData> oldGroups = app.Groups.GetGroupList();
            if (!app.Groups.IsPresent())
            {
                app.Groups.Create(newData);
            }
            else
            {
                app.Groups.Modify(0, newData);

                /*           List<GroupData> newGroups = app.Groups.GetGroupList();
                           oldGroups[0].Name= newData.Name;
                           oldGroups.Sort();
                           newGroups.Sort();
                           Assert.AreEqual(oldGroups, newGroups);*/


            }
        }

    }
}
