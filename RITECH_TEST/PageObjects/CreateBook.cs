using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;
using RITECH_TEST.WrapperFactory;

namespace RITECH_TEST.PageObjects
{
    public class CreateBook
    {
        public const string   NameInput = "Flori Test";
        public const string AuthorPicked = "Arthur Conan Doyle";
        public const string GenrePicked = "Historical Fiction";

        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'Name')]")]
        [CacheLookup]
        private IWebElement Name { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'Author')]")]
        [CacheLookup]
        private IWebElement Author { get; set; }

        [FindsBy(How = How.XPath, Using = "//select[contains(@id,'Genre')]")]
        [CacheLookup]
        private IWebElement Genre { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Insert')]")]
        [CacheLookup]
        private IWebElement InsertButton { get; set; }

        public void createBook() 
        {
            Name.EnterText(NameInput, "Name field");
            Author.SelectByText(AuthorPicked, "Author selectList");
            Genre.SelectByText(GenrePicked, "Genre selectList");
            InsertButton.ClickOnIt("Insert button");
        }

    }
}
