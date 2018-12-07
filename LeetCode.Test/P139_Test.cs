using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P139_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P139();
            var wordDict = new string[] { "cats", "dog", "sand", "and", "cat" };
            t.WordBreak("Hello", wordDict);
        }
    }
}
