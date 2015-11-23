using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAverage()
        {
            double expected = 0.3;
            
            IEnumerable<double> doubleEnum = new List<double>() { 0.1, 0.2, 0.3, 0.4, 0.5 };                        
            TestClass cl = new TestClass();
            double res = cl.Average(doubleEnum);
            
            Assert.AreEqual(expected, res, 0.001, "Not expected value");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestAverageArgumentNullException()
        {
            TestClass cl = new TestClass();
            double res = cl.Average(null);

            // assert is handled by ExpectedException
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestAverageArgumentOutOfRangeException()
        {
            IEnumerable<double> doubleEnum = new List<double>() { };
            TestClass cl = new TestClass();
            double res = cl.Average(doubleEnum);
            
            // assert is handled by ExpectedException
        }
    }
}
