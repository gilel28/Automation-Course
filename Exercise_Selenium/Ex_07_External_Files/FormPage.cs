using Allure.Net.Commons.Attributes;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_07_External_Files
{
    public class FormPage
    {
        protected readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

        }

        private IWebElement Weight => wait.Until(d=>d.FindElement(By.Id("weight")));
        private IWebElement Height => wait.Until(d => d.FindElement(By.Id("hight")));
        private IWebElement button => wait.Until(d => d.FindElement(By.Id("calculate_data")));
        private IWebElement result => wait.Until(d => d.FindElement(By.Id("bmi_means")));

        public String Fill(string weight, string height)
        {
            Weight.SendKeys(weight);
            Height.SendKeys(height);
            button.Click();
            return result.GetAttribute("value");
        }


    }
}
