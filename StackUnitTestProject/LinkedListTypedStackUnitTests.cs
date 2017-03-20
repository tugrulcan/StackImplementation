using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;
using LinkedListImplementation;

namespace LinkedListTypedStackUnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void DoesIsEmptyReturnsTrueWhenStackIsEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            bool expected = true;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesIsEmptyReturnsFaleWhenStackIsNotEmpty() // Depends on push() method
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);

            bool expected = false;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DoesPushAddElementIntoStackWhenStackIsEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);

            string expected = "1 ";
            string actual = stack.DisplayElements();
            Assert.AreEqual(expected, actual);

            int expected_top_val = 1;
            int actual_top_val = ((Node)stack.Top).Data;
            Assert.AreEqual(expected_top_val, actual_top_val);
        }

        [TestMethod]
        public void DoesPushAddElementIntoStackWhenStackIsNotEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);
            stack.Push(2);

            string expected = "2 1 ";
            string actual = stack.DisplayElements();
            Assert.AreEqual(expected, actual);

            int expected_top_val = 2;
            int actual_top_val = ((Node)stack.Top).Data;
            Assert.AreEqual(expected_top_val, actual_top_val);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesPeekThrowsExcetionWhenStackIsEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            Node top = (Node)stack.Peek();
        }

        [TestMethod]
        public void DoesPeekRetrieveTopWhenStackHasOnlyOneElement()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);

            int expected = 1;
            int actual = ((Node)stack.Peek()).Data;
            Assert.AreEqual(expected, actual);

            int expected_size = 1;
            int actual_size = stack.Size;
            Assert.AreEqual(expected_size, actual_size);

        }

        [TestMethod]
        public void DoesPeekRetrieveTopWhenStackIsNotEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);
            stack.Push(2);

            int expected = 2;
            int actual = ((Node)stack.Peek()).Data;
            Assert.AreEqual(expected, actual);

            int expected_size = 2;
            int actual_size = stack.Size;
            Assert.AreEqual(expected_size, actual_size);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DoesPopThrowsExcetionWhenStackIsEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            Node top = (Node)stack.Pop();
        }

        [TestMethod]
        public void DoesPopMethodRetrieveTopWhenStackHasOnlyOneElement()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);

            int expected = 1;
            int actual = ((Node)stack.Pop()).Data;
            Assert.AreEqual(expected, actual);

            Assert.AreEqual(true, stack.IsEmpty());
            Assert.IsNull(stack.Top);
        }

        [TestMethod]
        public void DoesPopRetrieveTopWhenStackIsNotEmpty()
        {
            LinkedListTypedStack stack = new LinkedListTypedStack();
            stack.Push(1);
            stack.Push(2);

            int expected = 2;
            int actual = ((Node)stack.Pop()).Data;
            Assert.AreEqual(expected, actual);

            int expected_size = 1;
            int actual_size = stack.Size;
            Assert.AreEqual(expected_size, actual_size);

            int expected_new_top_val = 1;
            int actual_new_top_val = ((Node)stack.Top).Data;
            Assert.AreEqual(expected_new_top_val, actual_new_top_val);
        }
    }
}
