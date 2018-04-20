using System;
using System.Collections.Generic;
using UnityEngine;
public abstract class Processor : MonoBehaviour
{
    public List<Processor> outputs = new List<Processor>();// Values On this person Affected by this value
    public List<Func<float>> Inputs = new List<Func<float>>();
    [SerializeField] float Value;
    private void Awake()
    {
        outputs.ForEach((x) => x.Inputs.Add(() => Value));
    }
    public void Process()
    {
        DoMyProcess();
        outputs.ForEach((x) => Process());
    }
    protected abstract void DoMyProcess();    
}
