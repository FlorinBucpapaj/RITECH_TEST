using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;

namespace RITECH_TEST.PageObjects
{
    public class EditBook
    {

        public const string NameInput = "Flori Test Edit";
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

        [FindsBy(How = How.XPath, Using = "//input[contains(@value,'Update')]")]
        [CacheLookup]
        private IWebElement InsertButton { get; set; }

        public void editBook()
        {
            Name.EnterText(NameInput, "Name field");
            Author.SelectByText(AuthorPicked, "Author selectList");
            Genre.SelectByText(GenrePicked, "Genre selectList");
            InsertButton.ClickOnIt("Update button");
        }

        public void editBookWithNewAuthor()
        {
            Name.EnterText(NameInput, "Name field");
            Author.SelectByText(CreateAuthor.AuthorName, "Author selectList");
            Genre.SelectByText(GenrePicked, "Genre selectList");
            InsertButton.ClickOnIt("Update button");
        }

    }
}
