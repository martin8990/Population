using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class InterAction
{
    public List<ValueType> ActiveTypes;
    public List<ValueType> PassiveTypes;
    // Foreach activeType -> GetTargetSocialReceptionTypes
}

public class Value
{
    [SerializeField] float BaseValue;

    ValueType myType;

    public List<ValueType> targetTypes = new List<ValueType>();
    public List<SocialReceptorType> targetSocialTypes = new List<SocialReceptorType>();
    public List<SocialReceptorType> SelfReceptor = new List<SocialReceptorType>();

    List<Func<float>> Modifiers = new List<Func<float>>();
    public float GetValue()
    {
        return BaseValue * (1 + Modifiers.Sum((x) => x()));
    }
}

public class SocialReceptor
{
    List<Func<float>> Links = new List<Func<float>>();
    List<Func<float>> Modifiers = new List<Func<float>>();

    public void AddLink(Func<float> link)
    {

    }
    public void AddModifier(Func<float> Modifier)
    {

    }
}

public enum SocialReceptorType
{
    Smell
}

public enum ValueType
{Charisma}








[System.Serializable]
public class Result : IResult
{
    [SerializeField] float Value;
    public List<float> Modifiers;

    public void SetBaseValue(float _val)
    {
        Value = _val;
    }

    public Result(float value, List<float> modifier)
    {
        Value = value;
        Modifiers = modifier;
    }

    public Result(float value) 
    {
        Value = value;
        Modifiers = new List<float>();
    }

    public float GetResult()
    {
        var result = Value;
        for (int i = 0; i < Modifiers.Count; i++)
        {
            result *= Modifiers[i];
        }
        return result;
    }
    public void Add(float value)
    {
        Debug.Log("OnAdd " + value);
        Value += value;
    }
    public void Remove(float value)
    {
        Value += value;
    }
}
