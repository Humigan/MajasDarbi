using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe8.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Salary_HoursAndBasePay_Salary()
        {
            // Arrange
            double hours = 30;
            double BasePay = 10;
            var expected = 300;

            // Act
            var result = Arithmetic_exe8.Salary(hours, BasePay);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Salary_HoursAndBasePay_SalaryOverWork()
        {
            // Arrange
            double hours = 50;
            double BasePay = 10;
            var expected = 550;

            // Act
            var result = Arithmetic_exe8.Salary(hours, BasePay);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
