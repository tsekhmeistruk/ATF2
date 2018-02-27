using OpenQA.Selenium;
using System;
using ATF;


namespace PageObjects
{
   public class ASPNetMainPage :BasePage
    {
        private readonly string aspNetMainPage = @"https://www.asp.net/";
        private By learnLink = By.XPath("//a[contains(text(), 'Learn')]");
        private By Language = By.XPath("//a[contains(text(), 'Language')]");
        private By translateButton = By.Id("TranslateSpan");

        public ASPNetMainPage(WebDriverWrapper driver) : base(driver) { }

        public void Open()
        { Driver.OpenPage(aspNetMainPage); }

        public LearnPage ClickOnLearnLink()
        { Driver.Click(learnLink);
            return new LearnPage(Driver);
        }
        
    }
}
