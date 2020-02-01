using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class NewBook
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "User logins to the system and creates a new book")]
        public void CreateBook()
        {

            Librarian_Login.Login(driver, homeURL);     //User logins to the system.

            IWebElement BookManagementButton = 
driver.FindElement(By.XPath("//a[contains(text(),'Book Management')]"));
            BookManagementButton.Click();

            WebDriverWait wait = new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15));
            IWebElement CreateNewBook = wait.Until(ExpectedConditions.ElementToBeClickable       //User clicks the "Create new book" link.
                 ((By.XPath("/ html / body / form / div[3] / div[2] / p / a"))));
            CreateNewBook.Click();

            IWebElement NameField =     //User gives the book name, author and genre for the new book.
driver.FindElement(By.XPath("//*[@id='MainContent_txtName']"));
            string NameInput = "Flori Test";
            NameField.SendKeys(NameInput);

            IWebElement AuthorList =
driver.FindElement(By.XPath("//*[@id='MainContent_ddlAuthor']"));
            SelectElement Author = new SelectElement(AuthorList);
            string AuthorPicked = "Arthur Conan Doyle";
            Author.SelectByText(AuthorPicked);

            IWebElement GenreList =
driver.FindElement(By.XPath("//*[@id='MainContent_ddlGenre']"));
            SelectElement Genre = new SelectElement(GenreList);
            string GenrePicked = "Historical Fiction";
            Genre.SelectByText(GenrePicked);

            IWebElement InsertBook =        //User clicks the "Insert" button.
driver.FindElement(By.XPath("//*[@id='MainContent_btnSubmit']"));
            InsertBook.Click();

            IWebElement AddedBook =         //User verifies the new book has been added to the grid.
driver.FindElement(By.XPath($"//tr[td[contains(text(),'{NameInput}')] and td[contains(text(),'{AuthorPicked}')] and td[contains(text(),'{GenrePicked}')]]"));
            bool status = AddedBook.Displayed;
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(AddedBook));
          

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