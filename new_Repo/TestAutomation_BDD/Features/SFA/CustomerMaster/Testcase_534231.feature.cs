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
namespace Kantar_BDD.Features.SFA.CustomerMaster
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_534231")]
    public partial class TestCase_534231Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "Testcase_534231.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/CustomerMaster", "TestCase_534231", "\tTestcase_534231", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_MD_CUST_UI_005_VALIDATE_VAT")]
        [NUnit.Framework.CategoryAttribute("BDD_534231")]
        [NUnit.Framework.CategoryAttribute("SFA_Weekly")]
        [NUnit.Framework.TestCaseAttribute("Customer Master", "New customer", "Bill-to customer", "ITALY", "1566", "Error VAT CODE", "01299511210", "VAT/TAX code already exists.", "Bill-to and Ship-to", "Error VAT CODE", "Bill-to, Ship-to and POS", "Replace an existing", "Activate on the current division", "00067920389", "Continue?", null)]
        public virtual void WEB_SFA_MD_CUST_UI_005_VALIDATE_VAT(
                    string navigator, 
                    string customerAction1, 
                    string bILL_TO, 
                    string nATION, 
                    string vATCODE_CHECK, 
                    string mSG_CHECK_ERR, 
                    string vATCODE_DUPLICATE, 
                    string mSG_DUPLICATE_ERROR, 
                    string bILL_TO_SHIP_TO, 
                    string mSG_CHECK_WARN_1, 
                    string bILL_TO_SHIP_TO_POS, 
                    string rEPLACE_CUST, 
                    string aCTIVATE_CUST, 
                    string vATCODE_OTHERDIV, 
                    string mSG_CHECK_WARN_2, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_534231",
                    "SFA_Weekly"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("navigator", navigator);
            argumentsOfScenario.Add("CustomerAction1", customerAction1);
            argumentsOfScenario.Add("BILL_TO", bILL_TO);
            argumentsOfScenario.Add("NATION", nATION);
            argumentsOfScenario.Add("VATCODE_CHECK", vATCODE_CHECK);
            argumentsOfScenario.Add("MSG_CHECK_ERR", mSG_CHECK_ERR);
            argumentsOfScenario.Add("VATCODE_DUPLICATE", vATCODE_DUPLICATE);
            argumentsOfScenario.Add("MSG_DUPLICATE_ERROR", mSG_DUPLICATE_ERROR);
            argumentsOfScenario.Add("BILL_TO_SHIP_TO", bILL_TO_SHIP_TO);
            argumentsOfScenario.Add("MSG_CHECK_WARN_1", mSG_CHECK_WARN_1);
            argumentsOfScenario.Add("BILL_TO_SHIP_TO_POS", bILL_TO_SHIP_TO_POS);
            argumentsOfScenario.Add("REPLACE_CUST", rEPLACE_CUST);
            argumentsOfScenario.Add("ACTIVATE_CUST", aCTIVATE_CUST);
            argumentsOfScenario.Add("VATCODE_OTHERDIV", vATCODE_OTHERDIV);
            argumentsOfScenario.Add("MSG_CHECK_WARN_2", mSG_CHECK_WARN_2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_MD_CUST_UI_005_VALIDATE_VAT", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given(string.Format("the user navigates to the \'{0}\' page", navigator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("the user adds a new Customer Master where Action: \'{0}\', Customer Type: \'{1}\', Na" +
                            "tion: \'{2}\', VAT Code: \'{3}\'", customerAction1, bILL_TO, nATION, vATCODE_CHECK), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.Then(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is displayed", mSG_CHECK_ERR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 10
 testRunner.And("\'Popup Title\' is populated with \'Customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.When(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_DUPLICATE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.Then(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is not shown", mSG_CHECK_ERR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Customer Type\' is d" +
                        "isplayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.And("\'Popup Title\' is populated with \'Customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is displayed", mSG_DUPLICATE_ERROR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When("the user clicks on \'Generic Drop Down Trigger\' with value \'Customer Type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And(string.Format("the user select value \'{0}\' from dropdown list \'Generic Drop Down Trigger\'", bILL_TO_SHIP_TO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Nation\'", nATION), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_CHECK), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.Then("the user validates that the \'Alert Dialog Message Box\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.And(string.Format("the user validates that \'Alert Dialog Message Box\' text contains \'{0}\'", mSG_CHECK_WARN_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("the user validates that \'Alert Dialog Message Box\' text contains \'{0}\'", mSG_CHECK_WARN_2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.When("the user clicks on the \'Alert Dialog No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.Then("\'Popup Title\' is populated with \'Customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_DUPLICATE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is displayed", mSG_DUPLICATE_ERROR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 43
 testRunner.When("the user clicks on \'Generic Drop Down Trigger\' with value \'Customer Type\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And(string.Format("the user select value \'{0}\' from dropdown list \'Generic Drop Down Trigger\'", bILL_TO_SHIP_TO_POS), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Nation\'", nATION), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_CHECK), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 48
 testRunner.And("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.Then("the user validates that the \'Alert Dialog Message Box\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 50
 testRunner.And(string.Format("the user validates that \'Alert Dialog Message Box\' text contains \'{0}\'", mSG_CHECK_WARN_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And(string.Format("the user validates that \'Alert Dialog Message Box\' text contains \'{0}\'", mSG_CHECK_WARN_2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.When("the user clicks on the \'Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("the user validates that the \'Side Panel Tab\' with value \'Main Information\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.When("the user clicks on the \'Toolbar Close Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 59
 testRunner.And("the user clicks on the \'No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then(string.Format("the user is on the \'{0}\' page", navigator), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.When(string.Format("the user adds a new Customer and does not close the popup where Action: \'{0}\', Cu" +
                            "stomer Type: \'{1}\', Customer Position: 3", rEPLACE_CUST, bILL_TO), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 63
 testRunner.And(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Nation\'", nATION), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_CHECK), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is displayed", mSG_CHECK_ERR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("\'Popup Title\' is populated with \'Customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 71
 testRunner.When(string.Format("the user enters the characters \'{0}\' in field \'Input By Label Name\' with value \'V" +
                            "AT Code\'", vATCODE_DUPLICATE), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 72
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("the user clicks on \'Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.And(string.Format("the user validates that the \'Pop Up Error Message\' with value \'{0}\' is displayed", mSG_DUPLICATE_ERROR), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 75
 testRunner.And("\'Popup Title\' is populated with \'Customer\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.And("the user clicks on \'Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 78
 testRunner.When(string.Format("the user adds a new Customer where Action: \'{0}\', Customer Type: \'{1}\', Nation: \'" +
                            "{2}\', VAT Code: \'{3}\', Customer Position: 1", aCTIVATE_CUST, bILL_TO_SHIP_TO, nATION, vATCODE_OTHERDIV), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 79
 testRunner.Then("the user validates that the \'Side Panel Tab\' with value \'Main Information\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
