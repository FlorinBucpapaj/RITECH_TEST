using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;

namespace RITECH_TEST.TestCases
{
    class NewAuthor
    {
        public static string handle = "";


        [Test]
        public void CreateNewAuthor()
        {

            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
            handle = BrowserFactory.GetCurrentHandle();

            Page.Login.LoginToApplication();
            Page.Home.ClickAuthorManagement();
            Page.authorManagement.ClickOnCreate();
            Page.createAuthor.createAuthor();
            Page.authorManagement.VerifyCreatedAuthor();


        }
        [Test]
        public void EditNewAuthor()
        {

            BrowserFactory.Driver.SwitchTo().Window(NewAuthor.handle);

            Page.Home.ClickBookManagement();
            Page.bookManagement.FirstBookEdit();
            Page.editBook.editBookWithNewAuthor();


            BrowserFactory.CloseAllDrivers();
        }
    }
}