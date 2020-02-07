using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;
using System;

namespace RITECH_TEST.TestCases
{
    [TestFixture]
    class NewBook
    {

        [Test]
        public void Test()
        {

            Page.Login.LoginToApplication();
            Page.Home.ClickBookManagement();
            Page.bookManagement.ClickOnCreate();
            Page.createBook.createBook();
            Page.bookManagement.VerifyCreatedBook();

            BrowserFactory.CloseAllDrivers();
        }

        [TearDown]
        public void TearDownTest()
        {
            BrowserFactory.Driver.Quit();
        }

        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            BrowserFactory.LoadPage();
        }
    }
}
