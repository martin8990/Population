using System;
using System.Collections.Generic;
using System.Linq;

public class JobTarget
{
    Func<Result> targetStat;
    List<Func<float>> effectModifiers;
    float baseEffect;

    public JobTarget(Func<Result> targetStat, List<Func<float>> effectModifiers, float baseEffect)
    {
        this.targetStat = targetStat;
        this.effectModifiers = effectModifiers;
        this.baseEffect = baseEffect;
    }

    public void Execute()
    {
        targetStat().Add(baseEffect * effectModifiers.Sum((x) => x()));
    }
}

