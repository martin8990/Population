using UnityEngine;
[System.Serializable]
public struct CultIdentity 
{
    public Result Influence;

    public CultIdentity(Result influence)
    {
        Influence = influence;
    }
}
