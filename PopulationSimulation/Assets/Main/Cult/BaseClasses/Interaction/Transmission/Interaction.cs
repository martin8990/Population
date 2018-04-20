using System.Collections.Generic;
[System.Serializable]
public class Interaction
{
    public List<TransmissionSO> transmissions = new List<TransmissionSO>();
    public ValueContainerGroup TargetGroup;

    public void Interact(ValueContainerGroup originGroup)
    {
        foreach (var transmission in transmissions)
        {
            foreach (var origin in originGroup.valueContainer)
            {
                foreach (var destination in TargetGroup.valueContainer)
                {
                    transmission.Transmit(origin, destination);
                }
            }
        }
    }
}


















