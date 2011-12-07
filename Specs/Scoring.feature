Feature: Scoring
	In order to keep track of my score
	As a bowler
	I want to use an automated scoring system with some other feedback

@mytag
Scenario: Bowling a strike
	Given I am on the first frame
	When I bowl a strike
	Then I should see an "X" and a message that says "Good job!"

Scenario: Not scoring in a whole game
	
Scenario: Bowling a gutter ball
	
Scenario: x