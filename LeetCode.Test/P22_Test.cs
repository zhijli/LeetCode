using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P22_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P22();
            var result = t.GenerateParenthesis(4);

            foreach(var str in result)
            {
                Console.WriteLine(str);
            }
        }
    }
}
