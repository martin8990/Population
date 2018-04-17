using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;



namespace Utility
{


    public enum UILayout
    {
        Vertical,Horizontal
    }

    public static class UIGenerator
    {
        public static GameObject[] GenerateUI(GameObject prefab, Transform parent, int amount, UILayout layout)
        {
            var GOS = new GameObject[amount].InitEXT(() => GameObject.Instantiate(prefab, parent));
            var rectTFs = GOS.Map((x) => x.GetComponent<RectTransform>());
            if (layout == UILayout.Vertical)
            {
                UIPositioner.PositionVertically(parent, rectTFs);
            }
            else if (layout == UILayout.Horizontal)
            {
                UIPositioner.PositionHorizontally(parent, rectTFs);
            }
            return GOS;
        }

        public static GameObject[] GenerateUIFixedSize(GameObject prefab, Transform parent, int amount, UILayout layout,float sizePerElement)
        {
            var GOS = new GameObject[amount].InitEXT(() => GameObject.Instantiate(prefab, parent));
            var rectTFs = GOS.Map((x) => x.GetComponent<RectTransform>());
            if (layout == UILayout.Vertical)
            {
                UIPositioner.PositionPixelwiseVertically(parent, rectTFs, sizePerElement);
            }
            else if (layout == UILayout.Horizontal)
            {
                UIPositioner.PositionHorizontally(parent, rectTFs);
            }
            return GOS;
        }

        public static T[] GenerateUIFixedSize<T>(T prefab, Transform parent, int amount, UILayout layout, float sizePerElement) where T : Component
        {
            var GOS = new T[amount].InitEXT(() => GameObject.Instantiate(prefab, parent));
            var rectTFs = GOS.Map((x) => x.GetComponent<RectTransform>());
            if (layout == UILayout.Vertical)
            {
                UIPositioner.PositionPixelwiseVertically(parent, rectTFs, sizePerElement);
            }
            else if (layout == UILayout.Horizontal)
            {
                UIPositioner.PositionHorizontally(parent, rectTFs);
            }
            return GOS;
        }

    }

    
}