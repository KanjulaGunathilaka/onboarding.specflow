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

	And Seller enter availability details
		| Availability | Hours                    | EarnTarget               |
		| Part Time    | Less than 30hours a week | Less than $500 per month |

	And Seller enter "Experienced IT Solutions" as description

	And Seller add language details
		| Language | Level |
		| English  | Basic |

	And Seller enter skills details
		| Skill              | Level    |
		| Functional Testing | Beginner |

	And Seller enter education details
		| University          | Country   | Title  | Degree | Year |
		| Victoria University | Australia | B.Tech | BSc IT | 2022 |
	And Seller enter Certification details
		| Certificate | Institute | Year |
		| ISTQB CTFL  | ISTQB     | 2022 |

	Then Seller should be able to see profile details successfully


Scenario: Seller share Sellers profile details
	Given Seller logged in to the website
	When Seller is navigate to share skill page
	And Seller enter "Quality Finds" Title
	And Seller enter "Discover a world of handpicked treasures and unique finds" Description
	And Seller select "Digital Marketing" as category and "Content Marketing" as sub Category
	And Seller enter "LimitedEdition" and "QualityProducts" as tags
	And Seller select "Hourly basis service" as Service type
	And Seller select "Online" as Location type
	And Seller select "10/06/2023" as start date and "30/06/2023" as end date
	And Seller choose "Credit" as skill trade
	And Seller select "Active" services
	And Seller click save button
	Then Seller is able to save share skill page successfully

Scenario: Seller view sellers added profile details
	Given Seller logged in to the website
	When Seller navigate to manage listing
	And listing details visible
	And Seller click "View sign"  on share skill page
	Then Seller is able to see the seller’s profile details successfully

