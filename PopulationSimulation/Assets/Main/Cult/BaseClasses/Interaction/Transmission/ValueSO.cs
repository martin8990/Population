using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[CreateAssetMenu]
public class ValueSO : ScriptableObject
{
    public int Id { get { return GetHashCode(); } }
    [SerializeField] float baseValue;

    [SerializeField] List<ValueSO> Adders = new List<ValueSO>();
    [SerializeField] List<ValueSO> Multipliers = new List<ValueSO>();

    public void InsertValue(ValueContainer valueCont)
    {
        valueCont.valueDict.Add(Id,new Value(baseValue));
    }
    public void SetupLinks(ValueContainer valueContainer)
    {
        var adders = new List<Value>();
        for (int i = 0; i < Adders.Count; i++)
        {
            if (valueContainer.valueDict.ContainsKey(Adders[i].Id))
            {
                adders.Add(Adders[i].GetValue(valueContainer));
            }
        }
        var mult = new List<Value>();
        for (int i = 0; i < Multipliers.Count; i++)
        {
            if (valueContainer.valueDict.ContainsKey(Multipliers[i].Id))
            {
                mult.Add(Multipliers[i].GetValue(valueContainer));
            }
        }
        GetValue(valueContainer).Adders = adders;
        GetValue(valueContainer).Adders = mult;
    }

    public Value GetValue(ValueContainer valueContainer)
    {
        return valueContainer.valueDict[Id];
    }

}


















