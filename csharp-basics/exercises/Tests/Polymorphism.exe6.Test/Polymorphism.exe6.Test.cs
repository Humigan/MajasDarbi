using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Polymorphism.exe6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void animalName_Name_Chana()
        {
            // Arrange
            var a = new Polymorphism_exe6();
            string expected = "Chana";

            // Act
            a.animalName = "Chana";
            var result = a.animalName;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void animalType_Type_Cat()
        {
            // Arrange
            var b = new Polymorphism_exe6();
            string expected = "Cat";

            // Act
            b.animalType = "Cat";
            var result = b.animalType;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void animalWeight_Weight_50_5()
        {
            // Arrange
            var c = new Polymorphism_exe6();
            double expected = 50.5;

            // Act
            c.animalWeight = 50.5;
            var result = c.animalWeight;

            // Assert
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void LivingRegion_Region_Forest()
        {
            // Arrange
            var d = new Polymorphism_exe6();
            string expected = "Forest";

            // Act
            d.LivingRegion = "Forest";
            var result = d.LivingRegion;

            // Assert
            Assert.AreEqual(expected, result);
        }
    }
}
