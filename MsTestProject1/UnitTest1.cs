using Microsoft.VisualStudio.TestTools.UnitTesting;
using MsTestProject;
using System;
using System.Diagnostics;

namespace MsTestProject1
{
    [TestClass]
    public class CalculatorTestClass
    {
        [TestMethod]
        [TestCategory("Addition")]
        public void Given_TwoNumbers_should_Return_Sum()
        {
            ///AAA Methodology
            ///Arrenge
            int x =10;
            int y = 20;
            int expected = 30;
            Calculator calculator = new Calculator();

            //act
            int actual = calculator.AddtwoNumbers(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }

        //2nd type- we can write this program like this
        //public class CalculatorTestClass
        //{
        //    [TestMethod]
        //    [DataRow(10, 20, 30)]
        //    [DataRow(30, 20, 50)]
        //    [DataRow(30, 20, 30)]
        //    public void Given_TwoNumbers_should_Return_Sum(int x, int y, int expected)
        //    {
        //        ///AAA Methodology
        //        ///Arrenge

        //        Calculator calculator = new Calculator();

        //        //act
        //        int actual = calculator.AddtwoNumbers(x, y);

        //        //assert
        //        Assert.AreEqual(expected, actual);
        //    }
        //}

        //2nd test case (difference of two numbers)
        [TestMethod]
        [DataRow(10, 20, 30)]
        [DataRow(30, 20, 50)]
        [DataRow(10, 20, 30)]
        [TestCategory("Substraction")]
        public void Given_TwoNumbers_should_Return_Difference(int x, int y, int expected)
        {
            ///AAA Methodology
            ///Arrenge

            Calculator calculator = new Calculator();

            //act
            int actual = calculator.AddtwoNumbers(x, y);

            //assert
            Assert.AreEqual(expected, actual);
        }
    }

   

}
