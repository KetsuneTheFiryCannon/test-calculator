using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using calculator;

namespace calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Sum_10plus25_35()
        {
            int firstNum = 10;
            int secondNum = 25;
            int expected = 35;

            Calc c = new Calc();
            int actual = c.Sum(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Min_25min10_15()
        {
            int firstNum = 25;
            int secondNum = 10;
            int expected = 15;

            Calc c = new Calc();
            int actual = c.Min(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Umn_10umn25_250()
        {
            int firstNum = 10;
            int secondNum = 25;
            int expected = 250;

            Calc c = new Calc();
            int actual = c.Umn(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Del_250del10_25()
        {
            int firstNum = 250;
            int secondNum = 10;
            int expected = 25;

            Calc c = new Calc();
            int actual = c.Del(firstNum, secondNum);

            Assert.AreEqual(expected, actual);
        }
    }
}
