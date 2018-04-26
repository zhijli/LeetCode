using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P4_Test
    {
        [TestMethod]
        public void TestMethod1()
        {

            var t = new P4();
            //Console.Write(t.FindMedianSortedArrays(new int[] { 3, 3, 3, 3 }, new[] { 3, 3, 3, 3 }));


            // Console.Write(t.FindMedianSortedArrays(new int[] { 1, 1, 2, 3, 4, 5, 6, 6, 6, 6, 7, 8, 9, 11 }, new[] { 1, 1, 2, 3, 3 }));
            Console.Write(t.FindMedianSortedArrays(new int[] { 1}, new[] { 2,3,4,5,6,7,8, }));
        }
    }
}
