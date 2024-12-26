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
    [NUnit.Framework.DescriptionAttribute("Comparing dynamic sets against tables")]
    public partial class ComparingDynamicSetsAgainstTablesFeature
    {
        
        private global::Reqnroll.ITestRunner testRunner;
        
        private static string[] featureTags = ((string[])(null));
        
        private static global::Reqnroll.FeatureInfo featureInfo = new global::Reqnroll.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "", "Comparing dynamic sets against tables", "\tIn order to easier and slicker do assertions\r\n\tAs a Reqnroll developer\r\n\tI want " +
                "to be able to compare a list of dynamic items against a table", global::Reqnroll.ProgrammingLanguage.CSharp, featureTags);
        
#line 1 "ComparingDynamicSets.feature"
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
        [NUnit.Framework.DescriptionAttribute("Comparing against an identical table should match")]
        public async System.Threading.Tasks.Task ComparingAgainstAnIdenticalTableShouldMatch()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Comparing against an identical table should match", null, tagsOfScenario, argumentsOfScenario, featureTags);
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
                global::Reqnroll.Table table15 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table15.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table15.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
                table15.AddRow(new string[] {
                            "Gustav",
                            "1",
                            "2010-03-19",
                            "0.84"});
                table15.AddRow(new string[] {
                            "Arvid",
                            "1",
                            "2010-03-19",
                            "0.85"});
#line 8
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table15, "Given ");
#line hidden
                global::Reqnroll.Table table16 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table16.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table16.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
                table16.AddRow(new string[] {
                            "Gustav",
                            "1",
                            "2010-03-19",
                            "0.84"});
                table16.AddRow(new string[] {
                            "Arvid",
                            "1",
                            "2010-03-19",
                            "0.85"});
#line 14
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table16, "When ");
#line hidden
#line 20
 await testRunner.ThenAsync("no set comparison exception should have been thrown", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when 1 column name differ")]
        public async System.Threading.Tasks.Task NotMatchingWhen1ColumnNameDiffer()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when 1 column name differ", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 22
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table17 = new global::Reqnroll.Table(new string[] {
                            "Name"});
                table17.AddRow(new string[] {
                            "Marcus"});
                table17.AddRow(new string[] {
                            "Albert"});
                table17.AddRow(new string[] {
                            "Gustav"});
                table17.AddRow(new string[] {
                            "Arvid"});
#line 23
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table17, "Given ");
#line hidden
                global::Reqnroll.Table table18 = new global::Reqnroll.Table(new string[] {
                            "N"});
                table18.AddRow(new string[] {
                            "Marcus"});
                table18.AddRow(new string[] {
                            "Albert"});
                table18.AddRow(new string[] {
                            "Gustav"});
                table18.AddRow(new string[] {
                            "Arvid"});
