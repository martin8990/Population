using NUnit.Framework;
using UnityEngine;

public class ChanceCurveTest
{
    [Test]
    public void ChanceCurveAlwaysBetweenValuesX()
    {
        var curve = new ChanceCurve(new float[] {5,9 },new float[] {2,6});
        for (int i = 0; i < 1000; i++)
        {
            Assert.IsTrue(curve.GetValue() >= 5 && curve.GetValue() <= 9);
        }
    }

    [Test]
    public void ChanceCurveAlwaysExact()
    {
        var curve = new ChanceCurve(new float[] {0, 1}, new float[] { 2, 6 });
        bool notAlwaysExact = false;
        for (int i = 0; i < 10; i++)
        {
            if (curve.GetValue() > 0 && curve.GetValue() < 1)
            {
                notAlwaysExact = true;
                break;
            }
        }
        Assert.IsFalse(notAlwaysExact);
    }
}
