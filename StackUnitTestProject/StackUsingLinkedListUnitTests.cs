﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StackImplementation;
using LinkedListImplementation;

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
        public void DoesIsEmptyReturnsFaleWhenStackIsNotEmpty() // Depends on push() method
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(1);

            bool expected = false;
            bool actual = stack.IsEmpty();
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DoesPushAddElementIntoStackWhenStackIsEmpty()
        {
            StackUsingLinkedList stack = new StackUsingLinkedList();
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
            StackUsingLinkedList stack = new StackUsingLinkedList();
            stack.Push(1);
            stack.Push(2);

            string expected = "2 1 ";
            string actual = stack.DisplayElements();
            Assert.AreEqual(expected, actual);

            int expected_top_val = 2;
            int actual_top_val = ((Node)stack.Top).Data;
            Assert.AreEqual(expected_top_val, actual_top_val);
        }

    }
}
