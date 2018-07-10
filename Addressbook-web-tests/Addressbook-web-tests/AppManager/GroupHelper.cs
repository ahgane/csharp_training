using System;
using System.Collections.Generic;
using OpenQA.Selenium;

namespace WebAddressBookTests
{
    public class GroupHelper : HelperBase
    {
        public GroupHelper(ApplicationManager manager) : base (manager)
        {

        }

        public GroupHelper Create (GroupData group)
        {
            manager.Navigator.GoToGroupsPage();
            InitCreateNewGroup();
            FillInGroupData(group);
            manager.Action.Submit();
            manager.Navigator.GoToGroupsPage();
          //  manager.Auth.Logout();
            return this;
        }

        public List<GroupData> GetGroupList()
        {
            List<GroupData> groups = new List<GroupData>();

            manager.Navigator.GoToGroupsPage();

            ICollection<IWebElement> elements = driver.FindElements(By.CssSelector("span.group"));

            foreach (IWebElement element in elements)
            {
                groups.Add (new GroupData(element.Text));
            }

            return groups;
        }

        public GroupHelper Modify(int v, GroupData newData)
        {
            manager.Navigator.GoToGroupsPage();
            manager.Action.SelectRecord(v);
            InitGroupModification();
            FillInGroupData(newData);
            SubmitGroupModification();
            //  manager.Navigator.GoToGroupsPage();
            //  manager.Auth.Logout();

            return this;
        }
        public GroupHelper RemoveGroup(int v)
        {
            manager.Navigator.GoToGroupsPage();
            manager.Action.SelectRecord(v);
            RemoveGroup();
            manager.Navigator.ReturnToGroupPage();
            // manager.Auth.Logout();
            return this;
            
        }


        public GroupHelper InitCreateNewGroup()
        {
            driver.FindElement(By.Name("new")).Click();
            return this;
        }

        public GroupHelper FillInGroupData(GroupData group)
        {
           Type(By.Name("group_name"), group.Name);
           Type(By.Name("group_header"), group.Header);
           Type(By.Name("group_footer"), group.Footer);
            return this;
        }

        public GroupHelper RemoveGroup()
        {
            driver.FindElement(By.Name("delete")).Click();
            return this;
        }

        public GroupHelper InitGroupModification()
        {
            driver.FindElement(By.Name("edit")).Click();
            return this;
        }

        public GroupHelper SubmitGroupModification()
        {
            driver.FindElement(By.Name("update")).Click();
            return this;
        }

        public bool IsPresent()
        {
            return IsElementPresent(By.Name("checkbox"));
        }

    }
}
