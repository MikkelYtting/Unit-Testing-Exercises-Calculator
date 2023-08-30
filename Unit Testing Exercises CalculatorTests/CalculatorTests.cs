using Microsoft.VisualStudio.TestTools.UnitTesting;
using Unit_Testing_Exercises_Calculator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Exercises_Calculator.Tests
{
    [TestClass()]
    public class CalculatorTests
    {
        [TestMethod]
        public void TestSum()
        {
            CalculatorModel calculator = new CalculatorModel();
            int result = calculator.Sum(2, 3);
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void TestSubtract()
        {
            CalculatorModel calculator = new CalculatorModel();
            int result = calculator.Subtract(5, 3);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestMultiply()
        {
            CalculatorModel calculator = new CalculatorModel();
            int result = calculator.Multiply(2, 3);
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestDivide()
        {
            CalculatorModel calculator = new CalculatorModel();
            double result = calculator.Divide(6, 3);
            Assert.AreEqual(2.0, result);
        }

        [TestMethod]
        public void TestDivideByZero()
        {
            CalculatorModel calculator = new CalculatorModel();
            double result = calculator.Divide(5, 0);
            Assert.AreEqual(0, result); // Check for 0 result when dividing by zero
        }
    }
}