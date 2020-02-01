using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriver_CSharp_Example
{


    [TestFixture]
    public class EditBook
    {
        private IWebDriver driver;
        public string homeURL;


        [Test(Description = "User logins to the system and updates a book")]
        public void UpdateBook()
        {

            Librarian_Login.Login(driver, homeURL); //User logins to the system.

            IWebElement BookManagementButton =
driver.FindElement(By.XPath("//a[contains(text(),'Book Management')]"));
            BookManagementButton.Click();

            IWebElement EditFirstBook =  //User clicks "Edit" link on the first book.
driver.FindElement(By.XPath("//*/tbody/tr[2]/td[5]/a"));
            EditFirstBook.Click();


            IWebElement NameField =     //User edits the information of the selected book.
driver.FindElement(By.XPath("//*[@id='MainContent_txtName']"));
            string NameInput = "Flori Edit Test";
            NameField.Clear();
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

            IWebElement EditBook =    //User clicks the "Update" button
driver.FindElement(By.XPath("//*[@id='MainContent_btnSubmit']"));
            EditBook.Click();


            IWebElement EditedBook =    //User verifies the change on the grid.
driver.FindElement(By.XPath($"//tr[td[contains(text(),'{NameInput}')] and td[contains(text(),'{AuthorPicked}')] and td[contains(text(),'{GenrePicked}')]]"));
            bool status = EditedBook.Displayed;
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(EditedBook));





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