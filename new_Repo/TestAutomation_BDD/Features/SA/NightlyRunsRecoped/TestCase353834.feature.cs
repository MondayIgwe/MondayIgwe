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
    [NUnit.Framework.DescriptionAttribute("TestCase353834")]
    public partial class TestCase353834Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase353834.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase353834", "\tWEB_SA_BALANCE_MATCHED CLAIMS-PROMOTIONS_BALANCE_005 - Create Balance from \'Matc" +
                    "hed Claims - Promotion\' using last claim rows", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SA_BALANCE_MATCHED_CLAIMS_PROMOTIONS_BALANCE_005")]
        [NUnit.Framework.CategoryAttribute("TTC_Nightly")]
        [NUnit.Framework.CategoryAttribute("TCC")]
        [NUnit.Framework.CategoryAttribute("BDD_353834")]
        [NUnit.Framework.TestCaseAttribute("Level 0", "EC13085", "353834#2", "EC86190", "MATCHED CLAIMS-PROMOTIONS_BALANCE_005", "010", "Product", "Display", "200.00", "EC13094", "MATCHED CLAIMS-PROMOTIONS_BALANCE_005B", "011", "012", "100.00", "200.00", "TO BE AUTHORIZED", "CONFIRM", "250.00", "250.00", "300.00", "200.00", "100.00", "Finalization", "100", "50", "250.00", "25.00", "Negative balance", "Positive balance", "Matched Claims - Promotions", "Balances", "x/x/y", "d/m/y", "d+10/m/y", "", "", null)]
        public virtual void WEB_SA_BALANCE_MATCHED_CLAIMS_PROMOTIONS_BALANCE_005(
                    string cUSTLEV, 
                    string customer, 
                    string customerDocNr1, 
                    string supplier, 
                    string description, 
                    string product, 
                    string productLevel, 
                    string mechanic, 
                    string measure, 
                    string customerB, 
                    string descriptionB, 
                    string product1, 
                    string product2, 
                    string measureProduct1, 
                    string measureProduct2, 
                    string status, 
                    string status2, 
                    string amount, 
                    string amountToMatchPromo1, 
                    string amountB, 
                    string amountToMatchPromo2A, 
                    string amountToMatchPromo2B, 
                    string finalizationPopupTitle, 
                    string balancePercentageValue, 
                    string percent, 
                    string amountToMatch, 
                    string totalBalanceAmount, 
                    string balanceType1, 
                    string balanceType2, 
                    string matchedCPNavigator, 
                    string balancesNavigator, 
                    string sELLINSTARTYEAR, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string sELLOUTSTARTDATE, 
                    string sELLOUTENDDATE, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "TTC_Nightly",
                    "TCC",
                    "BDD_353834"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CUSTLEV", cUSTLEV);
            argumentsOfScenario.Add("customer", customer);
            argumentsOfScenario.Add("CustomerDocNr1", customerDocNr1);
            argumentsOfScenario.Add("supplier", supplier);
            argumentsOfScenario.Add("description", description);
            argumentsOfScenario.Add("product", product);
            argumentsOfScenario.Add("productLevel", productLevel);
            argumentsOfScenario.Add("mechanic", mechanic);
            argumentsOfScenario.Add("measure", measure);
            argumentsOfScenario.Add("customerB", customerB);
            argumentsOfScenario.Add("descriptionB", descriptionB);
            argumentsOfScenario.Add("Product1", product1);
            argumentsOfScenario.Add("Product2", product2);
            argumentsOfScenario.Add("measureProduct1", measureProduct1);
            argumentsOfScenario.Add("measureProduct2", measureProduct2);
            argumentsOfScenario.Add("status", status);
            argumentsOfScenario.Add("status2", status2);
            argumentsOfScenario.Add("amount", amount);
            argumentsOfScenario.Add("amountToMatchPromo1", amountToMatchPromo1);
            argumentsOfScenario.Add("amountB", amountB);
            argumentsOfScenario.Add("amountToMatchPromo2a", amountToMatchPromo2A);
            argumentsOfScenario.Add("amountToMatchPromo2b", amountToMatchPromo2B);
            argumentsOfScenario.Add("FinalizationPopupTitle", finalizationPopupTitle);
            argumentsOfScenario.Add("balancePercentageValue", balancePercentageValue);
            argumentsOfScenario.Add("Percent", percent);
            argumentsOfScenario.Add("amountToMatch", amountToMatch);
            argumentsOfScenario.Add("TotalBalanceAmount", totalBalanceAmount);
            argumentsOfScenario.Add("BalanceType1", balanceType1);
            argumentsOfScenario.Add("balanceType2", balanceType2);
            argumentsOfScenario.Add("MatchedCPNavigator", matchedCPNavigator);
            argumentsOfScenario.Add("BalancesNavigator", balancesNavigator);
            argumentsOfScenario.Add("SELLINSTARTYEAR", sELLINSTARTYEAR);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLOUTSTARTDATE", sELLOUTSTARTDATE);
            argumentsOfScenario.Add("SELLOUTENDDATE", sELLOUTENDDATE);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SA_BALANCE_MATCHED_CLAIMS_PROMOTIONS_BALANCE_005", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", description, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mechanic), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
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
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", measure, mechanic, product), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", descriptionB, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mechanic), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user clicks on \'Top Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, product2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, product1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", measureProduct1, mechanic, product1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'{1}\' for product code \'{2}\'", measureProduct2, mechanic, product2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("the user navigates to the \'Claims\' page under division\'Claims\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.When(string.Format("the user creates a New Claim \'{0}\' \'{1}\' \'{2}\' \'{3}\'", customerDocNr1, cUSTLEV, customer, amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Document I" +
                        "D\' and saves it as \'ClaimDocumentID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Matchings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user selects action \'Match To Generic Amounts\' \'Match To Payable Amounts\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user opens the Grid Settings Menu option: \'Remove Filter\' in the \'Select Paya" +
                        "ble Amount\' pop up table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("the user filters the column by column name \'Payable Amount Logical Key\', \'Like\', " +
                        "\'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user clicks on \'Grid Checkbox Containing\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the user clicks on \'Button\' with value \'Assign\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.When("the user navigates to the \'Claims\' page under division\'Claims\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.When(string.Format("the user creates a New Claim \'{0}\' \'{1}\' \'{2}\' \'{3}\'", customerDocNr1, cUSTLEV, customerB, amountB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 53
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Document I" +
                        "D\' and saves it as \'ClaimDocumentID2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Matchings\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user selects action \'Match To Generic Amounts\' \'Match To Payable Amounts\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("the user opens the Grid Settings Menu option: \'Remove Filter\' in the \'Select Paya" +
                        "ble Amount\' pop up table", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user filters the column by column name \'Payable Amount Logical Key\', \'Like\', " +
                        "\'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user clicks on \'Popup All Checkbox By Name\' with value \'Select Payable Amount" +
                        "\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", amountToMatchPromo2A, product1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("the user enters \'{0}\' in grid cell with column \'Amount to match\' and row text \'{1" +
                            "}\' in popup \'Matching finalization\'", amountToMatchPromo2B, product2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.When("the user navigates to the \'Matched Claims - Promotions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 68
 testRunner.When("the user clicks on \'Grid Checkbox\' with value \'ActionCode1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 69
 testRunner.And("the user clicks on \'Grid Checkbox\' with value \'ActionCode2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("the user clicks on \'Button Link\' with value \'Balance\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then(string.Format("\'Popup Title\' text contains \'{0}\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.And("the user validates that the \'Grid Checkbox Containing\' with value \'ActionCode1\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("the user validates that the \'Grid Checkbox Containing\' with value \'ActionCode2\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balance Percentage\' has \'{1}\' with ro" +
                            "w text \'ActionCode1\'", finalizationPopupTitle, balancePercentageValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balance Percentage\' has \'{1}\' with ro" +
                            "w text \'ActionCode2\'", finalizationPopupTitle, balancePercentageValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 81
 testRunner.When("the user clicks on \'Popup All Checkbox By Name\' with value \'Finalization\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.And("the user selects action \'Percentage\' \'50%\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.Then(string.Format("the user validates that popup \'{0}\' column \'Amount to Balance\' has \'25.00\' with r" +
                            "ow text \'ActionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 85
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balance Percentage\' has \'50\' with row" +
                            " text \'ActionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Promo Description\' has \'{1}\' with row" +
                            " text \'ActionCode1\'", finalizationPopupTitle, description), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 87
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balanced Amount\' has \'0.00\' with row " +
                            "text \'ActionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Deviation\' has \'25.00\' with row text " +
                            "\'ActionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Customer code\' has \'{1}\' with row tex" +
                            "t \'ActionCode1\'", finalizationPopupTitle, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'ABS OPA\' has \'50.00\' with row text \'A" +
                            "ctionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Absolute Amount to Balance\' has \'25.0" +
                            "0\' with row text \'ActionCode1\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.Then(string.Format("the user validates that popup \'{0}\' column \'Amount to Balance\' has \'0.00\' with ro" +
                            "w text \'ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balance Percentage\' has \'50\' with row" +
                            " text \'ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Promo Description\' has \'{1}\' with row" +
                            " text \'ActionCode2\'", finalizationPopupTitle, descriptionB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Balanced Amount\' has \'0.00\' with row " +
                            "text \'ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 97
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Deviation\' has \'100.00\' with row text" +
                            " \'ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Customer code\' has \'{1}\' with row tex" +
                            "t \'ActionCode2\'", finalizationPopupTitle, customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'ABS OPA\' has \'200.00\' with row text \'" +
                            "ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.And(string.Format("the user validates that popup \'{0}\' column \'Absolute Amount to Balance\' has \'100." +
                            "00\' with row text \'ActionCode2\'", finalizationPopupTitle), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Total Balance Amount\' h" +
                            "as text \'{0}\'", totalBalanceAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.When("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Balance ID" +
                        "\' and saves it as \'BalanceID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("the user validates that column \'Amount\' has \'25.00\' with row number \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.And(string.Format("the user validates that column \'Balanced %\' has \'{0}\' with row number \'1\'", percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And(string.Format("the user validates that column \'Balance type\' has \'{0}\' with row number \'1\'", balanceType1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And(string.Format("the user validates that column \'Beneficiary\' has \'{0}\' with row number \'1\'", customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And("the user validates that column \'Promo ID\' has \'ActionCode1\' with row number \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And("the user validates that column \'Amount\' has \'50.00\' with row number \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And(string.Format("the user validates that column \'Balanced %\' has \'{0}\' with row number \'2\'", percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.And(string.Format("the user validates that column \'Balance type\' has \'{0}\' with row number \'2\'", balanceType1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And(string.Format("the user validates that column \'Beneficiary\' has \'{0}\' with row number \'2\'", customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("the user validates that column \'Promo ID\' has \'ActionCode2\' with row number \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.And("the user validates that column \'Amount\' has \'50.00\' with row number \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And(string.Format("the user validates that column \'Balanced %\' has \'{0}\' with row number \'3\'", percent), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And(string.Format("the user validates that column \'Balance type\' has \'{0}\' with row number \'3\'", balanceType2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And(string.Format("the user validates that column \'Beneficiary\' has \'{0}\' with row number \'3\'", customerB), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.And("the user validates that column \'Promo ID\' has \'ActionCode2\' with row number \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 125
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'AMOUNT\' has text \'{0}\'", totalBalanceAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Year\' has text \'{0}\'", sELLINSTARTYEAR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.And("the user validates that the \'Input By Label Name\' with value \'Customer\' is empty", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
 testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'Supplier\' contains text" +
                            " \'{0}\'", supplier), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Status\' has text \'New\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 133
 testRunner.Then("the \'Alert Dialog Message Box\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 134
 testRunner.And("the user is on the \'Matched Claims - Promotions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 136
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 137
 testRunner.And("the user navigates to the \'Balances\' page by sm1-id \'BALANCE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 139
 testRunner.Then("the user validates that the \'Text in Grid\' with value \'BalanceID\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 141
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 143
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
