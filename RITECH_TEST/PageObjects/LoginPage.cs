using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class LoginPage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.Id, Using = "MainContent_LoginUser_UserName")][CacheLookup]
        private IWebElement UserName { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_LoginUser_Password")][CacheLookup]
        private IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "MainContent_LoginUser_LoginButton")][CacheLookup]
        private IWebElement SubmitLogin { get; set; }

        public void LoginToApplication()
        {
            UserName.EnterText("librarian", "Username");
            Password.EnterText("librarian", "Password");
            SubmitLogin.ClickOnIt("Login Button");
        }
    }
}