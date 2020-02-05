using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class CreateAuthor
    {
        public const string AuthorName = "Flori  Author";
        public const string AuthorAge = "21";



        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Name')]")]
        [CacheLookup]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Age')]")]
        [CacheLookup]
        private IWebElement Age { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Insert')]")]
        [CacheLookup]
        private IWebElement InsertButton { get; set; }
        public void createAuthor()
        {
            Name.EnterText(AuthorName, "Name field");
            Age.EnterText(AuthorAge, "Author selectList");
            InsertButton.ClickOnIt("Insert button");
        }

    }
}
