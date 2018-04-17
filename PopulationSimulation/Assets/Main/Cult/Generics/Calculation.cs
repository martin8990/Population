using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utility;


public abstract class Calculation : MonoBehaviour
{
    public float value;
    public event Action OnRecalculate;
    void ReCalculate()
    {
        Calculate();
        OnRecalculate();
    }

    [SerializeField] protected List<Calculation> childCalculations = new List<Calculation>();
    private void Awake()
    {
        childCalculations.Iter((x) => x.OnRecalculate += ReCalculate);

    }

    public void AddCalculation(Calculation calculation)
    {
        calculation.OnRecalculate += ReCalculate;
        childCalculations.Add(calculation);
    }
    protected abstract void Calculate();
}
