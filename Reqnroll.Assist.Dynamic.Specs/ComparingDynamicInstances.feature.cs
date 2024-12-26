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
namespace AssistDynamic.Specs
{
    using Reqnroll;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Reqnroll", "2.0.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Comparing dynamic instances")]
    public partial class ComparingDynamicInstancesFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Comparing dynamic instances", "\tIn order to be able to easy do assertions\r\n\tAs a Reqnroll developer\r\n\tI want to " +
                "be able to compare dynamic instances", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "ComparingDynamicInstances.feature"
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
        [NUnit.Framework.DescriptionAttribute("Matching a dynamic instance against a table")]
        public async System.Threading.Tasks.Task MatchingADynamicInstanceAgainstATable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Matching a dynamic instance against a table", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table5 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table5.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
#line 7
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table5, "Given ");
#line hidden
                global::Reqnroll.Table table6 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table6.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
#line 10
 await testRunner.WhenAsync("I compare it to this table", ((string)(null)), table6, "When ");
#line hidden
#line 13
 await testRunner.ThenAsync("no instance comparison exception should have been thrown", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 header differ")]
        public async System.Threading.Tasks.Task NotMatchingWhen1HeaderDiffer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when 1 header differ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 15
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table7 = new global::Reqnroll.Table(new string[] {
                            "Name"});
                table7.AddRow(new string[] {
                            "Marcus"});
#line 16
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table7, "Given ");
#line hidden
                global::Reqnroll.Table table8 = new global::Reqnroll.Table(new string[] {
                            "N"});
                table8.AddRow(new string[] {
                            "Marcus"});
#line 19
 await testRunner.WhenAsync("I compare it to this table", ((string)(null)), table8, "When ");
#line hidden
#line 22
 await testRunner.ThenAsync("an instance comparison exception should be thrown with 2 differences", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 23
 await testRunner.AndAsync("one difference should be on the \'Name\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 24
 await testRunner.AndAsync("one difference should be on the \'N\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 2 header differ")]
        public async System.Threading.Tasks.Task NotMatchingWhen2HeaderDiffer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when 2 header differ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 26
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table9 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Birth date"});
                table9.AddRow(new string[] {
                            "Marcus",
                            "2000-01-01"});
#line 27
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table9, "Given ");
#line hidden
                global::Reqnroll.Table table10 = new global::Reqnroll.Table(new string[] {
                            "N",
                            "Date of birth"});
                table10.AddRow(new string[] {
                            "Marcus",
                            "2000-01-01"});
#line 30
 await testRunner.WhenAsync("I compare it to this table", ((string)(null)), table10, "When ");
#line hidden
#line 33
 await testRunner.ThenAsync("an instance comparison exception should be thrown with 4 differences", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 34
 await testRunner.AndAsync("one difference should be on the \'Name\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 35
 await testRunner.AndAsync("one difference should be on the \'BirthDate\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 36
 await testRunner.AndAsync("one difference should be on the \'N\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
 await testRunner.AndAsync("one difference should be on the \'DateOfBirth\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 value differ")]
        public async System.Threading.Tasks.Task NotMatchingWhen1ValueDiffer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when 1 value differ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 39
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table11 = new global::Reqnroll.Table(new string[] {
                            "Name"});
                table11.AddRow(new string[] {
                            "Marcus"});
#line 40
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table11, "Given ");
#line hidden
                global::Reqnroll.Table table12 = new global::Reqnroll.Table(new string[] {
                            "Name"});
                table12.AddRow(new string[] {
                            "Albert"});
#line 43
 await testRunner.WhenAsync("I compare it to this table", ((string)(null)), table12, "When ");
#line hidden
#line 46
 await testRunner.ThenAsync("an instance comparison exception should be thrown with 1 difference", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 47
 await testRunner.AndAsync("one difference should be on the \'Name\' property", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 48
 await testRunner.AndAsync("one message should state that the instance had the value \'Marcus\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 49
 await testRunner.AndAsync("one message should state that the table had the value \'Albert\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when several value differ")]
        public async System.Threading.Tasks.Task NotMatchingWhenSeveralValueDiffer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when several value differ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 51
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table13 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "BirthDate",
                            "LengthInMeters"});
                table13.AddRow(new string[] {
                            "Marcus",
                            "1972-10-09",
                            "1.96"});
#line 52
 await testRunner.GivenAsync("I create a dynamic instance from this table", ((string)(null)), table13, "Given ");
#line hidden
                global::Reqnroll.Table table14 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Birth date",
                            "Length in meters"});
                table14.AddRow(new string[] {
                            "Albert",
                            "2008-01-24",
                            "1.04"});
#line 55
 await testRunner.WhenAsync("I compare it to this table", ((string)(null)), table14, "When ");
#line hidden
#line 58
 await testRunner.ThenAsync("an instance comparison exception should be thrown with 3 difference", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 59
 await testRunner.AndAsync("one difference should be on the \'Name\' property", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 60
 await testRunner.AndAsync("one difference should be on the \'BirthDate\' property", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 61
 await testRunner.AndAsync("one difference should be on the \'LengthInMeters\' property", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion