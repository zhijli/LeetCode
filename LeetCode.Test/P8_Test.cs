using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P8_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P8();
            Console.Write(t.MyAtoi("2147483646"));
        }
    }
}
