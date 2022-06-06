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
namespace Kantar_BDD.Features.SA.NightlyRunsRecoped
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase454642")]
    public partial class TestCase454642Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase454642.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase454642", "\tWEB_SA_BALANCE_MATCHED CLAIMS_BALANCE_002 - Create a balance for generic promo r" +
                    "ows with different customer", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SA_BALANCE_MATCHED CLAIMS_BALANCE_002")]
        [NUnit.Framework.CategoryAttribute("TTC_Nightly")]
        [NUnit.Framework.CategoryAttribute("TTC")]
        [NUnit.Framework.CategoryAttribute("BDD_454642")]
        [NUnit.Framework.TestCaseAttribute("EC91600", "Level 1", "Promo_1_balance", "060", "Leaflet", "200.00", "Confirmed", "Product", "EC86279", "Promo_2_balance", "061", "Display", "300.00", "400", "finalization", "LF", "DP", "Positive", "Negative", "d-3/m/y", "d+4/m/y", "Level 2", null)]
        public virtual void WEB_SA_BALANCE_MATCHEDCLAIMS_BALANCE_002(
                    string customer, 
                    string customerLevel, 
                    string description1, 
                    string product, 
                    string mechanic, 
                    string measure, 
                    string status, 
                    string prodLevel, 
                    string customerB, 
                    string description2, 
                    string productB, 
                    string mechanicB, 
                    string measureB, 
                    string amount, 
                    string finalizationPopup, 
                    string mechanicCode1, 
                    string mechanicCode2, 
                    string positiveType, 
                    string negativeType, 
                    string sellInStart, 
                    string sellInEnd, 
                    string customerLevel2, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TTC_Nightly",
                    "TTC",
                    "BDD_454642"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("customer", customer);
            argumentsOfScenario.Add("CustomerLevel", customerLevel);
            argumentsOfScenario.Add("description1", description1);
            argumentsOfScenario.Add("product", product);
            argumentsOfScenario.Add("mechanic", mechanic);
            argumentsOfScenario.Add("measure", measure);
            argumentsOfScenario.Add("status", status);
            argumentsOfScenario.Add("prodLevel", prodLevel);
            argumentsOfScenario.Add("customerB", customerB);
            argumentsOfScenario.Add("description2", description2);
            argumentsOfScenario.Add("productB", productB);
            argumentsOfScenario.Add("mechanicB", mechanicB);
            argumentsOfScenario.Add("measureB", measureB);
            argumentsOfScenario.Add("amount", amount);
            argumentsOfScenario.Add("FinalizationPopup", finalizationPopup);
            argumentsOfScenario.Add("mechanicCode1", mechanicCode1);
            argumentsOfScenario.Add("mechanicCode2", mechanicCode2);
            argumentsOfScenario.Add("positiveType", positiveType);
            argumentsOfScenario.Add("negativeType", negativeType);
            argumentsOfScenario.Add("SellInStart", sellInStart);
            argumentsOfScenario.Add("SellInEnd", sellInEnd);
            argumentsOfScenario.Add("CustomerLevel2", customerLevel2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SA_BALANCE_MATCHED CLAIMS_BALANCE_002", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 5
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
 testRunner.Given("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", customerLevel, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'\' \'\' \'{3}\'", description1, sellInStart, sellInEnd, mechanic), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user adds products \'{0}\' \'{1}\'", prodLevel, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.And(string.Format("the user enters \'{0}\' on column name \'Leaflet\' for product code \'{1}\'", measure, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on \'Sub Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
    testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
    testRunner.Then("the user validates that the \'Trigger By Field Name\' with value \'Current status\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
    testRunner.When("the user clicks on \'Trigger By Field Name\' with value \'Current status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
    testRunner.And("the user clicks on \'Radio Button\' with value \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Change Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
    testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Current status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
    testRunner.And("the user clicks on \'Radio Button\' with value \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Change Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", customerLevel2, customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'\' \'\' \'{3}\'", description2, sellInStart, sellInEnd, mechanicB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("the user adds products \'{0}\' \'{1}\'", prodLevel, productB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.And(string.Format("the user enters \'{0}\' on column name \'Display\' for product code \'{1}\'", measureB, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on \'Sub Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
    testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Workflow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.Then("the user validates that the \'Trigger By Field Name\' with value \'Current status\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
    testRunner.When("the user clicks on \'Trigger By Field Name\' with value \'Current status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
    testRunner.And("the user clicks on \'Radio Button\' with value \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Change Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
    testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Current status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
    testRunner.And("the user clicks on \'Radio Button\' with value \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Change Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user navigates to the \'Claims\' page under division\'Claims\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user creates a New Claim \'\' \'test case 454642\' \'{0}\' \'{1}\' \'{2}\'", customerLevel2, customerB, amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
    testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Document I" +
                        "D\' and saves it as \'DocumentID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Matchings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Button\' with value \'Match To Generic Amounts\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user clicks on \'Menu Item Text\' with value \'Match To Promo ID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.Then("the user validates that the \'Popup\' with value \'Select Promotions\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 53
 testRunner.And("the user filters the column by column name \'Action Code\', \'Like\', \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on \'Popup Checkbox\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Select Promotions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then("the user validates that the \'Popup\' with value \'Matching finalization\' is display" +
                        "ed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Amount to match\' contai" +
                            "ns text \'{0}\'", amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user clicks on \'Button\' with value \'Assign\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When(string.Format("the user in popup \'Matching finalization\' Clicks cell with column \'Last Claim\' an" +
                            "d row text \'{0}\'", description1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Matching finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_LASTCLAIM\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the user navigates to the \'Matched Claims\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("the user selects opens the filter at column \'Action Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user clicks on \'Filter Option\' with value \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user clicks on \'Filter Option\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Column:Action Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("the user clicks on \'Grid Checkbox\' with value \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user clicks on \'Grid Checkbox\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
    testRunner.And("the user clicks on \'Button\' with value \'Balance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.Then("the user validates that elements \'Basic Grid Rows\' have loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("the user retrieves count of \'Basic Grid Rows\' with value \'\' and saves it as \'RowC" +
                        "ountNew\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then("the user validates that the element \'RowCountNew\' is equal to \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 81
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Balance Percentage\' has \'100\' with row text \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Balance Percentage\' has \'100\' with row text \'300\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Amount to Balance\' has \'-200.00\' with row text \'Actio" +
                        "nCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Payable Amount Description\' has \'{0}\' with row text \'" +
                            "ActionCode\'", description1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Customer code\' has \'{0}\' with row text \'ActionCode\'", customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Aggregate attribute 1 (Promo ID)\' has \'ActionCode\' wi" +
                        "th row text \'200\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Promo Mechanics Code\' has \'{0}\' with row text \'Action" +
                            "Code\'", mechanicCode1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Start Date\' has \'{0}\' with row text \'ActionCode\'", sellInStart), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'End Date\' has \'{0}\' with row text \'ActionCode\'", sellInEnd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Amount to Balance\' has \'100.00\' with row text \'Action" +
                        "Code1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Payable Amount Description\' has \'{0}\' with row text \'" +
                            "ActionCode1\'", description2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Customer code\' has \'{0}\' with row text \'ActionCode1\'", customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                        "ame \'Finalization\' column \'Aggregate attribute 1 (Promo ID)\' has \'ActionCode1\' w" +
                        "ith row text \'300.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Promo Mechanics Code\' has \'{0}\' with row text \'Action" +
                            "Code1\'", mechanicCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'Start Date\' has \'{0}\' with row text \'ActionCode1\'", sellInStart), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALBALANCEFINALIZATIONPOPUP\' and n" +
                            "ame \'Finalization\' column \'End Date\' has \'{0}\' with row text \'ActionCode1\'", sellInEnd), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Total Balance Amount\' c" +
                        "ontains text \'-100.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.Then("the user validates that elements \'Basic Grid Rows\' have loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.When("the user retrieves count of \'Basic Grid Rows\' with value \'\' and saves it as \'RowC" +
                        "ountNew\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.Then("the user validates that the element \'RowCountNew\' is equal to \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 114
 testRunner.And(string.Format("the user validates that column \'Amount\' has \'{0}\' with row text \'ActionCode\'", measure), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("the user validates that column \'Balanced %\' has \'100\' with row text \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And(string.Format("the user validates that column \'Balance type\' contains \'{0}\' with row text \'Actio" +
                            "nCode\'", positiveType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And(string.Format("the user validates that column \'Beneficiary\' has \'{0}\' with row text \'ActionCode\'" +
                            "", customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And(string.Format("the user validates that column \'Promo ID\' has \'ActionCode\' with row text \'{0}\'", measure), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.And(string.Format("the user validates that column \'Mechanic\' has \'{0}\' with row text \'ActionCode\'", mechanic), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And(string.Format("the user validates that column \'Promo Description\' has \'{0}\' with row text \'Actio" +
                            "nCode\'", description1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.And("the user validates that column \'Amount\' has \'100.00\' with row text \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And("the user validates that column \'Balanced %\' has \'100\' with row text \'ActionCode1\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 125
 testRunner.And(string.Format("the user validates that column \'Balance type\' contains \'{0}\' with row text \'Actio" +
                            "nCode1\'", negativeType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.And(string.Format("the user validates that column \'Beneficiary\' has \'{0}\' with row text \'ActionCode1" +
                            "\'", customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.And("the user validates that column \'Promo ID\' has \'ActionCode1\' with row text \'<measu" +
                        "re1>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And(string.Format("the user validates that column \'Mechanic\' has \'{0}\' with row text \'ActionCode1\'", mechanicB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And(string.Format("the user validates that column \'Promo Description\' has \'{0}\' with row text \'Actio" +
                            "nCode1\'", description2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.And("the user validates that \'Input By Label Name\' with value \'AMOUNT\' contains text \'" +
                        "-100.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Year\' has text \'x/x/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Customer\' is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Supplier\' is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Status\' contains text \'" +
                        "New\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
    testRunner.When("the user retrieves text from element \'Input By Label Name\' with value \'Balance ID" +
                        "\' and saves it as \'BalanceID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 142
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.Then("the user validates that the \'Button\' with value \'Balance\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
 testRunner.And("the user navigates to the \'Balances\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 148
 testRunner.Then("the user validates that column \'Amount\' has \'-100.00\' with row text \'BalanceID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 151
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
