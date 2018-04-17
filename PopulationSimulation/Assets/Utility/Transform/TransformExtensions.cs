using UnityEngine;
using UnityEngine.AI;
namespace Utility
{
    public static class TransformExtensions
    {
        public static float GetAngle(this Transform transform, Vector3 target)
        {
            return Vector3.Angle(transform.forward,target-transform.position);

        }
     
    }

}
