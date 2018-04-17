﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using UnityEngine;

namespace Utility
{

    public static class MousePositioning
    {
        public static Vector3 MouseToWorldPos(Camera cam)
        {

            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit))
            {
                return hit.point;

                // Do something with the object that was hit by the raycast.
            }
            //Debug.Log("mis");
            return Vector3.zero;
        }
        public static Vector3 MouseToWorldPos(Camera cam,LayerMask layermask)
        {

            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            
            if (Physics.Raycast(ray, out hit,Mathf.Infinity, layermask))
            {
                Debug.DrawRay(hit.point + Vector3.down * 10,Vector3.up * 10,Color.red);
                return hit.point;

                // Do something with the object that was hit by the raycast.
            }
           // Debug.Log("mis");
            return Vector3.zero;
        }
        public static T GetTypeUnderMouse<T>(Camera cam, LayerMask layermask) where T : Component
        {

            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layermask))
            {
                Debug.DrawRay(hit.point + Vector3.down * 10, Vector3.up * 10, Color.red);
                return hit.collider.gameObject.GetComponent<T>();

                // Do something with the object that was hit by the raycast.
            }
            // Debug.Log("mis");
            return default(T);
        }
        public static GameObject GetGamobjectUnderMouse(Camera cam, LayerMask layermask)
        {

            RaycastHit hit;
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, layermask))
            {
                Debug.DrawRay(hit.point + Vector3.down * 10, Vector3.up * 10, Color.red);
                return hit.collider.gameObject;

                // Do something with the object that was hit by the raycast.
            }
            // Debug.Log("mis");
            return null;
        }



        public static bool VerticalRayCast(Vector3 p,float range,out RaycastHit hit)
        {
            var p_up = new Vector3(p.x, range, p.z);
            var p_down = new Vector3(0, -range, 0);

            var ray = new Ray(p_up, p_down);

            //Debug.DrawRay(p_up, p_down);
            return Physics.Raycast(ray, out hit);
        }
        public static bool VerticalRayCast(Vector3 p, float range, out RaycastHit hit, LayerMask layerMask)
        {
            var p_up = new Vector3(p.x, range, p.z);
            var p_down = new Vector3(0, -range, 0);

            var ray = new Ray(p_up, p_down);

            //Debug.DrawRay(p_up, p_down);
            return Physics.Raycast(ray, out hit,range*2, layerMask);
        }

    }
}
