Feature: Login Feature

  @Smoke
  Scenario: Valid user logs into the system
    Given I launch the application
    When I enter username "standard_user" and password "secret_sauce"
    And I click on login button
    Then I should be navigated to the homepage
