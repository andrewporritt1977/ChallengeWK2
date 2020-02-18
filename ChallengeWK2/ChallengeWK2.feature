Feature: ChhallengeWK2
	In order to entertain myself
	As a game player
	I want to be able to select the game

	@game_selection
Scenario: Game Selection 1
	Given I have entered 1 into the game selector
	When I press select
	Then the result should be Game1

		@game_selection
Scenario: Game Selection 2
	Given I have entered 2 into the game selector
	When I press select
	Then the result should be Game2 

		@game_selection
Scenario: Game Selection 3
	Given I have entered 3 into the game selector
	When I press select
	Then the result should be Game3 

		@game_selection
Scenario: Game Selection 4
	Given I have entered 4 into the game selector
	When I press select
	Then the result should be Error

		@game_selection
Scenario: Game Selection 0
	Given I have entered 0 into the game selector
	When I press select
	Then the result should be Error