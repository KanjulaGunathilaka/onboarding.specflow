Feature: Login
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Seller Add Sellers profile details
	Given Seller logged in to the website
	When Seller enter "valid" name details
	And Seller save name details
	Then Name details section should be updated succussfully

Scenario:Seller Add Sellers Availability details
	Given Seller logged in to the website
	When Seller enter availability details as "Part Time"   
	And Seller enter Hours details as "Less than 30 hours per week"   
	And Seller enter Earn Targets as "Less than $500 per month"   
	Then "Availability Details" should be updated succussfully 
