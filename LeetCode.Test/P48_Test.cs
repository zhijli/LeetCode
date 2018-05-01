using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P48_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P48();
            t.Rotate(new[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } });
        }
    }

}
