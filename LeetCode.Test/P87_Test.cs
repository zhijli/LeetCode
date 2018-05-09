using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P87_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P87();
            t.IsScramble("abcd", "bcda");
        }
    }
}
