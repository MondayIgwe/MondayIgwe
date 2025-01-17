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
namespace Kantar_BDD.Features.PLAN.IBP.RescopedNightlyRegression
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_278517")]
    public partial class TestCase_278517Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TC_278517.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/PLAN/IBP/RescopedNightlyRegression", "TestCase_278517", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_IBP_APPLYVALUE_005-Apply percentage at aggregated level")]
        [NUnit.Framework.CategoryAttribute("RESCOPED_BDD_278517")]
        [NUnit.Framework.CategoryAttribute("PLAN_Nightly")]
        [NUnit.Framework.CategoryAttribute("PLAN")]
        [NUnit.Framework.TestCaseAttribute("CBP_2020", "SHELL_MEASURES", "1", "1", "SEC_MEASURES_1", "EC94100_4", "M4", "132", null)]
        public virtual void WEB_TPM_IBP_APPLYVALUE_005_ApplyPercentageAtAggregatedLevel(string docProcessYear, string docShellModel, string docWeek, string docMonth, string sectionName, string customerFilters, string monthFilters, string documentID, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "RESCOPED_BDD_278517",
                    "PLAN_Nightly",
                    "PLAN"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DocProcessYear", docProcessYear);
            argumentsOfScenario.Add("DocShellModel", docShellModel);
            argumentsOfScenario.Add("DocWeek", docWeek);
            argumentsOfScenario.Add("DocMonth", docMonth);
            argumentsOfScenario.Add("SectionName", sectionName);
            argumentsOfScenario.Add("CustomerFilters", customerFilters);
            argumentsOfScenario.Add("MonthFilters", monthFilters);
            argumentsOfScenario.Add("DocumentID", documentID);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_IBP_APPLYVALUE_005-Apply percentage at aggregated level", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.Given("the user navigates to the \'IBP Documents\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 8
 testRunner.When(string.Format("the user filters the column by column name \'Process Year\', \'Like\', \'{0}\'", docProcessYear), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user filters the column by column name \'Month\', \'Equal\', \'{0}\'", docMonth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 10
 testRunner.And(string.Format("the user filters the column by column name \'Document Shell Model\', \'Like\', \'{0}\'", docShellModel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("the user filters the column by column name \'Week\', \'Equal\', \'{0}\'", docWeek), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user clicks on \'{0}\' text on the grid", documentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
 testRunner.When(string.Format("the user selects a section \'{0}\' in IBP Summary Tab", sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 16
 testRunner.Then("the user is on the \'Shell Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When(string.Format("the user changes the filter on \'[F_MEASURE3]\' to \'{0}\' and filters with \'User Cod" +
                            "e\', \'Like\' in the IBP Shell Tab", customerFilters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.And(string.Format("the user changes the filter on \'[F_MEASURE4]\' to \'{0}\' and filters with \'User Cod" +
                            "e\', \'Like\' in the IBP Shell Tab", monthFilters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And(string.Format("the user enters the text \'-15\' on the Aggrid Grid table \'<GridName>\' at row: \'{0}" +
                            "\' and column: \'M4|MEASUR5\'", customerFilters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then(string.Format("the user validates on the Aggrid Grid table \'GRID_FR_MEASURES_1\' at row: \'{0}\' an" +
                            "d column: \'M4|MEASUR5\' and has the text \'-15\'", customerFilters), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
 testRunner.When("the user clicks on \'Button\' with value \'UPDATE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.And("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
