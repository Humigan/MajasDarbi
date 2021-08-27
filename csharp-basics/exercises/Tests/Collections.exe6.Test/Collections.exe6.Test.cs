using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collection.exe6.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ThirdElementChange_3_SameColor()
        {
            // Arrange

            // Act
            var result = Collections_exe6.ThirdElementRemove();

            // Assert
            CollectionAssert.AllItemsAreNotNull(result);
        }
    }
}