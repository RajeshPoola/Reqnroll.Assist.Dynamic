# Reqnroll.Assist.Dynamic

Reqnroll.Assist.Dynamic is a couple of simple extension methods for the Reqnroll Table object that helps you to write less code. 

What would you rather write? 
This:
```c#
[Binding]
public class StepsUsingStaticType
{
    private Person _person;

    [Given(@"I create an instance from this table")]
    public void GivenICreateAnInstanceFromThisTable(Table table)
    {
        _person = table.CreateInstance<Person>();
    }

    [Then(@"the Name property on Person should equal '(.*)'")]
    public void PersonNameShouldBe(string expectedValue)
    {
        Assert.AreEqual(expectedValue, _person.Name);
    }
}

// And then make sure to not forget defining a separate Person class for testing, 
// since you don't want to reuse the one your system under test is using - that's bad practice

// Should probably be in another file too...
// might need unit tests if the logic is complicated
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public DateTime BirthDate { get; set; }
    public double LengthInMeters { get; set; }
}
```
    
Or this:  
```c#
[Binding]
public class StepsUsingDynamic
{
    private dynamic _instance;

    [Given(@"I create an instance from this table")]
    public void c(dynamic instance) { _instance = instance; }

    [Then(@"the Name property should equal '(.*)'")]
    public void NameShouldBe(string expectedValue) { Assert.AreEqual(expectedValue, _instance.Name);  }
}
```
The later version uses Reqnroll.Assist.Dynamic. Shorter, sweater and more fun!

> well, this is may be one of the best usecase for dynamic i have ever seen
>> A happy Reqnroll.Assists.Dynamic user

Full [documentation on the wiki](https://github.com/RajeshPoola/Reqnroll.Assist.Dynamic/wiki/Documentation)
