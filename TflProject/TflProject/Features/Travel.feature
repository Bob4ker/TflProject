Feature: Travel

As a tfl user I want to plan my journey
from Barking to Heathrow 

@tag1
Scenario: Verify user can travel by train
	Given I am on "https://tfl.gov.uk/"
	When I select Journey Planner
	And I enter "<from>"Origin
	And I enter "<to>"Destination
	And I click to select plan my journey button
	Then journey page is displayed


	Examples: 
	| from    | to       |
	| Barking | Heathrow |
	
