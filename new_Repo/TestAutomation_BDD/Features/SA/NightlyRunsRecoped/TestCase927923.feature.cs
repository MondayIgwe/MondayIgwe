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
namespace Kantar_BDD.Features.SA.NightlyRunsRecoped
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase927923")]
    public partial class TestCase927923Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase927923.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SA/NightlyRunsRecoped", "TestCase927923", "\tWEB_SA_BALANCE_MATCHED CLAIMS-PROMOTIONS_002 - Unmatch button when matched amoun" +
                    "t and balance amount = 0", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SA_BALANCE_MATCHED CLAIMS-PROMOTIONS_002")]
        [NUnit.Framework.CategoryAttribute("BDD_927923")]
        [NUnit.Framework.CategoryAttribute("TTC")]
        [NUnit.Framework.TestCaseAttribute("Supply", "Year End Bonuses", "Unconditional", "Level 4", "EC86217", "1000", "Invoice payable", "Monthly", "TC927923_rebate", "Confirm", "Leaflet", "Product", "059", "1,000", "TC927923_promo", "d/m/y", "d+1/m/y", "To be authorized", "Net sales revenue", null)]
        public virtual void WEB_SA_BALANCE_MATCHEDCLAIMS_PROMOTIONS_002(
                    string classification, 
                    string reason, 
                    string targetType, 
                    string customerLevel, 
                    string customerHolder, 
                    string fixedAmount, 
                    string paymentMode, 
                    string paymentFrequency, 
                    string description_Rebate, 
                    string status, 
                    string mechanic, 
                    string productLevel, 
                    string productCode, 
                    string measure, 
                    string description_Promo, 
                    string sellInStart, 
                    string sellInEnd, 
                    string promo_Status, 
                    string dataSource, 
                    string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_927923",
                    "TTC"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Classification", classification);
            argumentsOfScenario.Add("Reason", reason);
            argumentsOfScenario.Add("TargetType", targetType);
            argumentsOfScenario.Add("CustomerLevel", customerLevel);
            argumentsOfScenario.Add("CustomerHolder", customerHolder);
            argumentsOfScenario.Add("FixedAmount", fixedAmount);
            argumentsOfScenario.Add("PaymentMode", paymentMode);
            argumentsOfScenario.Add("PaymentFrequency", paymentFrequency);
            argumentsOfScenario.Add("Description_rebate", description_Rebate);
            argumentsOfScenario.Add("Status", status);
            argumentsOfScenario.Add("Mechanic", mechanic);
            argumentsOfScenario.Add("ProductLevel", productLevel);
            argumentsOfScenario.Add("ProductCode", productCode);
            argumentsOfScenario.Add("Measure", measure);
            argumentsOfScenario.Add("Description_Promo", description_Promo);
            argumentsOfScenario.Add("SellInStart", sellInStart);
            argumentsOfScenario.Add("SellInEnd", sellInEnd);
            argumentsOfScenario.Add("Promo_Status", promo_Status);
            argumentsOfScenario.Add("DataSource", dataSource);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SA_BALANCE_MATCHED CLAIMS-PROMOTIONS_002", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 6
 testRunner.Given("the user navigates to the \'Rebates\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 9
 testRunner.When("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 10
 testRunner.And("the user clicks on the \'Customer Holder\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And(string.Format("the user clicks on \'Hier. level side panel\' with value \'{0}\'", customerLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And(string.Format("the user clicks on \'Customer Code table\' with value \'{0}\'", customerHolder), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'Customer Holder\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
    testRunner.Then("the user validates that the \'Popup\' with value \'New Rebate\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 15
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Classification\' is " +
                        "displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 16
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Classification\'", classification), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Reason\'", reason), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 18
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Target Type\'", targetType), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
    testRunner.And("the user clicks on \'Input By Label Name\' with value \'Reason\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 20
    testRunner.And("the user clicks on \'Popup Ok Button\' with value \'New Rebate\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
    testRunner.Then("the user is on the \'Summary Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 22
    testRunner.Then("the user validates that the \'Input By Label Name\' with value \'Rebate code\' is dis" +
                        "played", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
    testRunner.When("the user retrieves text from element \'Input By Label Name\' with value \'Rebate cod" +
                        "e\' and saves it as \'RebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Data source\'", dataSource), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 25
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Payment mode\'", paymentMode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 26
 testRunner.When(string.Format("the user enters \'{0}\' in field \'Input By Label Name\' with value \'Payment Frequenc" +
                            "y\'", paymentFrequency), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
    testRunner.And("the user clicks on \'Input By Label Name\' with value \'DESCRIPTION\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user enters \'{0}\' in cell with column \'Fixed amount\' and row containing text " +
                            "\'0.0\'", fixedAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General Info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
    testRunner.And("the user clicks on the \'Status Arrow Icon\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 31
    testRunner.When(string.Format("the user changes the status to \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 34
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Dashboard\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 35
 testRunner.And("the user clicks on \'Sub Tab\' with value \'Settlements and Claims\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
    testRunner.And("the user clicks on the \'Settlements Claims Update Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 37
    testRunner.Then("the user waits for the element \'Update Button\' attribute \'aria-disabled\' to be \'f" +
                        "alse\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
    testRunner.And(string.Format("the user validates that \'Input By Label Name\' with value \'PAYABLE AMOUNT\' contain" +
                            "s text \'{0}\'", fixedAmount), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
    testRunner.When("the user navigates to the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 40
    testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", customerLevel, customerHolder), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 41
    testRunner.Then(string.Format("the user populates the cockpit \'{0}\' \'{1}\' \'{2}\' \'\' \'\' \'{3}\'", description_Promo, sellInStart, sellInEnd, mechanic), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
    testRunner.When(string.Format("the user adds a product \'{0}\' \'{1}\'", productLevel, productCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
    testRunner.When("the user is on the \'Products Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
    testRunner.And(string.Format("the user enters \'{0}\' on column name \'Leaflet\' for product code \'{1}\'", measure, productCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Cockpit\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
    testRunner.When(string.Format("the user changes the status to \'{0}\'", promo_Status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 48
 testRunner.And("the user clicks on \'Trigger By Field Name\' with value \'Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
    testRunner.When(string.Format("the user changes the status to \'{0}\'", status), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 51
 testRunner.And("the user clicks on \'Sub Tab\' with value \'Header info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
    testRunner.And("the user retrieves text from element \'Input By Label Name\' with value \'Action cod" +
                        "e\' and saves it as \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 55
    testRunner.When("the user navigates to the \'Matched Claims\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 56
    testRunner.And("the user filters the column by column name \'Rebate code\', \'Equal\', \'RebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
    testRunner.And("the user clicks on \'Grid Checkbox\' with value \'RebateCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.Then("the user validates the \'Unmatch Link\' is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
    testRunner.When("the user navigates to the \'Matched Claims - Promotions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
    testRunner.And("the user filters the column by column name \'Action Code\', \'Like\', \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
    testRunner.And("the user clicks on \'Grid Checkbox\' with value \'ActionCode\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 62
    testRunner.Then("the user validates the \'Unmatch Link\' is disabled", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
