using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ClassesAndObjects.exe12.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Deposit_Add100_Balance100()
        {
            // Arrange
            var a = new ClassesAndObjects_exe12();
            int expected = 100;

            // Act
            var result = a.deposit(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Withdrawal_70_70()
        {
            // Arrange
            var b = new ClassesAndObjects_exe12();
            int expected = 70;

            // Act
            var result = b.withdrawal(expected);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Transfer_To50Add100_Balance150()
        {
            // Arrange
            var c = new ClassesAndObjects_exe12();
            var d = new ClassesAndObjects_exe12();
            double cBalance = 100;
            double dBalance = 50;
            var expected = 150;

            // Act
            c.deposit(cBalance);
            d.deposit(dBalance);
            c.Transfer(c, d, 100);
            var result = d.balance();

            // Assert
            Assert.AreEqual(expected, result);
        }

    }
}
