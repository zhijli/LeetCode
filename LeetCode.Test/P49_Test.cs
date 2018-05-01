using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P49_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P49();
            t.GroupAnagrams(new string[] {"eat", "tea", "tan", "ate", "nat", "bat"});
        }
    }
}
