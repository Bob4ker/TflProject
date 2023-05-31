Feature: AutoTrader

As user on Auto trader I want to 
login so that I can buy a car

@tag1
Scenario: Verify user can buy a car
	Given I am on "https://www.autotrader.co.uk/"
	When I click on accept all cookies
	And I click on sign in menu
	And I enter username "borray24@hotmail.com"
	And I enter password "Rayrayx45$"
	And I click sign in button
	And I enter postcode in Find your Perfect Car column
	And I select distance 
	And I click to select the make 
	And I click to select the model 
	And I select cash 
	And I click to select Min price 
	And I click to select Max price
	And I click search button
	Then car search page is displayed
	And I click on prefered car

