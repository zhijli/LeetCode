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

            int[] nums = { -4, -2, -2, -2, 0, 1, 2, 2, 2, 3, 3, 4, 4, 6, 6 };
            var t = new P15_3Sum();
            var result = t.ThreeSum(nums);

            int[] nums1 = { 0, 0, 0 };
            result = t.ThreeSum(nums1);

            int[] nums2 = { -4, 1, -3, -4, 0, -5, -1, -1, 4, 4 };
            result = t.ThreeSum(nums2);
        }
    }
}
