using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace VIVALACODE
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Assert.AreEqual(2, PrimeFactor.breakdown(2));
        }
    }
}