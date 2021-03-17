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

        [Given(@"I am a user on Giftrete website")]
        public void GivenIAmAUserOnGiftreteWebsite()
        {
            driver.Navigate().GoToUrl(@"https://www.giftrete.com");
        }


               
        [When(@"I click on create account button")]
        public void WhenIClickOnCreateAccountButton()
        {
           
        }
        
        [When(@"I enter email address")]
        public void WhenIEnterEmailAddress()
        {
           
        }
        
        [When(@"I enter first name")]
        public void WhenIEnterFirstName()
        {
            
        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            
        }
        
        [When(@"I enter phone number")]
        public void WhenIEnterPhoneNumber()
        {
            
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
          
        }
        
        [When(@"I re-enter password to confirm password")]
        public void WhenIRe_EnterPasswordToConfirmPassword()
        {
           
        }
        
        [When(@"I click on register now!")]
        public void WhenIClickOnRegisterNow()
        {
            
        }
        
        [Then(@"I must be successfully registered")]
        public void ThenIMustBeSuccessfullyRegistered()
        {
            
        }
    }
}
