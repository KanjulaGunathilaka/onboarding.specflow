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