﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            if (!IsElementPresent(By.XPath("//img[@alt='Edit']")))
            {
                // проба добавить тест если контакт отсутствует
                ContactData contact = new ContactData("Mika", "Hakkinen");
                app.Contact
                    .InitContactCreation()
                    .FillContactForm(contact)
                    .SubmittingContactCreation(); 
            }
            //
            ContactData newData = new ContactData("Mika", "Hakkinen");
            newData.Firstname = null;
            newData.Lastname = null;

            app.Contact.Modify(1, newData);
        }

        private bool IsElementPresent(By by)
        {
            try
            {
                app.Driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }
    }
}
