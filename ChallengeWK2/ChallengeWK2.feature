Feature: ChhallengeWK2
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

	@game_selection
Scenario: Game Selection 1
	Given I have opened the the app
	And I want to play a game 
	When I enter 1
	Then then game 1 is loaded

	@game_selection
Scenario: Game Selection 2
	Given I have opened the the app
	And I want to play a game 
	When I enter 2
	Then then game 2 is loaded

	@game_selection
Scenario: Game Selection 3
	Given I have opened the the app
	And I want to play a game 
	When I enter 3
	Then then game 3 is loaded

	@game_selection
Scenario: Game Selection 4
	Given I have opened the the app
	And I want to play a game 
	When I enter 4
	Then then a message saying "Game not available." is returned.

		@game_selection
Scenario: Game Selection null
	Given I have opened the the app
	And I want to play a game 
	When I enter null
	Then then a message saying "Game not available." is returned.