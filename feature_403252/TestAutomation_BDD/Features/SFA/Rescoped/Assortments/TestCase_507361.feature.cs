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
namespace Kantar_BDD.Features.SFA.Rescoped.Assortments
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("TestCase_507361")]
    public partial class TestCase_507361Feature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "TestCase_507361.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features/SFA/Rescoped/Assortments", "TestCase_507361", null, ProgrammingLanguage.CSharp, ((string[])(null)));
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
        [NUnit.Framework.DescriptionAttribute("WEB_SFA_MD_ASSO_020_ASSORTMENT_CURRENT_CONDITIONS")]
        [NUnit.Framework.CategoryAttribute("BDD_507361")]
        [NUnit.Framework.CategoryAttribute("SFA_Nightly")]
        [NUnit.Framework.TestCaseAttribute("hierarchy", "Customer", "EC8211", "d/m/y", "01/01/2100", "WEB_SFA_MD_ASSO_020AssoProd", null)]
        public virtual void WEB_SFA_MD_ASSO_020_ASSORTMENT_CURRENT_CONDITIONS(string assortmentType, string customerLevel, string customer1, string startDate1, string endDate1, string description1, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "BDD_507361",
                    "SFA_Nightly"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("AssortmentType", assortmentType);
            argumentsOfScenario.Add("CustomerLevel", customerLevel);
            argumentsOfScenario.Add("Customer1", customer1);
            argumentsOfScenario.Add("StartDate1", startDate1);
            argumentsOfScenario.Add("EndDate1", endDate1);
            argumentsOfScenario.Add("Description1", description1);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("WEB_SFA_MD_ASSO_020_ASSORTMENT_CURRENT_CONDITIONS", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
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
#line 5
 testRunner.Given("the user navigates to the \'Assortments\' page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
#line 6
 testRunner.When(string.Format("the user creates a new assortment of Type: \'{0}\', Customer Level: \'{1}\', Customer" +
                            ": \'{2}\', Start Date: \'{3}\', End Date: \'{4}\', Description: \'{5}\'", assortmentType, customerLevel, customer1, startDate1, endDate1, description1), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 8
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 9
 testRunner.And("the user clicks on the \'Add Button\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 11
 testRunner.And("the user filter the pop up menu: \'New Products: Selection 1/3\' by column name \'Pr" +
                        "oduct\', \'Like\', \'03\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 12
 testRunner.And("the user clicks on \'Grid CheckBox\' with value \'035\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 13
 testRunner.And("the user clicks on \'Grid CheckBox\' with value \'036\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 14
 testRunner.And("the user clicks on \'Grid CheckBox\' with value \'037\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 15
 testRunner.And("the user clicks on \'Grid CheckBox\' with value \'038\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 16
 testRunner.And("the user clicks on \'Popup Button\' with value \'Next\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 17
 testRunner.Then("the user validates that the \'Popup\' with value \'New Products: Assortment Attribut" +
                        "es 2/3\' is visible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 19
 testRunner.When("the user enters \'LISTED\' in field \'Input By Label Name\' with value \'Status\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 20
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 21
 testRunner.And("the user clicks on \'Popup Button\' with value \'Next\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 22
 testRunner.Then("the user validates that the \'Popup\' with value \'New Products: Preview 3/3\' is vis" +
                        "ible", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 23
 testRunner.And("the user validates that the page with \'Div Text in Grid\' with value \'BACCO LAMBRU" +
                        "SCO 0.75 lt\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 24
 testRunner.And("the user validates that the \'Div Text in Grid\' with value \'BACCO LAMBRUSCO 0.75 l" +
                        "t\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 25
 testRunner.And("the user validates that the \'Div Text in Grid\' with value \'BACCO LAMBRUSCO 1.5 lt" +
                        "\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 26
 testRunner.And("the user validates that the \'Div Text in Grid\' with value \'BACCO MERLOT 0.75 lt\' " +
                        "is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 27
 testRunner.And("the user validates that the \'Div Text in Grid\' with value \'BACCO MERLOT 1.5 lt\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 29
 testRunner.When("the user clicks on \'Popup Button\' with value \'Confirm\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 30
 testRunner.Then("the user validates that the page with \'Text in Grid\' with value \'BACCO LAMBRUSCO " +
                        "0.75 lt\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 31
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 0.75 lt\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 32
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 1.5 lt\' is" +
                        " displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 33
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO MERLOT 0.75 lt\' is d" +
                        "isplayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 34
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO MERLOT 1.5 lt\' is di" +
                        "splayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 36
 testRunner.When("the user clicks on \'Top Tab\' with value \'Current Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
 testRunner.Then("the user validates that the page with \'Text in Grid\' with value \'BACCO LAMBRUSCO " +
                        "0.75 lt\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 38
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 0.75 lt\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 39
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 1.5 lt\' is" +
                        " displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 40
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO MERLOT 0.75 lt\' is d" +
                        "isplayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 41
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO MERLOT 1.5 lt\' is di" +
                        "splayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 43
 testRunner.When("the user clicks on \'Top Tab\' with value \'Products\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 44
 testRunner.And("the user clicks on \'Column\' with value \'Unit of Minimum Order\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 45
 testRunner.And("the user clicks and enters the date \'d+2/m/y\' in the \'Assortment Product\' multigr" +
                        "id table in the \'lower\' column name: \'Start Date\' in row number: \'2\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 46
 testRunner.And("the user clicks and enters the date \'d+1/m/y\' in the \'Assortment Product\' multigr" +
                        "id table in the \'lower\' column name: \'End Date\' in row number: \'3\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 47
 testRunner.And("the user clicks and enters the text \'PENDING\' in the \'Assortment Product\' multigr" +
                        "id table in the \'lower\' column name: \'Status\' in row number: \'4\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 49
 testRunner.When("the user clicks on \'Top Tab\' with value \'Current Conditions\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 50
 testRunner.Then("the user validates that the page with \'Text in Grid\' with value \'BACCO LAMBRUSCO " +
                        "0.75 lt\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 51
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 0.75 lt\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 52
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO MERLOT 0.75 lt\' is d" +
                        "isplayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 54
 testRunner.When("the user enters the characters \'d+2/m/y\' in field \'Input By Label Name\' with valu" +
                        "e \'Reference Date\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 55
 testRunner.Then("the user validates that the page with \'Text in Grid\' with value \'BACCO LAMBRUSCO " +
                        "1.5 lt\' is loaded", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 56
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 0.75 lt\' i" +
                        "s displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 57
 testRunner.And("the user validates that the \'Text in Grid\' with value \'BACCO LAMBRUSCO 1.5 lt\' is" +
                        " displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 59
 testRunner.When("the user clicks on \'Button\' with value \'Save\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 60
 testRunner.And("the user clicks on \'Side Panel Tab\' with value \'General Info\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 61
 testRunner.And("the user clicks on the \'Assortment Status Field\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 63
 testRunner.And("the user enters \'Pending\' in the \'Assortment Status Field\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 64
 testRunner.And("the user moves the focus away from the element", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 66
 testRunner.And("the user clicks on \'Button\' with value \'Save\'", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
#line 67
 testRunner.Then("the user validates that the \'Toast Message Field\' is displayed", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
#line 68
 testRunner.And("the user closes the page and saves the work done", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "And ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
