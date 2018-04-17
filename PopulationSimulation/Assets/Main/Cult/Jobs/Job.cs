using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

[System.Serializable]
public class Job
{
    List<Action> activities;

    public Job(List<Action> activities)
    {
        this.activities = activities;
    }

    public void ExecuteJob()
    {
        activities.ForEach((x) => x());
    }
}

public interface IResultContainer
{
    IResult[] results { get; set; }
}


public class TransmissionInjectors<T>
{
    List<InteractionModifier<T>> Modifiers = new List<InteractionModifier<T>>();
    List<InteractionAdder<T>> Adders = new List<InteractionAdder<T>>();

    public void SortInjector(IResult injector)
    {
        var modifier = injector as InteractionModifier<T>;
        var baseValue = injector as InteractionAdder<T>;

        if (modifier != null)
        {
            Modifiers.Add(modifier);
        }
        if (baseValue != null)
        {
            Adders.Add(baseValue);
        }

    }
}

public class InteractionInjectors<T>
{
    TransmissionInjectors<T> SenderInjectors;
    TransmissionInjectors<T> ReceiverInjectors;

    List<Target<T>> Targets = new List<Target<T>>();

    bool active;
    public InteractionInjectors(bool active)
    {
        this.active = active;
    }

    public void AcceptInjector(IResult injector)
    {
        var target = injector as Target<T>;
        if (active)
        {
            if (injector is Active<T>)
            {
                if (injector is Receiver<T>)
                {
                    ReceiverInjectors.SortInjector(injector);
                }
                else if (injector is Sender<T>)
                {
                    SenderInjectors.SortInjector(injector);
                }
                if (target != null)
                {
                    Targets.Add(target);
                }
            }
        }
        else
        {
            if (injector is Passive<T>)
            {
                if (injector is Receiver<T>)
                {
                    ReceiverInjectors.SortInjector(injector);
                }
                else if (injector is Sender<T>)
                {
                    SenderInjectors.SortInjector(injector);
                }
                if (target != null)
                {

                    Targets.Add(target);

                }
            }
        }


        
    }



}

public class Interaction<T>
{
    InteractionInjectors<T> activeInjectors = new InteractionInjectors<T>(true);
    InteractionInjectors<T> passiveInjectors = new InteractionInjectors<T>(false);

    void InternalSetup(List<IResultContainer> ActiveInjectors, List<IResultContainer> PassiveInjectors)
    {
        ActiveInjectors.ForEach((x) => x.results);
    }
    void ProcessActiveInjector(IResultContainer activeContainer)
    {

    }
    void ProcessPassiveInjector(IResultContainer passiveContainer)
    {

    }

    public void Setup(GameObject Active, List<GameObject> passives)
    {
        var ActiveInjectors = new List<IResultContainer>();
        var PassiveInjectors = new List<IResultContainer>();

        ActiveInjectors.AddRange(Active.GetComponents<IResultContainer>());
        passives.ForEach((x) => PassiveInjectors.AddRange(x.GetComponents<IResultContainer>()));
        InternalSetup(ActiveInjectors, PassiveInjectors);
    }
    public void Execute()
    {
        var result = baseValues.Sum(y => y.Value);
        if (modifiers.Count > 0)
        {
            result *= modifiers.Sum((x) => x.Value);
        }
        targets.ForEach(x => x.AddValue(result));
    }

}

public interface Active<T>
{
}
public interface Passive<T>
{
}
public interface Sender<T>
{
}
public interface Receiver<T>
{
}
public interface InteractionModifier<T>
{
    float Value { get; }
}
public interface InteractionAdder<T>
{
    float Value { get; }
}
public interface Target<T>
{
    void AddValue(float val);
}




