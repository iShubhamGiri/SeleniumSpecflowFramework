Feature: Login Functionality

  Scenario: Successful login with valid credentials
    Given I login with valid credentials
    Then I should be redirected to the products page
