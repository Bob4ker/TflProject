Feature: Amazon

As user on Amazon I want to buy a product

@tag1
Scenario: Verify user can buy a product
	Given I navigate to website "https://www.amazon.co.uk/"
	When I select sign in
	And I enter username "borray24@hotmail.com"
	And I click continue button
	And I enter password "Rayrayx45$"
	And I click sign button
	Then amazon page is displayed
