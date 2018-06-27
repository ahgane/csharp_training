﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Text.RegularExpressions;
using System.Threading;
using WebAddressBookTests;
using WebAddressbookTests;

namespace WebAddressBookTests
{
    public class TestBase
    {
        protected ApplicationManager app;
        
        [SetUp]
        public void SetupTest()
        {
            app = ApplicationManager.GetInstance();
        }
    }
}
