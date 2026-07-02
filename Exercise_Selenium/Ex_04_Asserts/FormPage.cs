using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_04_Controllers
{

    public class FormPage
    {
        protected readonly IWebDriver driver;
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Weight => driver.FindElement(By.Id("weight"));
        private IWebElement Height => driver.FindElement(By.Id("hight"));
        private IWebElement button => driver.FindElement(By.Id("calculate_data"));
        private IWebElement result => driver.FindElement(By.Id("bmi_means"));


        public String Fill(string weight, string height)
        {
            Weight.SendKeys(weight);
            Height.SendKeys(height);
            button.Click();
            return result.GetAttribute("value");
        }


    }
}







