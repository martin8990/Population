using System.Collections.Generic;

[System.Serializable]
public class Person
{
    public string Name = "John";
    public int Age = 20;
    public Gender gender = Gender.Male;
    public Skills skills;
    public CultIdentity cultIdentity;
    public List<Job> jobs = new List<Job>();

}