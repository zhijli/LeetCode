using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetCode.Test
{
    [TestClass]
    public class P37_Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var t = new P37();
            char[,] board = {{'5', '3', '.', '.', '7', '.', '.', '.', '.'},{'6', '.', '.', '1', '9', '5', '.', '.', '.'},{'.', '9', '8', '.', '.', '.', '.', '6', '.'},{'8', '.', '.', '.', '6', '.', '.', '.', '3'},{'4', '.', '.', '8', '.', '3', '.', '.', '1'},{'7', '.', '.', '.', '2', '.', '.', '.', '6'},{'.', '6', '.', '.', '.', '.', '2', '8', '.'},{'.', '.', '.', '4', '1', '9', '.', '.', '5'},{'.', '.', '.', '.', '8', '.', '.', '7', '9'}};
            t.SolveSudoku(board);
        }
    }
}
