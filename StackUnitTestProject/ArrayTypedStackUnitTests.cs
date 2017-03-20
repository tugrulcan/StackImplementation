using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;

namespace ArrayTypedStackUnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesDisplayElementsThrowExceptionWhenStackIsEmpty()
        {
            ArrayTypedStack stack = new ArrayTypedStack(5);
            string s = stack.DisplayElements();
            
        }

        [TestMethod]
        public void DoesDisplayElementsPrintsCorrectly()
        {
            ArrayTypedStack stack = new ArrayTypedStack(3);
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            string expected = "3 2 1 ";
            string actual = stack.DisplayElements();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesIsEmptyReturnFalseWhenStackIsNotEmpty()
        {
            ArrayTypedStack stack = new ArrayTypedStack(2);
            stack.Push(3);
            bool actualResult = stack.IsEmpty();
            bool expectedResult = false;
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void DoesPushAddElementWhenStackIsEmpty()
        {
            ArrayTypedStack stack = new ArrayTypedStack(1);
            stack.Push(3);

            string actual = stack.DisplayElements();
            string expected = "3 ";
            Assert.AreEqual(expected, actual);

            int actualSize = stack.Size;
            int expectedSize = 1;
            Assert.AreEqual(expectedSize, actualSize);
        }

        [TestMethod]
        [ExpectedException(typeof(StackOverflowException))]
        public void DoesPushAddElementWhenStackIsFull()
        {
            ArrayTypedStack stack = new ArrayTypedStack(2);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
        }

        [TestMethod]
        public void DoesPushAddElementWhenStackIsNotEmpty()
        {
            ArrayTypedStack stack = new ArrayTypedStack(3);
            stack.Push(3);
            stack.Push(2);

            string actual = stack.DisplayElements();
            string expected = "2 3 ";
            Assert.AreEqual(expected, actual);

            int actualSize = stack.Size;
            int expectedSize = 2;
            Assert.AreEqual(expectedSize, actualSize);
        }

        
    }
}
