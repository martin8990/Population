//using UnityEngine;
//using System.Collections.Generic;
//using Utility;
//public class StartingPopulationGenerator : MonoBehaviourExt
//{
//    [SerializeField]int AgeLimit = 101;
//    [SerializeField] [Range(0, 1f)] float femaleFrac = 0.55f;
//    [SerializeField] AnimationCurve maleAgeCurve;
//    [SerializeField] AnimationCurve femaleAgeCurve;
//    [SerializeField] Gender males;
//    [SerializeField] Gender females;
//    [SerializeField] int startingPopulation = 10000;

//    void Start()
//    {
//        CreateNewPopulation();        
//    }
//    [Button]
//    public void CreateNewPopulation()
//    {
//        int nMales =Mathf.RoundToInt(startingPopulation * (1f - femaleFrac));
//        int nFemales = Mathf.RoundToInt(startingPopulation * (femaleFrac));
//        males.PopulationPerAge = EvaluateAgeCurve(maleAgeCurve, nMales);        
//        females.PopulationPerAge = EvaluateAgeCurve(femaleAgeCurve, nFemales);

//    }
//    List<int> EvaluateAgeCurve(AnimationCurve curve, int nPeople)
//    {
//        List<int> AgeGroups = new List<int>(AgeLimit);
//        float totalScore = 0;
//        for (int i = 0; i < AgeLimit; i++)
//        {
//            totalScore += curve.Evaluate(i * (1f / AgeLimit));
//        }
//        for (int i = 0; i < AgeLimit; i++)
//        {
//            int AgePopulation = Mathf.RoundToInt(curve.Evaluate(i * (1f / AgeLimit))/totalScore * nPeople);
//            AgeGroups.Add(AgePopulation);
//        }
//        return AgeGroups;
//    }

//}