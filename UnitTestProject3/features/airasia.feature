Feature: SpecFlowFeature1
	


Scenario: test to verify that user able to redirect to guest page
	Given User Launched airasia portal
    When User selects To and From destination 
    And User search for Flights
    And User selects any flight 
    And User click on continue
    Then Verify user redirect to guest details page