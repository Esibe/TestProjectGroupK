Feature: Registration
	In order to benefit from website 
	The user must first register

@mytag
Scenario: Valid Registration 
	Given I navigated to the website
	And I click on sign up
	And I enter my username 
	And I enter my Email
	And I enter my Passward 
	When when I click on Sign up button
	Then I should be able to register successfully 