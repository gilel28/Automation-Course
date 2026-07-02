namespace Exercise_01_Basics
{
    public class Test : BaseTest
    {



        [Test]
        public void Test_01()
        {
            driver.Navigate().Refresh();
            String actualTitle = driver.Title;
            String actualUrl = driver.Url;
            String expectedTitle = "IMDb: Ratings, Reviews, and Where to Watch the Best Movies & TV Shows";
            String expectedUrl = "https://www.imdb.com/";           
            Assert.That(actualUrl, Is.EqualTo(expectedUrl), "URL does not match");
            //Assert.That(actualTitle, Is.EqualTo(expectedTitle), "Title does not match");
        }
    }
}
