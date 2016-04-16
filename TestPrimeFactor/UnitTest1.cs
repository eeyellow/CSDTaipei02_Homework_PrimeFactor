using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections;
using System.Collections.Generic;

namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            CollectionAssert.AreEqual(new List<int> { 2 }, PrimeFactor.breakdown(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            CollectionAssert.AreEqual(new List<int> { 3 }, PrimeFactor.breakdown(3));
        }
    }
}