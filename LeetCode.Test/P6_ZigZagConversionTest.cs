using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P6_ZigZagConversionTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            var s = "PAYPALISHIRING";
            var numRows = 3;
            var expected = "PAHNAPLSIIGYIR";
            var t = new P6_ZigZagConversion();
            var actual = t.Convert(s, numRows);
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void TestMethod2()
        {

            var s = "A";
            var numRows = 1;
            var expected = "A";
            var t = new P6_ZigZagConversion();
            var actual = t.Convert(s, numRows);
            Assert.AreEqual(expected, actual);

        }
    }
}
