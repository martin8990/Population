using UnityEngine;
using NUnit.Framework;
namespace Utility
{
    public class AngleTest
    {
        [Test]
        public void AngleInFrontIs0()
        {
            var tf = new GameObject().transform;
            Assert.IsTrue(tf.GetAngle(new Vector3(0, 0, 1)) == 0);
        }

        [Test]
        public void AngleLeftIsBiggerThan0Angle()
        {
            var tf = new GameObject().transform;
            var angle1 = tf.GetAngle(new Vector3(0, 0, 1)) ;
            var angle2 = tf.GetAngle(new Vector3(-1, 0, 1));
            Assert.IsTrue(angle2 > angle1);
        }

        [Test]
        public void AngleRightIsBiggerThan0Angle()
        {
            var tf = new GameObject().transform;
            var angle1 = tf.GetAngle(new Vector3(0, 0, 1));
            var angle2 = tf.GetAngle(new Vector3(1, 0, 1));
            Assert.IsTrue(angle2 > angle1);
        }
        [Test]
        public void DistanceNotRelevant()
        {
            var tf = new GameObject().transform;
            var angle1 = tf.GetAngle(new Vector3(1, 0, 100));
            var angle2 = tf.GetAngle(new Vector3(-1, 0, 1));
            Assert.IsTrue(angle2 > angle1);
        }
        [Test]
        public void AngleBehindIs180()
        {
            var tf = new GameObject().transform;
            var angle1 = tf.GetAngle(new Vector3(0, 0, -1));
            Assert.IsTrue(179 < angle1);
        }
    }

}
