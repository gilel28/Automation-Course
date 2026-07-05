using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;

namespace Ex_06_Synchronization
{
    public class SynchronizationPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;

        public SynchronizationPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }

        // Buttons
        private IWebElement StartRendered => driver.FindElement(By.Id("rendered"));
        private IWebElement Remove => driver.FindElement(By.Id("btn"));

        // Explicit Wait
        private IWebElement RenderedElement => wait.Until(d =>
        {
            var element = d.FindElement(By.Id("finish2"));
            return element.Displayed ? element : null;
        });

        // Implicit Wait
        private IWebElement RemoveMessage =>
            driver.FindElement(By.Id("message"));

        public string Rendered()
        {
            StartRendered.Click();
            return RenderedElement.Text;
        }

        public string Delete()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Remove.Click();

            return RemoveMessage.Text;
        }
    }
}