using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P15_3SumTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] nums = { -1, 0, 1, 2, -1, -4 };
            var t = new P15_3Sum();
            t.ThreeSum(nums);
        }
    }
}
