using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Arithmetic.exe6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CozaLozaWoza_1Number_CozaWoza()
        {
            // Arrange
            int a = 84;
            string expected = "CozaWoza";

            // Act
            var result = Arithmetic_exe6.CozaLozaWoza(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CozaLozaWoza_1Number_CozaLoza()
        {
            // Arrange
            int a = 30;
            string expected = "CozaLoza";

            // Act
            var result = Arithmetic_exe6.CozaLozaWoza(a);

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void CozaLozaWoza_1Number_Woza()
        {
            // Arrange
            int a = 14;
            string expected = "Woza";

            // Act
            var result = Arithmetic_exe6.CozaLozaWoza(a);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
