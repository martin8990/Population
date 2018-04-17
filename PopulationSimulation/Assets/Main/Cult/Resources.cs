using System;
using UnityEngine;
using Utility;
using System.Collections;
public class Resources : MonoBehaviour
{
    [SerializeField] int StartWealth;
    public static int Wealth;
    private void Awake()
    {
        Wealth = StartWealth;
    }    
}