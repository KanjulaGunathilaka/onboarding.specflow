Feature: Profile Details
	As a Seller who already has a login
	Seller should be able to add, share and view profile details
	So that Seller can promote the skills
@mytag
Scenario: Seller Add Sellers profile details
	Given Seller logged in to the website
	When Seller enter "valid" name details
	And Seller enter availability details as "Part Time" and "Less Than 30" and "less than 500" 
	And Seller enter "Experienced IT Solutions" description  
	And Seller add "English" and "basic" as language details
	And Seller enter "Testing" and "Beginner" as skills details
	And Seller enter "massey","New Zealand","B.Sc", "Management" and "2020" as education details
	And Seller enter "Istqb" , "Adobe"  and "2019" as Certification details
	Then Seller able to add profile details successfully

Scenario: Seller share Sellers profile details
Given Seller logged in to the website
When Seller is navigate to share skill page
And Seller enter "Quality Finds" Title
And Seller enter "Discover a world of handpicked treasures and unique finds" Description
And Seller select "Business" as category
And Seller enter "LimitedEdition" and "QualityProducts" as tags 
And Seller select "Hourly basis" as Service type
And Seller select "On-site" as Location type
And Seller select 22/05/2023 as available start date and 28/05/2023 as end date
And Seller select "Monday " "8.00 am " as available start time and 5.00 pm as end time
And Seller choose "Skill-exchange" as  skill trade
And Seller add new tags "BusinessExchange" and "CodingExchange" for skill exchange
And Seller upload "work sample pdf" work samples
And Seller select "Active" services
And Seller click save button
Then Seller is able to save share skill page succussfully

