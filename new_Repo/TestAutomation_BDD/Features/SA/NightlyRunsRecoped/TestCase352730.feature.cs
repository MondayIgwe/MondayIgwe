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
    [NUnit.Framework.DescriptionAttribute("TestCase352730")]
    public partial class TestCase352730Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase352730.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase352730", "\tWEB_SA_BALANCE_BALANCE DOCUMENT_ADJUSTMENT_003_Finalization step", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SA_BALANCE_BALANCE_DOCUMENT_ADJUSTMENT_003_Finalization_step")]
        [NUnit.Framework.CategoryAttribute("TTC_Nightly")]
        [NUnit.Framework.CategoryAttribute("TCC")]
        [NUnit.Framework.CategoryAttribute("BDD_352730")]
        [NUnit.Framework.TestCaseAttribute("352730#1", "352730#2", "EC86276", "Level 2", "DOCUMENT_ADJUSTMENT_003_1", "DOCUMENT_ADJUSTMENT_003_2", "Product", "059", "060", "Display", "200", "Confirmed", "061", "062", "900", "350", "350", "100", "100", "x/x/y", "d/m/y", "d+10/m/y", "", "", "x/x/y", "", null)]
        public virtual void WEB_SA_BALANCE_BALANCE_DOCUMENT_ADJUSTMENT_003_Finalization_Step(
                    string customerDocNr1, 
                    string customerDocNr2, 
                    string customer, 
                    string level, 
                    string promodescription1, 
                    string promodescription2, 
                    string productLevel, 
                    string prod1, 
                    string prod2, 
                    string mech1, 
                    string meas, 
                    string status, 
                    string prod3, 
                    string prod4, 
                    string amount, 
                    string atm1, 
                    string atm2, 
                    string atm3, 
                    string atm4, 
                    string sELLINSTARTYEAR, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string sELLOUTSTARTDATE, 
                    string sELLOUTENDDATE, 
                    string balanceYear, 
                    string supplier, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TTC_Nightly",
                    "TCC",
                    "BDD_352730"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerDocNr1", customerDocNr1);
            argumentsOfScenario.Add("CustomerDocNr2", customerDocNr2);
            argumentsOfScenario.Add("customer", customer);
            argumentsOfScenario.Add("level", level);
            argumentsOfScenario.Add("promodescription1", promodescription1);
            argumentsOfScenario.Add("promodescription2", promodescription2);
            argumentsOfScenario.Add("productLevel", productLevel);
            argumentsOfScenario.Add("prod1", prod1);
            argumentsOfScenario.Add("prod2", prod2);
            argumentsOfScenario.Add("mech1", mech1);
            argumentsOfScenario.Add("meas", meas);
            argumentsOfScenario.Add("status", status);
            argumentsOfScenario.Add("prod3", prod3);
            argumentsOfScenario.Add("prod4", prod4);
            argumentsOfScenario.Add("amount", amount);
            argumentsOfScenario.Add("atm1", atm1);
            argumentsOfScenario.Add("atm2", atm2);
            argumentsOfScenario.Add("atm3", atm3);
            argumentsOfScenario.Add("atm4", atm4);
            argumentsOfScenario.Add("SELLINSTARTYEAR", sELLINSTARTYEAR);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLOUTSTARTDATE", sELLOUTSTARTDATE);
            argumentsOfScenario.Add("SELLOUTENDDATE", sELLOUTENDDATE);
            argumentsOfScenario.Add("BalanceYear", balanceYear);
            argumentsOfScenario.Add("Supplier", supplier);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SA_BALANCE_BALANCE_DOCUMENT_ADJUSTMENT_003_Finalization_step", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 7
 testRunner.Given("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", level, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", promodescription1, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mech1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user clicks on \'Top Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, prod1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, prod2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", meas, mech1, prod1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", meas, mech1, prod2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.When("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", level, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", promodescription2, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mech1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user clicks on \'Top Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, prod3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, prod4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", meas, mech1, prod3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", meas, mech1, prod4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.When("the user navigates to the \'Claims\' page under division\'Claims\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
 testRunner.And(string.Format("the user creates a New Claim \'{0}\' \'{1}\' \'{2}\' \'{3}\'", customerDocNr1, level, customer, amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Document I" +
                        "D\' and saves it as \'ClaimDocumentID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Matchings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user selects action \'Match To Generic Amounts\' \'Match To Payable Amounts\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user opens the Grid Settings Menu option: \'Remove Filter\' in the \'Select Paya" +
                        "ble Amount\' pop up table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user clicks on element \'Grid CheckBox Containing Multi Texts\' with value \'Act" +
                            "ionCode1\' and value \'{0}\'", prod1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And(string.Format("the user clicks on element \'Grid CheckBox Containing Multi Texts\' with value \'Act" +
                            "ionCode1\' and value \'{0}\'", prod2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And(string.Format("the user clicks on element \'Grid CheckBox Containing Multi Texts\' with value \'Act" +
                            "ionCode2\' and value \'{0}\'", prod3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user clicks on element \'Grid CheckBox Containing Multi Texts\' with value \'Act" +
                            "ionCode2\' and value \'{0}\'", prod4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", atm1, prod1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", atm2, prod2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", atm3, prod3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", atm4, prod4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.When("the user navigates to the \'Balances\' page by sm1-id \'BALANCE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 62
 testRunner.And(string.Format("user creates a new balance \'{0}\' \'{1}\' \'{2}\' \'{3}\'", level, customer, balanceYear, supplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user selects action \'Selector\' \'Promo Selector\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("the user clicks on \'Grid CheckBox Containing\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user clicks on \'Grid CheckBox Containing\' with value \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user clicks on \'Popup All Checkbox By Name\' with value \'Finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Acti" +
                        "onCode1\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.And("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Acti" +
                        "onCode2\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Open payable amount\' wi" +
                        "th unique row text \'ActionCode1\' and saves it as \'OpenPayableAmount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 77
 testRunner.Then("the user validates that popup \'Finalization\' column \'Amount to Balance\' has oppos" +
                        "ite value of \'OpenPayableAmount\' with row text \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 78
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Open payable amount\' wi" +
                        "th unique row text \'ActionCode2\' and saves it as \'OpenPayableAmount2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("the user validates that popup \'Finalization\' column \'Amount to Balance\' has oppos" +
                        "ite value of \'OpenPayableAmount2\' with row text \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 80
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode1\' has the correct color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode2\' has the correct color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 82
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode1\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 83
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode2\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' with row" +
                        " text \'ActionCode1\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' with row" +
                        " text \'ActionCode2\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' has \'100" +
                        "\' with row text \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' has \'100" +
                        "\' with row text \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Balance Percentage\' wit" +
                        "h unique row text \'ActionCode1\' and saves it as \'BalancePercentage1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 91
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'ABS OPA\' with unique ro" +
                        "w text \'ActionCode1\' and saves it as \'ABSOPA1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'Absolute Amount to Bala" +
                        "nce\' with unique row text \'ActionCode1\' and saves it as \'AbsoluteAmountToBalance" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.Then("user validates that \'AbsoluteAmountToBalance\' has value of \'ABSOPA1\' \'percent\' \'B" +
                        "alancePercentage1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Balance Percentage\' wit" +
                        "h unique row text \'ActionCode2\' and saves it as \'BalancePercentage2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'ABS OPA\' with unique ro" +
                        "w text \'ActionCode2\' and saves it as \'ABSOPA2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'Absolute Amount to Bala" +
                        "nce\' with unique row text \'ActionCode2\' and saves it as \'AbsoluteAmountToBalance" +
                        "2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.Then("user validates that \'AbsoluteAmountToBalance2\' has value of \'ABSOPA2\' \'percent\' \'" +
                        "BalancePercentage2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.Then("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode1\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.And("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode2\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Amount to Balance\' with" +
                        " unique row text \'ActionCode1\' and saves it as \'AmountToBalance1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 104
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'Amount to Balance\' with" +
                        " unique row text \'ActionCode2\' and saves it as \'AmountToBalance2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Total Bala" +
                        "nce Amount\' and saves it as \'TotalBalanceAmount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then("user validates that \'TotalBalanceAmount\' has value of \'AmountToBalance1\' \'plus\' \'" +
                        "AmountToBalance2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 109
 testRunner.Then("the user validates that the \'Popup Button\' with value \'Cancel\' is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 111
 testRunner.When("the user clicks on \'Input By Label Name\' with value \'Total Balance Amount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.And("the user clicks on \'Popup Cancel Button\' with value \'Finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.Then("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode1\' i" +
                        "s not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 114
 testRunner.And("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode2\' i" +
                        "s not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 117
 testRunner.And("the user clicks on the \'Alert Dialog No Button\' if it exists", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.When("the user navigates to the \'Balances\' page by sm1-id \'BALANCE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 121
 testRunner.And(string.Format("user creates a new balance \'{0}\' \'{1}\' \'{2}\' \'{3}\'", level, customer, balanceYear, supplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.And("the user selects action \'Selector\' \'Payable Amount Selector\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.And("the user selects opens the filter at column \'Action Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.And("the user clicks on \'Filter Option\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And("the user clicks on \'Filter Option\' with value \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Column:Action Code\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("the user clicks on element \'Select Row Checkbox\' with value \'Select Payable Amoun" +
                        "ts\' and value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 131
 testRunner.And("the user clicks on element \'Select Row Checkbox\' with value \'Select Payable Amoun" +
                        "ts\' and value \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.And("the user clicks on element \'Select Row Checkbox\' with value \'Select Payable Amoun" +
                        "ts\' and value \'5\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 133
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
 testRunner.And("the user clicks on \'Popup All Checkbox By Name\' with value \'Finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.Then("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Acti" +
                        "onCode1\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.And("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Acti" +
                        "onCode2\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 140
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Open payable amount\' wi" +
                        "th unique row text \'ActionCode1\' and saves it as \'OpenPayableAmount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 141
 testRunner.Then("the user validates that popup \'Finalization\' column \'Amount to Balance\' has oppos" +
                        "ite value of \'OpenPayableAmount\' with row text \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 142
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Open payable amount\' wi" +
                        "th unique row text \'ActionCode2\' and saves it as \'OpenPayableAmount2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.Then("the user validates that popup \'Finalization\' column \'Amount to Balance\' has oppos" +
                        "ite value of \'OpenPayableAmount2\' with row text \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 144
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode1\' has the correct color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 145
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode2\' has the correct color", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 146
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode1\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 147
 testRunner.And("the user validates that popup \'Finalization\' column \'Amount to Balance\' with row " +
                        "text \'ActionCode2\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 149
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' with row" +
                        " text \'ActionCode1\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 150
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' with row" +
                        " text \'ActionCode2\' is not editable", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 151
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' has \'100" +
                        "\' with row text \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 152
 testRunner.And("the user validates that popup \'Finalization\' column \'Balance Percentage\' has \'100" +
                        "\' with row text \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 154
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Balance Percentage\' wit" +
                        "h unique row text \'ActionCode1\' and saves it as \'BalancePercentage1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 155
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'ABS OPA\' with unique ro" +
                        "w text \'ActionCode1\' and saves it as \'ABSOPA1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 156
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'Absolute Amount to Bala" +
                        "nce\' with unique row text \'ActionCode1\' and saves it as \'AbsoluteAmountToBalance" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 157
 testRunner.Then("user validates that \'AbsoluteAmountToBalance\' has value of \'ABSOPA1\' \'percent\' \'B" +
                        "alancePercentage1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 158
 testRunner.When("the user retrieves text from popup \'Finalization\' column \'Balance Percentage\' wit" +
                        "h unique row text \'ActionCode2\' and saves it as \'BalancePercentage2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 159
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'ABS OPA\' with unique ro" +
                        "w text \'ActionCode2\' and saves it as \'ABSOPA2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 160
 testRunner.And("the user retrieves text from popup \'Finalization\' column \'Absolute Amount to Bala" +
                        "nce\' with unique row text \'ActionCode2\' and saves it as \'AbsoluteAmountToBalance" +
                        "2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 161
 testRunner.Then("user validates that \'AbsoluteAmountToBalance2\' has value of \'ABSOPA2\' \'percent\' \'" +
                        "BalancePercentage2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 164
 testRunner.Then("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode1\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 165
 testRunner.And("the user validates that the \'Grid CheckBox Containing\' with value \'ActionCode2\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 167
 testRunner.When("the user retrieves text from element \'Input By Label Name\' with value \'Total Bala" +
                        "nce Amount\' and saves it as \'TotalBalanceAmount\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 168
 testRunner.Then("user validates that \'TotalBalanceAmount\' has value of sum for popup \'Finalization" +
                        "\' colum \'Amount to Balance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
