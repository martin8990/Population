
using UnityEngine;
using System;
using UnityEngine.UI;

namespace Male
{
    [RequireComponent(typeof(Image))]
    public class StatusBar : MonoBehaviour
    {
        public Func<float> GetValue;
        
        Image image;

        private void Awake()
        {
            image = GetComponent<Image>();
        }

        public void Update()
        {
            if (GetValue == null)
            {
                Debug.Log(gameObject.name);
            }
            image.fillAmount = GetValue();
        }

    }



}



