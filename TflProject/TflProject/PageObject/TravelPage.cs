using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflProject.Hooks;

namespace TflProject.PageObject
{
    public class TravelPage
    {
        public static IWebDriver driver;

        public TravelPage()
        {
            driver = WebHooks.driver;
        }

        private IWebElement acceptButton => driver.FindElement(By.XPath("//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]/strong"));
        private IWebElement popuppage => driver.FindElement(By.XPath("//*[@id=\"cb-left\"]/h2"));
        private IWebElement journeyPlannerButton => driver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
        private IWebElement fromTestField => driver.FindElement(By.XPath("//input[@id='InputFrom']"));
        private IWebElement toTestField => driver.FindElement(By.XPath("//input[@id='InputTo']"));
        private IWebElement planMyJourneyButton => driver.FindElement(By.XPath("//input[@id='plan-journey-button']"));
        private IWebElement journeyPageDisplayed => driver.FindElement(By.XPath("//span[@class='jp-results-headline']"));


        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptCookies()
        {
            if (popuppage.Displayed)

            acceptButton.Click();
        }

       public void SelectJourneyPlanner()
        {
            journeyPlannerButton.Click();
        }

        public void EnterOrigin(string from)
        {
            fromTestField.SendKeys(from);
        }
     
        public void EnterDestination(string to)
        {
            toTestField.SendKeys(to);
        }

        
        public void ClickPlanMyJourneyButton()
        {
            planMyJourneyButton.Click();
        }

        public bool TravelPageIsDisplayed()
        {
            return driver.Url.Contains("https://tfl.gov.uk/plan-a-journey/");
        }
    }
}
