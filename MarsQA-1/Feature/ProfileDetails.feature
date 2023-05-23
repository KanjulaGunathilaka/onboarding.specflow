Feature: Profile Details
	As a Seller who already has a login
	Seller should be able to add, share and view profile details
	So that Seller can promote the skills
@mytag
Scenario: Seller Add Sellers profile details
	Given Seller logged in to the website
	When Seller enter "valid" name details
	And Seller enter "valid" availability details
	And Seller enter "Experienced IT Solutions" description  
	And Seller add language details
	And Seller enter skills details
	And Seller enter education details
	And Seller enter Certification details
	Then Seller able to add profile details successfully

Scenario: Seller share Sellers profile details
Given Seller logged in to the website
When Seller is navigate to share skill page
And Seller enter "Valid" Title
And Seller enter "Valid" Description
And Seller enter "Valid" Description
And Seller enter tags 
And Seller select Service type
And Seller select Location type
And Seller select available start date and end date
And Seller select available start date and end date
And Seller choose skill trade
And Seller add new tags for skill exchange
And Seller upload work samples
And Seller Active services
And Seller click save button
Then Seller is able to save share skill page succussfully