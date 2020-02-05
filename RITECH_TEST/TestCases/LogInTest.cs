using NUnit.Framework;
using RITECH_TEST.PageObjects;
using System.Configuration;
using RITECH_TEST.WrapperFactory;
using OpenQA.Selenium;

namespace RITECH_TEST.TestCases
{
    [TestFixture]
    public class LogInTest
    {


        [SetUp]
        public void SetUp()
        {
            BrowserFactory.InitBrowser("Chrome");
            BrowserFactory.LoadApplication(ConfigurationManager.AppSettings["URL"]);
        }

        [Test]
        public void Test()
        {

            Page.Login.LoginToApplication();
            Page.Home.VerifyBookManagement();

        }
        [TearDown]
        public void TearDownTest()
        {
            BrowserFactory.CloseAllDrivers();

        }
    }
}
