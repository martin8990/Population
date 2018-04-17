
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Male
{
    [RequireComponent(typeof(Text))]
    public class IntText : MonoBehaviour
    {
        public Func<int> GetValue;
        public String PreText = "";
        Text text;

        private void Awake()
        {
            text = GetComponent<Text>();
        }

        public void Update()
        {
            if (null == GetValue)
            {
                Debug.Log(gameObject.name);
            }
            text.text = PreText + GetValue();
        }

    }



}



