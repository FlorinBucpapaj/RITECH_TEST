using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class AuthorManagement
    {

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'(Create new author)')]")]
        [CacheLookup]
        private IWebElement CreateAuthorLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[td[contains(text(),'Flori Test Author')] and "
                                          + "td[contains(text(),'Arthur Conan Doyle')] and "
                                          + "td[contains(text(),'Historical Fiction')]]")]
        private IWebElement CreatedAuthor { get; set; }

        public void ClickOnCreate()
        {

            CreateAuthorLink.ClickOnIt("Create book");
        }

        public void VerifyCreatedAuthor()
        {
            CreatedAuthor.IsDisplayed("Added book");
        }
    }
}
