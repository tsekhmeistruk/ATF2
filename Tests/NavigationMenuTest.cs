using NUnit.Framework;
using PageObjects;
using System.Collections.Generic;

namespace Tests
{
    [TestFixture]
    public class NavigationMenuTest : BaseTest
    {
        [Test]
        public void CheckTitles()
        {
            //Arrange
            List<string> menuOptions = new List<string>()
            {
                "News",
                "Documentation",
                "Contact"
            };
            var homePage = PageObjectFactory.GetPage<NUnitHomePage>();
            homePage.Open();

            foreach (var menuOption in menuOptions)
            {
                //Act
                homePage.OpenMenu(menuOption.ToLower());
                string actualResult = homePage.GetTitle();

                //Assert
                Assert.IsTrue(actualResult.Contains(menuOption));
            }        
        }
    }
}
