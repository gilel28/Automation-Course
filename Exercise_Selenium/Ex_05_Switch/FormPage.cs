

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_05_Controllers
{

    public class FormPage
    {
        protected readonly IWebDriver driver;
        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement alert => driver.FindElement(By.Id("btnAlert"));
        private IWebElement prompt => driver.FindElement(By.Id("btnPrompt"));
        private IWebElement confirm => driver.FindElement(By.CssSelector("[id='btnConfirm'"));
        private IWebElement tab => driver.FindElement(By.Id("btnNewTab"));
        private IWebElement output => driver.FindElement(By.Id("output"));
        private IWebElement newTabContext => driver.FindElement(By.Id("new_tab_container"));
        IAlert alertWindow => driver.SwitchTo().Alert();



        public void DoThings()
        {
            alert.Click();
            Console.WriteLine(alertWindow.Text);
            alertWindow.Accept();
            prompt.Click();
            Console.WriteLine(alertWindow.Text);
            alertWindow.SendKeys("Hello");
            alertWindow.Accept();
            Assert.That(output.Text,Is.EqualTo("Hello"));
            String originalWindow = driver.CurrentWindowHandle;
            tab.Click();
            foreach (string window in driver.WindowHandles)
            {
                if (originalWindow != window)
                {
                    driver.SwitchTo().Window(window);
                    break;
                }
            }
            Console.WriteLine(newTabContext.Text);
            Assert.That(newTabContext.Text, Is.EqualTo("This is a new tab"));
            driver.Close();
            driver.SwitchTo().Window(originalWindow);





        }


    }
}
