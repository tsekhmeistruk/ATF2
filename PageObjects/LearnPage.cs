using OpenQA.Selenium;
using System;
using ATF;

namespace PageObjects
{
    public class LearnPage:BasePage
    {
        private readonly string learnPage;
        public LearnPage(WebDriverWrapper driver) : base(driver) { }
        
    }
}
