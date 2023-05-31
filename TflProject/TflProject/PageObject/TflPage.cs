using FluentAssertions;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflProject.Hooks;

namespace TflProject.PageObject
{
    public class TflPage
    {
      public IWebDriver driver;
       
        public TflPage()
        {
            driver = WebHooks.driver;
        }

        
        
        private IWebElement planAJourney => driver.FindElement(By.CssSelector("#mainnav > div.top-row > div > div:nth-child(2) > ul > li.plan-journey > a"));
        private IWebElement acceptCookies => driver.FindElement(By.XPath("//*[@id=\"CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll\"]/strong"));
        private IWebElement popUpPage => driver.FindElement(By.XPath("//*[@id=\"cb-left\"]/h2"));
        private IWebElement fromTestField  => driver.FindElement(By.XPath("//*[@id=\"InputFrom\"]"));
        private IWebElement toTestField => driver.FindElement(By.XPath("(//input[@id='InputTo'])[1]"));

        private IWebElement planMyJourneyButton => driver.FindElement(By.XPath("//span[@class='jp-results-headline']"));
       

        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptCookies()
        {
            if (popUpPage.Displayed)
            {
                acceptCookies.Click();
            }
            
        }
        public void ClickOnPlanAJourneyMenu()
        {
            planAJourney.Click();
        }

        public void EnterOrigin(string from)
        {
            Thread.Sleep(3000);
            fromTestField.SendKeys(from);
        }

        public void EnterDestination(string to)
        {
            toTestField.SendKeys(to);
        }

        public void ClickOnPlanMyJourneyButton()
        {
            planMyJourneyButton.Click();
        }

        public bool TflPageIsDisplayed()
        {
            return driver.Url.Contains("https://tfl.gov.uk/plan-a-journey/");
        }


    }
}
