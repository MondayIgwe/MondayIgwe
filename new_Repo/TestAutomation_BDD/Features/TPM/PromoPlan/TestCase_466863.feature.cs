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
    [NUnit.Framework.DescriptionAttribute("TestCase_466863")]
    public partial class TestCase_466863Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_466863.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoPlan", "TestCase_466863", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_SP_PROMOPLANDOCUMENT_SOURCE_SCENARIO_FIELD_POSSIBLE_LOV_RESTRICT_US434914" +
            "_AC1_002")]
        [NUnit.Framework.CategoryAttribute("BDD_466863")]
        [NUnit.Framework.CategoryAttribute("PROMO_Nightly")]
        [NUnit.Framework.CategoryAttribute("noSellOutDate")]
        [NUnit.Framework.CategoryAttribute("PromoPlan")]
        [NUnit.Framework.TestCaseAttribute("XTEL SFA AUTOMATION - Global Group SM1V4", "EC86177", "x/x/y", "Family", "RUM", "Scenario Alternative 1", "- None", null)]
        public virtual void WEB_TPM_SP_PROMOPLANDOCUMENT_SOURCE_SCENARIO_FIELD_POSSIBLE_LOV_RESTRICT_US434914_AC1_002(string dIVISION, string customer_Code, string year_Of_Reference, string product_Level_PPHolder, string description_0, string scenario_Description_AltScen1, string value, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_466863",
                    "PROMO_Nightly",
                    "noSellOutDate",
                    "PromoPlan"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DIVISION", dIVISION);
            argumentsOfScenario.Add("Customer_Code", customer_Code);
            argumentsOfScenario.Add("Year_Of_Reference", year_Of_Reference);
            argumentsOfScenario.Add("Product_Level_PPHolder", product_Level_PPHolder);
            argumentsOfScenario.Add("Description_0", description_0);
            argumentsOfScenario.Add("Scenario_Description_AltScen1", scenario_Description_AltScen1);
            argumentsOfScenario.Add("Value", value);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_SP_PROMOPLANDOCUMENT_SOURCE_SCENARIO_FIELD_POSSIBLE_LOV_RESTRICT_US434914" +
                    "_AC1_002", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When(string.Format("the user filters the column by column name \'Customer Code\', \'Like\', \'{0}\'", customer_Code), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.And(string.Format("the user filters the column by column name \'Year of Reference\', \'Equal\', \'{0}\'", year_Of_Reference), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And(string.Format("the user clicks on \'Text\' with value \'{0}\'", customer_Code), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on the \'Segment Responsibility\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("the user validates that the Loading Mask is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.And(string.Format("the user select value \'{0}\' from dropdown list \'Product Level\'", product_Level_PPHolder), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("the user assigns segments to user in responsibility matrix \'{0}\'", description_0), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user clicks on the \'Alert Dialog Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And("the user clicks on \'Indexed Row Link\' with value \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.Then("the user validates that the Loading Mask is not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.And("the user validates that the \'Button\' with value \'Edit\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.When("the user clicks on \'Button\' with value \'Edit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 36
 testRunner.And("the user clicks on the Promo Action \'Add New Scenario\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.And("the user retrieves the \'Generic Drop Down Selected Value\' text with value \'Source" +
                        " Scenario\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And(string.Format("the user enter text \'{0}\' on the field with label \'Scenario Description\'", scenario_Description_AltScen1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 42
 testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.And("the user clicks on the Promo Action \'Add New Scenario\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.Then(string.Format("the user select value containing \'{0}\' from dropdown list \'Source Scenario\'", value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.Then(string.Format("the user select value containing \'{0}\' from dropdown list \'Source Scenario\'", scenario_Description_AltScen1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.Then("the user select value containing \'Retrieved\' from dropdown list \'Source Scenario\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 49
 testRunner.When("the user clicks on \'Popup Button\' with value \'Cancel\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user clicks on the \'Close Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
