﻿using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;


namespace WebAddressBookTests
{
    [TestFixture]
    public class GroupRemovalTests  : AuthTestBase
    {
       [Test]
        public void GroupRemovalTest()
        {
            app.Groups.RemoveGroup(2);

        }
        
    }
}

