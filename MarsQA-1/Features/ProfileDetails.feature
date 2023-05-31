Feature: Profile Details
	As a Seller who already has a login
	Seller should be able to add, share and view profile details
	So that Seller can promote the skills

@SELLERPROFILE
Scenario: Seller Add Sellers profile details
	Given Seller logged in to the website
	When Seller enter name details
		| FirstName | LastName |
		| Sandha    | Herath   |
	#And Seller enter availability details as "Part Time" and "Less Than 30" and "less than 500"
	#And Seller enter "Experienced IT Solutions" description
	#And Seller add "English" and "basic" as language details
	#And Seller enter "Testing" and "Beginner" as skills details
	#And Seller enter "massey","New Zealand","B.Sc", "Management" and "2020" as education details
	#And Seller enter "Istqb" , "Adobe"  and "2019" as Certification details
	#Then Seller able to add profile details successfully

Scenario: Seller share Sellers profile details
	Given Seller logged in to the website
	When Seller is navigate to share skill page
	And Seller enter "Quality Finds" Title
	And Seller enter "Discover a world of handpicked treasures and unique finds" Description
	And Seller select "Business" as category and "Presentations" as sub Category
	And Seller enter "LimitedEdition" and "QualityProducts" as tags
	And Seller select "Hourly basis" as Service type
	And Seller select "On-site" as Location type
	And Seller select "10/06/2023" as start date and "30/06/2023" as end date
	And Seller select "Monday " "8.00 am " as available start time and 5.00 pm as end time
	And Seller choose "Skill-exchange" as  skill trade
	And Seller add new tags "BusinessExchange" and "CodingExchange" for skill exchange
	And Seller upload "work sample pdf" work samples
	And Seller select "Active" services
	And Seller click save button
	Then Seller is able to save share skill page succussfully

Scenario: Seller view sellers added profile details
	Given Seller logged in to the website
	When Seller navigate to manage listing
	And listing details visible
	And Seller click "View sign"  on share skill page
	Then Seller is able to see the seller’s profile details successfully

