using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
 
        [Test]
        public void ContactCreationTest()
        {
            OpenHomePage();
            Login(new AccountData("admin", "secret"));
            InitContactCreation();
            ContactData contact = new ContactData("Ivan");
            contact.Lastname = "Ivanov";
            FillContactForm(contact);
            // ERROR: Caught exception [Error: Dom locators are not implemented yet!]
            Logout();
        }




    }
}
