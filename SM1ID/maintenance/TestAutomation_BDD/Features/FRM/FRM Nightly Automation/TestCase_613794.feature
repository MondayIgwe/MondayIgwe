﻿Feature: TestCase_613794
	Validates the functionality of the stateless column checkbox

@BDD_TC613794 @FRM_Nightly @FRM
Scenario: WEB_FRM_REFDOC_SHOW_STATELESS_COLUMN

    # Step 1 - 2
    Given the user navigates to the 'Reference Docs' page
    When the user creates a Reference doc with Date 1: 'Today'  Date 2: 'Today' Textbox: 'Test' Combo: 'voice1' DatePicker: 'Today' Force Uppercase On Validation: '613794'
	And the user filters the column by column name 'Progressive', Filter Type 'Like', Value 'ProgressiveValue'
    And the user clicks on the link with value 'ProgressiveValue' on the grid

    # Step 3
    And the user clicks on 'Side Panel Tab' with value 'Grids Examples'

    # Step 4
    And the user clicks on 'Checkbox' with value 'Show Stateless Column'
    Then the user validates that the 'Column' with value 'Stateless Column' is displayed

    # Step 5
    When the user clicks on 'Checkbox' with value 'Show Stateless Column'
    Then the user validates that the 'Column' with value 'Stateless Column' is displayed
