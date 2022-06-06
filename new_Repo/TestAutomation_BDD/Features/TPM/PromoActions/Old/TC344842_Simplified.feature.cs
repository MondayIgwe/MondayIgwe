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
namespace Kantar_BDD.Features.TPM.PromoActions.Old
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TC344842_Simplified")]
    public partial class TC344842_SimplifiedFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TC344842_Simplified.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/TPM/PromoActions/Old", "TC344842_Simplified", "\tSimple calculator for adding two numbers", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("Add two numbers")]
        [NUnit.Framework.CategoryAttribute("mytag")]
        [NUnit.Framework.TestCaseAttribute("EC10019", "Level 3", "Holder Level", "TPM_SP_W_SMOKE_R80V1_0014", "d/m/y", "d+10/m/y", "TPR in %", "Hostess", "Def. Cut Price in %", "TPR in %,Hostess,Def. Cut Price in %", "Leaflet", "Level 0", "008", "011", "009", "ESTIMATEDDEFDISCPERC", "DEMO_COST", "DEF_DISC_PERC", "40", "884", "% Cut Price,% Def. Cut Price,Demo", "ACTIVITIES", "LF_COST", null)]
        public virtual void AddTwoNumbers(
                    string customerCode, 
                    string customerHierarchyLevel, 
                    string confirmationLevel, 
                    string description, 
                    string sellInStartDate, 
                    string sellInEndDate, 
                    string promoActionMechanic1, 
                    string promoActionMechanic2, 
                    string promoActionMechanic3, 
                    string comaSeperatedMechanics, 
                    string promoActionMechanic4, 
                    string productLevel, 
                    string productcode1, 
                    string productcode2, 
                    string product1LCCost, 
                    string measMechID1, 
                    string measMechID2, 
                    string measMechID3, 
                    string mEAS_VALUE_PROD, 
                    string fund, 
                    string comaSeperatedMechanicList, 
                    string promomechanicsm1ID, 
                    string leafletSm1ID, 
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
            argumentsOfScenario.Add("ConfirmationLevel", confirmationLevel);
            argumentsOfScenario.Add("Description", description);
            argumentsOfScenario.Add("SellInStartDate", sellInStartDate);
            argumentsOfScenario.Add("SellInEndDate", sellInEndDate);
            argumentsOfScenario.Add("PromoActionMechanic1", promoActionMechanic1);
            argumentsOfScenario.Add("PromoActionMechanic2", promoActionMechanic2);
            argumentsOfScenario.Add("PromoActionMechanic3", promoActionMechanic3);
            argumentsOfScenario.Add("ComaSeperatedMechanics", comaSeperatedMechanics);
            argumentsOfScenario.Add("PromoActionMechanic4", promoActionMechanic4);
            argumentsOfScenario.Add("ProductLevel", productLevel);
            argumentsOfScenario.Add("Productcode1", productcode1);
            argumentsOfScenario.Add("Productcode2", productcode2);
            argumentsOfScenario.Add("Product1LCCost", product1LCCost);
            argumentsOfScenario.Add("MeasMechID1", measMechID1);
            argumentsOfScenario.Add("MeasMechID2", measMechID2);
            argumentsOfScenario.Add("MeasMechID3", measMechID3);
            argumentsOfScenario.Add("MEAS_VALUE_PROD", mEAS_VALUE_PROD);
            argumentsOfScenario.Add("Fund", fund);
            argumentsOfScenario.Add("ComaSeperatedMechanicList", comaSeperatedMechanicList);
            argumentsOfScenario.Add("Promomechanicsm1ID", promomechanicsm1ID);
            argumentsOfScenario.Add("LeafletSm1ID", leafletSm1ID);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Add two numbers", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
 testRunner.When(string.Format("the user creates a Promo \'{0}\' \'{1}\'", customerHierarchyLevel, customerCode), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 9
 testRunner.And(string.Format("the user populates the cockpit \'Promo Action ID\' \'{0}\' \'Sell-In start\' \'Sell-In e" +
                            "nd\' \'{1}\'", description, promoActionMechanic1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.Then("the user clicks on the \'save button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 13
 testRunner.When("the \'green notification banner\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 14
 testRunner.Then("the user clicks on the \'close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 17
 testRunner.Then("the user is on the \'Promotional actions\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 18
 testRunner.When("the user filters \'Action Id\' \'number\' column for \'Promo Action ID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 19
 testRunner.Then("the user clicks on the \'Promo Action ID\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 21
 testRunner.When("the user is on the \'Cockpit Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
 testRunner.Then("the user clicks on the \'edit button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.When("the user clicks on the \'General Info Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 24
 testRunner.Then("the user is on the \'General Info Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 26
 testRunner.When(string.Format("the user sets the mechanics \'{0}\'", comaSeperatedMechanics), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
    testRunner.And(string.Format("the user adds a product \'{0}\' \'<ProductCode1>\'", productLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 28
 testRunner.And(string.Format("the user adds a product \'{0}\' \'<ProductCode2>\'", productLevel), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
    testRunner.And("the user changes the Measure level to \'All\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 30
 testRunner.When(string.Format("the user validates the \'{0}\' is on the grid", comaSeperatedMechanicList), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
 testRunner.Then("the user clicks on the \'General Info Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 33
 testRunner.Then("the user is on the \'General Info Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 34
 testRunner.When(string.Format("the user sets the mechanics \'{0}\'", promoActionMechanic3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 35
 testRunner.And("the user clicks on the \'Popup Yes Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.Then("the user clicks on the \'Products Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 37
 testRunner.When("the user is on the \'Products Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 38
 testRunner.Then(string.Format("the user validates the table does have \'{0}\'", promoActionMechanic3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 40
 testRunner.Then("the user clicks on the \'General Info Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 41
 testRunner.Then("the user is on the \'General Info Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 42
 testRunner.When(string.Format("the user sets the mechanics \'{0}\'", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 43
 testRunner.And("the user clicks on the \'No Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 44
 testRunner.Then("the user clicks on the \'Products Tab\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 45
 testRunner.When("the user is on the \'Products Tab\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 46
 testRunner.Then(string.Format("the user validates the table does not have \'{0}\'", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 48
 testRunner.When(string.Format("the user clicks Data on the products table \'{0}\' \'{1}\'", productcode1, promomechanicsm1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 49
 testRunner.And("the user clicks the dropdown on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 50
 testRunner.Then(string.Format("the user clicks \'{0}\' under the checkbox in row \'{0}\' in table", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.And("the user clicks on the \'Ok\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
    testRunner.Then(string.Format("the user validates the table does have \'{0}\'", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 54
 testRunner.When(string.Format("the user clicks Data on the products table \'{0}\' \'{1}\'", productcode2, promomechanicsm1ID), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.And("the user clicks the dropdown on the grid", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 56
 testRunner.Then(string.Format("the user clicks \'{0}\' under the checkbox in row \'{0}\' in table", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 57
 testRunner.And("the user clicks on the \'Pop up Mechanic Selection\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 58
    testRunner.Then(string.Format("the user validates the table does have \'{0}\'", promoActionMechanic4), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 59
 testRunner.And(string.Format("the user validates the cell is deactivated on the products table \'<Product2>\'\'{0}" +
                            "\'", promoActionMechanic3), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 60
 testRunner.Then(string.Format("the user enters \'{0}\' under the column \'{1}\' in row \'{2}\' in table \'Products\'", product1LCCost, leafletSm1ID, productcode1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 61
 testRunner.Then("the user clicks on the \'Funds SubPage\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 62
 testRunner.Then(string.Format("the user validates that Fund \'{0}\' is not visible", fund), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 64
 testRunner.Then("the user clicks on the \'save button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 65
 testRunner.When("the \'green notification banner\' is present", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 66
 testRunner.Then("the user clicks on the \'close button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
