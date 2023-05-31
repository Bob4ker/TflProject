Feature: TflHomePage

As user on Tlf
I want to go on the homepage
so that I can plan a journey
from Oxford circus to Paddington station

@tag1
    Scenario Outline: Verify a user can plan journey form Oxford circus to Paddington station
	Given A user navigate to website "https://tfl.gov.uk/"
	And I click on accept cookies
	When I click on plan a journey menu
	And I enter "<from>" Origin
	And I enter "<to>" Destnation
	And I click plan my journey button
	Then I should be able to view journey from Oxford circus to Padding to station 

	Examples: 
	| from          | to                 |
	| Oxford circus | Paddington station |
	
	
	