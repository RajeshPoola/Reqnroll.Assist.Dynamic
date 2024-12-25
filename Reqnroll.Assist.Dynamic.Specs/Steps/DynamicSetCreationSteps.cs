using System;
using System.Linq;
using FluentAssertions;

namespace Reqnroll.Assist.Dynamic.Specs.Steps;

[Binding]
public class DynamicSetCreationSteps(State state)
{
    private dynamic GetItem(int itemNumber)
    {
        return state.OriginalSet[itemNumber - 1];
    }


    [Given("I create a set of dynamic instances from this table")]
    [When("I create a set of dynamic instances from this table")]
    public void WithMethodBInding(Table table)
    {
        state.OriginalSet = table.CreateDynamicSet().ToList();
    }

    [Given("I create a set of dynamic instances from this table using no type conversion")]
    public void WithMethodBIndingNoTypeConversion(Table table)
    {
        state.OriginalSet = table.CreateDynamicSet(false).ToList();
    }


    [Then(@"I should have a list of (\d+) dynamic objects")]
    public void ShouldContain(int expectedNumberOfItems)
    {

        var actualNumberOfItems = state.OriginalSet.Count;
        actualNumberOfItems.Should().Be(expectedNumberOfItems);
    }

    [Then(@"the (\d+) item should have BirthDate equal to '(.*)'")]
    public void ItemInSetShouldHaveExpectedBirthDate(int itemNumber, string expectedBirthDate)
    {
        GetItem(itemNumber).BirthDate.Should().Be(DateTime.Parse(expectedBirthDate));
    }

    [Then(@"the (\d+) item should have Age equal to '(\d+)'")]
    public void ItemInSetShouldHaveExpectedAge(int itemNumber, int expectedAge)
    {
        GetItem(itemNumber).Age.Should().Be(expectedAge);
    }

    [Then("the (.*) item should still Name equal '(.*)'")]
    public void ThenTheItemShouldStillNameEqual(int itemNumber, string expectedName)
    {
        GetItem(itemNumber).Name.Should().Be(expectedName);
    }

    [Then("the (.*) item should still Age equal '(.*)'")]
    public void ThenTheItemShouldStillAgeEqual(int itemNumber, string expectedAge)
    {
        GetItem(itemNumber).Age.Should().Be(expectedAge);
    }


    [Then(@"the (\d+) item should have Name equal to '(.*)'")]
    public void ItemInSetShouldHaveExpectedName(int itemNumber, string expectedName)
    {
        GetItem(itemNumber).Name.Should().Be(expectedName);
    }

    [Then(@"the (\d+) item should have LengthInMeters equal to '(\d+\.\d+)'")]
    public void ItemInSetShouldHaveExpectedLenghtInMeters(int itemNumber, double expectedLengthInMetersItem)
    {
        GetItem(itemNumber).LengthInMeters.Should.Be(expectedLengthInMetersItem);
    }

    [When("I create a set of dynamic instances from this table using no type conversion")]
    public void WhenICreateASetOfDynamicInstancesFromThisTableUsingNoTypeConversion(Table table)
    {
        state.OriginalSet = table.CreateDynamicSet(false).ToList();
    }
}