using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ex09_Actions
{
    internal class Test : BaseTest
    {
        private FormPage formPage;

        [Test]

        public void Test_01()
        {
            formPage = new FormPage(driver);
            String result=formPage.DragAndDrop();
            Assert.That(result, Is.EqualTo("Dropped!"));

        }
        [Test]
        public void Test_02()
        {
            formPage = new FormPage(driver);
            formPage.SelectItems();
        }

        [Test]
        public void Test_03()
        {
            formPage = new FormPage(driver);
            formPage.DoubleClick();
        }

        [Test]
        public void Test_04()
        {
            formPage = new FormPage(driver);
            formPage.MouseHover();

        }

        [Test]
        public void Test_05()
        {
            formPage = new FormPage(driver);
            String result = formPage.ScrollToElement();
            Assert.That(result, Is.EqualTo("This Element is Shown When Scrolled"));
        }


    }
}
