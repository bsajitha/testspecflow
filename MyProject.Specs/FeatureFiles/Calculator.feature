﻿Feature: Calculator
	As a user
	I want to be told the sum of two numbers


Scenario: Add two numbers
	Given I have entered 55 into the calculator
	And I have also entered 85 into the calculator
	When I press add
	Then the result should be 140 on the screen


