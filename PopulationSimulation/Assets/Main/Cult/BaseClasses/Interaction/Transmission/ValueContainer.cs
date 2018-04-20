using System.Collections.Generic;
using UnityEngine;
public class ValueContainer : MonoBehaviour
{
    public List<ValueSO> values;
    public Dictionary<int,Value> valueDict = new Dictionary<int, Value>();

   
    void SetupValues()
    {
        values.ForEach((x) => x.InsertValue(this));
        values.ForEach((x) => x.SetupLinks(this));
    }

}


















