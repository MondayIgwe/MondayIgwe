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
namespace Kantar_BDD.Features.SFA.Rescoped.AdvancedPricingActions
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_481638")]
    public partial class TestCase_481638Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_481638.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/Rescoped/AdvancedPricingActions", "TestCase_481638", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_SF_CNVACT_058_Can_Edit_a_Benefit_node_in_canvass_action")]
        [NUnit.Framework.CategoryAttribute("SFA_Nightly")]
        [NUnit.Framework.CategoryAttribute("BDD_481638")]
        public virtual void WEB_SFA_SF_CNVACT_058_Can_Edit_A_Benefit_Node_In_Canvass_Action()
        {
            string[] tagsOfScenario = new string[] {
                    "SFA_Nightly",
                    "BDD_481638"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_SF_CNVACT_058_Can_Edit_a_Benefit_node_in_canvass_action", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'Advanced Pricing Actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.When("the user adds a new Advanced Pricing Action with Advanced Pricing Book: \'29 - JHN" +
                        "\', Application Type: \'Semiautomatic\', Valorization Type: \'Amount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And("the user populates the \'General info\' tab where \'Description\' input field: \'Canva" +
                        "ss for WEB_SFA_SF_CNVACT_058\', \'Valorization Attribute\' input field: \'Net Amount" +
                        "\', \'Measure Unit\' input field: \'Euro\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Customers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Top Tab\' with value \'Customer Attributes\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the user clicks on \'Top Tab\' with value \'Inclusion Rules (0)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user selects from the \'Customer Category\' drop down grid menu the \'B2B\' optio" +
                        "n", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Benefits\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user clicks on \'Top Tab\' with value \'Benefit brackets\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user clicks on \'Button Link\' with value \'Threshold\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Input By Partial Label Name\' with value \'Net Amount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("the user enters the characters \'15000.00\' in field \'Input By Partial Label Name\' " +
                        "with value \'Net Amount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user clicks on the hierarchical node with the value \'Thresholds - Net Amount " +
                        "15000 Euro\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on \'Button Link\' with value \'Benefit Group\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Description\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user enters \'Benefit group for WEB_SFA_SF_CNVACT_057\' in field \'Input By Labe" +
                        "l Name\' with value \'Description\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user clicks on the hierarchical node with the value \'Thresholds - Net Amount " +
                        "15000 Euro\' -> \'Group Benefit group for WEB_SFA_SF_CNVACT_057 - Cost 15000 - Max" +
                        " Number of Times 0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user clicks on \'Button Link\' with value \'Benefit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user enters \'3 - % Discount on Order Row\' in field \'Input By Label Name\' with" +
                        " value \'Benefit type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user enters the characters \'10.00\' in field \'Input By Label Name\' with value " +
                        "\'Benefit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user enters \'Rule-based pricing Mkt Disc.\' in field \'Input By Label Name\' wit" +
                        "h value \'Benefit reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.When("the user filters the column by column name \'Code\', \'Like\', \'AdvancedPricingAction" +
                        "Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.And("the user opens the grid item in row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Benefits\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.And("the user clicks on the hierarchical node with the value \'Thresholds - Net Amount " +
                        "15000 Euro\' -> \'Group Benefit group for WEB_SFA_SF_CNVACT_057 - Cost 15000 - Max" +
                        " Number of Times 0\' -> \'% Discount on Order Row - 10% \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user clicks on the \'Edit Button Link\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Benefit type\' has text " +
                        "\'3 - % Discount on Order Row\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Benefit\' has text \'10.0" +
                        "0\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Max. Value\' has text \'1" +
                        "0.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("the user validates that \'Input By Label Name\' with value \'1° Alarm Max discount\' " +
                        "has text \'10.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Benefit reason\' has tex" +
                        "t \'Rule-based pricing Mkt Disc.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Benefit sub-reason\' has" +
                        " text \'Quantity Disc. on specialized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.When("the user clicks on \'Input By Label Name\' with value \'Benefit type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 76
 testRunner.And("the user enters \'5 - Amount discount on Order Row\' in field \'Input By Label Name\'" +
                        " with value \'Benefit type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And("the user enters \'1.00\' in field \'Input By Label Name\' with value \'Benefit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit Um.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And("the user enters \'EUR - Euro\' in field \'Input By Label Name\' with value \'Benefit U" +
                        "m.\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("the user enters \'Contractual Discount\' in field \'Input By Label Name\' with value " +
                        "\'Benefit reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'Benefit sub-reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And("the user enters \'Base discount\' in field \'Input By Label Name\' with value \'Benefi" +
                        "t sub-reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("the user clicks on the hierarchical node with the value \'Thresholds - Net Amount " +
                        "15000 Euro\' -> \'Group Benefit group for WEB_SFA_SF_CNVACT_057 - Cost 15000 - Max" +
                        " Number of Times 0\' -> \'Amount discount on Order Row - 1 Euro \'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("the user clicks on the \'Edit Button Link\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Benefit Um.\' has text \'" +
                        "EUR - Euro\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.When("the user clicks on \'Popup Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 103
 testRunner.Then("the user validates that the hierarchical node with value \'Thresholds - Net Amount" +
                        " 15000 Euro\' -> \'Group Benefit group for WEB_SFA_SF_CNVACT_057 - Cost 15000 - Ma" +
                        "x Number of Times 0\' -> \'Amount discount on Order Row - 1 Euro \' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 104
 testRunner.And("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
