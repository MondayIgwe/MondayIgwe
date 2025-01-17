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
    [NUnit.Framework.DescriptionAttribute("TestCase548052")]
    public partial class TestCase548052Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase548052.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase548052", "\tWEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_076 - display info for standard r" +
                    "ebate - brackets and edit it", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("TC548052 - WEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_076")]
        [NUnit.Framework.CategoryAttribute("TTC_Nightly")]
        [NUnit.Framework.CategoryAttribute("TTC")]
        [NUnit.Framework.CategoryAttribute("BDD_548052")]
        [NUnit.Framework.TestCaseAttribute("Level 4", "EC86217", "Supply", "Year End Bonuses", "Brackets", "Net sales revenue", "Invoice payable", "Monthly", "50.00", "50.00", "2.00", "75.00", "10.00", "3.00", "Brand", "In", "01", "Level 1", "EC87135", "909090", "Not aggregated", "ALL", "ea7400", "2", "Draft", "1.00", "008fe1", "Aggregated", "All Products", "Details", null)]
        public virtual void TC548052_WEB_SA_AGREEMENT_AGREEMENTDOCUMENT_CONDITIONS_076(
                    string customerLevel, 
                    string customer, 
                    string classification, 
                    string reason, 
                    string targetType, 
                    string calculationBasis, 
                    string paymentMode, 
                    string paymentFrequency, 
                    string threshold1, 
                    string amountQty1, 
                    string forEach1, 
                    string threshold2, 
                    string amountQty2, 
                    string forEach2, 
                    string attribute, 
                    string @operator, 
                    string value, 
                    string hierLevel, 
                    string hierCustomer, 
                    string grayCircleIcon, 
                    string target, 
                    string custFilter, 
                    string orangeCircleIcon, 
                    string counter, 
                    string status, 
                    string percentage, 
                    string blueCircleIcon, 
                    string target1, 
                    string allProducts, 
                    string productValue, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TTC_Nightly",
                    "TTC",
                    "BDD_548052"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerLevel", customerLevel);
            argumentsOfScenario.Add("Customer", customer);
            argumentsOfScenario.Add("Classification", classification);
            argumentsOfScenario.Add("Reason", reason);
            argumentsOfScenario.Add("TargetType", targetType);
            argumentsOfScenario.Add("CalculationBasis", calculationBasis);
            argumentsOfScenario.Add("PaymentMode", paymentMode);
            argumentsOfScenario.Add("PaymentFrequency", paymentFrequency);
            argumentsOfScenario.Add("Threshold1", threshold1);
            argumentsOfScenario.Add("AmountQty1", amountQty1);
            argumentsOfScenario.Add("ForEach1", forEach1);
            argumentsOfScenario.Add("Threshold2", threshold2);
            argumentsOfScenario.Add("AmountQty2", amountQty2);
            argumentsOfScenario.Add("ForEach2", forEach2);
            argumentsOfScenario.Add("Attribute", attribute);
            argumentsOfScenario.Add("Operator", @operator);
            argumentsOfScenario.Add("Value", value);
            argumentsOfScenario.Add("HierLevel", hierLevel);
            argumentsOfScenario.Add("HierCustomer", hierCustomer);
            argumentsOfScenario.Add("GrayCircleIcon", grayCircleIcon);
            argumentsOfScenario.Add("Target", target);
            argumentsOfScenario.Add("CustFilter", custFilter);
            argumentsOfScenario.Add("OrangeCircleIcon", orangeCircleIcon);
            argumentsOfScenario.Add("counter", counter);
            argumentsOfScenario.Add("Status", status);
            argumentsOfScenario.Add("Percentage", percentage);
            argumentsOfScenario.Add("BlueCircleIcon", blueCircleIcon);
            argumentsOfScenario.Add("Target1", target1);
            argumentsOfScenario.Add("AllProducts", allProducts);
            argumentsOfScenario.Add("ProductValue", productValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC548052 - WEB_SA_AGREEMENT_AGREEMENT DOCUMENT_CONDITIONS_076", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'Rebates\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
 testRunner.When(string.Format("the user creates a Rebate \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\'", customerLevel, customer, classification, reason, targetType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
    testRunner.When("the user retrieves text from element \'Input By Label Name\' with value \'Rebate cod" +
                        "e\' and saves it as \'RebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
 testRunner.And(string.Format("the user populates the Rebate mandatory data \'{0}\' \'{1}\' \'{2}\'", calculationBasis, paymentMode, paymentFrequency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user enters \'Sales volumes (pieces)\' in the \'Tagret Data Source Field\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user enters \'<Description>\' in field \'Input By Label Name\' with value \'DESCRI" +
                        "PTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("the user enters \'{0}\' in cell with column \'Threshold\' and row containing text \'0." +
                            "0\'", threshold1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'DESCRIPTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And(string.Format("the user enters \'{0}\' in cell with column \'Amount/Qty\' and row containing text \'0" +
                            ".0\'", amountQty1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'DESCRIPTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Text\' with value \'for each 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
    testRunner.Then("the user validates that the \'Popup\' with value \'For each quantity\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'For each\'", forEach1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'For each quantity\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("the user enters \'{0}\' in cell with column \'Threshold\' and row containing text \'51" +
                            ".0\'", threshold2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'DESCRIPTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the user enters \'{0}\' in cell with column \'Amount/Qty\' and row containing text \'{" +
                            "1}\'", amountQty2, threshold2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the user clicks on \'Input By Label Name\' with value \'DESCRIPTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("the user clicks on \'Text\' with value \'for each 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
    testRunner.Then("the user validates that the \'Popup\' with value \'For each quantity\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'For each\'", forEach2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'For each quantity\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Calculation Basis Filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user clicks on the \'Popup Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And(string.Format("the user in popup \'Filter Maker\' enters \'{0}\' in cell with column \'Attribute\' and" +
                            " row text \'\'", attribute), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And(string.Format("the user in popup \'Filter Maker\' enters \'{0}\' in cell with column \'Operator\' and " +
                            "row text \'{1}\'", @operator, attribute), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
    testRunner.And("the user clicks on \'Popup Grid Trigger\' with value \'LOGICALFILTERMAKERPOPUP\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
    testRunner.Then("the user validates that the \'Popup\' with value \'Selection\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
    testRunner.When(string.Format("the user clicks on \'Grid Checkbox\' with value \'{0}\'", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Selection\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.Then("the user validates that the \'Popup\' with value \'Selection\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 46
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Filter Maker\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
    testRunner.Then("the user validates that the \'Popup\' with value \'Save Filter (Required)\' is displa" +
                        "yed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When("the user enters \'AGREE DOC_COND_076_ProdFILTER\' in field \'Input By Label Name\' wi" +
                        "th value \'Filter Name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Save Filter (Required)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Customers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Hier Filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_newFilterSet\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
    testRunner.Then("the user validates that the \'Popup\' with value \'Customer Hierarchy Filter\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.When(string.Format("the user clicks on \'Hier. level side panel\' with value \'{0}\'", hierLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.And(string.Format("the user clicks on \'{0}\' text on the grid", hierCustomer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Customer Hierarchy Filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
    testRunner.Then("the user validates that the \'Popup\' with value \'Customer Hierarchy Filter\' is not" +
                        " present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Filter Maker\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.When("the user enters \'AGREE DOC_COND_076_HierFILTER\' in field \'Input By Label Name\' wi" +
                        "th value \'Filter Name\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Save Filter (Required)\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.Then("the user validates that the \'CheckBox Filter CalcBasis\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General Info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user clicks on the \'Agreement ID Increment Icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And("the user clicks on the \'Agreement Code Label\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Agreement Code\' is " +
                        "displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
 testRunner.When("the user enters \'AGREE DOC_COND_076_AGREE\' in field \'Input By Label Name\' with va" +
                        "lue \'Agreement Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 73
 testRunner.And("the user enters \'AGREE DOC_COND_076_AGREE\' in the \'Agreement Description field\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
    testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Agreement " +
                        "ID\' and saves it as \'AgreementID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("the user navigates to the \'Agreements\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And("the user clicks on \'AgreementID\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
    testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Agreement ID\' is di" +
                        "splayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Rebate description\' has \'<Description>\' with row text \'{0}\'", reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 90
 testRunner.When("the user makes all coumns visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 92
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Rebate Header ID\' has \'RebateCode\' with row text \'{0}\'", reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 93
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Rebate description\' has \'<Description>\' with row text \'{0}\'", reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Reason\' has \'{0}\' with row text \'<Description>\'", reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Target Type\' has \'{0}\' with row text \'<Description>\'", targetType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Target\' has \'{0}\' with row text \'<Description>\'", target), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Classification\' has \'{0}\' with row text \'<Description>\'", classification), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Payment Modes\' has \'{0}\' with row text \'<Description>\'", paymentMode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Calculation Basis\' has \'{0}\' with row text \'<Description>\'", calculationBasis), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                        "ader\' column \'Target Source\' has \'Sales volumes (pieces)\' with row text \'<Descri" +
                        "ption>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Beneficiary Level\' has \'{0}\' with row text \'<Description>\'", customerLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                        "ader\' column \'Hier Filter\' contains \'AGREE DOC_COND_076_HierFILTER\' with row tex" +
                        "t \'<Description>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Customer Filter\' has \'{0}\' with row text \'<Description>\'", custFilter), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                        "ader\' column \'Customer Holder\' has \'EC86217 - ALTRI NON ASSOCIATI\' with row text" +
                        " \'<Description>\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.When("the user clicks on \'RebateCode\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 108
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Product\' contains \'AGREE DOC_COND_076_ProdFILTER\' with row text" +
                            " \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Value\' has \'10 / 3\' with row text \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Status\' has \'{0}\' with row text \'AGREE DOC_COND_076_ProdFILTER\'" +
                            "", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Type Of Value\' has \'Amount/Qty 2\' with row text \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.When("the user clicks on \'10 / 3\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 115
    testRunner.Then("the user validates that the \'Popup\' with value \'All Conditions\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALPOPUP\' and name \'All Conditions" +
                            "\' column \'Threshold\' has \'{0}\' with row text \'for each 2\'", threshold1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALPOPUP\' and name \'All Conditions" +
                            "\' column \'Threshold\' has \'{0}\' with row text \'for each 3\'", threshold2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
    testRunner.When("the user clicks on \'Popup Ok Button\' with value \'All Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 121
 testRunner.And("the user clicks on \'Element by SM1Id\' with value \'ACTION_edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 125
 testRunner.When("the user clicks on the \'Same Filters Checkbox\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 128
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Calculation Basis Filte" +
                        "r\' contains text \'AGREE DOC_COND_076_ProdFILTER\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 130
 testRunner.When("the user clicks on the \'Calculation Basic Filter Clear\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 131
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Calculation Basis Filte" +
                        "r\' contains text \'No filter\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 134
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 135
    testRunner.Then("the user validates that the \'Element by SM1Id\' with value \'CHKFLGSAMEFILTER\' is d" +
                        "isplayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.When(string.Format("the user enters \'{0}\' in cell with column \' % \' and row containing text \'{1}\'", percentage, threshold2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 139
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 142
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 143
    testRunner.Then("the user validates that the \'Element by SM1Id\' with value \'ACTION_edit\' is displa" +
                        "yed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 146
 testRunner.When("the user clicks on \'RebateCode\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 147
    testRunner.Then("the user validates that the \'Element Background Color\' with value \'008FE1\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 148
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebatesHeader\' and name \'Rebate He" +
                            "ader\' column \'Target\' has \'{0}\' with row text \'AGREE DOC_COND_076_REBATE\'", target1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Product\' has \'{0}\' with row text \'{1}\'", allProducts, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Value\' contains \'{0}\' with row text \'{1}\'", productValue, status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'cardRebateProducts\' and name \'Rebate P" +
                            "roducts\' column \'Type Of Value\' has \'Amount/QtyPercentage 2\' with row text \'{0}\'" +
                            "", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.When("the user clicks on \'Details...\' text on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 155
 testRunner.Then(string.Format("the user validates that popup with sm1 ID \'LOGICALPOPUP\' and name \'All Conditions" +
                            "\' column \'Threshold\' has \'{0}\' with row text \'for each 2\'", threshold1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 156
 testRunner.And(string.Format("the user validates that popup with sm1 ID \'LOGICALPOPUP\' and name \'All Conditions" +
                            "\' column \'Threshold\' has \'{0}\' with row text \'{1}\'", threshold2, percentage), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 157
    testRunner.When("the user clicks on \'Popup Ok Button\' with value \'All Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
