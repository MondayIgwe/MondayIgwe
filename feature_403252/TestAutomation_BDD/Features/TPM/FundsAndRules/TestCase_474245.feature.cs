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
namespace Kantar_BDD.Features.TPM.FundsAndRules
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_474245")]
    public partial class TestCase_474245Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_474245.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/FundsAndRules", "TestCase_474245", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_FRDOCUMENT_RATEBASEDFUND_CALCULATE_SOME_CONSTRAINTS_001")]
        [NUnit.Framework.CategoryAttribute("BDD_474245")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("FundsAndRules")]
        [NUnit.Framework.TestCaseAttribute("Rate Based Fund", "01/01/2020", "31/10/2020", "5 - Level 5", "", "EC86162", "SOURCE1 - NETAMOUNT", "01/01/2020", "31/08/2020", "10", "01/09/2020", "31/10/2020", "20", "Deposit", "Funds & Rules", "", null)]
        public virtual void WEB_TPM_SP_FRDOCUMENT_RATEBASEDFUND_CALCULATE_SOME_CONSTRAINTS_001(
                    string cONFIGURATIONID, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string cUSTOMERLEVEL, 
                    string sELECTCUSTOMERNODES, 
                    string cUST, 
                    string rATEFUNDSOURCE, 
                    string sTARTDATE1, 
                    string eNDDATE1, 
                    string iNITIALRATEFUND1, 
                    string sTARTDATE2, 
                    string eNDDATE2, 
                    string iNITIALRATEFUND2, 
                    string tYPEOFMOVEMENT, 
                    string pAGEDESCRIPTION, 
                    string pRODUCT_GROUPS, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_474245",
                    "PROMO_Nightly",
                    "FundsAndRules"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CONFIGURATIONID", cONFIGURATIONID);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("CUSTOMERLEVEL", cUSTOMERLEVEL);
            argumentsOfScenario.Add("SELECTCUSTOMERNODES", sELECTCUSTOMERNODES);
            argumentsOfScenario.Add("CUST", cUST);
            argumentsOfScenario.Add("RATEFUNDSOURCE", rATEFUNDSOURCE);
            argumentsOfScenario.Add("STARTDATE1", sTARTDATE1);
            argumentsOfScenario.Add("ENDDATE1", eNDDATE1);
            argumentsOfScenario.Add("INITIALRATEFUND1", iNITIALRATEFUND1);
            argumentsOfScenario.Add("STARTDATE2", sTARTDATE2);
            argumentsOfScenario.Add("ENDDATE2", eNDDATE2);
            argumentsOfScenario.Add("INITIALRATEFUND2", iNITIALRATEFUND2);
            argumentsOfScenario.Add("TYPEOFMOVEMENT", tYPEOFMOVEMENT);
            argumentsOfScenario.Add("PAGEDESCRIPTION", pAGEDESCRIPTION);
            argumentsOfScenario.Add("PRODUCT_GROUPS", pRODUCT_GROUPS);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_FRDOCUMENT_RATEBASEDFUND_CALCULATE_SOME_CONSTRAINTS_001", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'Funds & Rules\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 7
 testRunner.When(string.Format("the user creates a new fund and rules \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\' \'{6}\'", cONFIGURATIONID, cUSTOMERLEVEL, pAGEDESCRIPTION, sELLINSTART, sELLINEND, pRODUCT_GROUPS, rATEFUNDSOURCE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And(string.Format("user adds a \'% Rate Fund\' constraint with value \'{0}\' \'{1}\' \'{2}\' \'\'", iNITIALRATEFUND1, sTARTDATE1, eNDDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("user adds a \'% Rate Fund\' constraint with value \'{0}\' \'{1}\' \'{2}\' \'\'", iNITIALRATEFUND2, sTARTDATE2, eNDDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Funds & Ru" +
                        "les code\' and saves it as \'FundsRulesCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user clicks on \'Text\' with value \'FundsRulesCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then(string.Format("the user validates that column \'Fund Source Value\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'10.00\' with row text \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'0.0000\' with row text \'" +
                            "{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("the user validates that column \'Fund Source Value\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'20.00\' with row text \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'0.0000\' with row text \'" +
                            "{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And(string.Format("the user clicks on \'Div Text in Grid\' with value \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user clicks on \'Button Link\' with value \'Calculate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.Then(string.Format("the user validates that column \'Fund Source Value\' has \'8,000.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'10.00\' with row text \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'800.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'800.0000\' with row text \'" +
                            "{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And(string.Format("the user validates that column \'Fund Source Value\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'20.00\' with row text \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'0.0000\' with row text \'" +
                            "{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.When("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Text\' with value \'FundsRulesCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then(string.Format("the user validates that column \'Fund Source Value\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'10.00\' with row text \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'0.0000\' with row text \'" +
                            "{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And(string.Format("the user validates that column \'Fund Source Value\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'20.00\' with row text \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'0.0000\' with row text \'" +
                            "{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'0.0000\' with row text \'{0" +
                            "}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.When("the user clicks on \'Select Indexed Row\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.And("the user clicks on \'Select Indexed Row\' with value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user clicks on \'Button Link\' with value \'Calculate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.Then(string.Format("the user validates that column \'Fund Source Value\' has \'8,000.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 71
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'10.00\' with row text \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'800.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'800.0000\' with row text \'" +
                            "{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And(string.Format("the user validates that column \'Fund Source Value\' has \'2,000.0000\' with row text" +
                            " \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'20.00\' with row text \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 77
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'400.0000\' with row text" +
                            " \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'400.0000\' with row text \'" +
                            "{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 80
 testRunner.When("the user clicks on \'Funds Folder Icon By Row\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 82
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Remaining balance\' has " +
                        "text \'800.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Uncommitted Balance\' ha" +
                        "s text \'800.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
  testRunner.And("the user validates that \'Input By Label Name\' with value \'Fund reserve\' has text " +
                        "\'0.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.And(string.Format("the user validates that popup \'Movements\' column \'Value\' has \'800.0000\' with row " +
                            "text \'{0}\'", tYPEOFMOVEMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.When("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 90
 testRunner.And("the user clicks on \'Funds Folder Icon By Row\' with value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 91
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Remaining balance\' has " +
                        "text \'400.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Uncommitted Balance\' ha" +
                        "s text \'400.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
  testRunner.And("the user validates that \'Input By Label Name\' with value \'Fund reserve\' has text " +
                        "\'0.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.And(string.Format("the user validates that popup \'Movements\' column \'Value\' has \'400.0000\' with row " +
                            "text \'{0}\'", tYPEOFMOVEMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 96
 testRunner.When("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 99
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 101
 testRunner.And("the user clicks on the \'Refresh Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.And("the user clicks on \'Text\' with value \'FundsRulesCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 104
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 106
 testRunner.Then(string.Format("the user validates that column \'Fund Source Value\' has \'8,000.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'10.00\' with row text \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 108
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'800.0000\' with row text" +
                            " \'{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'800.0000\' with row text \'" +
                            "{0}\'", sTARTDATE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.And(string.Format("the user validates that column \'Fund Source Value\' has \'2,000.0000\' with row text" +
                            " \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 112
 testRunner.And(string.Format("the user validates that column \'% Rate Fund\' has \'20.00\' with row text \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And(string.Format("the user validates that column \'Uncommitted Balance\' has \'400.0000\' with row text" +
                            " \'{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 114
 testRunner.And(string.Format("the user validates that column \'Remaining balance\' has \'400.0000\' with row text \'" +
                            "{0}\'", sTARTDATE2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 116
 testRunner.When("the user clicks on \'Funds Folder Icon By Row\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 118
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Remaining balance\' has " +
                        "text \'800.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 119
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Uncommitted Balance\' ha" +
                        "s text \'800.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
  testRunner.And("the user validates that \'Input By Label Name\' with value \'Fund reserve\' has text " +
                        "\'0.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 121
 testRunner.And(string.Format("the user validates that popup \'Movements\' column \'Value\' has \'800.0000\' with row " +
                            "text \'{0}\'", tYPEOFMOVEMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.When("the user clicks on \'Popup Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 125
 testRunner.And("the user clicks on \'Funds Folder Icon By Row\' with value \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 127
 testRunner.Then("the user validates that \'Input By Label Name\' with value \'Remaining balance\' has " +
                        "text \'400.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 128
 testRunner.And("the user validates that \'Input By Label Name\' with value \'Uncommitted Balance\' ha" +
                        "s text \'400.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 129
  testRunner.And("the user validates that \'Input By Label Name\' with value \'Fund reserve\' has text " +
                        "\'0.0000\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.And(string.Format("the user validates that popup \'Movements\' column \'Value\' has \'400.0000\' with row " +
                            "text \'{0}\'", tYPEOFMOVEMENT), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 132
 testRunner.When("the user clicks on \'Popup Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 133
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 134
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
