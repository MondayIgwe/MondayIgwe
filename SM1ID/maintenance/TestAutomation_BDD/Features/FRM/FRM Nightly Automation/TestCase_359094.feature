﻿Feature: TestCase_359094
	Validates 'Checkbox' checkbox in the Field Examples tab

@BDD_TC359094 @FRM_Nightly
Scenario: FRM_WEB_REFDOC_CHECKBOX_001

    # Step 1 - Login and create a new Reference doc from scratch and view it
    Given the user navigates to the 'Reference Docs' page
    When the user creates a Reference doc with Date 1: 'Today'  Date 2: 'Today' Textbox: 'Test' Combo: 'voice1' DatePicker: 'Today' Force Uppercase On Validation: '359094'
	And the user filters the column by column name 'Progressive', Filter Type 'Like', Value 'ProgressiveValue'
    And the user clicks on the link with value 'ProgressiveValue' on the grid

    # Step 3 & 4 - Go on field examples tab and observe the 'Checkbox' checkbox
    And the user clicks on 'Side Panel Tab' with value 'Field Examples'

    # Expected result - Checkbox is visible for the user 
    Then the user validates that the 'Checkbox' with value 'Checkbox' is displayed
    And the user validates that the 'Checkbox' with value 'Checkbox' is disabled

    # Step 5 - Click on Edit button 
    When the user clicks on 'Button' with value 'Edit'

    # Expected result - 'Checkbox' checkbox is enabled and available for the user 
    Then the user validates that the 'Checkbox By Label' with value 'Checkbox' is enabled
    And the user validates that 'Checkbox' with value 'Checkbox' is marked as: 'false'

    # Step 6 - Check the 'Checkbox' checkbox 
    When the user clicks on 'Checkbox' with value 'Checkbox'
    Then the user validates that 'Checkbox' with value 'Checkbox' is marked as: 'true'

    # Step 7 - Uncheck the 'Checkbox' checkbox 
    When the user clicks on 'Checkbox' with value 'Checkbox'
    Then the user validates that 'Checkbox' with value 'Checkbox' is marked as: 'false'