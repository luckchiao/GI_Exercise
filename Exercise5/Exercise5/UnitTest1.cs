using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercise5
{
    [TestClass]
    public class UnitTest1
    {
        private Exercise5 exercise5 = new Exercise5();

        [TestMethod]
        public void GetElementsByQ1Test()
        {
            var actual = exercise5.GetElementsByQ1();
            var expected = new[] {4, 1, 3, 2, 0};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ2Test()
        {
            var actual = exercise5.GetElementsByQ2();
            var expected = new[]{"five","six","seven","eight","nine"};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ3Test()
        {
            var actual = exercise5.GetElementsByQ3();
            var expected = new[] {5, 4, 1};

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ4Test()
        {
            var actual = exercise5.GetElementsByQ4();
            var expected = new[] { 9, 8, 6, 7, 2, 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ5Test()
        {
            var actual = exercise5.GetElementsByQ5();
            var expected = new[] { 5, 4, 1, 3 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ6Test()
        {
            var actual = exercise5.GetElementsByQ6();
            var expected = new[] { 5, 4 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ7Test()
        {
            var actual = exercise5.GetElementsByQ7();
            var expected = "four";

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ8Test()
        {
            var actual = exercise5.GetElementsByQ8();
            var expected ="five" ;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ9Test()
        {
            var actual = exercise5.GetElementsByQ9();
            var expected =  1 ;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetElementsByQ10Test()
        {
            var actual = exercise5.GetElementsByQ10();
            var expected =  8 ;

            Assert.AreEqual(expected, actual);
        }
    }
}
