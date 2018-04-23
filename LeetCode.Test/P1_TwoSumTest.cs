using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    using System.Runtime.Remoting;

    [TestClass]
    public class P1_TwoSumTest
    {
        [TestMethod]
        public void P1_TwoSum()
        {
            var input = new int[] {2, 7, 11, 15};
            var target = 9;
            var expected = new int[] { 0, 1 };

            var t = new P1_TwoSum();
            var actual = t.TwoSum(input, target);
            
            Assert.AreEqual(expected[0], actual[0]);
            Assert.AreEqual(expected[1], actual[1]);

        }
    }
}
