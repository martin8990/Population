using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Utility;
using System;

public abstract class StatModifier
{
    public abstract void ModifyStat(Person person);    
}
public class CharismaModifier : StatModifier
{
    public override void ModifyStat(Person person)
    {
        throw new NotImplementedException();
    }
}






public class InfluenceJobAssigner : MonoBehaviourExt
{
    [SerializeField] float BaseCost = 0.3f;
    [SerializeField] float CharismaMod = 0.8f;
    [SerializeField] float BaseEffect = 0.8f;

    [SerializeField] int OriginId = 0;
    [SerializeField] int targetId = 1;
    [SerializeField] Cult cult;
    [Button]
    public void Execute()
    {
        var origin = cult.people[OriginId];
        var target = cult.people[targetId];
        AssignInfluenceJob(origin, target);

   
    }

    public void AssignInfluenceJob(Person origin, Person target)
    {

        var InfluenceCostActivity = ActivityLibrary.GetInfluenceActivity(target, () => BaseCost);
        var InfluenceEffect = ActivityLibrary.GetCharismaticAbility(target);
        Func<float> InfluenceEffectMod = () => CharismaMod;
        Func<float> InfluenceEffectBase = () => BaseEffect;
        Func<float> TotalCharismaticAbility = () => InfluenceEffect() * InfluenceEffectMod() + InfluenceEffectBase();

        var a1 = ActivityLibrary.GetInfluenceActivity(origin, () => BaseCost);
        var a2 = ActivityLibrary.GetInfluenceActivity(target, TotalCharismaticAbility);

        origin.jobs.Add(new Job(new List<Action> {a1,a2 }));
        
    }










}



public class SampleValue
{
    public static int id;
}

public class Inherited : SampleValue
{
    public new static int id;
}