using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class Header
    {
        //private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Book Management")]
        [CacheLookup]
        private IWebElement BookManagement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Author Management")]
        [CacheLookup]
        private IWebElement AuthorManagement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Home")]
        [CacheLookup]
        private IWebElement HomeButton { get; set; }

        [FindsBy(How = How.LinkText, Using = "Log Out")]
        [CacheLookup]
        private IWebElement LogOutBButton { get; set; }

        public void VerifyBookManagement()
        {
            BookManagement.IsDisplayed("Book Management");
        }

    }
}