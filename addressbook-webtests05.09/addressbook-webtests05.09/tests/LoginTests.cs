﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class LoginTests : TestBase
    {
        [Test]
        public void LoginWithValidCredentials()
        {
            // prepare
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "secret");
            app.Auth.Login(account);

            // verification
            Assert.IsTrue(app.Auth.IsLoggedIn(account));
        }
        [Test]
        public void LoginWithInValidCredentials()
        {

            // prepare
            app.Auth.Logout();

            // action
            AccountData account = new AccountData("admin", "123456");
    

            // action
            
            app.Auth.Login(account);

            // verification
            Assert.IsFalse(app.Auth.IsLoggedIn(account));
        }
    }
}
 