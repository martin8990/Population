using System.Linq;
using UnityEngine;
[System.Serializable]
public class ChanceCurve
{
    public float[] values;
    public float[] Chances;

    public ChanceCurve(float[] values, float[] chances)
    {
        this.values = values;
        Chances = chances;
    }

    public float GetValue()
    {
        var totalChance = Chances.Sum();
        float t = Random.Range(0, totalChance);
        int j = 0;
        for (int i = 0; i < Chances.Length; i++)
        {
            if (totalChance - Chances[i] < 0)
            {
                j = i;
                break;
            }
            else
            {
                totalChance -= Chances[i];
            }
        }
        return values[j];
    }
}
