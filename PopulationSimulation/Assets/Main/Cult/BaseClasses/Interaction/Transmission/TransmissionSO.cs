using UnityEngine;


[CreateAssetMenu]
public class TransmissionSO : ScriptableObject
{
    ValueSO actuator;
    ValueSO sensor;
    [SerializeField]bool Mult;
       
    public void Transmit(ValueContainer origin, ValueContainer dest)
    {
        if (Mult)
        {
            sensor.GetValue(origin).TransmittedMultiplier.Add(actuator.GetValue(origin).Val);
        }
        else
        {
            sensor.GetValue(origin).TransmittedAdders.Add(actuator.GetValue(origin).Val);
        }
    }

    public void UnSet(ValueContainer origin, ValueContainer dest)
    {
        if (Mult)
        {
            sensor.GetValue(origin).TransmittedMultiplier.Remove(actuator.GetValue(origin).Val);
        }
        else
        {
            sensor.GetValue(origin).TransmittedAdders.Remove(actuator.GetValue(origin).Val);
        }
    }

}


















