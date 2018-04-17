using System;
using UnityEngine;
using Utility;
using System.Collections;
public class TimeManager : MonoBehaviour
{
    public event Action OnTick = delegate { };
    public event Action OnEndYear = delegate { };
    public static TimeManager Instance;
    public int TicksPerYear = 12;
    [SerializeField] float TicksPerSecond = 1;
    int tick = 0;
    private void Awake()
    {
        Instance = this;
        StartCoroutine(Tick());
    }

    IEnumerator Tick()
    {
        yield return new WaitForSeconds(TicksPerSecond);
        OnTick();
        tick++;
        if (tick == TicksPerYear)
        {
            tick = 0;
            OnEndYear();
        }
        StartCoroutine(Tick());
    }
   



}