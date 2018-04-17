using System;
using UnityEngine;


namespace Utility
{

    public class SaturatedInt : MonoBehaviour
    {
        public int MinValue = 0;
        public int MaxValue = 10;
        public int Value = 5;

        //public SaturatedInt(int minValue, int maxValue, int value)
        //{
        //    MinValue = minValue;
        //    MaxValue = maxValue;
        //    Value = value;
        //}

        public event Action<int> OnUpperSaturation = delegate { };
        public event Action<int> OnLowerSaturation = delegate { };
        public event Action OnAdd = delegate { };
        public event Action OnSubtract = delegate { };

        public void Subtract(int subtract)
        {
            if (subtract < 0)
            {
                Add(-subtract);
            }
            else if (subtract != 0)
            {
      
                Value -= subtract;
                if (Value <= MinValue)
                {
                    int delta = MinValue - Value;
                    Value = MinValue;
                    OnLowerSaturation(delta);
                }
                OnSubtract();
            }
        }
        public void Add(int add)
        {
            if (add<0)
            {
                Subtract(-add);
            }
            else if (add != 0)
            {
              
                Value += add;
                if (Value >= MaxValue)
                {
                    int delta = Value - MaxValue;
                    Value = MaxValue;
                    OnUpperSaturation(delta);
                }
                OnAdd();
            }            
        }

  
    }

    
}


