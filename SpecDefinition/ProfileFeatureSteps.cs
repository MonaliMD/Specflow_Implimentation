using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Specflow_task1.Pages;
using System;
using TechTalk.SpecFlow;

namespace Specflow_task1.SpecDefinition
{
    [Binding]
    public class ProfileFeatureSteps
    {
        [Given(@"I go the website url")]
        public void GivenIGoTheWebsiteUrl()
        {
            //open chrome browser
            IWebDriver driver = new ChromeDriver();
            SignIn signInPage = new SignIn();
            signInPage.signInActions(driver);
        }
    }
}
