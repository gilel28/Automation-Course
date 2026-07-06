using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_10_Page_Objects
{
    internal class BaseTest
    {
       protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://atidcollege.co.il/Xamples/webdriveradvance.html");
        }


        [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit();
            }
        }
}
}

