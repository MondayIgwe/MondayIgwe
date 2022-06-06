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
namespace Kantar_BDD.Features.TPM.PromoPlan
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_614800")]
    public partial class TestCase_614800Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_614800.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoPlan", "TestCase_614800", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_PROMOACTION_PREVENT_EDIT_NONRESPONSIBLE_USER_US592949_AC2_ON_004")]
        [NUnit.Framework.CategoryAttribute("BDD_614800")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("applicationbug")]
        [NUnit.Framework.CategoryAttribute("PromoPlan")]
        [NUnit.Framework.TestCaseAttribute("XTEL AUTOMATION 3 - Global Group SM1V4", "EC91604", "x/x/y", "Family", "ITALIAN WHITE", "ITALIAN RED", "\" - None\"", "Scen1_US592949", "Scen2_US592949", "Holder Level", "Level 3", "ITALIAN WHITE", "ITALIAN RED", "US592949_001_REST", "10/10/y", "29/10/y", "10/10/y", "29/10/y", "Trade Price Reduction (%)", "Product", "002", "023", "024", "", null)]
        public virtual void WEB_TPM_SP_PROMOACTION_PREVENT_EDIT_NONRESPONSIBLE_USER_US592949_AC2_ON_004(
                    string dIVISION, 
                    string cUSTOMER, 
                    string rEFYEAR, 
                    string pRODLEVEL, 
                    string pRODDESC1, 
                    string pRODDESC2, 
                    string sOURCESCEN, 
                    string sCENDESC1, 
                    string sCENDESC2, 
                    string cONFLEVEL, 
                    string cUSTLEVEL, 
                    string pRODSEGMENT1, 
                    string pRODSEGMENT2, 
                    string dESCPROMO, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string sELLOUTSTART, 
                    string sELLOUTEND, 
                    string mECH, 
                    string pRODLVL, 
                    string pRODCODE1, 
                    string pRODCODE2, 
                    string pRODCODE3, 
                    string pROMOACID, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_614800",
                    "PROMO_Nightly",
                    "applicationbug",
                    "PromoPlan"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DIVISION", dIVISION);
            argumentsOfScenario.Add("CUSTOMER", cUSTOMER);
            argumentsOfScenario.Add("REFYEAR", rEFYEAR);
            argumentsOfScenario.Add("PRODLEVEL", pRODLEVEL);
            argumentsOfScenario.Add("PRODDESC1", pRODDESC1);
            argumentsOfScenario.Add("PRODDESC2", pRODDESC2);
            argumentsOfScenario.Add("SOURCESCEN", sOURCESCEN);
            argumentsOfScenario.Add("SCENDESC1", sCENDESC1);
            argumentsOfScenario.Add("SCENDESC2", sCENDESC2);
            argumentsOfScenario.Add("CONFLEVEL", cONFLEVEL);
            argumentsOfScenario.Add("CUSTLEVEL", cUSTLEVEL);
            argumentsOfScenario.Add("PRODSEGMENT1", pRODSEGMENT1);
            argumentsOfScenario.Add("PRODSEGMENT2", pRODSEGMENT2);
            argumentsOfScenario.Add("DESCPROMO", dESCPROMO);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLOUTSTART", sELLOUTSTART);
            argumentsOfScenario.Add("SELLOUTEND", sELLOUTEND);
            argumentsOfScenario.Add("MECH", mECH);
            argumentsOfScenario.Add("PRODLVL", pRODLVL);
            argumentsOfScenario.Add("PRODCODE1", pRODCODE1);
            argumentsOfScenario.Add("PRODCODE2", pRODCODE2);
            argumentsOfScenario.Add("PRODCODE3", pRODCODE3);
            argumentsOfScenario.Add("PROMOACID", pROMOACID);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_PROMOACTION_PREVENT_EDIT_NONRESPONSIBLE_USER_US592949_AC2_ON_004", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given(string.Format("the user has logged in with division \'{0}\'", dIVISION), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When("the user navigates to the \'Promo plan\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("the user validates that the \'First Row\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.When(string.Format("the user filters the column by column name \'Customer Code\', \'Like\', \'{0}\'", cUSTOMER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And(string.Format("the user filters the column by column name \'Year of Reference\', \'Equal\', \'{0}\'", rEFYEAR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the user clicks on \'Text\' with value \'{0}\'", cUSTOMER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on the \'Segment Responsibility\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And(string.Format("the user select value \'{0}\' from dropdown list \'Product Level\'", pRODLEVEL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And(string.Format("the user assigns segments to user in responsibility matrix \'{0}\'", pRODDESC2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user clicks on the Promo Action \'Add New Scenario\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And(string.Format("the user enter text \'{0}\' on the field with label \'Scenario Description\'", sCENDESC1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user clicks on the Promo Action \'Add New Scenario\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user enter text \'{0}\' on the field with label \'Scenario Description\'", sCENDESC2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("the user creates a Promo \'{0}\' \'{1}\'", cUSTLEVEL, cUSTOMER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCPROMO, sELLINSTART, sELLINEND, sELLOUTSTART, sELLOUTEND, mECH), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user clicks on \'Button\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user clicks on \'Generic Drop Down Trigger\' with value \'PRODUCT SEGMENT\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And(string.Format("the user clicks on \'Selection Popup Checkbox\' with value \'{0}\'", pRODSEGMENT1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And(string.Format("the user clicks on \'Selection Popup Checkbox\' with value \'{0}\'", pRODSEGMENT2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", pRODLVL, pRODCODE1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks on the \'Segment Responsibility\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And(string.Format("the user select value \'{0}\' from dropdown list \'Product Level\'", pRODLEVEL), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the user assigns segments to user in responsibility matrix \'{0}\'", pRODDESC1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.And("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user clicks on the \'Filter Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.And(string.Format("the user selects active scenario \'{0}\' from dropdown list \'Active Scenario\'", sCENDESC2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user clicks on \'Button\' with value \'Apply\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.Then(string.Format("the user validates that the \'Calendar Promo Plan\' with value \'{0}\' is present", dESCPROMO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.When(string.Format("the user clicks on Calendar Promo Plan with value \'{0}\'", dESCPROMO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 67
 testRunner.And("the user clicks on the Promo Action \'Scenario re-assignment\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And(string.Format("the user clicks on \'Selection Popup Checkbox Contains\' with value \'{0}\'", sCENDESC1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And(string.Format("the user clicks on \'Selection Popup Checkbox Contains\' with value \'{0}\'", sCENDESC2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
