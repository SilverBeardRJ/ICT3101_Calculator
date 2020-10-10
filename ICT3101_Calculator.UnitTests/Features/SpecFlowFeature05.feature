Feature: UsingCalculatorBasicReliability
	In order to calculate the Basic Musa model's failures/intensities
	As a Software Quality Metric enthusiast
	I want to use my calculator to do this

@Musa
Scenario: Calculating Current Failure Intenstiy
	Given I have a calculator
	When I have entered "50" and "10" into the calculator and press Failure Intenstiy
	Then the Failure intensity result should be "5"

@Musa
Scenario: Calculate Average Number of Expected Failures after 10 hours
    Given I have a calculator
    When I have entered "10" and "10" into the calculator and press AEF
    Then the average number of expected failures result should be "63"

@Musa
Scenario: Calculate Average Number of Expected Failures after 100 hours
    Given I have a calculator
    When I have entered "10" and "100" into the calculator and press AEF
    Then the average number of expected failures result should be "100"