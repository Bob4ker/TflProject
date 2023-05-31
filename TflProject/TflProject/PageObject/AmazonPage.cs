using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TflProject.Hooks;

namespace TflProject.PageObject
{
    public class AmazonPage
    {
        public static IWebDriver driver;

        public AmazonPage()
        {
            driver = WebHooks.driver;
        }

        private IWebElement acceptButton => driver.FindElement(By.XPath("//*[@id=\"sp-cc-accept\"]"));
        private IWebElement popUpPage => driver.FindElement(By.XPath("//*[@id=\"cb-left\"]/h2"));
        private IWebElement signIn => driver.FindElement(By.XPath("//div[@id='nav-signin-tooltip']//span[@class='nav-action-inner'][normalize-space()='Sign in']"));
        private IWebElement enterUserName => driver.FindElement(By.XPath("//input[@id='ap_email']"));
        private IWebElement continueButton  => driver.FindElement(By.XPath("//input[@id='continue']"));
        private IWebElement enterPassword => driver.FindElement(By.XPath("//input[@id='ap_password']"));
        private IWebElement signButton => driver.FindElement(By.XPath("//input[@id='signInSubmit']"));
        private IWebElement amazonPageIsDisplayed => driver.FindElement(By.XPath("//img[@class='ad-background-image mrc-btr-creative']"));




        public void NavigateToUrl(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public void AcceptCookies()
        {
            if (popUpPage.Displayed)

            acceptButton.Click();
        }

        public void SelectSignIn()
        {
            //Thread.Sleep(3000);
            signIn.Click();
        }

        public void UserName(string uname)
        {
            //Thread.Sleep(3000);
            enterUserName.SendKeys(uname);
        }

        public void ClickContinueButton()
        {
            continueButton.Click();
        }
        public void EnterPassword(string pword)
        {
            //Thread.Sleep(3000);
            enterPassword.SendKeys(pword);
        }

        public void ClickSignButton()
        {
            //Thread.Sleep(3000);
            signButton.Click();
        }

        public bool AmazonPageIsDisplayed()
        {
            return driver.Url.Contains("https://www.amazon.co.uk");
        }


    }

}
