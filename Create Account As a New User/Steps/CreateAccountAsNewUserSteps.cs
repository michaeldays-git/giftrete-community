using Giftrete_Community.Hooks;
using Giftrete_Community.PageObjects;
using OpenQA.Selenium;
using TechTalk.SpecFlow;


namespace Giftrete_Community.Steps
{
    [Binding]
    public class CreateAccountAsNewUserSteps
    {
        public IWebDriver driver = WebHook.driver;

        CreateAccountPage createAccountPage = new CreateAccountPage();
        private object _createAccountPage;

        [Given(@"that I am a user on Giftrete website \(www\.giftrete\.com\)")]
        public void GivenThatIAmAUserOnGiftreteWebsiteWww_Giftrete_Com()
        {
            driver.Navigate().GoToUrl(@"https://www.giftrete.com");
        }
        
        [When(@"I click on create account button")]
        public void WhenIClickOnCreateAccountButton()
        {
            _createAccountPage.ToString();
        }
        
        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter first name")]
        public void WhenIEnterFirstName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I re-enter password to confirm password")]
        public void WhenIRe_EnterPasswordToConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on register now!")]
        public void WhenIClickOnRegisterNow()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I must be successfully registered")]
        public void ThenIMustBeSuccessfullyRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
