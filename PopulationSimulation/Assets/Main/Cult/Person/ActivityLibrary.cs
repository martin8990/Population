using System;
public static class ActivityLibrary
{
    public static Action GetInfluenceActivity(Person target,Func<float> GetEffectiveness)
    {
        return () => target.cultIdentity.Influence.Add(GetEffectiveness());
    }
    public static Func<float> GetCharismaticAbility(Person target)
    {
        return () => target.skills.Charisma.GetResult();
    }

}



