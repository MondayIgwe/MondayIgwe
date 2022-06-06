﻿Feature: TestCase_223528
	Validates the 'Entity Selector' field functionality

@BDD_223528 @FRM_Nightly
Scenario: FRM_REFDOC_ENTITYSELECTOR_001

    # Step 1 - View any document in read-only 
    Given the user navigates to the 'Reference Docs' page
    When the user creates a Reference doc 'Today' 'Today' 'Test223528' 'voice1' 'Today' 'Test223528'
    When the user filters the column by column name 'Progressive', 'Like', 'ProgressiveValue'
    And the user opens the grid item in row '1'

    # Step 2 - In the 'Summary' side panel tab, go to 'Transactional Data' tab
    And the user clicks on 'Horizontal Panel Tab' with value 'Transactional Data'

    # Expected result - The 'User creator' field is disabled
    Then the user validates that the 'Input By Label Name' with value 'User creator' is disabled

    # Step 3 - Click on the 'Edit' button and open the selector popup
    When the user clicks on 'Button' with value 'Edit'
    And the user clicks on 'Generic Drop Down Trigger' with value 'User creator'
    And the user filters the column by column name 'User Name', 'Like', 'ADINA MOBILE'
    And the user clicks on 'ADINA MOBILE' text on the grid
    And the user clicks on 'Popup Button' with value 'OK'

    # Expected result - The 'User creator' textfield is filled with 'ADINA MOBILE'
    Then the user validates that 'Input By Label Name' with value 'User creator' has text 'ADINA MOBILE'

    # Step 4 - open the selector popup and select 'ALEXANDER GRANDI'
    When the user clicks on 'Generic Drop Down Trigger' with value 'User creator'
    And the user filters the column by column name 'User Name', 'Like', 'ALEXANDER GRANDI'
    And the user clicks on 'ALEXANDER GRANDI' text on the grid
    And the user clicks on 'Popup Button' with value 'OK'

    # Expected result - The 'User creator' textfield is filled with 'ALEXANDER GRANDI'
    Then the user validates that 'Input By Label Name' with value 'User creator' has text 'ALEXANDER GRANDI'


   # Step 5 - Click on the three dots available on entity selector
   When the user clicks on 'Trigger By Field Name' with value 'User creator'

   # Expected  result - 
   Then the user validates that 'Home Toolbar Label' text contains 'ALEXANDER GRANDI'