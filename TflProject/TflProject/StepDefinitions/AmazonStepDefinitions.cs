using System;
using TechTalk.SpecFlow;
using TflProject.PageObject;

namespace TflProject.StepDefinitions
{
    [Binding]
    public class AmazonStepDefinitions
    {
        AmazonPage amazonPage = new AmazonPage();

        [Given(@"I navigate to website ""([^""]*)""")]
        public void GivenINavigateToWebsite(string url)
        {
            amazonPage.NavigateToUrl(url);
        }

        [When(@"I select sign in")]
        public void WhenISelectSignIn()
        {
            amazonPage.SelectSignIn();
        }

        [When(@"I enter username ""([^""]*)""")]
        public void WhenIEnterUsername(string uname)
        {
            amazonPage.UserName(uname);
        }

        [When(@"I click continue button")]
        public void WhenIClickContinueButton()
        {
            amazonPage.ClickContinueButton();
        }

        [When(@"I enter password ""([^""]*)""")]
        public void WhenIEnterPassword(string pword)
        {
            amazonPage.EnterPassword(pword);
        }

        [When(@"I click sign button")]
        public void WhenIClickSignButton()
        {
            amazonPage.ClickSignButton();
        }

        [Then(@"amazon page is displayed")]
        public void ThenAmazonPageIsDisplayed()
        {
            amazonPage.AmazonPageIsDisplayed().Should().BeTrue();
        }
    }
}
