using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace RITECH_TEST.UnrefinedTests
{

    //Helper class since login is repeated
    public class Librarian_Login
    {

        //Helper method for test classes to use
        public static void Login(IWebDriver driver, string homeURL)
        {

            driver.Navigate().GoToUrl(homeURL);

            IWebElement UsernameField =     //User inputs "librarian" as username and password
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_UserName']"));  //alternate xpath: //input[contains(@id,'UserName')]
            new WebDriverWait(driver,
TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(UsernameField));
            UsernameField.SendKeys("librarian");

            IWebElement PasswordField =
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_Password']"));  //alternate xpath: //input[contains(@id,'Password')]
            new WebDriverWait(driver,
TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(PasswordField));
            PasswordField.SendKeys("librarian");

            IWebElement LoginButton =       //User clicks the "Login" button
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_LoginButton']"));   //alternate xpath: //input[contains(@id,'LoginButton')]
            LoginButton.Click();
            IWebElement BookManagementButton =
driver.FindElement(By.XPath("//a[contains(text(),'Book Management')]"));
            bool status = BookManagementButton.Displayed;

        }


    }


}