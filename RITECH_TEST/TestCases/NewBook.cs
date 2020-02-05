using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;

namespace RITECH_TEST.TestCases
{
    class NewBook
    {

        [Test]
        public void Test()
        {

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);

            Page.Login.LoginToApplication();
            Page.Home.ClickBookManagement();
            Page.bookManagement.ClickOnCreate();
            Page.createBook.createBook();
            Page.bookManagement.VerifyCreatedBook();

            BrowserFactory.CloseAllDrivers();
        }
    }
}
