using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using UnityEngine;

namespace Utility
{

    public class BrenshamTest
    {
        [Test]
        public void StartAndEndConnected()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(6, 8);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(p1) && connected.Contains(p2));
        }
        [Test]
        public void StartAndEndConnectedInv()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(6, 7);
            var p2 = new Vector2Int(3, 3);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            //Brensham.Connect(p1, p2, (x) => Debug.Log(x));

            Assert.IsTrue(connected.Contains(p1) && connected.Contains(p2));
        }
        [Test]
        public void StartAndEndConnectedSameVal()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(3, 3);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(p1) && connected.Contains(p2));
        }
        [Test]
        public void StartAndEndConnecteddx1()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(4, 3);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(p1) && connected.Contains(p2));
        }
        [Test]
        public void StartAndEndConnecteddy1()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(3, 4);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(p1) && connected.Contains(p2));
        }
        [Test]
        public void MidpointInSet()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(1, 1);
            var p2 = new Vector2Int(3, 3);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(new Vector2Int(2,2)));
        }
        [Test]
        public void MidpointInSetInv()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(1, 1);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(new Vector2Int(2, 2)));
        }
        [Test]
        public void NoOvershoot()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(3, 3);
            var p2 = new Vector2Int(1, 1);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(!connected.Contains(new Vector2Int(4, 4)));
        }
        [Test]
        public void MidpointVertical()
        {
            var connected = new List<Vector2Int>();
            var p1 = new Vector2Int(1, 3);
            var p2 = new Vector2Int(1, 1);
            Brensham.Connect(p1, p2, (x) => connected.Add(x));
            Assert.IsTrue(connected.Contains(new Vector2Int(1, 2)));
        }

    }
   
}
