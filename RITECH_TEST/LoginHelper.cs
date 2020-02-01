using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace WebDriver_CSharp_Example
{

//Helper class since login is repeated
    public class Librarian_Login
    {

        //Helper method for test classes to use
        public static void Login(IWebDriver driver, string homeURL)
        {

            driver.Navigate().GoToUrl(homeURL);

            IWebElement UsernameField =
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_UserName']"));
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(UsernameField));
            UsernameField.SendKeys("librarian");

            IWebElement PasswordField =
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_Password']"));
            new WebDriverWait(driver,
System.TimeSpan.FromSeconds(15)).Until(ExpectedConditions.ElementToBeClickable(PasswordField));
            PasswordField.SendKeys("librarian");

            IWebElement LoginButton =
driver.FindElement(By.XPath("//*[@id='MainContent_LoginUser_LoginButton']"));
            LoginButton.Click();
            IWebElement BookManagementButton =
driver.FindElement(By.XPath("//a[contains(text(),'Book Management')]"));
            Boolean status = BookManagementButton.Displayed;

        }


    }


}