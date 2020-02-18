Feature: NumberPoke
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	@game_results
Scenario: Player has a Pair
	Given my first number is 1
	And my second number is 3
	And and my third number is 3
	When I press continue
	Then the result will be Win

	@game_results
Scenario: Player has three of a kind
	Given my first number is 3
	And my second number is 3
	And and my third number is 3
	When I press continue
	Then the result will be Superwin

	@game_results
Scenario: Player has no Pair
	Given my first number is 1
	And my second number is 2
	And and my third number is 3
	When I press continue
	Then the result will be Lose

