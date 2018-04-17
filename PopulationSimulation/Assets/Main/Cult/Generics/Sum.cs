using System.Linq;
public class Sum : Calculation
{
    protected override void Calculate()
    {
        value = childCalculations.Sum((x) => x.value);
    }
}

