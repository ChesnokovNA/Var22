using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Var22;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string a = "2";
            string expented = "ба";

            Class p = new Class();
            p.Kolvo = a;
            string actual = p.isTempIce();

            Assert.AreEqual(expented, actual);
        }
    }
}
