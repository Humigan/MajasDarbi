using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collection.exe9.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void JoinList_2Lists_true()
        {
            // Arrange

            // Act
            var list = Collections_exe9.JoinList();

            // Assert
            CollectionAssert.Contains(list,"Red");
        }

        [TestMethod]
        public void JoinList_Lists_true()
        {
            // Arrange

            // Act
            var list = Collections_exe9.JoinList();

            // Assert
            CollectionAssert.DoesNotContain(list, "Orange");
        }
    }
}
