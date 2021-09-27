using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collection.exe5.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThirdElementChange_Color_SameColor()
        {
            // Arrange
            string color = "Yellow";
            string expected = "Yellow";

            // Act
            var result = Collections_exe5.ThirdElementChange(color);

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
