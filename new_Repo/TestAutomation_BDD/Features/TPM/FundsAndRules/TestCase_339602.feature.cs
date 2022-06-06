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
    [NUnit.Framework.DescriptionAttribute("TestCase_339602")]
    public partial class TestCase_339602Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_339602.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/FundsAndRules", "TestCase_339602", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("TPM_FR_W_SMOKE_R81V1_0007 - F&R Product Selectors")]
        [NUnit.Framework.CategoryAttribute("BDD_339602")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("FundsAndRules")]
        [NUnit.Framework.TestCaseAttribute("16", "FOREIGN WINE", "CHOCOLATE BARS", "SWEET LIQUEURS", "VODKA", "FRENCH WINE", "MILK CHOC.", "NUT CHOC.", "WHITE VOD. 0.7 lt", "MINT VOD. 0.7 lt", "MIRENE BORDEAUX 0.75 lt", "MIRENE BEAUJOLAIS 0.75 lt", "BACIOCK MILK EXTRA 200 gr", "106_DELICE NUT EXTRA 100 gr", null)]
        public virtual void TPM_FR_W_SMOKE_R81V1_0007_FRProductSelectors(string fUND_1, string cAT_A, string cAT_B, string cAT_C, string fAM_C1, string fAM_A1, string fAM_B1, string fAM_B2, string sKU_C1, string sKU_C2, string sKU_A1, string sKU_A2, string sKU_B1, string sKU_B2, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_339602",
                    "PROMO_Nightly",
                    "FundsAndRules"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("FUND_1", fUND_1);
            argumentsOfScenario.Add("CAT_A", cAT_A);
            argumentsOfScenario.Add("CAT_B", cAT_B);
            argumentsOfScenario.Add("CAT_C", cAT_C);
            argumentsOfScenario.Add("FAM_C1", fAM_C1);
            argumentsOfScenario.Add("FAM_A1", fAM_A1);
            argumentsOfScenario.Add("FAM_B1", fAM_B1);
            argumentsOfScenario.Add("FAM_B2", fAM_B2);
            argumentsOfScenario.Add("SKU_C1", sKU_C1);
            argumentsOfScenario.Add("SKU_C2", sKU_C2);
            argumentsOfScenario.Add("SKU_A1", sKU_A1);
            argumentsOfScenario.Add("SKU_A2", sKU_A2);
            argumentsOfScenario.Add("SKU_B1", sKU_B1);
            argumentsOfScenario.Add("SKU_B2", sKU_B2);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TPM_FR_W_SMOKE_R81V1_0007 - F&R Product Selectors", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 8
 testRunner.When(string.Format("the user clicks on \'Text\' with value \'{0}\'", fUND_1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Product Groups\' has" +
                        " no text", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 12
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("the user validates that the \'Grid Unfiltered Column Filter\' with value \'Family\' i" +
                        "s present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.And("the user validates that the \'Grid Unfiltered Column Filter\' with value \'Product\' " +
                        "is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
 testRunner.When("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And("the user clicks on \'Generic Drop Down Trigger\' with value \'Product Groups\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
 testRunner.Then("the user validates that the \'Popup Grid Selected Rows\' with value \'Product level\'" +
                        " is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
 testRunner.When(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", cAT_A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", cAT_B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user opens the trigger on column \'Family\' and Row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", cAT_C), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", fAM_C1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is present", cAT_A), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is present", cAT_B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.When(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", fAM_A1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", fAM_B1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", fAM_B2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user opens the trigger on column \'Product\' and Row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.Then(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", sKU_C1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", sKU_C2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", sKU_A1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", sKU_A2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", sKU_B1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", sKU_B2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Summary\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Generic Drop Down Trigger\' with value \'Product Groups\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And(string.Format("the user clicks on \'Grid CheckBox\' with value \'{0}\'", cAT_B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.And("the user clicks on the \'Alert Dialog Ok Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Constraints\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.And("the user opens the trigger on column \'Family\' and Row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", fAM_B1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", fAM_B2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", cAT_B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", cAT_C), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 65
 testRunner.When("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.And("the user opens the trigger on column \'Product\' and Row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", sKU_B1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", sKU_B2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 69
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", cAT_B), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 70
 testRunner.And(string.Format("the user validates that the \'Grid CheckBox\' with value \'{0}\' is not present", cAT_C), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 72
 testRunner.And("the user clicks on \'Popup Button\' with value \'OK\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 74
 testRunner.When("the user clicks on the \'Alert Dialog No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
