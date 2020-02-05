using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;
using OpenQA.Selenium;

namespace RITECH_TEST.TestCases
{
    [TestFixture]
    public class EditBook
    {

        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
        }

        [Test]
        public void Edit()
        {
            
            Page.Login.LoginToApplication();
            Page.Home.ClickBookManagement();
            Page.bookManagement.FirstBookEdit();
            Page.editBook.editBook();
            Page.bookManagement.VerifyEditedBook();

        }

        [TearDown]
        public void TearDownTest()
        {
            BrowserFactory.CloseAllDrivers();
        }
    }
}
