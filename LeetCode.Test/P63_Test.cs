using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P63_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P63();
            t.UniquePathsWithObstacles(new int[,] {{0, 0, 0}, {0, 1, 0}, {0, 0, 0}});
        }
    }
}
