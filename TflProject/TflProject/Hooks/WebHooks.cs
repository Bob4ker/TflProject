using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Reflection;
using TechTalk.SpecFlow;

namespace TflProject.Hooks
{
    [Binding]
    public class WebHooks
    {
        // declare your driver object
        public static IWebDriver driver;

        [BeforeScenario("@tag1")]
        public void BeforeScenarioWithTag()
        {

            //instantiate your driver with chromedriver
            driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));   
            driver.Manage().Window.Maximize();  //mazimise chromedriver
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);


        }

        [AfterScenario]
        public void AfterScenario()
        {
            //Thread.Sleep(3000);
            driver.Quit();
           
        }
    }
}