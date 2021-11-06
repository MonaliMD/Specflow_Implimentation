using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Specflow_task1.SpecDefinition
{
    [Binding]
    public class ProfileFeatureSteps : Driver
    {

        SignIn signInObj = new SignIn();
        
        [Given(@"I go the website url")]
        public void GivenIGoTheWebsiteUrl()
        {   
            SignIn.SigninStep();
        }

        [Given(@"I click on login button")]
        public void GivenIClickOnLoginButton()
        {
            SignIn.selectLogin();
        }

        [When(@"I enter my valid '(.*)' and '(.*)' and click on login button")]
        public void WhenIEnterMyValidAndAndClickOnLoginButton(string p0, string p1)
        {
            SignIn.enterUserNamePw(p0,p1);
        }

        [Then(@"Then I should be able to see my name on the page")]
        public void ThenThenIShouldBeAbleToSeeMyNameOnThePage()
        {
            string newProfileName = signInObj.getProfileName(driver);
            Assert.That(newProfileName == "Monali Marapana", "Login failed.");
        }


    }
}
