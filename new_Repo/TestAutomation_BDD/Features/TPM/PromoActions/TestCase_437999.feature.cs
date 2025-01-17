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
namespace Kantar_BDD.Features.TPM.PromoActions
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_437999")]
    public partial class TestCase_437999Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_437999.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoActions", "TestCase_437999", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_PROMODOCUMENT_WEEKLYSPLIT_001")]
        [NUnit.Framework.CategoryAttribute("BDD_437999")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("PromoActions")]
        [NUnit.Framework.TestCaseAttribute("Level 3", "EC94679", "TPR in %", "Next Monday", "Next Next Sunday", "", "", "Weekly Split test 1", "Weekly Split test 2", "01", "Family - 01", "50.000", "500.000", "0.000", "30", "70", "1000", "EC95056", "2 Weeks", "40.000", "60.000", "001", "002", "1", "2", "100", "200", null)]
        public virtual void WEB_TPM_SP_PROMODOCUMENT_WEEKLYSPLIT_001(
                    string cUSTLEV, 
                    string cUSTOMER, 
                    string mECHANICS, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string sELLOUTSTARTDATE, 
                    string sELLOUTENDDATE, 
                    string dESCRIPTION, 
                    string dESCRIPTION2, 
                    string fAM, 
                    string fAMILYROW, 
                    string cOLUMNVALUES, 
                    string cOLUMNVALUES2, 
                    string cOLUMNVALUES3, 
                    string w1, 
                    string w2, 
                    string qTYESTIMATED_VALUE, 
                    string cUSTOMER2, 
                    string pERIOD, 
                    string dEFW1, 
                    string dEFW2, 
                    string pRODS, 
                    string pRODS2, 
                    string wPRODS, 
                    string wPRODS2, 
                    string qTYESTIMATED_VAL_PRODS, 
                    string qTYESTIMATED_VAL_PRODS2, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_437999",
                    "PROMO_Nightly",
                    "PromoActions"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CUSTLEV", cUSTLEV);
            argumentsOfScenario.Add("CUSTOMER", cUSTOMER);
            argumentsOfScenario.Add("MECHANICS", mECHANICS);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLOUTSTARTDATE", sELLOUTSTARTDATE);
            argumentsOfScenario.Add("SELLOUTENDDATE", sELLOUTENDDATE);
            argumentsOfScenario.Add("DESCRIPTION", dESCRIPTION);
            argumentsOfScenario.Add("DESCRIPTION2", dESCRIPTION2);
            argumentsOfScenario.Add("FAM", fAM);
            argumentsOfScenario.Add("FAMILYROW", fAMILYROW);
            argumentsOfScenario.Add("COLUMNVALUES", cOLUMNVALUES);
            argumentsOfScenario.Add("COLUMNVALUES2", cOLUMNVALUES2);
            argumentsOfScenario.Add("COLUMNVALUES3", cOLUMNVALUES3);
            argumentsOfScenario.Add("W1", w1);
            argumentsOfScenario.Add("W2", w2);
            argumentsOfScenario.Add("QTYESTIMATED_VALUE", qTYESTIMATED_VALUE);
            argumentsOfScenario.Add("CUSTOMER2", cUSTOMER2);
            argumentsOfScenario.Add("PERIOD", pERIOD);
            argumentsOfScenario.Add("DEFW1", dEFW1);
            argumentsOfScenario.Add("DEFW2", dEFW2);
            argumentsOfScenario.Add("PRODS", pRODS);
            argumentsOfScenario.Add("PRODS2", pRODS2);
            argumentsOfScenario.Add("WPRODS", wPRODS);
            argumentsOfScenario.Add("WPRODS2", wPRODS2);
            argumentsOfScenario.Add("QTYESTIMATED_VAL_PRODS", qTYESTIMATED_VAL_PRODS);
            argumentsOfScenario.Add("QTYESTIMATED_VAL_PRODS2", qTYESTIMATED_VAL_PRODS2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_PROMODOCUMENT_WEEKLYSPLIT_001", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, cUSTOMER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCRIPTION, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user adds a product \'Family\' \'{0}\'", fAM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user clicks on \'Top Tab\' with value \'Weekly Split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox Containing\' with value \'{0}\'", fAMILYROW), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.Then("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Prod" +
                        "uct -\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.And("the user validates that the \'Button Link\' with value \'Default Week Split Drivers\'" +
                        " is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("user validates that all product \'Weight\' for column \'W 1\' are set to \'{0}\'", cOLUMNVALUES), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When(string.Format("the user enters \'{0}\' on Weekly Split column name \'W 1\' for product code \'{1}\' an" +
                            "d row \'Weight\'", w1, fAMILYROW), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And(string.Format("the user enters \'{0}\' on Weekly Split column name \'W 2\' for product code \'{1}\' an" +
                            "d row \'Weight\'", w2, fAMILYROW), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then("user validates that all product \'Weight\' for column \'W 1\' are set to \'30.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
 testRunner.And("user validates that all product \'Weight\' for column \'W 2\' are set to \'70.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.When("the user clicks on \'Button Link\' with value \'Reset to default split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.And("the user clicks on the \'Alert Dialog No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("user validates that all product \'Weight\' for column \'W 1\' are set to \'30.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.And("user validates that all product \'Weight\' for column \'W 2\' are set to \'70.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("the user clicks on \'Button Link\' with value \'Reset to default split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.And("the user clicks on the \'Alert Dialog Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.Then("user validates that all product \'Weight\' for column \'W 1\' are set to \'50.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.And("user validates that all product \'Weight\' for column \'W 2\' are set to \'50.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.When("the user clicks on \'Top Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'Estimated quantity\' for product code \'{1}\'", qTYESTIMATED_VALUE, fAM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks on \'Top Tab\' with value \'Weekly Split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.Then(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 1\' is set to \'500.000\'", fAM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.And(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 2\' is set to \'500.000\'", fAM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.When("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
 testRunner.And("the user navigates to the \'Default Week Split Driver\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And(string.Format("the user filters the column by column name \'Code\', \'Like\', \'{0}\'", cUSTOMER2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user opens the grid item in row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user enters \'40\' on Weekly Split driver for promo week row \'W1\' and promo wee" +
                        "k column \'2 Weeks\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("the user enters \'60\' on Weekly Split driver for promo week row \'W2\' and promo wee" +
                        "k column \'2 Weeks\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, cUSTOMER2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCRIPTION2, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And(string.Format("the user adds a product \'Family\' \'{0}\'", fAM), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user clicks on \'Top Tab\' with value \'Weekly Split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox Containing\' with value \'{0}\'", fAMILYROW), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.Then("the user validates that the \'Unchecked Grid CheckBox Containing\' with value \'Prod" +
                        "uct -\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.And("the user validates that the \'Button Link\' with value \'Default Week Split Drivers\'" +
                        " is enabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And(string.Format("user validates that all product \'Weight\' for column \'W 1\' are set to \'{0}\'", dEFW1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And(string.Format("user validates that all product \'Weight\' for column \'W 2\' are set to \'{0}\'", dEFW2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 79
 testRunner.When("the user clicks on \'Button Link\' with value \'Default Week Split Drivers\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 81
 testRunner.Then("the user validates that the \'Text in Grid\' with value \'Promo week\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.And("the user validate that Weekly Split driver for promo week row \'W2\' and promo week" +
                        " column \'2 Weeks\' is \'60.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And("the user validate that Weekly Split driver for promo week row \'W1\' and promo week" +
                        " column \'2 Weeks\' is \'40.000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 89
 testRunner.And(string.Format("the user enters \'<WPRODS1>\' on Weekly Split column name \'W 1\' for product code \'{" +
                            "0}\' and row \'Weight\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("the user enters \'{0}\' on Weekly Split column name \'W 2\' for product code \'{1}\' an" +
                            "d row \'Weight\'", wPRODS2, pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.And(string.Format("the user enters \'<WPRODS1>\' on Weekly Split column name \'W 1\' for product code \'{" +
                            "0}\' and row \'Weight\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 92
 testRunner.And(string.Format("the user enters \'{0}\' on Weekly Split column name \'W 2\' for product code \'{1}\' an" +
                            "d row \'Weight\'", wPRODS2, pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And("the user clicks on \'Top Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 95
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'Estimated quantity\' for product code \'{1}\'", qTYESTIMATED_VAL_PRODS, pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.And(string.Format("the user enters \'{0}\' on column name \'Estimated quantity\' for product code \'{1}\'", qTYESTIMATED_VAL_PRODS2, pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.And("the user clicks on \'Top Tab\' with value \'Weekly Split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 100
 testRunner.Then(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 1\' is set to \'33.333\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 101
 testRunner.And(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 2\' is set to \'66.667\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 103
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox Containing\' with value \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 105
 testRunner.When("the user clicks on \'Button Link\' with value \'Reset to default split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 106
 testRunner.And("the user clicks on the \'Alert Dialog No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 1\' is set to \'33.333\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.And(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 2\' is set to \'66.667\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.When("the user clicks on \'Button Link\' with value \'Reset to default split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 111
 testRunner.And("the user clicks on the \'Alert Dialog Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.Then(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 1\' is set to \'40.000\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 114
 testRunner.And(string.Format("user validates that product code \'{0}\' with row \'Estimated quantity\' for column \'" +
                            "W 2\' is set to \'60.000\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.And("the user clicks on \'Top Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 117
 testRunner.And("the user clicks on \'Grid CheckBox Containing\' with value \'01 - ITALIAN WHITE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 118
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox Containing\' with value \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.And("the user clicks on the \'Remove Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.And("the user clicks on the \'Alert Dialog Ok Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And("the user clicks on \'Top Tab\' with value \'Weekly Split\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 124
 testRunner.Then(string.Format("the user validates that the \'Text Containing\' with value \'Product - {0}\' is not p" +
                            "resent", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.When("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
