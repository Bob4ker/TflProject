using System;
using TechTalk.SpecFlow;
using TflProject.PageObject;

namespace TflProject.StepDefinitions
{
    [Binding]
    public class TravelStepDefinitions
    {
        TravelPage travelPage = new TravelPage();

        [Given(@"I am on ""([^""]*)""")]
        public void GivenIAmOn(string url)
        {
            travelPage.NavigateToUrl(url);
        }

        [When(@"I select Journey Planner")]
        public void WhenISelectJourneyPlanner()
        {
            travelPage.AcceptCookies();
        }

        [When(@"I enter ""([^""]*)""Origin")]
        public void WhenIEnterOrigin(string from)
        {
            travelPage.EnterOrigin(from);
        }

        [When(@"I enter ""([^""]*)""Destination")]
        public void WhenIEnterDestination(string to)
        {
            travelPage.EnterDestination(to);
        }

        [When(@"I click to select plan my journey button")]
        public void WhenIClickToSelectPlanMyJourneyButton()
        {
            travelPage.ClickPlanMyJourneyButton();
        }


        [Then(@"journey page is displayed")]
        public void ThenJourneyPageIsDisplayed()
        {
           travelPage.TravelPageIsDisplayed().Should().BeTrue();
        }

    }
}
