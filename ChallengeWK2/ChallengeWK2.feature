Feature: ChhallengeWK2
	In order to entertain myself
	As a game player
	I want to be able to select the game

	@game_selection
Scenario: Game Selection 1
	Given I have entered 1 into the game selector
	When I press select
	Then the result should be 1 on the screen

		@game_selection
Scenario: Game Selection 2
	Given I have entered 1 into the game selector
	When I press select
	Then the result should be 2 on the screen

		@game_selection
Scenario: Game Selection 3
	Given I have entered 1 into the game selector
	When I press select
	Then the result should be 3 on the screen

		@game_selection
Scenario: Game Selection 4
	Given I have entered 4 into the game selector
	When I press select
	Then the result should be an error message telling the user that there is no associated game

		@game_selection
Scenario: Game Selection null
	Given I have entered null into the game selector
	When I press select
	Then the result should be an error message telling the user that there is no associated game