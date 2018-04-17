//using UnityEngine;
//using NUnit.Framework;
//using UnityEngine.TestTools;

//namespace Utility
//{


//    public class SaturatedValueTest
//    {
//        [Test]
//        public void SaturatedIntOnValueChangesRuns()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);
//            SInt.Value = 0;
//            bool works = false;
//            SInt.OnAdd += () => works = true;
//            SInt.Add(1);
//            Assert.IsTrue(works);
//        }
//        [Test]
//        public void SaturatedIntOnValueSaturatedRuns()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            bool works = false;
//            SInt.OnUpperSaturation += (x) => works = true;
//            SInt.Value = 5;
//            SInt.MaxValue = 7;
//            SInt.Add(2);
//            Assert.IsTrue(works);
//        }
//        [Test]
//        public void SaturatedMaxValue()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            SInt.Value = 5;
//            SInt.MaxValue = 7;
//            SInt.Add(3);
//            Assert.IsTrue(SInt.Value == 7);
//        }
//        [Test]
//        public void SaturatedMinValue()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            SInt.Value = 5;
//            SInt.MinValue = 3;
//            SInt.Add(-3);
//            Assert.IsTrue(SInt.Value == 3);
//        }
//        [Test]
//        public void OnMinValueRuns()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            bool works = false;
//            SInt.OnLowerSaturation += (x) => works = true;
//            SInt.Value = 5;
//            SInt.MinValue = 3;
//            SInt.Add(-3);
//            Assert.IsTrue(works);
//        }
//        [Test]
//        public void OnMinValueReturnsRemainder()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            SInt.OnLowerSaturation += (x) => Assert.IsTrue(x == 1);
//            SInt.Value = 5;
//            SInt.MinValue = 3;
//            SInt.Add(-3);

//        }

//        [Test]
//        public void OnMaxValueReturnsRemainder()
//        {
//            var SInt = new SaturatedInt(0, 10, 5);

//            SInt.Value = 0;
//            SInt.OnUpperSaturation += (x) => Assert.IsTrue(x == 1);
//            SInt.Value = 5;
//            SInt.MaxValue = 8;
//            SInt.Add(4);

//        }


//    }


//}


