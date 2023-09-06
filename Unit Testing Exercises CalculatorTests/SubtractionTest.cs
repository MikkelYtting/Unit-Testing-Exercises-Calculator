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
    public class SubtractionTest
    {
        [TestMethod]
        public void TestSubtract_WithPositiveNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Subtract(7, 3);

            // Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestSubtract_WithNegativeNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Subtract(-5, -2);

            // Assert
            Assert.AreEqual(-3, result);
        }

        [TestMethod]
        public void TestSubtract_WithZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Subtract(0, 5);

            // Assert
            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void TestSubtract_WithOneZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result1 = calculator.Subtract(0, 9);
            int result2 = calculator.Subtract(8, 0);

            // Assert
            Assert.AreEqual(-9, result1);
            Assert.AreEqual(8, result2);
        }
        [TestMethod]
        public void TestSubtract_WithMinValue()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Subtract(int.MinValue, 1);

            // Assert
            Assert.AreEqual(int.MinValue + 1, result);
        }

        [TestMethod]
        public void TestSubtract_WithMaxValue()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Subtract(int.MaxValue, 1);

            // Assert
            Assert.AreEqual(int.MaxValue - 1, result);
        }
    }
}