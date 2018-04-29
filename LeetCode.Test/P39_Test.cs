using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P39_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P39();
            var result = t.CombinationSum(new[] { 2, 3, 6, 7 }, 7);
        }
    }
}
