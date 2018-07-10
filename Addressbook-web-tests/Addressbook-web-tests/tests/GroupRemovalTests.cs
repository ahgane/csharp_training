using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests  : AuthTestBase
    {
       [Test]
        public void GroupRemovalTest()
        {
            //            List<GroupData> oldGroups = app.Groups.GetGroupList();

            if (!app.Groups.IsPresent())
            {
                GroupData newData = new GroupData("NoGroupTest_R");
                newData.Header = "NGT_R";
                newData.Footer = "NGT_R";

                app.Groups.Create(newData);
            }
            else
            {
                app.Groups.RemoveGroup(0);
            }

 /*           List<GroupData> newGroups = app.Groups.GetGroupList();

            oldGroups.RemoveAt(0);
            Assert.AreEqual(oldGroups, newGroups);*/

        }

    }
}

