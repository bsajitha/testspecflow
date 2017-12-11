Feature: Assert the search results for items matching 'Mini Antigona Tote'
	As a user
	I want to search for an Mini Antigona Tote and assert results


Scenario: Search an item on harrods website
	Given I have entered https://www.harrods.com into the browser
	When I search for Mini Antigona Tote
	Then check 5 items matching the Mini Antigona Tote are returned
	
