using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P10_Test
    {
        [TestMethod]
        public void TestMethod1()
        {            
            var t = new P10();
            Assert.IsTrue(t.IsMatch("aa", "a*"));
            Assert.IsTrue(t.IsMatch("ab", ".*"));
            Assert.IsTrue(t.IsMatch("aab", "a*bc*"));
            Assert.IsTrue(t.IsMatch("aaab", "a*ab"));
            Assert.IsTrue(t.IsMatch("aab", "c*a*b"));
            Assert.IsFalse(t.IsMatch("aa", "c*a*b"));
            Assert.IsFalse(t.IsMatch("mississippi", "mis*is*p*."));
            Assert.IsTrue(t.IsMatch("bbbbba", ".*a*a"));
            Assert.IsTrue(t.IsMatch("a", "a*a"));
            Assert.IsFalse(t.IsMatch("ab", ".*c"));            

        }
    }
}
