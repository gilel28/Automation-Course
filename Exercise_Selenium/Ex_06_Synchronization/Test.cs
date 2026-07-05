using NUnit.Framework;

namespace Ex_06_Synchronization
{
    public class Test : BaseTest
    {
        [Test]
        public void ExplicitWaitTest()
        {
            SynchronizationPage page = new SynchronizationPage(driver);
            Assert.That( page.Rendered(),Is.EqualTo("My Rendered Element After Fact!"));
        }

        [Test]
        public void ImplicitWaitTest()
        {
            SynchronizationPage page = new SynchronizationPage(driver);

            Assert.That(page.Delete(), Is.EqualTo("It's gone!"));
        }
    }
}