Feature: Calculator
@mytag
Scenario: Successful calculating
	Given Calculator was opened
		And Numbers '12', '999' were entered and added up 
		And The result was remembered
	When The user enters number '19'
		And The user adds it to a number in memory
	Then Number '1030' is shown
		And The Calculator is closed