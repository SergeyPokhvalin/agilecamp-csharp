using System;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AFT
{
    public class LoginPage
    {
        private readonly ChromeDriver driver;

        public LoginPage(ChromeDriver driver)
        {
            if (driver == null) throw new ArgumentNullException(nameof(driver));
            this.driver = driver;
        }

        public LoginPage Navigate()
        {
            driver.Navigate().GoToUrl("http://localhost:49333/Account/Login");
            return this; 
        }

        public IWebElement GetEmailField()
        {
            return driver.FindElementsByXPath("//*[@id='Email']").First();
        }

        public LoginPage SetEmailField(string email)
        {
            GetEmailField().SendKeys(email);
            return this;
        }

        public IWebElement GetloginErrorMessage()
        {
            return driver.FindElementByXPath("//*[@id='loginForm']/form/div[1]/div/span/span");
        }

        public LoginPage SublitButtonClick()
        {
            driver.FindElementByXPath("//*[@id='loginForm']/form/div[4]/div/input").Click();
            return this;
        }
    }
}