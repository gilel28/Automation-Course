using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_10_Page_Objects
{
    internal class LoginPage: BasePage
    {
        public LoginPage(IWebDriver driver) : base(driver) { }

        private IWebElement Username => wait.Until(d => d.FindElement(By.Id("username2")));
        private IWebElement Password => wait.Until(d => d.FindElement(By.Id("password2")));
        private IWebElement SubmitButton => wait.Until(d => d.FindElement(By.Id("submit")));



        public void Login(string username, string password)
        {
            Username.SendKeys(username);
            Password.SendKeys(password);
            SubmitButton.Click();
        }

        public bool CheckButton()
        {
            return driver.FindElement(By.CssSelector("button[type='button']")).Displayed;
        }
      
}
}
