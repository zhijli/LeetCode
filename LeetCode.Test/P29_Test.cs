using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P29_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P29();
            Assert.AreEqual(t.Divide(123456, 3), 123456/3);
            Assert.AreEqual(t.Divide(123456, -3), 123456 / -3);
            Assert.AreEqual(t.Divide(-123456, 3), -123456 / 3);
            Assert.AreEqual(t.Divide(-123456, -3), -123456 / -3);
        }
    }
}
