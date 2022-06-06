﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Kantar_BDD.Features.TPM.FundsAndRules.Archive
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_335200")]
    public partial class TestCase_335200Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_335200.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/FundsAndRules/Archive", "TestCase_335200", "\tViews a specific fund and Rule,\r\n\tAdds movements and validates the added movemen" +
                    "ts,\r\n\tThen closes and reopens the new fund to validate that the added data is st" +
                    "ill present.", ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Test Case : 335200")]
        [NUnit.Framework.TestCaseAttribute("21", "DTEMOVEMENT;CODMOVEMENTTYPE;DESREASON;IDACTIONNUM;MOVEMENTVALUE;TRANSFER_IDCHECKS" +
            "ET;TRANSFER_IDCONSTRAINT", "Deposit", "100", "TEST", "Withdrawal", "200", "Reservation", "100", "Deposit Reservation", "100", null)]
        public virtual void TestCase335200(string fund_1, string movementPanelHeading, string depositName, string depositValue, string reason, string withdrawalName, string withdrawalValue, string reserveName, string reserveValue, string depReserveName, string depReserveValue, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Fund_1", fund_1);
            argumentsOfScenario.Add("MovementPanelHeading", movementPanelHeading);
            argumentsOfScenario.Add("DepositName", depositName);
            argumentsOfScenario.Add("DepositValue", depositValue);
            argumentsOfScenario.Add("Reason", reason);
            argumentsOfScenario.Add("WithdrawalName", withdrawalName);
            argumentsOfScenario.Add("WithdrawalValue", withdrawalValue);
            argumentsOfScenario.Add("ReserveName", reserveName);
            argumentsOfScenario.Add("ReserveValue", reserveValue);
            argumentsOfScenario.Add("DepReserveName", depReserveName);
            argumentsOfScenario.Add("DepReserveValue", depReserveValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Test Case : 335200", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 8
 testRunner.Given("the user is on the \'Funds & Rules\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("the user clicks on the \'Funds & Rules code\' column link value \'{0}\' on the grid", fund_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And("the user clicks the edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on the \'Constraints Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then("the user is on the \'Constraints Tab Container\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.And("the user clicks on the \'Movement panel folder\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user validates that \'Remaining Balance Textfield\' is read-only", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user validates that \'Uncommitted Balance Textfield\' is read-only", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user validates that \'Fund Reserve Textfield\' is read-only", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("the user validates the \'Movements Grid Headings\' grid headings \'{0}\'", movementPanelHeading), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When(string.Format("the user creates a New Movement \'{0}\' \'{1}\' \'{2}\'", depositName, depositValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
 testRunner.Then("\'Remaining Balance Textfield\' is populated with \'1100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.And("\'Uncommitted Balance Textfield\' is populated with \'1100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("\'Fund Reserve Textfield\' is populated with \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("the user validates the movement is added \'{0}\' \'{1}\' \'{2}\'", depositName, depositValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.When(string.Format("the user creates a New Movement \'{0}\' \'{1}\' \'{2}\'", withdrawalName, withdrawalValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.Then("\'Remaining Balance Textfield\' is populated with \'900\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("\'Uncommitted Balance Textfield\' is populated with \'900\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("\'Fund Reserve Textfield\' is populated with \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And(string.Format("the user validates the movement is added \'{0}\' \'{1}\' \'{2}\'", withdrawalName, withdrawalValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.When(string.Format("the user creates a New Movement \'{0}\' \'{1}\' \'{2}\'", reserveName, reserveValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
 testRunner.Then("\'Remaining Balance Textfield\' is populated with \'900\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.And("\'Uncommitted Balance Textfield\' is populated with \'900\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("\'Fund Reserve Textfield\' is populated with \'100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user validates the movement is added \'{0}\' \'{1}\' \'{2}\'", reserveName, reserveValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.When(string.Format("the user creates a New Movement \'{0}\' \'{1}\' \'{2}\'", depReserveName, depReserveValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.Then("\'Remaining Balance Textfield\' is populated with \'1000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.And("\'Uncommitted Balance Textfield\' is populated with \'1000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("\'Fund Reserve Textfield\' is populated with \'0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And(string.Format("the user validates the movement is added \'{0}\' \'{1}\' \'{2}\'", depReserveName, depReserveValue, reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.When("the user gets the number of rows from \'Movements Popup Rows\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("the user clicks on the \'Movements Popup OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.Then("the user validates \'Movements Popup Close Button\' is not visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.When("the user clicks on the \'Movement panel folder\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.Then("the user validates the number of rows from \'Movements Popup Rows\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("the user clicks on the \'Movements Popup OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 64
 testRunner.And("the user clicks \'Save\' and \'Close\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.When(string.Format("the user clicks on the link value \'{0}\' on the grid", fund_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.And("the user clicks the edit button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 70
 testRunner.And("the user clicks on the \'Constraints Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.Then("the user is on the \'Constraints Tab Container\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 73
 testRunner.And("the user clicks on the \'Movement panel folder\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.Then("the user validates the number of rows from \'Movements Popup Rows\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 77
 testRunner.Then("the user clicks on the \'Movements Popup Close Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.Then("the user clicks on \'Close\' button on the toolbar", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
