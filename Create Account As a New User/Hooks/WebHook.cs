using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Giftrete_Community.Hooks
{
    [Binding]
    public class WebHook
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public static void BeforeScenario()
        {
            driver = new ChromeDriver(AppDomain.CurrentDomain.BaseDirectory);
        }

        [AfterScenario]
        public static void AfterScenario()
        {
            //TODO: implement logic that has to run after executing each scenario
        }
    }
}
