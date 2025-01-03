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
    [NUnit.Framework.DescriptionAttribute("ReservedCharsInCSharp")]
    public partial class ReservedCharsInCSharpFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "ReservedCharsInCSharp", "\tIn order to be able to write more expressive meaningful scenarios\r\n\tAs a scenari" +
                "o writer\r\n\tI want to be able to use any character, including reserved words", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "ReservedCharsInCSharp.feature"
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
        [NUnit.Framework.DescriptionAttribute("Using reserved C# characters in column names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public async System.Threading.Tasks.Task UsingReservedCCharactersInColumnNames()
        {
            string[] tagsOfScenario = new string[] {
                    "wip"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Using reserved C# characters in column names", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                global::Reqnroll.Table table38 = new global::Reqnroll.Table(new string[] {
                            "C$harp n@me (with strange chars)"});
                table38.AddRow(new string[] {
                            "A value"});
#line 8
    await testRunner.WhenAsync("I create a dynamic instance from this table", ((string)(null)), table38, "When ");
#line hidden
#line 11
    await testRunner.ThenAsync("the CharpNmeWithStrangeChars property should equal \'A value\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Only alfa numeric characters, plus underscore is allowed in variable names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public async System.Threading.Tasks.Task OnlyAlfaNumericCharactersPlusUnderscoreIsAllowedInVariableNames()
        {
            string[] tagsOfScenario = new string[] {
                    "wip"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Only alfa numeric characters, plus underscore is allowed in variable names", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                global::Reqnroll.Table table39 = new global::Reqnroll.Table(new string[] {
                            "My_Nice_Variable",
                            "My $$ Variable (needs clean up)"});
                table39.AddRow(new string[] {
                            "A value",
                            "Another value"});
#line 16
       await testRunner.WhenAsync("I create a dynamic instance from this table", ((string)(null)), table39, "When ");
#line hidden
#line 19
    await testRunner.ThenAsync("the My_Nice_Variable property should equal \'A value\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 20
           await testRunner.AndAsync("the MyVariableNeedsCleanUp property should equal \'Another value\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Using only reserved C# characters in column names")]
        [NUnit.Framework.CategoryAttribute("wip")]
        public async System.Threading.Tasks.Task UsingOnlyReservedCCharactersInColumnNames()
        {
            string[] tagsOfScenario = new string[] {
                    "wip"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Using only reserved C# characters in column names", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 23
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table40 = new global::Reqnroll.Table(new string[] {
                            "$@()"});
                table40.AddRow(new string[] {
                            "A value"});
#line 24
    await testRunner.WhenAsync("I create a dynamic instance with only reserved chars", ((string)(null)), table40, "When ");
#line hidden
#line 27
    await testRunner.ThenAsync("an exception with a nice error message about the property only containing reserve" +
                        "d chars should be thrown", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
