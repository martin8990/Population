//using UnityEngine;
//using UnityEditor;
//using System.Reflection;
//using System.Collections.Generic;
//using Utility;
//using System;
//using System.Linq;

//[CustomEditor(typeof(Transmission))]
//public class ControlEditor : Editor
//{
//    // Get All signals
        
//    Dictionary<TransmissionID, List<GameObject>> sensorLookup;
      
//    public override void OnInspectorGUI()
//    {
//        base.OnInspectorGUI();
//        Transmission ctrl = target as Transmission;
//        if (sensorLookup == null || GUILayout.Button("Update"))
//        {
//            UpdateRelations(ctrl);
//        }
       
//        if (ctrl.Active != null)
//        {
//            var actuators = ctrl.Active.GetComponentsInChildren<IActuator>();
//            foreach (var actuator in actuators)
//            {
//                var SignalID = actuator.GetSignalID();
//                if (sensorLookup.ContainsKey(SignalID))
//                {
//                    var targets = sensorLookup[SignalID];

//                    var guistyle = new GUIStyle();
//                    guistyle.fontSize = 15;

//                    EditorGUILayout.LabelField(SignalID.name + " on " + actuator.gameObject.name, guistyle);
//                    foreach (var target in targets)
//                    {
//                        if (GUILayout.Button(target.name))
//                        {
//                            actuator.Actuate(target);
//                        }
//                    }
//                }
//                else
//                {
//                    Debug.Log(SignalID.name + " not found ");
//                }
//            }
//        }
//    }

//    void UpdateRelations(Transmission ctrl)
//    {

//        sensorLookup = new Dictionary<TransmissionID, List<GameObject>>();
//        var signalIds = ctrl.signalHierarchy.signals;
//        signalIds.ForEach((x) => sensorLookup.Add(x, new List<GameObject>()));

//        if (ctrl.Passive != null)
//        {
//            var sensors = ctrl.Passive.GetComponentsInChildren<ISensor>();
//            foreach (var sensor in sensors)
//            {
//                var id = sensor.GetSignalId();
//                sensorLookup[id].Add(sensor.gameObject);
//            }
//        }
        
//    }

//    //public static List<Type> GetInheritedOfType<T>() 
//    //{
//    //    var types = new List<Type>();
//    //    foreach (Type type in
//    //        Assembly.GetAssembly(typeof(T)).GetTypes()
//    //        .Where(myType => !myType.IsAbstract && myType.IsSubclassOf(typeof(T))))
//    //    {
//    //        types.Add(type);
//    //    }
//    //    return types;
//    //}

//}




















