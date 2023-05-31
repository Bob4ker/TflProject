using NUnit.Framework;
using OpenQA.Selenium;
using System;
using TechTalk.SpecFlow;
using TflProject.PageObject;

namespace TflProject.StepDefinitions
{
    [Binding]
    public class TflHomePageStepDefinitions
    {
        TflPage tflPage = new TflPage();


        [Given(@"A user navigate to website ""([^""]*)""")]
        public void GivenAUserNavigateToWebsite(string url)
        {
            tflPage.NavigateToUrl(url);
        }

        [Given(@"I click on accept cookies")]
        public void GivenIClickOnAcceptCookies()
        {
            tflPage.AcceptCookies();
        }




        [When(@"I click on plan a journey menu")]
        public void WhenIClickOnPlanAJourneyMenu()
        {
            tflPage.AcceptCookies();
        }

        [When(@"I enter ""([^""]*)"" Origin")]
        public void WhenIEnterOrigin(string from)
        {
            tflPage.EnterOrigin(from);
        }

        [When(@"I enter ""([^""]*)"" Destnation")]
        public void WhenIEnterDestnation(string to)
        {
            tflPage.EnterDestination(to);
        }


        [When(@"I click plan my journey button")]
        public void WhenIClickPlanMyJourneyButton()
        {
            tflPage.ClickOnPlanAJourneyMenu();
        }


        [Then(@"I should be able to view journey from Oxford circus to Padding to station")]
        public void ThenIShouldBeAbleToViewJourneyFromOxfordCircusToPaddingToStation()
        {
            tflPage.TflPageIsDisplayed().Should().BeTrue();
        }

    }
}
