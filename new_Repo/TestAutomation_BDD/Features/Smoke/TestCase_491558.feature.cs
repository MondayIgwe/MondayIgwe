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
namespace Kantar_BDD.Features.Smoke
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_491558")]
    public partial class TestCase_491558Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_491558.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/Smoke", "TestCase_491558", "\tCreate rebate with different filter on target", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Create rebate with different filter on target")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("EC86217", "Level 4", "TestAutomationAgreementCode", "TestAutomationAgreementDescription", "Supply", "CLASSIFICATION", "Year End Bonuses", "REASON", "Brackets", "TARGETTYPE", "Credit note", "PAYMENTMODE", "Net sales revenue", "CALCBASESOURCE", "01", "02", "30", "11", "Level 1", "EC87135", "TestAutomationFilter1", "Level 1", "BENEFICIARYLEVEL", "Nielsen Area", "In", "AN4", "TestAutomationFilter2", "EAN", "8000102030059", "TestAutomationFilter3", "Family", "01", "Level 0", "TARGETLEVEL", "EAN", "8000101010011", "TestAutomationFilter4", "01", "02", "30", "06", "01", "07", "30", "11", "100", "dtpPeriod", "dtpCalcBase", "dtpTarget", "01/01/2021", "12/31/2021", "02/01/2021", "06/30/2021", "06/30/2021", "CHKFLGSAMEFILTER", "EC87135", null)]
        public virtual void CreateRebateWithDifferentFilterOnTarget(
                    string customerCode, 
                    string customerHierarchyLevel, 
                    string agreementCode, 
                    string agreementDesc, 
                    string classification, 
                    string classificationSM1ID, 
                    string reason, 
                    string reasonSM1ID, 
                    string targetType, 
                    string targetTypeSM1ID, 
                    string paymentMode, 
                    string paymentModeSM1ID, 
                    string calculationBasis, 
                    string calculationBasisSM1ID, 
                    string startDay, 
                    string startMonth, 
                    string endDay, 
                    string endMonth, 
                    string customerHierarchyLevel1, 
                    string customerCode1, 
                    string filterName, 
                    string beneficiaryLvl, 
                    string beneficiaryLvlSM1ID, 
                    string attribute1, 
                    string operator1, 
                    string filterValue1, 
                    string filterName1, 
                    string attribute2, 
                    string filterValue2, 
                    string filterName2, 
                    string productsLevel, 
                    string productsCode, 
                    string targetLevel, 
                    string targetLevelSM1ID, 
                    string attribute3, 
                    string filterValue3, 
                    string filterName3, 
                    string startDay1, 
                    string startMonth1, 
                    string endDay1, 
                    string endMonth1, 
                    string startDay2, 
                    string startMonth2, 
                    string endDay2, 
                    string endMonth2, 
                    string lumpSum, 
                    string rebateDateSm1ID, 
                    string calcultionbasisDateSm1ID, 
                    string targetDateSm1ID, 
                    string startDate, 
                    string endDate, 
                    string startDate1, 
                    string endDate1, 
                    string endDate2, 
                    string samefiltersontargetSm1ID, 
                    string filterValue, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "mytag"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("CustomerCode", customerCode);
            argumentsOfScenario.Add("CustomerHierarchyLevel", customerHierarchyLevel);
            argumentsOfScenario.Add("AgreementCode", agreementCode);
            argumentsOfScenario.Add("AgreementDesc", agreementDesc);
            argumentsOfScenario.Add("Classification", classification);
            argumentsOfScenario.Add("ClassificationSM1ID", classificationSM1ID);
            argumentsOfScenario.Add("Reason", reason);
            argumentsOfScenario.Add("ReasonSM1ID", reasonSM1ID);
            argumentsOfScenario.Add("TargetType", targetType);
            argumentsOfScenario.Add("TargetTypeSM1ID", targetTypeSM1ID);
            argumentsOfScenario.Add("PaymentMode", paymentMode);
            argumentsOfScenario.Add("PaymentModeSM1ID", paymentModeSM1ID);
            argumentsOfScenario.Add("CalculationBasis", calculationBasis);
            argumentsOfScenario.Add("CalculationBasisSM1ID", calculationBasisSM1ID);
            argumentsOfScenario.Add("StartDay", startDay);
            argumentsOfScenario.Add("StartMonth", startMonth);
            argumentsOfScenario.Add("EndDay", endDay);
            argumentsOfScenario.Add("EndMonth", endMonth);
            argumentsOfScenario.Add("CustomerHierarchyLevel1", customerHierarchyLevel1);
            argumentsOfScenario.Add("CustomerCode1", customerCode1);
            argumentsOfScenario.Add("FilterName", filterName);
            argumentsOfScenario.Add("BeneficiaryLvl", beneficiaryLvl);
            argumentsOfScenario.Add("BeneficiaryLvlSM1ID", beneficiaryLvlSM1ID);
            argumentsOfScenario.Add("Attribute1", attribute1);
            argumentsOfScenario.Add("Operator1", operator1);
            argumentsOfScenario.Add("FilterValue1", filterValue1);
            argumentsOfScenario.Add("FilterName1", filterName1);
            argumentsOfScenario.Add("Attribute2", attribute2);
            argumentsOfScenario.Add("FilterValue2", filterValue2);
            argumentsOfScenario.Add("FilterName2", filterName2);
            argumentsOfScenario.Add("ProductsLevel", productsLevel);
            argumentsOfScenario.Add("ProductsCode", productsCode);
            argumentsOfScenario.Add("TargetLevel", targetLevel);
            argumentsOfScenario.Add("TargetLevelSM1ID", targetLevelSM1ID);
            argumentsOfScenario.Add("Attribute3", attribute3);
            argumentsOfScenario.Add("FilterValue3", filterValue3);
            argumentsOfScenario.Add("FilterName3", filterName3);
            argumentsOfScenario.Add("StartDay1", startDay1);
            argumentsOfScenario.Add("StartMonth1", startMonth1);
            argumentsOfScenario.Add("EndDay1", endDay1);
            argumentsOfScenario.Add("EndMonth1", endMonth1);
            argumentsOfScenario.Add("StartDay2", startDay2);
            argumentsOfScenario.Add("StartMonth2", startMonth2);
            argumentsOfScenario.Add("EndDay2", endDay2);
            argumentsOfScenario.Add("EndMonth2", endMonth2);
            argumentsOfScenario.Add("LumpSum", lumpSum);
            argumentsOfScenario.Add("rebateDateSm1ID", rebateDateSm1ID);
            argumentsOfScenario.Add("calcultionbasisDateSm1ID", calcultionbasisDateSm1ID);
            argumentsOfScenario.Add("targetDateSm1ID", targetDateSm1ID);
            argumentsOfScenario.Add("StartDate", startDate);
            argumentsOfScenario.Add("EndDate", endDate);
            argumentsOfScenario.Add("StartDate1", startDate1);
            argumentsOfScenario.Add("EndDate1", endDate1);
            argumentsOfScenario.Add("EndDate2", endDate2);
            argumentsOfScenario.Add("SamefiltersontargetSm1ID", samefiltersontargetSm1ID);
            argumentsOfScenario.Add("filterValue", filterValue);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Create rebate with different filter on target", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
    testRunner.Given("the user is on the \'Agreements\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
    testRunner.When("the user clicks on the \'Add button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.Then("the user clicks on the \'Customer Holder Icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 11
 testRunner.When(string.Format("the user selects \'{0}\' in the \'Hier. level side panel\'", customerHierarchyLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 12
 testRunner.Then(string.Format("the user selects \'{0}\' in the \'Customer code table\'", customerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("the user clicks on the \'OK Customer code button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.When(string.Format("the user enters \'{0}\' in the \'Agreement Code\'", agreementCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 15
 testRunner.And(string.Format("the user enters \'{0}\' in the \'Agreement Desc\'", agreementDesc), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.Then("the user clicks on the \'New Agreement OK button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.Then("the user is on the \'Conditions Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
 testRunner.When("the user clicks on the \'Rebates Add A Product Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 23
 testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.When(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", classification, classificationSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", reason, reasonSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", targetType, targetTypeSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", paymentMode, paymentModeSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", calculationBasis, calculationBasisSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.Then(string.Format("the user selects a date wtih \'{0}\' \'{1}\' \'{2}\' \'{3}\'", startDay, startMonth, endDay, endMonth), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 32
 testRunner.Then(string.Format("the user populates \'hier\' filter maker \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'{4}\'", attribute1, operator1, filterValue, filterName1, customerHierarchyLevel1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 35
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", beneficiaryLvl, beneficiaryLvlSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 38
 testRunner.Then(string.Format("the user populates \'customer\' filter maker \'{0}\' \'{1}\' \'{2}\' \'{3}\' \'\'", attribute1, operator1, filterValue1, filterName1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.Then(string.Format("the user populates \'product\' filter maker \'{0}\' \'<Operator2>\' \'{1}\' \'{2}\' \'\'", attribute2, filterValue2, filterName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 44
 testRunner.Then("the user clicks on the \'Rebates Add Product Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When(string.Format("the user selects \'{0}\' in the \'Products Level\'", productsLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then(string.Format("the user selects \'{0}\' in the \'Products code table\'", productsCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 47
 testRunner.When("the user clicks on Ok button on the popup \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("the user clicks on the \'Target button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.Then("the user checks on the \'AggregatedCheckbox\' checkbox", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 52
 testRunner.And(string.Format("the user selects \'{0}\' in the dropbox \'{1}\'", targetLevel, targetLevelSM1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 53
 testRunner.Then(string.Format("the user populates \'target\' filter maker \'{0}\' \'<Operator3>\' \'{1}\' \'{2}\' \'\'", attribute3, filterValue3, filterName3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When("the user clicks on Ok button on the popup \'Target\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
 testRunner.Then("the user clicks on the \'Other Info Arrow\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 58
 testRunner.Then("the user clicks on the \'Calculation Basis Start Date\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.Then(string.Format("the user selects a date wtih \'{0}\' \'{1}\' \'{2}\' \'{3}\'", startDay, startMonth, endDay, endMonth1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 60
 testRunner.Then("the user clicks on the \'Target Start Date\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then(string.Format("the user selects a date wtih \'{0}\' \'{1}\' \'{2}\' \'{3}\'", startDay1, startMonth1, endDay1, endMonth1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.Then(string.Format("the user enters \'{0}\' under the column number \'4\' in row number \'1\' in table \'Pro" +
                            "ducts Rebate Table\'", lumpSum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.Then(string.Format("the user enters \'{0}\' under the column number \'4\' in row number \'2\' in table \'Pro" +
                            "ducts Rebate Table\'", lumpSum), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.When("the user clicks on Ok button on the popup \'New Rebate:\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 71
 testRunner.Then("the user clicks on the \'Agreement save button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 72
    testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 73
 testRunner.Then("the user saves the \'AgreementID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 74
 testRunner.Then("the user clicks on the \'close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 75
 testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 76
 testRunner.Then("the user is on the \'Agreements\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 79
 testRunner.Given("the user is on the \'Rebates\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 80
 testRunner.Then("the user filters the column by sm1ID \'AGREEMENTID\', \'Equal\', \'269\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 83
 testRunner.Then("the user clicks under the column name \'Rebate code\' in row number \'2\' in table \'R" +
                        "ebates\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 84
 testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 85
 testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 86
 testRunner.Then(string.Format("the user validates that the \'{0}\' validaty dates \'{1}\' \'{2}\'", rebateDateSm1ID, startDate, endDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 87
 testRunner.Then(string.Format("the user validates that the \'{0}\' validaty dates \'{1}\' \'{2}\'", calcultionbasisDateSm1ID, startDate1, endDate1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 88
 testRunner.Then(string.Format("the user validates that the \'calculationbasis\' section filter \'{0}\' \'{0}\' \'{1}\'", filterName2, filterName3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 89
 testRunner.And(string.Format("the user validates that the \'Target\' section filter \'{0}\' \'{1}\' \'{0}\'", filterName1, filterName3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 90
 testRunner.And(string.Format("the user validates that the checkbox \'{0}\' is not flagged", samefiltersontargetSm1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 93
 testRunner.Then("the user clicks on the \'Products Side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 94
 testRunner.Then("the user is on the \'Products Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 95
    testRunner.And("the user validates \'<ProductCode>\' under the column name \'1\' in row number \'1\' in" +
                        " table \'Products Rebate Table\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 98
 testRunner.Then("the user clicks on the \'Target side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 99
 testRunner.And("the user validates \'<ProductCode1>\' under the column name \'1\' in row number \'1\' i" +
                        "n table \'Products Rebate Table\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 102
 testRunner.Then("the user clicks on the \'Calculation Basis side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 103
 testRunner.Then("the user clicks on the \'Refresh button calculation basis\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 104
 testRunner.And("the user validates the table contains a single row in table \'Products Rebate Tabl" +
                        "e\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 107
 testRunner.Then("the user clicks on the \'Target side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 108
 testRunner.And("the user validates the table contains a single row in table \'Target Rebate Table\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 109
 testRunner.Then("the user clicks on the \'close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 110
 testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 113
 testRunner.When("the user is on the \'Rebates\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 114
 testRunner.Then("the user clicks under the column name \'Rebate code\' in row number \'1\' in table \'R" +
                        "ebates\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 115
 testRunner.Then(string.Format("the user validates that the \'{0}\' validaty dates \'{1}\' \'{2}\'", rebateDateSm1ID, startDate, endDate), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 116
 testRunner.Then(string.Format("the user validates that the \'{0}\' validaty dates \'{1}\' \'{2}\'", calcultionbasisDateSm1ID, startDate1, endDate1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 117
 testRunner.Then(string.Format("the user validates that the \'calcultionbasis\' section filter \'{0}\' \'{1}\' \'{2}\'", filterName1, filterName2, filterName3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 118
 testRunner.And(string.Format("the user validates that the \'Target\' section filter \'{0}\' \'{1}\' \'<FilterName4>\'", filterName1, filterName2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 119
 testRunner.And(string.Format("the user validates that the checkbox \'{0}\' is not flagged", samefiltersontargetSm1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 122
 testRunner.Then("the user clicks on the \'Product page\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 123
 testRunner.And("the user validates \'<ProductCode>\' under the column name \'1\' in row number \'1\' in" +
                        " table \'Products Rebate Table\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 126
 testRunner.Then("the user clicks on the \'Target side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 127
 testRunner.And("the user validates \'<ProductCode1>\' under the column name \'1\' in row number \'1\' i" +
                        "n table \'Target Rebate Table\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 130
 testRunner.Then("the user clicks on the \'Calculation Basis side Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 131
 testRunner.Then("the user clicks on the \'Refresh button calculation basis\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 132
 testRunner.And("the user validates the table contains a single row in table \'Products Rebate Tabl" +
                        "e\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 135
 testRunner.Then("the user clicks on the \'Target Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 136
 testRunner.And("the user validates the table contains a single row in table \'Target Rebate Table\'" +
                        "", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 137
 testRunner.Then("the user clicks on the \'close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 138
 testRunner.And("the user handles the loading screen", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion