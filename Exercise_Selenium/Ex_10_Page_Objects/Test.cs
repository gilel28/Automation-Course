using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_10_Page_Objects
{
    internal class Test  : BaseTest
    {
        private LoginPage loginPage;
        private FormPage formPage;
        [SetUp] 
        public void SetUp() 
        {
            loginPage = new LoginPage(driver);
            formPage = new FormPage(driver);
        }

        [Test]
        public void TestLogin()
        {
            loginPage.Login("selenium", "webdriver");
            Assert.That(driver.Url, Is.EqualTo("https://atidcollege.co.il/Xamples/webdriveradvance2.html"),"Login Failed!!!");
        }
        [Test]
        public void TestForm()
        {

            driver.Navigate().GoToUrl("https://atidcollege.co.il/Xamples/webdriveradvance2.html");
            formPage.FillForm("Engineer", "30", "New York");
            Assert.That(driver.Url, Is.EqualTo("https://atidcollege.co.il/Xamples/webdriveradvance3.html"), "Form Submission Failed!!!");
        }

        [Test]
        public void CheckButton()
        {
            driver.Navigate().GoToUrl("https://atidcollege.co.il/Xamples/webdriveradvance3.html");
            Assert.That(loginPage.CheckButton(),"Click are not displayed!!");
        }
}
}
