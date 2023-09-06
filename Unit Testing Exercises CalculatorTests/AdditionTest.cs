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
        public void TestAdd_WithPositiveNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Sum(7, 3);

            // Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void TestAdd_WithNegativeNumbers()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Sum(-5, -2);

            // Assert
            Assert.AreEqual(-7, result);
        }

        [TestMethod]
        public void TestAdd_WithZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result = calculator.Sum(0, 0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void TestAdd_WithOneZero()
        {
            // Arrange
            CalculatorModel calculator = new CalculatorModel();

            // Act
            int result1 = calculator.Sum(0, 9);
            int result2 = calculator.Sum(8, 0);

            // Assert
            Assert.AreEqual(9, result1);
            Assert.AreEqual(8, result2);
        }
    }}