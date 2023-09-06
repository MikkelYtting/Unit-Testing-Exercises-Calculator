using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Unit_Testing_Exercises_Calculator;

namespace Unit_Testing_Exercises_CalculatorTests
{
    [TestClass]
    public class MultiplicationTest
    {
        [TestMethod]
        public void TestMultiply_WithPositiveNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Multiply(7, 3);

            // Assert
            Assert.AreEqual(21, result);
        }

        [TestMethod]
        public void TestMultiply_WithNegativeNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Multiply(-5, -2);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestMultiply_WithZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Multiply(0, 5);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestMultiply_WithOneZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result1 = calculator.Multiply(0, 9);
            int result2 = calculator.Multiply(8, 0);

            // Assert
            Assert.AreEqual(0, result1);
            Assert.AreEqual(0, result2);
        }
    }
}
