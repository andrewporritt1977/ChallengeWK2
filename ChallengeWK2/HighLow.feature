Feature: SpecFlowFeature1
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@game_result_highLow
Scenario: Failed Game
	Given I have a target number 4
	When I guess 7
	Then the highLow result will be Lose

@game_result_highLow
Scenario: Successful Game
	Given I have a target number 4
	When I guess 4
	Then the highLow result will be Win
