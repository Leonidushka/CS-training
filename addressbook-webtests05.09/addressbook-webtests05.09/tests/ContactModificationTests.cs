﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : TestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            app.Groups
            .GoToGroupsPage()
            .SelectGroup(1)
            .Remove()
            .ReturnToGroupPage();
        }
    }
}