Feature: nike
	

@mytag
Scenario: test to verify that selected product has been added to cart
	Given User launched Nike portal
    When User Navigate to All Shoes from Men
    Then Verify the Men shoes page is Displayed
    When User sort the shoes from High to Low
    And User selects any shoe
    And User select the size and click on Add to Bag
    Then verify if selected product has been added to cart successfully