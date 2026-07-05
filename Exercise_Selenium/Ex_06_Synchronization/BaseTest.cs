using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

namespace Ex_06_Synchronization
{
    public class BaseTest
    {
        protected IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl("https://atidcollege.co.il/Xamples/ex_synchronization.html");
        }

        [TearDown]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
    }
}