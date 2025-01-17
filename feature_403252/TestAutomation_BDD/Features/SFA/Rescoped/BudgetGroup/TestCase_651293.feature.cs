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
    [NUnit.Framework.DescriptionAttribute("TestCase_651293")]
    public partial class TestCase_651293Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_651293.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/Rescoped/BudgetGroup", "TestCase_651293", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_SF_BUDGET_018_BUDGET_WORKFLOW")]
        [NUnit.Framework.CategoryAttribute("SFA_Nightly")]
        [NUnit.Framework.CategoryAttribute("BDD_651293")]
        [NUnit.Framework.TestCaseAttribute("Free goods", "Sales rep", "BDG_018_1", "PACKS", "1000", "BDG_018_2", "No available transitions", "Status Desc.", "Workflow Status", "Budget Detail", "Status Code", "AANASTASIEI", null)]
        public virtual void WEB_SFA_SF_BUDGET_018_BUDGET_WORKFLOW(string typologyValue, string ownerLevelValue, string bdgDescription1, string measureUnitValue, string defaultInitailValue, string bdgDescription2, string mSG, string statusDescField, string wkfStatusField, string linkBudgetDetail, string statusCodeField, string ownerCode, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "SFA_Nightly",
                    "BDD_651293"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("TypologyValue", typologyValue);
            argumentsOfScenario.Add("OwnerLevelValue", ownerLevelValue);
            argumentsOfScenario.Add("BdgDescription1", bdgDescription1);
            argumentsOfScenario.Add("MeasureUnitValue", measureUnitValue);
            argumentsOfScenario.Add("DefaultInitailValue", defaultInitailValue);
            argumentsOfScenario.Add("BdgDescription2", bdgDescription2);
            argumentsOfScenario.Add("MSG", mSG);
            argumentsOfScenario.Add("StatusDescField", statusDescField);
            argumentsOfScenario.Add("WkfStatusField", wkfStatusField);
            argumentsOfScenario.Add("LinkBudgetDetail", linkBudgetDetail);
            argumentsOfScenario.Add("StatusCodeField", statusCodeField);
            argumentsOfScenario.Add("OwnerCode", ownerCode);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_SF_BUDGET_018_BUDGET_WORKFLOW", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 6
 testRunner.Given("the user navigates to the \'Budget Group\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When(string.Format("the user adds a new budget group where Budget Group Code is retrieved, Topology: " +
                            "\'{0}\', Owner Level: \'{1}\',Description: \'{2}\', Measure Unit: \'{3}\'", typologyValue, ownerLevelValue, bdgDescription1, measureUnitValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Code\' and " +
                        "saves it as \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.Then("the user validates that the \'Loading Mask\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Owners\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And("the user enters \'<DefaultInitialValue>\' in field \'Input By Label Name\' with value" +
                        " \'Default initial value - PACKS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", ownerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("the user validates \'Top Panel Status\' is not displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Current status\' has tex" +
                        "t \'Draft\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.When("the user changes the status to \'Validate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Current status\' has tex" +
                        "t \'Valid\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Top Tab\' with value \'History\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then("the user validates that the \'Text In Table Cell\' with value \'Draft\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Valid\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.When("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user filters the column by column name \'Code\', \'Like\', \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then(string.Format("the user validates that column \'Workflow Status\' has \'Valid\' with row text \'{0}\'", bdgDescription1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.When("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When("the user changes the status to \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("the user clicks on \'Top Tab\' with value \'History\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("the user validates that the \'Text In Table Cell\' with value \'Draft\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Valid\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Cancelled\' is presen" +
                        "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.When("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user filters the column by column name \'Code\', \'Like\', \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.Then(string.Format("the user validates that column \'Workflow Status\' has \'Cancelled\' with row text \'{" +
                            "0}\'", bdgDescription1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When(string.Format("the user adds a new budget group where Budget Group Code is retrieved, Topology: " +
                            "\'{0}\', Owner Level: \'{1}\',Description: \'{2}\', Measure Unit: \'{3}\'", typologyValue, ownerLevelValue, bdgDescription2, measureUnitValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Code\' and " +
                        "saves it as \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Owners\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user enters \'<DefaultInitialValue>\' in field \'Input By Label Name\' with value" +
                        " \'Default initial value - PACKS\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", ownerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.When("the user changes the status to \'Validate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 54
 testRunner.And("the user changes the status to \'Suspend\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user clicks on \'Top Tab\' with value \'History\' until \'Text In Table Cell\' with" +
                        " value \'Draft\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then("the user validates that the \'Text In Table Cell\' with value \'Draft\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Valid\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user validates that the count for \'Text In Table Cell\' with value \'Draft\' is " +
                        "\'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.When("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 61
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("the user filters the column by column name \'Code\', \'Like\', \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then(string.Format("the user validates that column \'Workflow Status\' has \'Draft\' with row text \'{0}\'", bdgDescription2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.When("the user changes the status to \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.And("the user clicks on \'Top Tab\' with value \'History\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then("the user validates that the \'Text In Table Cell\' with value \'Draft\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Valid\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user validates that the \'Text In Table Cell\' with value \'Cancelled\' is presen" +
                        "t", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("the user validates that the count for \'Text In Table Cell\' with value \'Draft\' is " +
                        "\'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Note / Attachments\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("the user validates that the \'Sub Tab Add Button Span\' with value \'Notes\' is disab" +
                        "led", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Owners\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("the user validates that the \'Button\' with value \'Import\' is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'General Info\' until \'Input By Lab" +
                        "el Name\' with value \'Description\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 83
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Description\' is dis" +
                        "abled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.And("the user validates that the \'Section Add Button by sm1 id\' with value \'Rules\' is " +
                        "disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("the user clicks on \'Generic Drop Down Trigger\' with value \'Current status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.Then(string.Format("the user validates that the \'Text\' with value \'{0}\' is present", mSG), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.When("the user clicks on \'Popup Cancel Button\' with value \'Change Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.And("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("the user opens the Grid Settings Menu option: \'Columns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.Then(string.Format("the user validates that the \'Text In Table Cell\' with value \'{0}\' is not present", statusDescField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
 testRunner.And(string.Format("the user validates that the \'Text In Table Cell\' with value \'{0}\' is present", wkfStatusField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.When("the user clicks on \'Popup Cancel Button\' with value \'Columns Settings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.And("the user filters the column by column name \'Code\', \'Like\', \'BudgetCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", bdgDescription2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And("the user clicks on \'Button\' with value \'Links\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("the user clicks on \'Menu Item Text\' with value \'Budget Detail\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("the user opens the Grid Settings Menu option: \'Columns\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.Then(string.Format("the user validates that the \'Text In Table Cell\' with value \'{0}\' is not present", statusDescField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 104
 testRunner.And(string.Format("the user validates that the \'Text In Table Cell\' with value \'{0}\' is not present", statusCodeField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And(string.Format("the user validates that the \'Text In Table Cell\' with value \'{0}\' is present", wkfStatusField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.When("the user clicks on \'Popup Cancel Button\' with value \'Columns Settings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 107
 testRunner.Then(string.Format("the user validates that the \'Column Heading\' with value \'{0}\' is not displayed", wkfStatusField), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.When("the user makes all coumns visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 110
 testRunner.Then(string.Format("the user validates that column \'Workflow Status\' has \'Cancelled\' with row text \'{" +
                            "0}\'", bdgDescription2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
