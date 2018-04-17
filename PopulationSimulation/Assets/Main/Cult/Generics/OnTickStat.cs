using UnityEngine;
public class OnTickStat : MonoBehaviour
{
    public float value;
    public Result derivative;
    [SerializeField] bool absolute;
    private void Start()
    {
        TimeManager.Instance.OnTick += Tick;   
    }
    void Tick()
    {
        value += derivative.GetResult();
        if (absolute && value<0)
        {
            value = 0;
        }
    }
    
}
