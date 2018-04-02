Feature: Searcing Aviva in google
	In order search Aviva in Google
	As a user
	I want to enter Aviva in google text box and click search

@PositiveScenario
Scenario Outline: Search Aviva in google and print the 5th link
	Given Open the google site
	And I have entered '<keyword>' into the google text box
	When I click the search button
	Then the resulted 5th link should be printed

Examples: 
| keyword | 
| Aviva   |

@NegativeScenario
Scenario Outline: Seraching with wrong name of Aviva
	Given Open the google site
	And I have entered '<keyword>' into the google text box
	When I click the search button
	Then Aviva results should be displayed

Examples: 
| keyword     |
| #^%$%$123Ab |
