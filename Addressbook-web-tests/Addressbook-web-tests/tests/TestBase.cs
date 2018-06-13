﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Threading;
using WebAddressBookTests;

namespace WebAddressBookTests
{
    public class TestBase
    {
         protected ApplicationManager app;
        
        [SetUp]
        public void SetupTest()
        {
            app = new ApplicationManager();
            app.Navigator.GoToLoginPage();
            app.Auth.Login(new AccountData("admin", "secret"));

        }

        [TearDown]
        public void TeardownTest()
        {
            app.Stop();
        }

    }
}
