using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ppedv.Finex.Data.EF.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void Calc_Sum_4_and_5_result_9()
        {
            //Arrange
            Calc calc = new Calc();

            //Act
            var result = calc.Sum(4, 5);

            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void Calc_Sum_0_and_0_result_0()
        {
            //Arrange
            Calc calc = new Calc();

            //Act
            var result = calc.Sum(0, 0);

            //Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Calc_Sum_MAX_and_1_throws()
        {
            Calc calc = new Calc();

            Assert.ThrowsException<OverflowException>(() => calc.Sum(int.MaxValue, 1));

        }
    }

    class Calc
    {
        public int Sum(int a, int b)
        {
            return checked(a + b);
        }
    }
}
