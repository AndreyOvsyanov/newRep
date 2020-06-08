using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int a = 2, b = 6, c = 9;
            string actError, expError = "Нет действительных корней";
            double[] expResult = new double[0];
            double[] actResult = Class1.Mathematics(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);
        }

        [TestMethod]
        public void TestMethod2()
        {
            int a = 0, b = 0, c = 0;
            string actError, expError = "R";
            double[] expResult = new double[0];
            double[] actResult = Class1.Mathematics(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);
        }

        [TestMethod]
        public void TestMethod3()
        {
            int a = 1, b = 2, c = 1;
            string actError, expError = "";
            double[] expResult = new double[] { -1, -1 };
            double[] actResult = Class1.Mathematics(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);
        }

        [TestMethod]
        public void TestMethod4()
        {
            int a = 1, b = -3, c = 2;
            string actError, expError = "";
            double[] expResult = new double[] { 2, 1 };
            double[] actResult = Class1.Mathematics(a, b, c, out actError);
            Assert.AreEqual(expError, actError, "Полученное сообщение (" + actError + ") об ошибке не совпадает с ожидаемым (" + expError + ")");
            Assert.AreEqual(expResult.Length, actResult.Length);
            for (int i = 0; i < expResult.Length; i++)
                Assert.AreEqual(expResult[i], actResult[i]);
        }
    }
}
