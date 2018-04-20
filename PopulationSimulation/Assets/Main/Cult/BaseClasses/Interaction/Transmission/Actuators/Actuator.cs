//using System;
//using UnityEngine;




//public interface IActuator
//{
//    TransmissionID GetSignalID();
//    GameObject gameObject { get; }
//    void Actuate(GameObject _target);
//}

//public abstract class Actuator<T> : MonoBehaviour, IActuator where T : Signal
//{
//    public T signal;
//    public Sensor<T> target;
//    public void Actuate(GameObject _target)
//    {
//        target = _target.GetComponentInChildren<Sensor<T>>();
//        target.Sense(signal);
//    }

//    public TransmissionID GetSignalID()
//    {
//        return signal.ID;
//    }
//}
