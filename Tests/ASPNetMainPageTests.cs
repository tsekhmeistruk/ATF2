
using PageObjects;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    class ASPNetMainPageTests : BaseTest
    {
        [Test]
        public void ASPNetMainPageVerifyTitle()
        {
            string pageTitle = "ASP.NET | The ASP.NET Site";
            var aspNetMainPage = PageObjectFactory.GetPage<ASPNetMainPage>();
            aspNetMainPage.Open();
            Assert.AreEqual(pageTitle, aspNetMainPage.GetTitle());
        }

        [Test]
        public void GoToLearnPage()
        {
            LearnPage learnPage;
            string pageTitle = "Learn | The ASP.NET Site";
            var aspNetMainPage = PageObjectFactory.GetPage<ASPNetMainPage>();
            aspNetMainPage.Open();
            learnPage=aspNetMainPage.ClickOnLearnLink();
            Assert.AreEqual(learnPage.GetTitle(), pageTitle);
        }
    }
}
