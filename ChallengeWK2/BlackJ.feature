Feature: BlackJ

@game_end
Scenario: Naturals human lose
Given the dealer's stand attribute is true
When the dealer's hand is 21
And the human's hand is 20
Then the result for the human is False

	@game_end
Scenario: Naturals human win
Given the dealer's stand attribute is true
When the dealer's hand is 21
And the human's hand is 21
Then the result for human is True
	
	@game_end
Scenario: Bust
Given the dealer's stand attribute is true
When the human's hand is 22 
Then the result for the human is False
	
	@game_ends
Scenario: Blackjack for human
Given the human's hand is 21
Then the result for human is True
	
	@game_end
Scenario: Blackjack for dealer
Given the human's hand is 20
Then the dealer's hand is 21
Then the result for the human is False
	
	@game_end
Scenario: Dealers Play human win
Given the dealer's stand attribute is true
When the dealer's hand is 17
And the human's hand is 18
Then the result for human is True
	
	@game_dealers_play
Scenario: Dealer's play when dealer hand is 17
Given the human's stand attribute is true
When the dealer's hand is 17
Then dealer's stand attribute is true
	
	@game_dealers_play
Scenario: Dealer's play when dealer hand is 16
Given the human's stand attribute is true
When the dealer's hand is 16
Then the dealer must take a card
