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
    [NUnit.Framework.DescriptionAttribute("TestCase507616")]
    public partial class TestCase507616Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase507616.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase507616", "\tWEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_051 - Save an agreement after edi" +
                    "ting of a rebate folder NEW", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_051")]
        [NUnit.Framework.CategoryAttribute("TTC_Nightly")]
        [NUnit.Framework.CategoryAttribute("TTC")]
        [NUnit.Framework.CategoryAttribute("BDD_507616")]
        [NUnit.Framework.TestCaseAttribute("Level 4", "EC86185", "Supply", "Year End Bonuses", "Unconditional", "Invoice payable", "Product", "010", "011", "10", "20", "Brackets", "01", "02", "30", "11", "Level 3", "Level 3", "Included", "EC86184", "HierFilter_051", "01", "06", "06", "All Products", "30.00", "30.00", "3,000.00", "50.00", "40.00", "40.00", "4,000.00", "400.00", "Level 5", null)]
        public virtual void WEB_SA_AGREEMENT_AGREEMENTDOCUMENT_CONDITIONS_051(
                    string customerLevel, 
                    string customerHolder, 
                    string classification, 
                    string reason, 
                    string targetType, 
                    string paymentMode, 
                    string productLevel, 
                    string productCode, 
                    string productCode2, 
                    string percentage1A, 
                    string percentage2A, 
                    string targetType2, 
                    string startDay, 
                    string startMonth, 
                    string endDay, 
                    string endMonth, 
                    string beneficiaryLevel, 
                    string hierLevel, 
                    string filtering, 
                    string customerCode, 
                    string filterName, 
                    string startMonth2, 
                    string endMonth2, 
                    string startMonth3, 
                    string allProducts, 
                    string threshold3A, 
                    string percentage3A, 
                    string threshold3B, 
                    string percentage3B, 
                    string threshold4A, 
                    string percentage4, 
                    string threshold4B, 
                    string amount_Qtyb, 
                    string targetLevel, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TTC_Nightly",
                    "TTC",
                    "BDD_507616"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerLevel", customerLevel);
            argumentsOfScenario.Add("CustomerHolder", customerHolder);
            argumentsOfScenario.Add("Classification", classification);
            argumentsOfScenario.Add("Reason", reason);
            argumentsOfScenario.Add("TargetType", targetType);
            argumentsOfScenario.Add("PaymentMode", paymentMode);
            argumentsOfScenario.Add("ProductLevel", productLevel);
            argumentsOfScenario.Add("ProductCode", productCode);
            argumentsOfScenario.Add("ProductCode2", productCode2);
            argumentsOfScenario.Add("Percentage1a", percentage1A);
            argumentsOfScenario.Add("Percentage2a", percentage2A);
            argumentsOfScenario.Add("TargetType2", targetType2);
            argumentsOfScenario.Add("startDay", startDay);
            argumentsOfScenario.Add("startMonth", startMonth);
            argumentsOfScenario.Add("endDay", endDay);
            argumentsOfScenario.Add("endMonth", endMonth);
            argumentsOfScenario.Add("BeneficiaryLevel", beneficiaryLevel);
            argumentsOfScenario.Add("HierLevel", hierLevel);
            argumentsOfScenario.Add("Filtering", filtering);
            argumentsOfScenario.Add("CustomerCode", customerCode);
            argumentsOfScenario.Add("FilterName", filterName);
            argumentsOfScenario.Add("startMonth2", startMonth2);
            argumentsOfScenario.Add("endMonth2", endMonth2);
            argumentsOfScenario.Add("startMonth3", startMonth3);
            argumentsOfScenario.Add("AllProducts", allProducts);
            argumentsOfScenario.Add("threshold3a", threshold3A);
            argumentsOfScenario.Add("Percentage3a", percentage3A);
            argumentsOfScenario.Add("threshold3b", threshold3B);
            argumentsOfScenario.Add("Percentage3b", percentage3B);
            argumentsOfScenario.Add("threshold4a", threshold4A);
            argumentsOfScenario.Add("Percentage4", percentage4);
            argumentsOfScenario.Add("threshold4b", threshold4B);
            argumentsOfScenario.Add("Amount_qtyb", amount_Qtyb);
            argumentsOfScenario.Add("targetLevel", targetLevel);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_051", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'Agreements\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("the user creates a New Document \'{0}\' \'{1}\' \'\' \'\'", customerLevel, customerHolder), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Agreement ID\' is di" +
                        "splayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("the user retrieves text from element \'Input By Label Name\' with value \'Agreement " +
                        "ID\' and saves it as \'AgreementID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And(string.Format("the user populates the New Rebate Details \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'Net sales reve" +
                            "nue\' \'RebateFolder_051\'", classification, reason, targetType, paymentMode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user clicks on \'Sub Tab Add Button\' with value \'Rebate Products:\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And(string.Format("the user clicks on \'Hier. level side panel\' with value \'{0}\'", productLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
    testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", productCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
    testRunner.And(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", productCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user clicks on \'Popup Ok Button SM1Id\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And(string.Format("the user in popup \'New Rebate:\' enters \'{0}\' in cell with column \'%\' and row text" +
                            " \'{1}\'", percentage1A, productCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("the user in popup \'New Rebate:\' enters \'{0}\' in cell with column \'%\' and row text" +
                            " \'{1}\'", percentage2A, productCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'New Rebate:\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user retrieves text in cell with column \'Rebate Header ID\' and row text \'Reba" +
                        "teFolder_051\' and saves as \'MasterRebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on \'RebateFolder_051\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And(string.Format("the user selects active scenario \'{0}\' from dropdown list \'Target Type\'", targetType2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user selects active scenario \'Sales volumes (pieces)\' from dropdown list \'Cal" +
                        "culation Basis\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user enters \'Sales volumes (pieces)\' in field \'Input By Label Name\' with valu" +
                        "e \'Target Source\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And(string.Format("the user selects active scenario \'{0}\' from dropdown list \'Beneficiary Level\'", beneficiaryLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the user enters \'newDescription_051\' in field \'Input By Label Name\' with value \'D" +
                        "escription\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user selects validity period \'01/02/y\' \'30/11/y\' on the \'New Rebate Validity " +
                        "Period Trigger\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user clicks on \'Generic Drop Down Trigger\' with value \'Hier Filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_newFilterSet\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And(string.Format("the user clicks on \'Hier. level side panel\' with value \'{0}\'", beneficiaryLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user clicks on \'Hier. level side panel\' with value \'{0}\'", filtering), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user clicks on \'{0}\' text on the grid", customerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Customer Hierarchy Filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Filter Maker\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Filter Name\'", filterName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Save Filter (Required)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on the \'Expend Panel Icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user selects validity period \'01/06/y\' \'30/11/y\' on the \'Calc Basis Validity " +
                        "Period\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user selects validity period \'01/01/y\' \'30/06/y\' on the \'Target Validity Peri" +
                        "od\' field", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And(string.Format("the user in popup \'New Rebate:\' Clicks cell with column \'Product\' and row text \'{" +
                            "0}\'", productCode2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_remove\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.Then("the user validates that the \'Alert Dialog Button\' with value \'OK\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 63
 testRunner.When("the user clicks on \'Alert Dialog Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_all-filters\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And(string.Format("the user in popup \'New Rebate:\' Clicks cell with column \'Product\' and row text \'{" +
                            "0}\'", allProducts), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_addThresholds\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.Then("the user validates that the \'Popup Ok Button\' with value \'All Conditions\' is disp" +
                        "layed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \'Threshold\' a" +
                            "nd row text \'0.00\'", threshold3A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \' % \' and row" +
                            " text \'{1}\'", percentage3A, threshold3A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \'Threshold\' a" +
                            "nd row text \'31.00\'", threshold3B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \' % \' and row" +
                            " text \'{1}\'", percentage3B, threshold3B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'All Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.And(string.Format("the user in popup \'New Rebate:\' Clicks cell with column \'Product\' and row text \'{" +
                            "0}\'", productCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_addThresholds\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.Then("the user validates that the \'Popup Ok Button\' with value \'All Conditions\' is disp" +
                        "layed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.When(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \'Threshold\' a" +
                            "nd row text \'0.00\'", threshold4A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 84
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \' % \' and row" +
                            " text \'{1}\'", percentage4, threshold4A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \'Threshold\' a" +
                            "nd row text \'41.00\'", threshold4B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And(string.Format("the user in popup \'All Conditions\' enters \'{0}\' in cell with column \'Amount/Qty\' " +
                            "and row text \'{1}\'", amount_Qtyb, threshold4B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'All Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_target\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("the user clicks on \'Checkbox By Label\' with value \'Aggregated\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And(string.Format("the user selects active scenario \'{0}\' from dropdown list \'Target Level\'", targetLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Target\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'New Rebate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("the user clicks on \'Button\' with value \'Save\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And("the user navigates to the \'Rebates\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.And("the user filters the column by column name \'Agreement ID\', \'Equal\', \'AgreementID\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("the user validates that elements \'Rows\' have loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.When("the user retrieves count of \'Popup Grid Rows\' with value \'\' and saves it as \'RowC" +
                        "ountNew\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 109
 testRunner.Then("the user validates that the element \'RowCountNew\' is equal to \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 112
 testRunner.When("the user filters the column by column name \'Rebate code\', \'Not Like\', \'MasterReba" +
                        "teCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 113
 testRunner.And("the user retrieves text in cell with column \'Rebate code\' and row text \'newDescri" +
                        "ption_051\' and saves as \'ChildRebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And("the user filters the column by column name \'Rebate code\', \'Not Like\', \'ChildRebat" +
                        "eCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And("the user retrieves text in cell with column \'Rebate code\' and row text \'newDescri" +
                        "ption_051\' and saves as \'ChildRebateCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And("the user clears filter at column  \'Agreement ID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("the user filters the column by column name \'Rebate code\', \'Like\', \'ChildRebateCod" +
                        "e\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And("the user clicks on link on column \'Rebate code\' with row text \'newDescription_051" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 121
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \'Threshold\' has \'{0}\' with row text \'{1}\'", threshold3A, percentage3A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \' % \' has \'{0}\' with row text \'{1}\'", percentage3A, threshold3A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \'Threshold\' has \'{0}\' with row text \'<Percentage3d>\'", threshold3B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \' % \' has \'{0}\' with row text \'{1}\'", percentage3B, threshold3B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.And("the user filters the column by column name \'Rebate code\', \'Like\', \'ChildRebateCod" +
                        "e1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And("the user clicks on link on column \'Rebate code\' with row text \'newDescription_051" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 132
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \'Threshold\' has \'{0}\' with row text \'{1}\'", threshold4A, percentage4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 133
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \' % \' has \'{0}\' with row text \'{1}\'", percentage4, threshold4A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \'Threshold\' has \'{0}\' with row text \'<AmountQtyb>\'", threshold4B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                            " \'Amount/Qty\' has \'{0}\' with row text \'{1}\'", amount_Qtyb, threshold4B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 138
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.And("the user filters the column by column name \'Rebate code\', \'Like\', \'MasterRebateCo" +
                        "de\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
 testRunner.And("the user clicks on link on column \'Rebate code\' with row text \'newDescription_051" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 142
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 143
 testRunner.And("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                        " \'Threshold\' has \'0.00\' with row text \'0.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 144
 testRunner.And("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                        " \'Amount/Qty\' has \'0.00\' with row text \'0.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                        " \' % \' has \'0.00\' with row text \'0.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.And("the user validates that popup with sm1 ID \'CARD_RANGES\' and name \'Benefit\' column" +
                        " \'Fixed amount\' has \'0.00\' with row text \'0.00\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Target Type\' contains t" +
                            "ext \'{0}\'", targetType2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 148
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Data source\' contains t" +
                        "ext \'Sales volumes (pieces)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.And("the user validates that \'Input By Label Name\' with value \'DESCRIPTION\' contains t" +
                        "ext \'newDescription_051\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
 testRunner.And("the user validates that \'Start Date\' with value \'Target\' contains text \'01/01/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And("the user validates that \'End Date\' with value \'Target\' contains text \'30/06/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 152
 testRunner.And("the user validates that \'Start Date\' with value \'CALCULATION BASIS VALIDITY\' cont" +
                        "ains text \'01/06/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 153
 testRunner.And("the user validates that \'End Date\' with value \'CALCULATION BASIS VALIDITY\' contai" +
                        "ns text \'30/11/y\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
