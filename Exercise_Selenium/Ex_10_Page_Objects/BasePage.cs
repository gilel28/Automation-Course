using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_10_Page_Objects
{
    public class BasePage
    {

        protected readonly IWebDriver driver;
        protected readonly WebDriverWait wait;
        protected readonly Actions action;

        public BasePage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            action = new Actions(driver);
        }
    }
}
