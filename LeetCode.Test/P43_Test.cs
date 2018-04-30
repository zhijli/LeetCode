using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P43_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P43();

            Console.WriteLine(t.Plus("8349", "344956"));
            Console.WriteLine(8349+344956);


            Console.WriteLine(t.Plus("999999", "100001"));
            Console.WriteLine(999999 + 100001);

            Console.WriteLine(t.Multiply("9399", "987"));
            Console.WriteLine(9399 * 987);
        }
    }
}
