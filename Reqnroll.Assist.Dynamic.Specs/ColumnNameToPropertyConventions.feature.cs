﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by Reqnroll (https://www.reqnroll.net/).
//      Reqnroll Version:2.0.0.0
//      Reqnroll Generator Version:2.0.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace Reqnroll.Assist.Dynamic.Specs
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Column name converts by convention to nicely formatted property name")]
    public partial class ColumnNameConvertsByConventionToNicelyFormattedPropertyNameFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Column name converts by convention to nicely formatted property name", "\tAs a developer\r\n\tI want my dynamic code to follow common conventions\r\n\tSo that I" +
                " know how to access them", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "ColumnNameToPropertyConventions.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public static async System.Threading.Tasks.Task FeatureSetupAsync()
        {
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public static async System.Threading.Tasks.Task FeatureTearDownAsync()
        {
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public async System.Threading.Tasks.Task TestInitializeAsync()
        {
            testRunner = global::Reqnroll.TestRunnerManager.GetTestRunnerForAssembly(featureHint: featureInfo);
            if (((testRunner.FeatureContext != null) 
                        && (testRunner.FeatureContext.FeatureInfo.Equals(featureInfo) == false)))
            {
                await testRunner.OnFeatureEndAsync();
            }
            if ((testRunner.FeatureContext == null))
            {
                await testRunner.OnFeatureStartAsync(featureInfo);
            }
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public async System.Threading.Tasks.Task TestTearDownAsync()
        {
            await testRunner.OnScenarioEndAsync();
            global::Reqnroll.TestRunnerManager.ReleaseTestRunner(testRunner);
        }
        
        public void ScenarioInitialize(global::Reqnroll.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public async System.Threading.Tasks.Task ScenarioStartAsync()
        {
            await testRunner.OnScenarioStartAsync();
        }
        
        public async System.Threading.Tasks.Task ScenarioCleanupAsync()
        {
            await testRunner.CollectScenarioErrorsAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Single word in columns are left untouched")]
        public async System.Threading.Tasks.Task SingleWordInColumnsAreLeftUntouched()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Single word in columns are left untouched", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 7
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table1 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "age"});
                table1.AddRow(new string[] {
                            "Marcus",
                            "39"});
#line 8
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table1, "Given ");
#line hidden
#line 11
 await testRunner.ThenAsync("the Name property should equal \'Marcus\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 12
  await testRunner.AndAsync("the age property should equal 39", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Two word in the column headers is converted to camel cased properties")]
        public async System.Threading.Tasks.Task TwoWordInTheColumnHeadersIsConvertedToCamelCasedProperties()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Two word in the column headers is converted to camel cased properties", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 14
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table2 = new global::Reqnroll.Table(new string[] {
                            "Birth date",
                            "Length in meters"});
                table2.AddRow(new string[] {
                            "1972-10-09",
                            "1.96"});
#line 15
 await testRunner.WhenAsync("I create a dynamic instance from this table", ((string)(null)), table2, "When ");
#line hidden
#line 18
 await testRunner.ThenAsync("the BirthDate property should equal 1972-10-09", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 19
  await testRunner.AndAsync("the LengthInMeters property should equal \'1.96\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Even if you go crazy with naming you columns we try to shape it up")]
        public async System.Threading.Tasks.Task EvenIfYouGoCrazyWithNamingYouColumnsWeTryToShapeItUp()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Even if you go crazy with naming you columns we try to shape it up", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 21
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table3 = new global::Reqnroll.Table(new string[] {
                            "Birth dAtE",
                            "Length IN mETERs"});
                table3.AddRow(new string[] {
                            "1972-10-09",
                            "1.96"});
#line 22
 await testRunner.WhenAsync("I create a dynamic instance from this table", ((string)(null)), table3, "When ");
#line hidden
#line 25
 await testRunner.ThenAsync("the BirthDate property should equal 1972-10-09", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 26
  await testRunner.AndAsync("the LengthInMeters property should equal \'1.96\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("But the first word is always left untouched since it might be abbreviations")]
        public async System.Threading.Tasks.Task ButTheFirstWordIsAlwaysLeftUntouchedSinceItMightBeAbbreviations()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("But the first word is always left untouched since it might be abbreviations", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 28
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table4 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "SAT score"});
                table4.AddRow(new string[] {
                            "Have no idea what an SAT should be",
                            "132"});
#line 29
 await testRunner.WhenAsync("I create a dynamic instance from this table", ((string)(null)), table4, "When ");
#line hidden
#line 32
 await testRunner.ThenAsync("the SATScore should be 132", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
