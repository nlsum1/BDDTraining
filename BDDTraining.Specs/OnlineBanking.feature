Feature: OnlineBanking
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers


@Sender @Transfer
Scenario: Transfer money to another account within same bank
	Given I'm the account owner who wants to transfer money
	And I have sufficient bank account amount
	When I enter 100 in the amount field
	And I enter the recipient account number
	And I click transfer button
	Then my bank account will be debited 100
	And I should receive the message from bank "Transferred successfully"

@Receiver @Transfer
Scenario: Receive money from another account within same bank
	Given I'm the account owner who receives money
	And person with acount number '1234' transfers 100 to my account
	When I check my account balance
	Then my bank account will be credited 100

