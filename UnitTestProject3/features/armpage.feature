Feature: armpage
	testing the footer copyright section text and links


Scenario:Test to verify Footer copyright section text and links are working or not
	Given user is on arm home page
	When  user accepts the cookie bar
	Then user should be able to view the copyright section text and links

Scenario:Test to verify Footer Legal section text and links are working or not
   Given user is on arm home page
   When user accepts the cookie bar
   Then user should be able to view the Legal section text and links

Scenario: Test to verify the title of arm home page
   Given user is on arm home page
   When user accepts the cookie bar
   Then user should be able to view the Home page title