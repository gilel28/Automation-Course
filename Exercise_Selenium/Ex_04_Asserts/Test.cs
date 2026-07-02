using Ex_04_Controllers;

namespace Ex_04_Controllers
{
    public class Test : BaseTest
    {

        private FormPage formPage;

        [Test]
        public void Test_01()
        {
            formPage = new FormPage(driver);
            String result = formPage.Fill("84", "180");
            Assert.That(result, Is.EqualTo("That you have overweight."));
        }

    }
}





