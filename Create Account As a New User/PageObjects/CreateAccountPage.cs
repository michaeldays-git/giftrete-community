
using Giftrete_Community.Hooks;
using OpenQA.Selenium;

namespace Giftrete_Community.PageObjects
{
    class CreateAccountPage
    {
        public IWebDriver driver;
        private By clickbutton = By.Name("Create account");


        public CreateAccountPage()
        {
            driver = WebHook.driver;
        }


        public void ClickCreateButton()
        {
            driver.FindElement(clickbutton).Click();
        }
    }
}
