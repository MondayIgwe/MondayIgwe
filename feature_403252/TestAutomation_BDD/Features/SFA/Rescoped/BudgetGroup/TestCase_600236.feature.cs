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
    [NUnit.Framework.DescriptionAttribute("TestCase_600236")]
    public partial class TestCase_600236Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_600236.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/Rescoped/BudgetGroup", "TestCase_600236", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_SF_BUDGET_001_CREATE_DISCOUNTS_BUDGET")]
        [NUnit.Framework.CategoryAttribute("BDD_600236")]
        [NUnit.Framework.CategoryAttribute("SFA_Nightly")]
        [NUnit.Framework.TestCaseAttribute("Discounts", "WEB_SFA_SF_BUDGET_001_CODE", "Sales rep", "0.00", "Euro", "WEB_SFA_SF_BUDGET_001", "US Dollar", "AANASTASIEI", null)]
        public virtual void WEB_SFA_SF_BUDGET_001_CREATE_DISCOUNTS_BUDGET(string typologyDValue, string bdgGroupCode, string owner, string numericValue, string uM, string bdgGroupDescription, string measureUnitValue, string ownerVal, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_600236",
                    "SFA_Nightly"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("TypologyDValue", typologyDValue);
            argumentsOfScenario.Add("BdgGroupCode", bdgGroupCode);
            argumentsOfScenario.Add("Owner", owner);
            argumentsOfScenario.Add("NumericValue", numericValue);
            argumentsOfScenario.Add("UM", uM);
            argumentsOfScenario.Add("BdgGroupDescription", bdgGroupDescription);
            argumentsOfScenario.Add("MeasureUnitValue", measureUnitValue);
            argumentsOfScenario.Add("OwnerVal", ownerVal);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_SF_BUDGET_001_CREATE_DISCOUNTS_BUDGET", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 6
 testRunner.When("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.Then("the user validates that the page with \'Input By Label Name\' with value \'Code\' is " +
                        "loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 9
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Code\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Typology\' is visibl" +
                        "e", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Owner Level\' is vis" +
                        "ible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Validity period\' is" +
                        " visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Code\' is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Typology\' is enable" +
                        "d", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Owner Level\' is ena" +
                        "bled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Validity period\' is" +
                        " enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Code\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Typology\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Owner Level\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Validity period\' is visi" +
                        "ble", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Typology\' has text \'Fre" +
                        "e goods\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Owner Level\' has text \'" +
                        "Sales rep\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user validates that \'Period Input By Label Name\' with value one \'Validity per" +
                        "iod\' and value two \'start\' has date text \'d/m/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user validates that \'Period Input By Label Name\' with value one \'Validity per" +
                        "iod\' and value two \'end\' has date text \'01/01/2100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.When("the user clicks on \'Generate Button\' with value \'Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Typology\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Typology\'", typologyDValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Code\'", bdgGroupCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("the user selects validity period \'d-1/m/y\' \'01/01/2100\' on the \'Generic Drop Down" +
                        " Trigger\' with value \'Validity period\' without validation", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.Then("the user validates that \'Period Input By Label Name\' with value one \'Validity per" +
                        "iod\' and value two \'start\' has date text \'d/m/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.When("the user selects validity period \'d+1/m/y\' \'01/01/2100\' on the \'Generic Drop Down" +
                        " Trigger\' with value \'Validity period\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then("the user validates that the page with \'Input By Label Name\' with value \'Descripti" +
                        "on\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Description\' is vis" +
                        "ible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Code\' contains text \'{0" +
                            "}\'", bdgGroupCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Typology\' contains text" +
                            " \'{0}\'", typologyDValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Owner level\' contains t" +
                            "ext \'{0}\'", owner), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Total initial value\' co" +
                            "ntains text \'{0}\'", numericValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Total Balance\' contains" +
                            " text \'{0}\'", numericValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Description\' is ena" +
                        "bled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Description\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user validates that \'Period Input By Label Name\' with value one \'Validity per" +
                        "iod\' and value two \'start\' has date text \'d+1/m/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user validates that \'Period Input By Label Name\' with value one \'Validity per" +
                        "iod\' and value two \'end\' has date text \'01/01/2100\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Validity period\' is" +
                        " enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("the user validates that the \'Mandatory Icon\' with value \'Validity period\' is visi" +
                        "ble", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Measure unit\' has text " +
                            "\'{0}\'", uM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Measure unit\' is en" +
                        "abled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Measure unit\' is vi" +
                        "sible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Budget measure\' is " +
                        "not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Event Typology\' is " +
                        "not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Positive movement %" +
                        "\' is not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Mandatory for order T" +
                        "aken\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("the user validates that the checkbox container \'Checkbox By Label\' with value \'Ma" +
                        "ndatory for order Taken\' is set to the state: \'OFF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Allow negative\' is vi" +
                        "sible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("the user validates that the checkbox container \'Checkbox By Label\' with value \'Al" +
                        "low negative\' is set to the state: \'OFF\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Usable by subordinate" +
                        "s\' is not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Block order if used b" +
                        "y subordinates\' is not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.When("the user clicks on \'Input By Label Name\' with value \'Description\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Description\'", bdgGroupDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Measure unit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Measure unit\'", measureUnitValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.Then(string.Format("the user is on the \'{0} | {1}\' page", bdgGroupCode, bdgGroupDescription), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Owners\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.And("the user clicks on \'Grid CheckBox\' with value \'AANASTASIEI\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General Info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Measure unit\' is en" +
                        "abled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 96
 testRunner.When("the user clicks on \'Button\' with value \'Save\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Description\' is ena" +
                        "bled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Validity period\' is" +
                        " enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Usable by subordinate" +
                        "s\' is not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("the user validates that the \'Checkbox By Label\' with value \'Block order if used b" +
                        "y subordinates\' is not shown", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Measure unit\' is di" +
                        "sabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And("the user closes all pages without saving the work done where there is no pop up", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.When("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Code\'", bdgGroupCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Typology\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Typology\'", typologyDValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.Then("the user validates that the \'Main Toolbar Error Message Field\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.When("the user clicks on \'Popup Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 120
 testRunner.Then("the user is on the \'Budget Group\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
