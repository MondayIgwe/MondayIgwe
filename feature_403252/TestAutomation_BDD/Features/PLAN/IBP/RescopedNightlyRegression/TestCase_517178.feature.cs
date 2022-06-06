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
    [NUnit.Framework.DescriptionAttribute("TestCase_517178")]
    public partial class TestCase_517178Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_517178.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/PLAN/IBP/RescopedNightlyRegression", "TestCase_517178", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_IBP_STRING_006-Split when Aggrule=DISTINCTCOUNT")]
        [NUnit.Framework.CategoryAttribute("BDD_517178")]
        [NUnit.Framework.CategoryAttribute("PLAN_Nightly")]
        [NUnit.Framework.CategoryAttribute("PLAN")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        [NUnit.Framework.TestCaseAttribute("CBP_2020", "SHELL_STRING", "10", "3", "[GUIGWPLANDOC.SEC_STRING_1]", "EC94721_4", "M4", "[F_STRING2]", "EC94721_4", "GRID_FR_STRING_1", "STRING2", "103", "M1", "X", "X (1)", "STRING_FORMULA2", "1", "138", null)]
        public virtual void WEB_TPM_IBP_STRING_006_SplitWhenAggruleDISTINCTCOUNT(
                    string docProcessYear, 
                    string docShellModel, 
                    string docWeek, 
                    string docMonth, 
                    string sectionName, 
                    string customerFilters, 
                    string monthFilters, 
                    string filter1, 
                    string filterValue, 
                    string gridName, 
                    string measure, 
                    string prodCell, 
                    string month, 
                    string value, 
                    string value1, 
                    string measure1, 
                    string value2, 
                    string documentID, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_517178",
                    "PLAN_Nightly",
                    "PLAN",
                    "Regression"};
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
            argumentsOfScenario.Add("Filter1", filter1);
            argumentsOfScenario.Add("FilterValue", filterValue);
            argumentsOfScenario.Add("GridName", gridName);
            argumentsOfScenario.Add("Measure", measure);
            argumentsOfScenario.Add("ProdCell", prodCell);
            argumentsOfScenario.Add("Month", month);
            argumentsOfScenario.Add("Value", value);
            argumentsOfScenario.Add("Value1", value1);
            argumentsOfScenario.Add("Measure1", measure1);
            argumentsOfScenario.Add("Value2", value2);
            argumentsOfScenario.Add("DocumentID", documentID);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_IBP_STRING_006-Split when Aggrule=DISTINCTCOUNT", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 13
 testRunner.And(string.Format("the user clicks on \'{0}\' text on the grid", documentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When(string.Format("the user selects a section \'{0}\' in IBP Summary Tab", sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.Then("the user is on the \'Shell Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.When(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", filter1, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 21
 testRunner.And(string.Format("the user enters the text \'{0}\' on the Aggrid Grid table \'{1}\' at row: \'{2}\' and c" +
                            "olumn: \'M1|STRING2\'", value, gridName, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.Then(string.Format("the user validates on the Aggrid Grid table \'{0}\' at row: \'{1}\' and column: \'M1|S" +
                            "TRING2\' and has the text \'X (4)\'", gridName, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 24
 testRunner.Then(string.Format("the user validates on the Aggrid Grid table \'{0}\' at row: \'EC94721_4|103\' and col" +
                            "umn: \'T1|STRING2\' and has the text \'{1}\'", gridName, value1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.And("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.When(string.Format("the user clicks on \'{0}\' text on the grid", documentID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 29
 testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 30
 testRunner.When(string.Format("the user selects a section \'{0}\' in IBP Summary Tab", sectionName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.Then("the user is on the \'Shell Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.When(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", filter1, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 33
 testRunner.And(string.Format("the user enters the text \'{0}\' on the Aggrid Grid table \'{1}\' at row: \'{2}\' and c" +
                            "olumn: \'M1|STRING2\'", value2, gridName, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.Then(string.Format("the user validates on the Aggrid Grid table \'{0}\' at row: \'{1}\' and column: \'M1|S" +
                            "TRING2\' and has the text \'1 (4)\'", gridName, filterValue), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.And(string.Format("the user validates on the Aggrid Grid table \'{0}\' at row: \'EC94721_4|103\' and col" +
                            "umn: \'T1|STRING2\' and has the text \'1 (1)\'", gridName), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("the user clicks on \'Button\' with value \'UPDATE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.And("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
