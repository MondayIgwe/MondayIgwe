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
    [NUnit.Framework.DescriptionAttribute("TestCase_428343")]
    public partial class TestCase_428343Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_428343.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoActions", "TestCase_428343", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_PROMODOCUMENT_SINGLECOPY_001")]
        [NUnit.Framework.CategoryAttribute("BDD_428343")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("PromoActions")]
        [NUnit.Framework.TestCaseAttribute("", "EC86170", "Promo 001", "Level 5", "Level 5", "Holder Level", "Original promo Description", "New changed promo description", "Draft", "03/03/y", "15/03/y", "04/03/y", "16/03/y", "TPR in %,Leaflet", "Product", "030", "031", "Copy of Original promo Description", null)]
        public virtual void WEB_TPM_SP_PROMODOCUMENT_SINGLECOPY_001(
                    string dIVISION, 
                    string hOLDER, 
                    string hOLDERDESCR, 
                    string hOLDERLEVEL, 
                    string cOVERAGE, 
                    string cONFIRMATIONLEVEL, 
                    string dESCRIPTION, 
                    string nEW_CHANGED_PROMO_DESCRIPTIONS, 
                    string wFSTATUS, 
                    string sELLINSTART, 
                    string sELLINEND, 
                    string sELLOUTSTART, 
                    string sELLOUTEND, 
                    string mECH, 
                    string pRODLEV, 
                    string pROD, 
                    string pROD2, 
                    string nEWDESCRIPTIONVALUE, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_428343",
                    "PROMO_Nightly",
                    "PromoActions"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DIVISION", dIVISION);
            argumentsOfScenario.Add("HOLDER", hOLDER);
            argumentsOfScenario.Add("HOLDERDESCR", hOLDERDESCR);
            argumentsOfScenario.Add("HOLDERLEVEL", hOLDERLEVEL);
            argumentsOfScenario.Add("COVERAGE", cOVERAGE);
            argumentsOfScenario.Add("CONFIRMATIONLEVEL", cONFIRMATIONLEVEL);
            argumentsOfScenario.Add("DESCRIPTION", dESCRIPTION);
            argumentsOfScenario.Add("NEW_CHANGED_PROMO_DESCRIPTIONS", nEW_CHANGED_PROMO_DESCRIPTIONS);
            argumentsOfScenario.Add("WFSTATUS", wFSTATUS);
            argumentsOfScenario.Add("SELLINSTART", sELLINSTART);
            argumentsOfScenario.Add("SELLINEND", sELLINEND);
            argumentsOfScenario.Add("SELLOUTSTART", sELLOUTSTART);
            argumentsOfScenario.Add("SELLOUTEND", sELLOUTEND);
            argumentsOfScenario.Add("MECH", mECH);
            argumentsOfScenario.Add("PRODLEV", pRODLEV);
            argumentsOfScenario.Add("PROD", pROD);
            argumentsOfScenario.Add("PROD2", pROD2);
            argumentsOfScenario.Add("NEWDESCRIPTIONVALUE", nEWDESCRIPTIONVALUE);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_PROMODOCUMENT_SINGLECOPY_001", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", hOLDERLEVEL, hOLDER), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\' \'{5}\'", dESCRIPTION, sELLINSTART, sELLINEND, sELLOUTSTART, sELLOUTEND, mECH), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", pRODLEV, pROD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("the user adds a product \'{0}\' \'{1}\'", pRODLEV, pROD2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user clicks on \'Button\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And(string.Format("the user enter text \'{0}\' on the field with label \'Description\'", nEW_CHANGED_PROMO_DESCRIPTIONS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user clicks on \'Button\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.And("the user clicks on the \'Remove Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.And("the user clicks on the \'Alert Dialog Ok Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 19
 testRunner.And("the user clicks on the \'Promo Copy Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Copy Promotion\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And("the user clicks on \'Button\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then(string.Format("\'Description\' is populated with \'{0}\'", nEWDESCRIPTIONVALUE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("the user clicks on \'Button\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.Then(string.Format("the user validates that the \'Product Grid Cell Contains\' with value \'{0}\' is pres" +
                            "ent", pROD), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
 testRunner.And(string.Format("the user validates that the \'Product Grid Cell Contains\' with value \'{0}\' is pres" +
                            "ent", pROD2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on the \'Save Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.Then("the user validates that the \'Button\' with value \'Cockpit\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
