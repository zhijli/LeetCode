using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P9_PalindromeNumberTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P9_PalindromeNumber();
            t.IsPalindrome(12321);
        }
    }
}
