using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;
using OpenQA.Selenium;
using System;

namespace RITECH_TEST.TestCases
{
    [TestFixture]
    class EditBook
    {

        



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
