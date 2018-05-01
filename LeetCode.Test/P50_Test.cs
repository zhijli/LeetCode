using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P50_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P50();
            Assert.AreEqual(t.MyPow(2, 10), Math.Pow(2, 10));
        }
    }
}
