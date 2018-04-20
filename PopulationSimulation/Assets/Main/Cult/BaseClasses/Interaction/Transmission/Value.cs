using System.Collections.Generic;
using System.Linq;

public class Value
{
    float baseValue;
    public List<Value> Adders = new List<Value>();
    public List<Value> Multipliers = new List<Value>();

    public List<float> TransmittedAdders = new List<float>();
    public List<float> TransmittedMultiplier = new List<float>();

    public Value(float baseValue)
    {
        this.baseValue = baseValue;
    }

    public float Val {
        get
        {
            float mult = 1;
            for (int i = 0; i < Multipliers.Count; i++)
            {
                mult *= Multipliers[i].Val;
            }
            for (int i = 0; i < TransmittedMultiplier.Count; i++)
            {
                mult *= TransmittedMultiplier[i];
            }

            return (baseValue + Adders.Sum((x) => x.Val) + TransmittedAdders.Sum()) * mult;
         }
    }

}


















