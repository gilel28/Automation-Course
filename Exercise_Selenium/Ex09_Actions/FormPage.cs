using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Xml.Linq;

namespace Ex09_Actions
{
    internal class FormPage
    {
        private readonly IWebDriver driver;
        private readonly WebDriverWait wait;
        private readonly Actions action;

        public FormPage(IWebDriver driver)
        {
            this.driver = driver;
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
             action = new Actions(driver);
        }

        private IWebElement draggable => wait.Until(d => d.FindElement(By.Id("draggable")));
        private IWebElement droppable => wait.Until(d => d.FindElement(By.Id("droppable")));
        private IList<IWebElement> listItems => driver.FindElements(By.XPath("//*[@id='select_items']/li"));
        private IWebElement doubleClickButton => wait.Until(d => d.FindElement(By.Id("dbl_click")));
        private IWebElement mouseHover => wait.Until(d => d.FindElement(By.Id("mouse_hover")));
        private IWebElement scrollElement => wait.Until(d => d.FindElement(By.Id("scrolled_element")));


        public String DragAndDrop()
        {
            action.DragAndDrop(draggable, droppable).Perform();
            return droppable.Text;
        }

         public void SelectItems()
        {
            action.KeyDown(Keys.Control)
          .Click(listItems[1]) 
          .Click(listItems[2]) 
          .KeyUp(Keys.Control)
          .Build()
          .Perform();
        }

          public void DoubleClick()
        {
            action.DoubleClick(doubleClickButton).Build().Perform();
        }

        public void MouseHover()
        {
            action.MoveToElement(mouseHover).Build().Perform();
        }

        public String ScrollToElement()
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            js.ExecuteScript("arguments[0].scrollIntoView(true);", scrollElement);
            return scrollElement.Text;
        }

    }
}
