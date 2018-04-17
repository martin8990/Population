
using UnityEngine;
using System;
using UnityEngine.UI;
using Utility;

namespace Male
{
    [RequireComponent(typeof(Text))]
    public class SaturatedIntText : MonoBehaviour
    {
        public SaturatedInt saturatedInt;
        public String PreText = "";
        Text text;

        private void Start()
        {
            text = GetComponent<Text>();
            saturatedInt.OnAdd += UpdateText;
            saturatedInt.OnSubtract += UpdateText;
            UpdateText();
        }

        public void UpdateText()
        {

            text.text = PreText + saturatedInt.Value;
        }

    }



}



