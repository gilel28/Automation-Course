
 using Ex_03_Controllers;

namespace Ex_03_Controllers
    {
        public class Test : BaseTest
        {

            private FormPage formPage;

            [Test]
            public void Test_01()
            {
                formPage = new FormPage(driver);
                formPage.Fill("gil", "eliav");

            }
        }
    }

}
