using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Array.exe6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Array_Random_Negative7()
        {
            // Arrange
            int expected = -7;

            // Act
            var result = Array_exe6.Array();

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
