using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator;

namespace Calculator.Fixture
{
    [TestClass]
    public class EngineTest
    {
        [TestMethod]
        public void SumTest()
        {
            var target = new Engine();
            int a = 5;
            int b = 4;
            int expected = 9;
            int actual;
            actual = target.Sum(a, b);
            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //[ExpectedException(typeof(ArgumentNullException))]
        //public void ThrowExceptionWhenSum()
        //{
        //    var target = new Engine();
        //    int a = 0;
        //    int b = 0;
        //    int expected = 0;
        //    target.Sum(0, 0);
        //}

        /// <summary>
        ///A test for Engine Constructor
        ///</summary>
        [TestMethod()]
        public void EngineConstructorTest()
        {
            Engine target = new Engine();
            Assert.IsNotNull(target);
            Assert.IsInstanceOfType(target, typeof(Engine));
        }
    }
}