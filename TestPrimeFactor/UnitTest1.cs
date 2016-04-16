using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod2()
        {
            Assert.AreEqual(2, PrimeFactor.breakdown(2));
        }

        [TestMethod]
        public void TestMethod3()
        {
            Assert.AreEqual(3, PrimeFactor.breakdown(3));
        }
    }
}