using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace calc_test
{
    [TestClass]
    public class UnitTest1

    {
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestMethod1()
        {
            var div = 0;
          int x=  1 / div;
        }
    }
}
