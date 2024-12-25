using System.Collections.Generic;

namespace Reqnroll.Assist.Dynamic.Specs.Steps;

[Binding]
public class StepArgumentTransformationSteps(State state)
{
    [Given("I create a set of dynamic instances from this table using step argument transformation")]
    public void A(IList<dynamic> dynamicSet)
    {
        state.OriginalSet = dynamicSet;
    }

    [When("I compare the set to this table using step argument transformation")]
    public void B(Table table)
    {
        table.CompareToDynamicSet(state.OriginalSet);
    }

    [Given("I create a dynamic instance from this table using step argument transformation")]
    public void C(dynamic instance)
    {
        state.OriginalInstance = instance;
    }

    [When("I compare it to this table using step argument transformation")]
    public void D(Table table)
    {
        var org = (object)state.OriginalInstance;
        table.CompareToDynamicInstance(org);
    }
}