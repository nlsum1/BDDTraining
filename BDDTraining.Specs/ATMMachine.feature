Feature: ATMMachine
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Account has sufficient funds
	Given the account balance is 1500
	And the debit card is valid
	And the ATM machine contains enough money with 10000
	When the Account Holder requests 500
	Then the ATM machine should dispense 500
	And the account balance should be 1000
	And the card should be returned


	@mytag
Scenario: Account does not have sufficient funds
	Given the account balance is 100
	And the debit card is valid
	And the ATM machine contains enough money with 10000
	When the Account Holder requests 500
	Then the ATM machine should not dispense money
	And the account balance should remain 100
	And the card should be returned
