using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Collection.exe8.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SortList_2Lists_true()
        {
            // Arrange
            var list = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "White",
                "Black"
            };

            // Act
            var list2 = Collections_exe8.SortList();

            // Assert
            CollectionAssert.AreEquivalent(list, list2);
        }
    }
}
