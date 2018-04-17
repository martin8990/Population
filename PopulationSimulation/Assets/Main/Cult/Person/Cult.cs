using System.Collections.Generic;
using UnityEngine;
public class Cult : MonoBehaviour
{
    public List<Person> people = new List<Person>();
    private void Start()
    {
        TimeManager.Instance.OnTick += DoJobs;
    }
    void DoJobs()
    {
        people.ForEach((x) => x.jobs.ForEach((y) => y.ExecuteJob()));
    }
}