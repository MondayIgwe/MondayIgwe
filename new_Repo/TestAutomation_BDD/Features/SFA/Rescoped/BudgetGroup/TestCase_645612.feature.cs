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
namespace Kantar_BDD.Features.SFA.Rescoped.BudgetGroup
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_645612")]
    public partial class TestCase_645612Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_645612.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/Rescoped/BudgetGroup", "TestCase_645612", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_SF_BUDGET_039_BALANCE_ADJUSTMENT_POPUP_CONFIRMATION")]
        [NUnit.Framework.CategoryAttribute("SFA_Nightly")]
        [NUnit.Framework.CategoryAttribute("BDD_645612")]
        [NUnit.Framework.TestCaseAttribute("Discounts", "Sales rep", "PACKS", "WEB_SFA_SF_BUDGET_039", "AANASTASIEI", "AANASTASIEI1", "ACAR", "100.00", "150.00", "200.00", "Adjustment successful in 3/3 budget details", "Balance Adjustment", "0.00", "-50.00", "-100.00", "All new budget balance will be 0", "", null)]
        public virtual void WEB_SFA_SF_BUDGET_039_BALANCE_ADJUSTMENT_POPUP_CONFIRMATION(
                    string typologyValue, 
                    string ownerLevelValue, 
                    string measureUnitValue, 
                    string bdgGroupDescription, 
                    string ownerCode, 
                    string ownerCode2, 
                    string ownerCode3, 
                    string defInitialValue, 
                    string defInitialValue2, 
                    string defInitialValue3, 
                    string messageOK, 
                    string aDJUSTMENT, 
                    string movement, 
                    string movement2, 
                    string movement3, 
                    string wARN_MSG, 
                    string documentKey, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SFA_Nightly",
                    "BDD_645612"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("TypologyValue", typologyValue);
            argumentsOfScenario.Add("OwnerLevelValue", ownerLevelValue);
            argumentsOfScenario.Add("MeasureUnitValue", measureUnitValue);
            argumentsOfScenario.Add("BdgGroupDescription", bdgGroupDescription);
            argumentsOfScenario.Add("OwnerCode", ownerCode);
            argumentsOfScenario.Add("OwnerCode2", ownerCode2);
            argumentsOfScenario.Add("OwnerCode3", ownerCode3);
            argumentsOfScenario.Add("DefInitialValue", defInitialValue);
            argumentsOfScenario.Add("DefInitialValue2", defInitialValue2);
            argumentsOfScenario.Add("DefInitialValue3", defInitialValue3);
            argumentsOfScenario.Add("MessageOK", messageOK);
            argumentsOfScenario.Add("ADJUSTMENT", aDJUSTMENT);
            argumentsOfScenario.Add("Movement", movement);
            argumentsOfScenario.Add("Movement2", movement2);
            argumentsOfScenario.Add("Movement3", movement3);
            argumentsOfScenario.Add("WARN_MSG", wARN_MSG);
            argumentsOfScenario.Add("DocumentKey", documentKey);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_SF_BUDGET_039_BALANCE_ADJUSTMENT_POPUP_CONFIRMATION", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 4
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
#line 5
 testRunner.Given("the user navigates to the \'Budget Group\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When(string.Format("the user removes all items by column \'Budget Group Description\' \'Like\' \'{0}\'", bdgGroupDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And(string.Format("the user adds a new budget group where Budget Group Code is retrieved, Topology: " +
                            "\'{0}\', Owner Level: \'<OwnerLevel>\',Description: \'{1}\', Measure Unit: \'<MeasureUn" +
                            "it>\'", typologyValue, bdgGroupDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Code\' and " +
                        "saves it as \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Owners\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", ownerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", ownerCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", ownerCode3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.When(string.Format("the user clicks and enters \'{0}\' into the \'Initial Value\' column in the Owners Ta" +
                            "b in row numbwr \'1\'", defInitialValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.When(string.Format("the user clicks and enters \'{0}\' into the \'Initial Value\' column in the Owners Ta" +
                            "b in row numbwr \'2\'", defInitialValue2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.When(string.Format("the user clicks and enters \'{0}\' into the \'Initial Value\' column in the Owners Ta" +
                            "b in row numbwr \'3\'", defInitialValue3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("the user changes the status to \'Validate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Current status\' has tex" +
                        "t \'Valid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.And("the user navigates to the \'Budget Detail\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("the user filters the column by column name \'Description\', \'Like\', \'{0}\'", bdgGroupDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user clicks on the \'Grid All Checkbox\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user clicks on \'Button\' with value \'Adjust balance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.Then(string.Format("the user validates that popup \'Budget Adjustment\' column \'Current Balance\' has \'{" +
                            "0}\' with row text \'{1}\'", defInitialValue, ownerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.And(string.Format("the user validates that popup \'Budget Adjustment\' column \'Current Balance\' has \'{" +
                            "0}\' with row text \'{1}\'", defInitialValue2, ownerCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user validates that popup \'Budget Adjustment\' column \'Current Balance\' has \'{" +
                            "0}\' with row text \'{1}\'", defInitialValue3, ownerCode3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("the user clicks on \'Popup Cancel Button\' with value \'Budget Adjustment\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("the user clicks on \'Button\' with value \'Adjust balance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'New Balance\'", defInitialValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Budget Adjustment\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then("the user validates that the \'Success Toast Message\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Initial Value\' column in the row number \'1\'", defInitialValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Initial Value\' column in the row number \'2\'", defInitialValue2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Initial Value\' column in the row number \'3\'", defInitialValue3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.When("the user clicks on the \'Grid All Checkbox\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And("the user clicks on \'Button\' with value \'Links\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user clicks on \'Menu Item Text\' with value \'Budget Movements\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Type\' column in the row number \'1\'", aDJUSTMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Type\' column in the row number \'2\'", aDJUSTMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Type\' column in the row number \'3\'", aDJUSTMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the date value \'" +
                        "d/m/y\' in the \'Operation Date\' column in the row number \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the date value \'" +
                        "d/m/y\' in the \'Operation Date\' column in the row number \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the date value \'" +
                        "d/m/y\' in the \'Operation Date\' column in the row number \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Dockey\' column in the row number \'1\'", documentKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Dockey\' column in the row number \'2\'", documentKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Dockey\' column in the row number \'3\'", documentKey), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the username cur" +
                        "rently logged in in the \'Made By\' column in the row number \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the username cur" +
                        "rently logged in in the \'Made By\' column in the row number \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("the user validates that the \'Basic Multigrid\' multigrid contains the username cur" +
                        "rently logged in in the \'Made By\' column in the row number \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.Then(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Value\' column in the row number \'1\'", movement), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Value\' column in the row number \'2\'", movement2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("the user validates that the \'Basic Multigrid\' multigrid has the value \'{0}\' in th" +
                            "e \'Operation Value\' column in the row number \'3\'", movement3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
