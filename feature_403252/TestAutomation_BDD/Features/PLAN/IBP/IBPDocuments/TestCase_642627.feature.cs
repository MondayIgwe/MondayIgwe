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
namespace Kantar_BDD.Features.PLAN.IBP.IBPDocuments
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_642627")]
    public partial class TestCase_642627Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_642627.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/PLAN/IBP/IBPDocuments", "TestCase_642627", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_TPM_IBP_AGGREGATION_ROL_MEAS_NOTAGG_006-US425392-AC4-Example 1")]
        [NUnit.Framework.CategoryAttribute("BDD_642627")]
        [NUnit.Framework.CategoryAttribute("PLAN_Nightly")]
        [NUnit.Framework.CategoryAttribute("PLAN")]
        [NUnit.Framework.TestCaseAttribute("CBP_2020", "SHELL_ROLMEAS", "41", "10", "SC_ROLMEAS_NOTAGG", "142", "EC94101_4", "M1", "M2", "[FLT_ROLMEAS_CUST]", "[FLT_ROLMEAS_PROD]", "[FLT_ROLMEAS_MONTH]", "[FLT_ROLMEAS_MEAS2]", "MEAS1_ROL", "GRID_FR_ROLMEAS_NOTAGG", "07_5", "Block", "Cell(s)", "55", "T1", "2020", null)]
        public virtual void WEB_TPM_IBP_AGGREGATION_ROL_MEAS_NOTAGG_006_US425392_AC4_Example1(
                    string docProcessYear, 
                    string docShellModel, 
                    string docWeek, 
                    string docMonth, 
                    string sectionName, 
                    string documentID, 
                    string customer, 
                    string month, 
                    string month1, 
                    string fLT_Rolmeas_Customer, 
                    string fLT_Rolmeas_Prod, 
                    string fLT_Rolmeas_Month, 
                    string fLT_Rolmeas_Meas, 
                    string measure, 
                    string gridName, 
                    string prodCell, 
                    string block, 
                    string blockType, 
                    string value, 
                    string quarter, 
                    string year, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_642627",
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
            argumentsOfScenario.Add("DocumentID", documentID);
            argumentsOfScenario.Add("Customer", customer);
            argumentsOfScenario.Add("Month", month);
            argumentsOfScenario.Add("Month1", month1);
            argumentsOfScenario.Add("FLT_Rolmeas_Customer", fLT_Rolmeas_Customer);
            argumentsOfScenario.Add("FLT_Rolmeas_Prod", fLT_Rolmeas_Prod);
            argumentsOfScenario.Add("FLT_Rolmeas_Month", fLT_Rolmeas_Month);
            argumentsOfScenario.Add("FLT_Rolmeas_Meas", fLT_Rolmeas_Meas);
            argumentsOfScenario.Add("Measure", measure);
            argumentsOfScenario.Add("GridName", gridName);
            argumentsOfScenario.Add("ProdCell", prodCell);
            argumentsOfScenario.Add("Block", block);
            argumentsOfScenario.Add("BlockType", blockType);
            argumentsOfScenario.Add("Value", value);
            argumentsOfScenario.Add("Quarter", quarter);
            argumentsOfScenario.Add("Year", year);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_TPM_IBP_AGGREGATION_ROL_MEAS_NOTAGG_006-US425392-AC4-Example 1", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
                            "\' in the IBP Shell Tab", fLT_Rolmeas_Customer, customer), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.And(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", fLT_Rolmeas_Month, month), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", fLT_Rolmeas_Month, month1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.And(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", fLT_Rolmeas_Prod, prodCell), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 23
 testRunner.And(string.Format("the user changes the filter on \'{0}\' to \'{1}\' and filters with \'User Code\', \'Like" +
                            "\' in the IBP Shell Tab", fLT_Rolmeas_Meas, measure), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And(string.Format("the user enters the text \'{0}\' on the Aggrid Grid table \'{1}\' at row: \'EC94101_4|" +
                            "07_5|MEAS1_ROL\' and column: \'{2}\'", value, gridName, month1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.Then(string.Format("the user validates on the Aggrid Grid table \'{0}\' at row: \'EC94101_4|07_5|MEAS1_R" +
                            "OL\' and column: \'{1}\' and has the text \'{2}\'", gridName, month1, value), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 29
 testRunner.When("the user clicks on \'Button\' with value \'UPDATE\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 31
 testRunner.And("the user closes all pages without saving the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
