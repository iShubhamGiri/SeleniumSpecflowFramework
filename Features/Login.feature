@Smoke @Login
Feature: Login Functionality

  Scenario: Valid user should login successfully
    Given I launch the application
    When I login with valid credentials
    Then I should see the dashboard
