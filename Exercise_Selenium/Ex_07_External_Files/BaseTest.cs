using Allure.NUnit;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Allure.NUnit.Attributes;
using Allure.Net.Commons;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_07_External_Files
{
    [AllureNUnit]
    [AllureSuite("medical")]
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://atidcollege.co.il/Xamples/bmi/");
        }

        [TearDown]
        public void TearDown()
        {
            if (TestContext.CurrentContext.Result.Outcome.Status == NUnit.Framework.Interfaces.TestStatus.Failed)
            {
                TakeScreenshot(driver);
                string errorMessage = TestContext.CurrentContext.Result.Message;
                Console.WriteLine("Test Failed! Error: " + errorMessage);
            }

            if (driver != null)
            {
                driver.Quit();
            }
        }
        public void TakeScreenshot(IWebDriver driver, string name = "Page Screenshot")
        {
            var screenshot = ((ITakesScreenshot)driver).GetScreenshot();
            byte[] screenshotBytes = screenshot.AsByteArray;

            AllureApi.AddAttachment(name, "image/png", screenshotBytes, "png");
        }
    }
}
