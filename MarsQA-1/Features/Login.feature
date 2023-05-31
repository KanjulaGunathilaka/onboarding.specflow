Feature: Seller Login to the Website
	As a Seller who already has a login
	Seller should be able to login to the website
	So that Seller can do some work

@SELLERLOGIN
Scenario: Seller login to website using login credentials
	Given Seller enter user credentials
	When Seller submit user credentials
	Then Seller should be navigated to the home page successfully