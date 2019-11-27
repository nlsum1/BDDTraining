Feature: OnlineTransact
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Register for online access
	Given I am a valid account holder
	When I enter the following details
	| Name | AccountNo | Phone      | Email          |
	| Hari | SB11111   | 9898989898 | hari@xnsio.com |
	And I register
	Then I should receive the message "Registration successful"


	
@mytag
Scenario: Register for online access when I'm not a valid account holder
	Given there are several valid account holders
	| Name | AccountNo | Phone      | Email          |
	| Hari | SB11111   | 9898989898 | hari@xnsio.com |
	| Aileen | SB11112   | 9898989898 | test@xnsio.com |
	When I enter the following details
	| Name | AccountNo | Phone      | Email          |
	| Sum | SB11113   | 9898989898 | test2@xnsio.com |
	And I register
	Then I should receive the message "No Account found"
