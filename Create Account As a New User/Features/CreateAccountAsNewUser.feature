Feature: CreateAccountAsNewUser
	AS a user on Giftrete website (www.giftrete.com)
	I want to register with my details
	So that I can have a registered account


@CreateAccountAsNewUser
Scenario: Valid registration
	Given that I am a user on Giftrete website (www.giftrete.com) 
	When I click on create account button
	And I enter email address
	And I enter first name
	And I enter last name
	And I enter phone number
	And I enter password
	And I re-enter password to confirm password
	And I click register now!
	Then I must be successfully registered