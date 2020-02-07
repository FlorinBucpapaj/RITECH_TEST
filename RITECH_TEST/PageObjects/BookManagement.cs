using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RITECH_TEST.Extensions;
using RITECH_TEST.WrapperFactory;

namespace RITECH_TEST.PageObjects
{
    public class BookManagement
    {

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'(Create new book)')]")]
        [CacheLookup]
        private IWebElement CreateBookLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//*/tbody/tr[2]/td[5]/a")]
        private IWebElement FirstBookLink { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[td[contains(text(),'Flori Test')] and "
                                          + "td[contains(text(),'Arthur Conan Doyle')] and "
                                          + "td[contains(text(),'Historical Fiction')]]")]
        private IWebElement CreatedBook { get; set; }

        [FindsBy(How = How.XPath, Using = "//tr[td[contains(text(),'Flori Test Edit')] and "
                                          + "td[contains(text(),'Arthur Conan Doyle')] and "
                                          + "td[contains(text(),'Historical Fiction')]]")]
        private IWebElement EditedBook { get; set; }

        //I had to use static values above because I could not put variables inside the attribute expression
        //When I tried to use this equivalent part of the code from my unrefined tests, I couldnt because 
        //for some reason it gave an error where the element couldnt be found
        //when I ran the code below I ran into issues when I added 3rd variable
        //[FindsBy(How = How.XPath, Using = $"//tr[td[contains(text(),'{CreateBook.NameInput}')] and " +
        //$"td[contains(text(),'{CreateBook.AuthorPicked}')] and " +
        //$"td[contains(text(),'{CreateBook.GenrePicked}')]]")]
        //private IWebElement EditFirstBookLink { get; set; }



        public void ClickOnCreate() {

            CreateBookLink.ClickOnIt("Create book");
        }

        public void VerifyCreatedBook()
        {
            CreatedBook.IsDisplayed("Added book");
        }

        public void FirstBookEdit()
        {
            FirstBookLink.ClickOnIt("First row edit link");
        }
        public void VerifyEditedBook()
        {
            EditedBook.IsDisplayed("Edited book");
        }

    }
}
