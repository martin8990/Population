using UnityEngine;
using UnityEngine.AI;
namespace Utility
{
    public static class monoBehave
    {

        public static GameObject AddSphericalColliderChild(this GameObject obj, string name, float range)
        {
            var GO = new GameObject(name);
            GO.transform.SetParent(obj.transform, false);
            GO.layer = obj.layer;

            var col = GO.AddComponent<SphereCollider>();
            col.radius = range;
            col.isTrigger = true;

            GO.AddComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
            return GO;
        }

        public static void SmoothlyRotateTowards(this Transform transform, Transform target, float speed)
        {
            Vector3 relativePos = target.position - transform.position;
            Quaternion rotation = Quaternion.LookRotation(relativePos);
            Quaternion current = transform.localRotation;
            transform.localRotation = Quaternion.Slerp(current, rotation, Time.deltaTime * speed);
        }

        public static bool WalkToMe(this Transform transform, NavMeshAgent agent)
        {
            agent.stoppingDistance = Mathf.Min(transform.localScale.x, transform.localScale.z) + 0.8f;
            if (Vector3.Distance(transform.position, (agent.transform.position)) > agent.stoppingDistance)
            {
                agent.isStopped = false;
                agent.SetDestination(transform.position);
                return false;
            }
            else
            {
                agent.isStopped = true; 
                return true;
            }
        }

        public static void DestroyKids(this MonoBehaviour go)
        {
            for (int i = go.transform.childCount - 1; i >= 0; i--)
            {
              MonoBehaviour.DestroyImmediate(go.transform.GetChild(i).gameObject);
            }
        }
        public static void DestroyKids(this GameObject go)
        {
            for (int i = go.transform.childCount - 1; i >= 0; i--)
            {
                MonoBehaviour.DestroyImmediate(go.transform.GetChild(i).gameObject);
            }
        }
        public static GameObject[] GetKids(this GameObject go)
        {
            var kids = new GameObject[go.transform.childCount];
            for (int i = go.transform.childCount - 1; i >= 0; i--)
            {
                kids[i] = go.transform.GetChild(i).gameObject;
            }
            return kids;
        }
    }

}
