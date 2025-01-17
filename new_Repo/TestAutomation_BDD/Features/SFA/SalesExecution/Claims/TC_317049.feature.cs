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
namespace Kantar_BDD.Features.SFA.SalesExecution.Claims
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TC317049")]
    public partial class TC317049Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TC_317049.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/SalesExecution/Claims", "TC317049", "    Creates a new claim with the specified data and saves it,\r\n    The new claim " +
                    "is then edited,\r\n    Then the data claim is validated for the edit data.", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("TC317049 - TPM_SA_W_SMOKE_R80V1_0008 - Create new Claim")]
        [NUnit.Framework.TestCaseAttribute("5465", "Level 3", "EC94439", "148.62", "NOVAT", "671.35", "819.97", "28.24", "176.86", "AMOUNT", "VATAMOUNT", "GROSSAMOUNT", "NETAMOUNT", "Amount", null)]
        public virtual void TC317049_TPM_SA_W_SMOKE_R80V1_0008_CreateNewClaim(string documentNumber, string level, string customer, string amount, string vATCode, string amount2, string totalAmount, string vATAmount, string grossAmount, string amountColumnSM1_Id, string vatAmountColumnSM1_Id, string grossAmountColumnSM1_Id, string netAmountColumnSM1_Id, string columnName, string[] exampleTags)
        {
            string[] tagsOfScenario = exampleTags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("DocumentNumber", documentNumber);
            argumentsOfScenario.Add("Level", level);
            argumentsOfScenario.Add("Customer", customer);
            argumentsOfScenario.Add("Amount", amount);
            argumentsOfScenario.Add("VAT Code", vATCode);
            argumentsOfScenario.Add("Amount2", amount2);
            argumentsOfScenario.Add("TotalAmount", totalAmount);
            argumentsOfScenario.Add("VATAmount", vATAmount);
            argumentsOfScenario.Add("GrossAmount", grossAmount);
            argumentsOfScenario.Add("AmountColumnSM1-id", amountColumnSM1_Id);
            argumentsOfScenario.Add("VatAmountColumnSM1-id", vatAmountColumnSM1_Id);
            argumentsOfScenario.Add("GrossAmountColumnSM1-id", grossAmountColumnSM1_Id);
            argumentsOfScenario.Add("NetAmountColumnSM1-id", netAmountColumnSM1_Id);
            argumentsOfScenario.Add("ColumnName", columnName);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("TC317049 - TPM_SA_W_SMOKE_R80V1_0008 - Create new Claim", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
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
    testRunner.Given("the user is on the \'Claims\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 10
    testRunner.When(string.Format("the user creates a New Claim \'{0}\' \'{1}\' \'{2}\' \'{3}\'", documentNumber, level, customer, amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 13
    testRunner.And("the user is on the \'Matchings Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
    testRunner.Then(string.Format("the user validates grid \'{0}\' value \'{1}\'", amountColumnSM1_Id, amount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
    testRunner.Then(string.Format("the user validates grid \'{0}\' value \'{1}\'", vatAmountColumnSM1_Id, vATAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
    testRunner.Then(string.Format("the user validates grid \'{0}\' value \'{1}\'", grossAmountColumnSM1_Id, grossAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 20
    testRunner.And("the user clicks on the \'Summary Tab Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
    testRunner.And("the user retrieves the Document ID", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
    testRunner.Then("the user clicks on the \'Save button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 25
    testRunner.And("the user clicks on the \'Close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
    testRunner.Then("the user is on the \'Claims\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 28
    testRunner.And("the user clicks on the \'Refresh button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
    testRunner.Then(string.Format("the user adds an invoice row in claims page \'{0}\' \'{1}\'", vATCode, amount2), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
    testRunner.Then(string.Format("the user validates claims grid \'{0}\' total summary value \'{1}\'", columnName, totalAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 36
    testRunner.When("the user clicks on the \'Save button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
    testRunner.And("the user clicks on the \'Close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
    testRunner.Then("the user is on the \'Claims\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
    testRunner.And("the user clicks on the \'Refresh button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
    testRunner.Then(string.Format("the user validates grid \'{0}\' value \'{1}\'", netAmountColumnSM1_Id, totalAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
