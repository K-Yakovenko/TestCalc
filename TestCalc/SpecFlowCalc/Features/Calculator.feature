Feature: Calculator
@mytag
Scenario: Successful calculating
	Given launch calculator
	And enter numbers '12', '999' and add them up 
	And remember the result
	When enter number '19'
	And add to a number in memory
	Then the result is '1030'
	And close calculator