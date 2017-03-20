using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;

namespace StackUsingLinkedListUnitTests
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void DoesIsEmptyReturnsTrueWhenStackIsEmpty()
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            bool expected = true;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DoesIsEmptyReturnsFaleWhenStackIsNotEmpty()
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(1);

            bool expected = false;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }
    }
}
