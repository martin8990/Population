using System;
using System.Linq;
using UnityEngine;
using Utility;

public interface IRecruitListener
{
    void OnRecruit();
}

public class PersonRecruiter : MonoBehaviourExt
{
    [SerializeField] Person person = new Person();
    [SerializeField] Cult cult;
    [Button]
    public void RecruitPerson()
    {
        cult.people.Add(person);
        person = new Person();
    }
}

public class PersonGenerator : MonoBehaviour
{

    [SerializeField] ChanceCurve ageCurve;
    public Result FemaleRatio;
    public Result Charisma;
    public Result Work;
    public Result Support;
    
    Person GeneratePerson()
    {
        var person = new Person();
        person.Age = (int)ageCurve.GetValue();
        if (UnityEngine.Random.Range(0,1f) > Randomizer.RandomizeWValue(FemaleRatio.GetResult(),0.1f))
        {
            person.gender = Gender.Female;
        }
        else
        {
            person.gender = Gender.Male;
        }
        person.skills.Charisma.SetBaseValue((int)Randomizer.RandomizeWRatio(Charisma.GetResult(), 0.1f));
        person.skills.Working.SetBaseValue((int)Randomizer.RandomizeWRatio(Work.GetResult(), 0.5f));
        person.skills.Support.SetBaseValue((int)Randomizer.RandomizeWRatio(Support.GetResult(), 0.5f));

        return person;

    }

}

public static class Randomizer
{
    public static float RandomizeWRatio(float val, float OffsetRatio)
    {
        return UnityEngine.Random.Range(val - val* OffsetRatio, val + val * OffsetRatio);
    }
    public static float RandomizeWValue(float val, float maxOffset)
    {
        return UnityEngine.Random.Range(val - maxOffset, val + maxOffset);
    }
}
