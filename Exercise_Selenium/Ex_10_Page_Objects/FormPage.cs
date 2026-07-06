using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_10_Page_Objects
{
    internal class FormPage :BasePage
    {
        public FormPage(IWebDriver driver) : base(driver) { }

        private IWebElement Accupation => wait.Until(d => d.FindElement(By.Id("occupation")));
        private IWebElement Age => wait.Until(d => d.FindElement(By.Id("age")));
        private IWebElement Location => wait.Until(d => d.FindElement(By.Id("location")));
        private IWebElement SubmitButton => wait.Until(d => d.FindElement(By.CssSelector("button[type='button']")));

        public void FillForm(string accupation, string age, string location)
        {
            Accupation.SendKeys(accupation);
            Age.SendKeys(age);
            Location.SendKeys(location);
            SubmitButton.Click();
        }
    }
}
