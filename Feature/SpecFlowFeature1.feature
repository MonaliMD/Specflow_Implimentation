Feature: Profile feature
	As a seller I would like to add my all details in my profile 
	So that others can my fully completed profile

@mytag
Scenario: Login to the website
	Given I go the website url
	And I click on login button
	When I enter my valid '<userName>' and '<password>' and click on login button
	Then Then I should be able to see my name on the page

	Examples: 
	| userName | password |
	| monalimeg@gmail.com | Mon6yhn@123 |
	