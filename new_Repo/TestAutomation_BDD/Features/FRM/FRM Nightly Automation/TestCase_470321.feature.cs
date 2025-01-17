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
namespace Kantar_BDD.Features.FRM.FRMNightlyAutomation
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_470321")]
    public partial class TestCase_470321Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_470321.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/FRM/FRM Nightly Automation", "TestCase_470321", "\tValidates the Gui Configurator \'Expanded\' checkbox functionality", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_FRM_CONFIGURATOR_EXPANDED_SECTION_COLLAPSIBLE_01")]
        [NUnit.Framework.CategoryAttribute("BDD_TC470321")]
        [NUnit.Framework.CategoryAttribute("FRM_Nightly")]
        public virtual void WEB_FRM_CONFIGURATOR_EXPANDED_SECTION_COLLAPSIBLE_01()
        {
            string[] tagsOfScenario = new string[] {
                    "BDD_TC470321",
                    "FRM_Nightly"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_FRM_CONFIGURATOR_EXPANDED_SECTION_COLLAPSIBLE_01", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 8
    testRunner.Given("the user navigates to the \'Reference Docs\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
    testRunner.When("the user creates a Reference doc \'Today\' \'Today\' \'Test\' \'voice1\' \'Today\' \'Test197" +
                        "396\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
    testRunner.When("the user filters the column by column name \'Progressive\', \'Like\', \'ProgressiveVal" +
                        "ue\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 11
    testRunner.And("the user opens the grid item in row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.And("the user clicks on the \'Gui Configurator Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
    testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Grids Examples\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 18
    testRunner.And("the user clicks on \'Top Tab\' with value \'List Grid With Drag & Drop\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.And("the user clicks on \'Top Tab Sub Section Settings Icon\' with value \'SM1.LogicalLis" +
                        "tGrid 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
    testRunner.Then("the user validates that the \'Checkbox By Label\' with value \'Expanded\' is displaye" +
                        "d", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 27
    testRunner.When("the user checks the \'Checkbox By Label\' with value \'Expanded\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 28
    testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.Then("the user validates that the \'Logical ListGrid 1 Item\' with value \'Position: 0\' is" +
                        " displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
    testRunner.When("the user clicks on \'Top Tab Sub Section Settings Icon\' with value \'SM1.LogicalLis" +
                        "tGrid 1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
    testRunner.And("the user unchecks the \'Checkbox By Label\' with value \'Expanded\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
    testRunner.And("the user clicks on the \'OK Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
    testRunner.Then("the user validates that the \'Logical ListGrid 1 Item\' with value \'Position: 0\' is" +
                        " not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
    testRunner.When("the user clicks on \'Button\' with value \'Save\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 45
    testRunner.And("the user clicks on the \'Gui Configurator Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
    testRunner.And("the user clicks on the \'Toolbar Close Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
    testRunner.And("the user clicks on the \'Toolbar Close Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
    testRunner.And("the user opens the grid item in row \'1\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
    testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Grids Examples\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
    testRunner.And("the user clicks on \'Top Tab\' with value \'List Grid With Drag & Drop\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
    testRunner.Then("the user validates that the \'Logical ListGrid 1 Item\' with value \'Position: 0\' is" +
                        " not present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
