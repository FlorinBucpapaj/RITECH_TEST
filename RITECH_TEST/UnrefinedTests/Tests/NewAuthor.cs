using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace RITECH_TEST.UnrefinedTests
{


    [TestFixture]
    public class NewAuthor
    {
        private IWebDriver driver = new ChromeDriver("E:\\Downloads");// "E:\\Downloads" is my location for downloaded webdriver, for some reason I had errors without adding the path
        public string homeURL = "http://www.libraryinformationsystem.org/Books.aspx";
        public static string NameInput = "Flori Author Test";
        public static string AgeInput = "21";


        [Test(Description = "User logins to the system and creates a new author")]
        public void CreateAuthor()
        {

            Librarian_Login.Login(driver, homeURL); //User logins to the system.

            IWebElement AuthorManagementButton =   //User navigates to Author management and clicks.
driver.FindElement(By.XPath("//a[contains(text(),'Author Management')]"));
            AuthorManagementButton.Click();

            WebDriverWait wait = new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15));
            IWebElement CreateNewAuthor =    //User create new author by clicking the link "Create new author"
wait.Until(ExpectedConditions.ElementToBeClickable
                 ((By.XPath("//a[contains(text(),'(Create new author)')]"))));   
            CreateNewAuthor.Click();

            IWebElement NameField =     //User adds a new author information with name and age, and inserts into the grid. 
driver.FindElement(By.XPath("//input[contains(@id,'Name')]"));     
            NameField.SendKeys(NameInput);

            IWebElement AgeField =
driver.FindElement(By.XPath("//input[contains(@id,'Age')]"));      
            AgeField.SendKeys(AgeInput);

            IWebElement InsertAuthor =      //User click the "Insert" button
driver.FindElement(By.XPath("//input[contains(@value,'Insert')]"));    
            InsertAuthor.Click();

            IWebElement AddedAuthor =       //User verifies the author has been added.
driver.FindElement(By.XPath($"//tr[td[contains(text(),'{NameInput}')] and td[contains(text(),'{AgeInput}')]]"));
            bool status = AddedAuthor.Displayed;
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(AddedAuthor));

        }


        [Test(Description = "User logins to the system and updates a book to the new author")]
        public void UpdateToNewAuthor()
        {

            IWebElement BookManagementButton =      //User goes to the Book Management grid.
driver.FindElement(By.XPath("//a[contains(text(),'Book Management')]"));
            BookManagementButton.Click();

            IWebElement EditFirstBook =     //User clicks the "Edit" link on the first row.
driver.FindElement(By.XPath("//*/tbody/tr[2]/td[5]/a"));
            EditFirstBook.Click();

            IWebElement AuthorList =    //User changes the author to the new one added in the test above.
driver.FindElement(By.XPath("//select[contains(@id,'Author')]"));   
            SelectElement Author = new SelectElement(AuthorList);
            string AuthorPicked = NewAuthor.NameInput;
            Author.SelectByText(AuthorPicked);

            IWebElement EditBook =      //User clicks the "Update" button.
driver.FindElement(By.XPath("//input[contains(@value,'Update')]"));   
            EditBook.Click();

            IWebElement EditedBook =    //User verified the changes have been made in the grid.
driver.FindElement(By.XPath($"//tr[td[contains(text(),'{AuthorPicked}')]]"));
            bool status = EditedBook.Displayed;
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(5)).Until(ExpectedConditions.ElementToBeClickable(EditedBook));

            driver.Close();

        }

    }  

}