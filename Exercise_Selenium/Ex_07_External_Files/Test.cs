using Allure.Net.Commons;
using Allure.Net.Commons.Attributes;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;


namespace Ex_07_External_Files
{

    public class Test : BaseTest
    {

        private FormPage formPage;

        [Test]
        [AllureName("check bmi")]
        public void Test_01()
        {
            try
            {
                formPage = new FormPage(driver);
                String result = formPage.Fill(GetData("Weight"), GetData("Height"));
                Assert.That(result, Is.EqualTo("That you have overweight."));
            }
            catch (Exception ex)
            {
                TakeScreenshot(driver);
                Console.WriteLine("Assert failed"+ ex);
            }
        }

        [Test]
        [AllureName("check bmi2")]
        public void Test_02()
        {
            try
            {
                formPage = new FormPage(driver);
                String result = formPage.Fill(GetData("Weight"), GetData("Height"));
                Assert.That(result, Is.EqualTo("That you have overweiht.fff"));
            }
            catch (Exception ex)
            {
                TakeScreenshot(driver);
                Console.WriteLine("Assert failed" + ex);
            }
        }






        public string GetData(string nodeName)
    {
        try
        {
            XDocument doc = XDocument.Load("./testConfig.xml");
            XElement element = doc.Descendants(nodeName).FirstOrDefault();
            return element?.Value;
        }
        catch (Exception e)
        {
            Console.WriteLine("Exception in reading XML file: " + e.Message);
            return null;
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
