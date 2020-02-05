using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;


namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class Login
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "User logins to the system and verifies BookManagement button is diplayed.")]
        public void Verify_Button()
        {
            
            Librarian_Login.Login(driver,homeURL); //User logins to the system.

        }


        [TearDown]
        public void TearDownTest()
        {
            driver.Close();
        }


        [SetUp]
        public void SetupTest()
        {
            homeURL = "http://www.libraryinformationsystem.org/Account/Login.aspx";
            driver = new ChromeDriver("E:\\Downloads");// "E:\\Downloads" is my location for downloaded webdriver, for some reason I had errors without adding the path

        }


    }


}