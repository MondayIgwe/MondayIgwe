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
    [NUnit.Framework.DescriptionAttribute("TestCase_458044")]
    public partial class TestCase_458044Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_458044.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoActions", "TestCase_458044", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_PROMOPLANDOCUMENT_DRAGDROP_PROMO_BORDERS_001")]
        [NUnit.Framework.CategoryAttribute("BDD_458044")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("PromoActions")]
        [NUnit.Framework.TestCaseAttribute("EC86165", "Holder Level", "Level 5", "458044 CAMPAIGN OUTSIDE", "458044 CAMPAIGN INSIDE", "458044 NATIONAL INSIDE CONFIRMED", "458044 NATIONAL INSIDE DRAFT", "458044 LOCAL INSIDE INAUTH", "2019", "2020", "01/06/2019", "01/06/2020", "15/06/2019", "15/06/2020", "TPR in %", "001", "002", "Product", "EC86163", "EC86316", "Level 3", "Level 2", "", "", null)]
        public virtual void WEB_TPM_SP_PROMOPLANDOCUMENT_DRAGDROP_PROMO_BORDERS_001(
                    string cUST, 
                    string cONFIRMATIONLEVHOLDER, 
                    string cUSTLEV, 
                    string dESCR_PROMO, 
                    string dESCR_PROMO2, 
                    string dESCR_PROMO3, 
                    string dESCR_PROMO4, 
                    string dESCR_PROMO5, 
                    string rEFYEAR, 
                    string rEFYEAR2, 
                    string sELLINSTART, 
                    string sELLINSTART2, 
                    string sELLINEND, 
                    string sELLINEND2, 
                    string mECHANICS, 
                    string pRODS, 
                    string pRODS2, 
                    string pRPDLEVEL, 
                    string pPHOLDER, 
                    string pPHOLDER2, 
                    string pPHOLDERLEV, 
                    string pPHOLDERLEV2, 
                    string sELLOUTSTARTDATE, 
                    string sELLOUTENDDATE, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_458044",
                    "PROMO_Nightly",
                    "PromoActions"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CUST", cUST);
            argumentsOfScenario.Add("CONFIRMATIONLEVHOLDER", cONFIRMATIONLEVHOLDER);
            argumentsOfScenario.Add("CUSTLEV", cUSTLEV);
            argumentsOfScenario.Add("DESCR_PROMO", dESCR_PROMO);
            argumentsOfScenario.Add("DESCR_PROMO2", dESCR_PROMO2);
            argumentsOfScenario.Add("DESCR_PROMO3", dESCR_PROMO3);
            argumentsOfScenario.Add("DESCR_PROMO4", dESCR_PROMO4);
            argumentsOfScenario.Add("DESCR_PROMO5", dESCR_PROMO5);
            argumentsOfScenario.Add("REFYEAR", rEFYEAR);
            argumentsOfScenario.Add("REFYEAR2", rEFYEAR2);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINSTART2", sELLINSTART2);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLINEND2", sELLINEND2);
            argumentsOfScenario.Add("MECHANICS", mECHANICS);
            argumentsOfScenario.Add("PRODS", pRODS);
            argumentsOfScenario.Add("PRODS2", pRODS2);
            argumentsOfScenario.Add("PRPDLEVEL", pRPDLEVEL);
            argumentsOfScenario.Add("PPHOLDER", pPHOLDER);
            argumentsOfScenario.Add("PPHOLDER2", pPHOLDER2);
            argumentsOfScenario.Add("PPHOLDERLEV", pPHOLDERLEV);
            argumentsOfScenario.Add("PPHOLDERLEV2", pPHOLDERLEV2);
            argumentsOfScenario.Add("SELLOUTSTARTDATE", sELLOUTSTARTDATE);
            argumentsOfScenario.Add("SELLOUTENDDATE", sELLOUTENDDATE);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_PROMOPLANDOCUMENT_DRAGDROP_PROMO_BORDERS_001", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, cUST), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCR_PROMO, sELLINSTART, sELLINEND, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\' until \'Active Side Panel" +
                        " Tab By Name\' with value \'Cockpit\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEV, cUST), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCR_PROMO2, sELLINSTART2, sELLINEND2, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user navigates to the \'Promo plan\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.Then("the user validates that the \'First Row\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.When(string.Format("the user filters the column by column name \'Customer Code\', \'Like\', \'{0}\'", pPHOLDER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And(string.Format("the user filters the column by column name \'Year of Reference\', \'Equal\', \'{0}\'", rEFYEAR2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", pPHOLDERLEV, pPHOLDER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 39
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCR_PROMO3, sELLINSTART2, sELLINEND2, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the user changes the status to \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", pPHOLDERLEV, pPHOLDER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 51
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCR_PROMO4, sELLINSTART2, sELLINEND2, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", pPHOLDERLEV2, pPHOLDER2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCR_PROMO5, sELLINSTART2, sELLINEND2, sELLOUTSTARTDATE, sELLOUTENDDATE, mECHANICS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action Id\'" +
                        " and saves it as \'ActionId1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("the user adds a product \'Product\' \'{0}\'", pRODS2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the user changes the status to \'To be authorized\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 68
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.And("the user navigates to the \'Promo plan\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("the user validates that the \'First Row\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.When(string.Format("the user filters the column by column name \'Customer Code\', \'Like\', \'{0}\'", pPHOLDER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 75
 testRunner.And(string.Format("the user filters the column by column name \'Year of Reference\', \'Equal\', \'{0}\'", rEFYEAR2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.Then("the user validates that the \'Loading Mask\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.When("the user clicks on \'Zoom Out Button\' until \'Year Quarter\' with value \'Q3\' and val" +
                        "ue \'1\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 80
 testRunner.Then(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "not present", dESCR_PROMO2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 82
 testRunner.And(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "not present", dESCR_PROMO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 84
 testRunner.And(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "present", dESCR_PROMO3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 86
 testRunner.When(string.Format("the user hovers over \'Calendar Promo Plan\' with value \'{0}\' until element \'Input " +
                            "By Label Name No Colon\' with \'Sell In End\' value is present", dESCR_PROMO3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 87
 testRunner.And("the user retrieves text from element \'Input By Label Name No Colon\' with value \'S" +
                        "ell In End\' and saves it as \'SellInEnd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 88
 testRunner.And(string.Format("the user drags promo \'{0}\' to year \'2020\' and quarter \'Q3\'", dESCR_PROMO3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 89
 testRunner.And(string.Format("the user hovers over \'Calendar Promo Plan\' with value \'{0}\' until element \'Input " +
                            "By Label Name No Colon\' with \'Sell In End\' value is present", dESCR_PROMO3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.Then("the user validates that \'Input By Label Name No Colon\' with value \'Sell In End\' h" +
                        "as text \'SellInEnd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 92
 testRunner.And(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "present", dESCR_PROMO4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 94
 testRunner.When(string.Format("the user drags promo \'{0}\' to year \'2020\' and quarter \'Q3\' until element \'Text\' w" +
                            "ith value \'Save changes?\' is present", dESCR_PROMO4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 95
 testRunner.Then("the user validates that the \'Text\' with value \'Save changes?\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 97
 testRunner.When(string.Format("the user double clicks on \'Calendar Promo Plan\' with value \'{0}\'", dESCR_PROMO4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 98
 testRunner.Then("the user validates that the element \'Alert Dialog Message Box\' has text \'Do you w" +
                        "ant to save the changes?\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 100
 testRunner.When("the user clicks on the \'Alert Dialog Cancel Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 101
 testRunner.Then("the user validates that the \'Text\' with value \'Save changes?\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.When("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 105
 testRunner.Then("the user validates that the \'Text\' with value \'Save changes?\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 107
 testRunner.And(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.And("the user validates that the \'Loading Mask\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 110
 testRunner.And(string.Format("the user validates that the \'Calendar Promo Plan\' with value \'{0}\' is present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 111
 testRunner.When(string.Format("the user hovers over \'Calendar Promo Plan\' with value \'{0}\' until element \'Input " +
                            "By Label Name No Colon\' with \'Sell In End\' value is present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 112
 testRunner.And("the user retrieves text from element \'Input By Label Name No Colon\' with value \'S" +
                        "ell In End\' and saves it as \'PROMO5SellInEnd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.And(string.Format("the user drags promo \'{0}\' to year \'2020\' and quarter \'Q3\' until element \'Text\' w" +
                            "ith value \'Save changes?\' is present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 115
 testRunner.Then("the user validates that the \'Text\' with value \'Save changes?\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.When(string.Format("the user double clicks on \'Calendar Promo Plan\' with value \'{0}\' until element \'A" +
                            "lert Dialog No Button\' is present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 119
 testRunner.And("the user clicks on the \'Alert Dialog No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 120
 testRunner.Then("the user validates that the \'Description\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 121
 testRunner.And("the user validates that the element \'Sell In End Date\' has text \'PROMO5SellInEnd\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.And("the user validates that the \'Text\' with value \'Save changes?\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 123
 testRunner.When("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 124
 testRunner.Then("the user validates that the \'Loading Mask\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 126
 testRunner.And(string.Format("the user validates that the \'Expandable Calendar Promo Plan\' with value \'{0}\' is " +
                            "present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 128
 testRunner.When(string.Format("the user drags promo \'{0}\' to year \'2020\' and quarter \'Q3\' until element \'Text\' w" +
                            "ith value \'Save changes?\' is present", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 129
 testRunner.Then("the user validates that the \'Text\' with value \'Save changes?\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 130
 testRunner.When(string.Format("the user double clicks on \'Calendar Promo Plan\' with value \'{0}\'", dESCR_PROMO5), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 132
 testRunner.And("the user clicks on the \'Alert Dialog Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 134
 testRunner.Then("the user validates that the \'Description\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 135
 testRunner.And("the user validates that the value \'Sell In End Date\' is not equal to \'SellInEnd\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.And("the user validates that the \'Text\' with value \'Save changes?\' is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
