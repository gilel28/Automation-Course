using OpenQA.Selenium;

namespace Exercise_02_Locators
{
    public class Test : BaseTest
    {
 

        [Test]
        public void Test_01()
        {

            IWebElement locatorId = driver.FindElement(By.Id("locator_id"));
            IWebElement locatorName = driver.FindElement(By.Name("locator_name"));
            IWebElement locatorTag = driver.FindElement(By.TagName("p"));
            IWebElement locatorcClass = driver.FindElement(By.ClassName("locator_class"));
            IWebElement locatorLinkText = driver.FindElement(By.LinkText("myLocator(5)"));
            IWebElement locatorPartialLinkText = driver.FindElement(By.PartialLinkText("Find my locator"));
            IWebElement locatorCss = driver.FindElement(By.CssSelector("input[myname='selenium']"));
            IWebElement locatorXpath = driver.FindElement(By.XPath("//*[@class='btn btn-2']"));

            List<IWebElement> elementsList = new List<IWebElement>
           {
             locatorId,
             locatorName,
             locatorTag,
             locatorcClass, 
             locatorLinkText,
             locatorPartialLinkText,
             locatorCss,
             locatorXpath
           };

            foreach (IWebElement element in elementsList)
            {
                Console.WriteLine(element);
            }


        }
    }
}
