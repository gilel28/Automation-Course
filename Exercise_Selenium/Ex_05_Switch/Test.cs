
 using Ex_05_Controllers;

namespace Ex_05_Controllers
    {
        public class Test : BaseTest
        {

            private FormPage formPage;

            [Test]
            public void Test_01()
            {
                formPage = new FormPage(driver);
                formPage.DoThings();

            }
        }
    }


