﻿Feature: TestCase_660177

@BDD_TC660177 @PLAN_Weekly @PLAN @Regression  @PLAN_Regression
Scenario: WEB_TPM_IBP_PROCESS_CALENDAR_004-Process from Draft to Confirm to Cancelled Visible
	# Step 1 - Open IBP Process Management navigator
	Given the user navigates to the 'IBP Process Management' page

	# Step 2 - Click on the "+" button
	When the user clicks on the 'Add Button'

	# Step 3 - Select @PROCESS_CODE, @REF_YEAR, @START_VALIDITY, @END_VALIDITY fields, @STATUS
	Then the user validates that the 'Popup' with value 'New Process' is displayed
	When the user clicks on 'Generic Drop Down Trigger' with value 'Process Code'
	And the user select value containing '<PROCESS_CODE>' from dropdown list 'Generic Drop Down Trigger'
	And the user clicks on 'Generic Drop Down Trigger' with value 'Reference Year'
	And the user select value containing '<REF_YEAR>' from dropdown list 'Generic Drop Down Trigger'
	And the user clicks on 'Popup Ok Button' with value 'New Process'
	And the user enters '<START_VALIDITY>' in field 'Input By Label Name' with value 'Start Validity'
	And the user enters '<END_VALIDITY>' in field 'Input By Label Name' with value 'End Validity'
	And the user clicks on 'Generic Drop Down Trigger' with value 'Status'
	And the user select value containing '<STATUS>' from dropdown list 'Generic Drop Down Trigger'

	# Step 4 - Save the process and Close the document
	And the user closes all pages without saving the work done

	# Step 5 - Open IBP Calendar Navigator
	And the user navigates to the 'IBP Calendar' page

	# Step 6 - Click on the "+" button
	And the user clicks on the 'Add Button'
	
	# Step 7 - Fill @Description, Select @ProcessID, select @Type, Press on the "OK" button
	Then the user validates that the 'Popup' with value 'New Planning Calendar' is displayed
	When the user enters '<DESCRIPTION>' in field 'Input By Label Name' with value 'Description'
	And  the user clicks on 'Generic Drop Down Trigger' with value 'Process ID'
	And the user select value containing '<ProcessID>' from dropdown list 'Generic Drop Down Trigger'
	And  the user clicks on 'Generic Drop Down Trigger' with value 'Type'
	And the user select value containing '<Type>' from dropdown list 'Generic Drop Down Trigger'
	And the user clicks on 'Popup Ok Button' with value 'New Planning Calendar'

	# Step 8 - In details section, press "+" button
	And the user clicks on 'Button Acton link' with value containing 'add'

	#Step 9 - In the row added, select @Activity,  @Frequency
	And the user filters the column by column name 'Activity', Filter Type 'Like', Value '<Activity>'
	And the user filters the column by column name 'Frequency', Filter Type 'Like', Value '<Frequency>'

	# Step 10 - Save the document and Close the document
	And the user closes all pages without saving the work done

	# Step 11 - Open the Process from preconditions, @PROCESS_CODE, @REF_YEAR, @START_VALIDITY, @END_VALIDITY, @STATUS
	And the user navigates to the 'IBP Process Management' page

	# Step 12 - Click on the "+" button
	And the user clicks on the 'Add Button'
	Then the user validates that the 'Popup' with value 'New Process' is displayed
	When the user clicks on 'Generic Drop Down Trigger' with value 'Process Code'
	And the user select value containing '<PROCESS_CODE>' from dropdown list 'Generic Drop Down Trigger'
	And the user clicks on 'Generic Drop Down Trigger' with value 'Reference Year'
	And the user select value containing '<REF_YEAR>' from dropdown list 'Generic Drop Down Trigger'
	And the user clicks on 'Popup Ok Button' with value 'New Process'

	# Step 13 - Select status @STATUS1
	And the user enters '<START_VALIDITY>' in field 'Input By Label Name' with value 'Start Validity'
	And the user enters '<END_VALIDITY>' in field 'Input By Label Name' with value 'End Validity'
	And the user clicks on 'Generic Drop Down Trigger' with value 'Status'
	And the user select value containing '<STATUS1>' from dropdown list 'Generic Drop Down Trigger'
	
	# Step 14 - Press Edit button
	And the user clicks on 'Button' with value 'Edit'

	# Step 15 - Change the status of the Process selecting @STATUS2
	And the user enters '<START_VALIDITY>' in field 'Input By Label Name' with value 'Start Validity'
	And the user enters '<END_VALIDITY>' in field 'Input By Label Name' with value 'End Validity'
	And the user clicks on 'Generic Drop Down Trigger' with value 'Status'
	And the user select value containing '<STATUS2>' from dropdown list 'Generic Drop Down Trigger'

	# Step 16 - Change the status of the Process selecting @STATUS3
	And the user clicks on 'Generic Drop Down Trigger' with value 'Status'
	And the user select value containing '<STATUS3>' from dropdown list 'Generic Drop Down Trigger'

	# Step 17 - Save the process and Close the document
	And the user closes all pages without saving the work done

	# Step 18 - The status of process @PROCESS_CODE, @REF_YEAR, @START_VALIDITY, @END_VALIDITY is @STATUS3
	Then the user validates that column 'Status' contains '<STATUS3>' with row text '<STATUS3>'

	Examples:
	| PROCESS_CODE | REF_YEAR | START_VALIDITY | END_VALIDITY | STATUS | DESCRIPTION | ProcessID | Type    | Activity    | Frequency | STATUS1   | STATUS2   | STATUS3   | STATUS4  | ChildProcess |
	| CBP2         | 2019     | 01/01/2021     | 01/01/2021   | Draft  | Calendar6   | CBP2      | Visible | Data Gather | Run Once  | Confirmed | Confirmed | Cancelled | Canceled | CBP2_2021    |
