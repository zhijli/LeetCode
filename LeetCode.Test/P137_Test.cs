using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P137_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t= new P137();
            var num = new int[] { 2,2,3,2};
            t.SingleNumber(num);
        }
    }
}
