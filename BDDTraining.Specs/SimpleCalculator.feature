Feature: SimpleCalculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have also entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

@mytag
Scenario: Subtract two numbers
	Given I have entered 70 into the calculator
	And I have also entered 50 into the calculator
	When I press subtract
	Then the result should be 20 on the screen

@mytag
Scenario: Divide two numbers
	Given I have entered 100 into the calculator
	And I have also entered 10 into the calculator
	When I press divide
	Then the result should be 10 on the screen

@mytag
Scenario: Multiply two numbers
	Given I have entered 20 into the calculator
	And I have also entered 5 into the calculator
	When I press multiply
	Then the result should be 100 on the screen

@myag
Scenario: : Clear two numbers
	Given I have entered 20 into the calculator
	And I have also entered 5 into the calculator
	When I press clear
	Then the result should be 0 on the screen

@mytag
Scenario Outline: Add two numbers outline
And I have entered <NumberOne> into the calculator
And I have also entered <NumberTwo> into the calculator
When I press add
Then the result should be <Result> on the screen

Examples:
| NumberOne | NumberTwo | Result |
| 70        | 70        | 140    |
| 20        | 120       | 140    |