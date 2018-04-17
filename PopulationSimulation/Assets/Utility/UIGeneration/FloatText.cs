
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Male
{
    [RequireComponent(typeof(Text))]
    public class FloatText : MonoBehaviour
    {
        public Func<float> GetValue;
        public String PreText;
        Text text;

        private void Awake()
        {
            text = GetComponent<Text>();
        }

        public void Update()
        {
            if (GetValue == null)
            {
                Debug.Log(gameObject.name);
            }
            text.text = PreText + GetValue();
        }
        
    }



}