#line 29
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table18, "When ");
#line hidden
#line 35
 await testRunner.ThenAsync("an set comparision exception should be thrown with 2 differences", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 36
 await testRunner.AndAsync("one set difference should be on the \'Name\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 37
 await testRunner.AndAsync("one set difference should be on the \'N\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
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
                global::Reqnroll.Table table19 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age"});
                table19.AddRow(new string[] {
                            "Marcus",
                            "39"});
                table19.AddRow(new string[] {
                            "Albert",
                            "3"});
                table19.AddRow(new string[] {
                            "Gustav",
                            "1"});
                table19.AddRow(new string[] {
                            "Arvid",
                            "1"});
#line 40
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table19, "Given ");
#line hidden
                global::Reqnroll.Table table20 = new global::Reqnroll.Table(new string[] {
                            "Namn",
                            "Ålder"});
                table20.AddRow(new string[] {
                            "Marcus",
                            "39"});
                table20.AddRow(new string[] {
                            "Albert",
                            "3"});
                table20.AddRow(new string[] {
                            "Gustav",
                            "1"});
                table20.AddRow(new string[] {
                            "Arvid",
                            "1"});
#line 46
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table20, "When ");
#line hidden
#line 52
 await testRunner.ThenAsync("an set comparision exception should be thrown with 4 differences", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 53
 await testRunner.AndAsync("one set difference should be on the \'Name\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 54
 await testRunner.AndAsync("one set difference should be on the \'Age\' field of the instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 55
 await testRunner.AndAsync("one set difference should be on the \'Namn\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 56
 await testRunner.AndAsync("one set difference should be on the \'Ålder\' column of the table", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Not matching when the number of rows are more in the table")]
        public async System.Threading.Tasks.Task NotMatchingWhenTheNumberOfRowsAreMoreInTheTable()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Not matching when the number of rows are more in the table", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 58
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table21 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age"});
                table21.AddRow(new string[] {
                            "Marcus",
                            "39"});
                table21.AddRow(new string[] {
                            "Albert",
                            "3"});
#line 59
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table21, "Given ");
#line hidden
                global::Reqnroll.Table table22 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age"});
                table22.AddRow(new string[] {
                            "Marcus",
                            "39"});
                table22.AddRow(new string[] {
                            "Albert",
                            "3"});
                table22.AddRow(new string[] {
                            "Arvid",
                            "1"});
#line 63
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table22, "When ");
#line hidden
#line 68
 await testRunner.ThenAsync("an set comparison exception should be thrown", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 69
 await testRunner.AndAsync("the error message for different rows should expect 3 rows for table and 2 rows fo" +
                        "r instance", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 1 value in 1 row should throw exceptions")]
        public async System.Threading.Tasks.Task DifferencesOn1ValueIn1RowShouldThrowExceptions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Differences on 1 value in 1 row should throw exceptions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 71
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table23 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table23.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table23.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
#line 72
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table23, "Given ");
#line hidden
                global::Reqnroll.Table table24 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table24.AddRow(new string[] {
                            "Hugo",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table24.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
#line 76
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table24, "When ");
#line hidden
#line 80
 await testRunner.ThenAsync("an set comparision exception should be thrown with 1 difference", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 81
 await testRunner.AndAsync("1 difference should be on row 1 on property \'Name\' for the values \'Marcus\' and \'H" +
                        "ugo\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 2 value in 2 different row should throw exceptions")]
        public async System.Threading.Tasks.Task DifferencesOn2ValueIn2DifferentRowShouldThrowExceptions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Differences on 2 value in 2 different row should throw exceptions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 83
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table25 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table25.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table25.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "0.03"});
#line 84
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table25, "Given ");
#line hidden
                global::Reqnroll.Table table26 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table26.AddRow(new string[] {
                            "Hugo",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table26.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
#line 88
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table26, "When ");
#line hidden
#line 92
 await testRunner.ThenAsync("an set comparision exception should be thrown with 2 difference", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 93
 await testRunner.AndAsync("1 difference should be on row 1 on property \'Name\' for the values \'Marcus\' and \'H" +
                        "ugo\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 94
 await testRunner.AndAsync("2 difference should be on row 2 on property \'LengthInMeters\' for the values \'0.03" +
                        "\' and \'1.03\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Differences on 4 value on 1 row should throw exceptions")]
        public async System.Threading.Tasks.Task DifferencesOn4ValueOn1RowShouldThrowExceptions()
        {
            string[] tagsOfScenario = ((string[])(null));
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            global::Reqnroll.ScenarioInfo scenarioInfo = new global::Reqnroll.ScenarioInfo("Differences on 4 value on 1 row should throw exceptions", null, tagsOfScenario, argumentsOfScenario, featureTags);
#line 96
this.ScenarioInitialize(scenarioInfo);
#line hidden
            if ((global::Reqnroll.TagHelper.ContainsIgnoreTag(scenarioInfo.CombinedTags) || global::Reqnroll.TagHelper.ContainsIgnoreTag(featureTags)))
            {
                testRunner.SkipScenario();
            }
            else
            {
                await this.ScenarioStartAsync();
                global::Reqnroll.Table table27 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table27.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table27.AddRow(new string[] {
                            "Albert",
                            "3",
                            "2008-01-24",
                            "1.03"});
#line 97
 await testRunner.GivenAsync("I create a set of dynamic instances from this table", ((string)(null)), table27, "Given ");
#line hidden
                global::Reqnroll.Table table28 = new global::Reqnroll.Table(new string[] {
                            "Name",
                            "Age",
                            "Birth date",
                            "Length in meters"});
                table28.AddRow(new string[] {
                            "Marcus",
                            "39",
                            "1972-10-09",
                            "1.96"});
                table28.AddRow(new string[] {
                            "Hugo",
                            "2",
                            "2010-01-24",
                            "0.03"});
#line 101
 await testRunner.WhenAsync("I compare the set to this table", ((string)(null)), table28, "When ");
#line hidden
#line 105
 await testRunner.ThenAsync("an set comparision exception should be thrown with 4 difference", ((string)(null)), ((global::Reqnroll.Table)(null)), "Then ");
#line hidden
#line 106
 await testRunner.AndAsync("1 difference should be on row 2 on property \'Name\' for the values \'Marcus\' and \'H" +
                        "ugo\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 107
 await testRunner.AndAsync("2 difference should be on row 2 on property \'Age\' for the values \'3\' and \'2\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 108
 await testRunner.AndAsync("3 difference should be on row 2 on property \'BirthDate\' for the values \'2008-01-2" +
                        "4 12:00AM\' and \'2010-01-24 12:00AM\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
#line 109
 await testRunner.AndAsync("4 difference should be on row 2 on property \'LengthInMeters\' for the values \'1.03" +
                        "\' and \'0.03\'", ((string)(null)), ((global::Reqnroll.Table)(null)), "And ");
#line hidden
            }
            await this.ScenarioCleanupAsync();
        }
    }
}
#pragma warning restore
#endregion
