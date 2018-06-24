using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using WebAddressBookTests;

namespace WebAddressbookTests
{
    [SetUpFixture]
    public class TestSuiteFixture
    {
        public static ApplicationManager app;

        [SetUp]
        public void InitApplicationManager()
        {
            app = new ApplicationManager();
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData("admin", "secret"));

        }

        [TearDown]
        public void CloseApplicationManager()
        {
            app.Stop();
        }
    }
}
