using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class HomePage
    {
        //private IWebDriver driver;

        [FindsBy(How = How.LinkText, Using = "Book Management")][CacheLookup]
        private IWebElement BookManagement { get; set; }

        [FindsBy(How = How.LinkText, Using = "Author Management")]
        [CacheLookup]
        private IWebElement AuthorManagement { get; set; }

        public void VerifyBookManagement()
        {
            BookManagement.IsDisplayed("Book Management");
        }
        public void ClickBookManagement()
        {
            BookManagement.ClickOnIt("Book Management");
        }
        public void ClickAuthorManagement()
        {
            AuthorManagement.ClickOnIt("Author Management");
        }
    }
}