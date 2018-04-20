//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using UnityEngine;
//using Utility;

//public class Population : MonoBehaviour {

//    public List<SocialGroup> groups = new List<SocialGroup>();
    
//}

//public class SocialGroup
//{
//    public List<Person> members = new List<Person>();
//    public Trait GetAverageTrait(TraitType type)
//    {
//        var traits = members.Map((x) => x.GetTrait(type));
//        float TotalValue = 0;
//        for (int i = 0; i < traits.Count; i++)
//        {
//            TotalValue += traits[i].Value;
//        }
//        return new Trait(TotalValue / members.Count, type);
//    }

//}

//public class Person
//{
//    public List<Trait> traits = new List<Trait>();
//    public Trait GetTrait(TraitId type)
//    {
//        for (int i = 0; i < traits.Count; i++)
//        {
//            if (traits[i].id == type)
//            {
//                return traits[i];
//            }
//        }
//        return null;
//    }
//}
//public class Trait
//{
//    float value;
//    public float Value { get { return value * (1 * Modifiers.Sum()); } }
//    public TraitId id;
//    public List<float> Modifiers = new List<float>();

//    public Trait(float value, TraitId id)
//    {
//        this.value = value;
//        this.id = id;
//    }
//}

//[CreateAssetMenu]
//public class TraitId : ScriptableObject
//{
//    public int Prio;
//}

//public class Modifier
//{
//    public List<Converter> converters = new List<Converter>();
//}

//public class Sensor : MonoBehaviour
//{
//    public SocialGroup target;
//    public TraitType type;
//    public Trait SenseTrait()
//    {
//        return target.GetAverageTrait(type);
//    }
//}

//public class Actuator<T> : MonoBehaviour
//{

//}
//public abstract class Converter : MonoBehaviour
//{
//    public abstract void Convert();
//}
//public abstract class BaseConverter<T> : Converter where T : Trait
//{
//    public List<Sensor<T>> sensors = new List<Sensor<T>>();
//}







