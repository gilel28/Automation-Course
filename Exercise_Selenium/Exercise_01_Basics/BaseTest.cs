using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_01_Basics
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver=new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.imdb.com/");
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
