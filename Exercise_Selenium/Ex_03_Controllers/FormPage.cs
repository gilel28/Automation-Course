

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_03_Controllers
{

    public class FormPage
    {
        protected readonly IWebDriver driver;
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement firstName => driver.FindElement(By.CssSelector("[name='firstname'"));
        private IWebElement lastName => driver.FindElement(By.CssSelector("[name='lastname'"));
        private IWebElement continents => driver.FindElement(By.CssSelector("[id='continents'"));
        private IWebElement button => driver.FindElement(By.Id("submit"));

        public void Fill(string firstName, string lastName)
        {
            this.firstName.SendKeys(firstName);
            this.lastName.SendKeys(lastName);
            SelectElement select = new SelectElement(continents);
            select.SelectByValue("europe");
            button.Click();
            string currentUrl = driver.Url;
            if (currentUrl.Contains(firstName) && currentUrl.Contains(lastName))
            {
                Console.WriteLine("Test Passed");
            }
            else
            {
                Console.WriteLine("Test Failed");
            }
        }


    }
}