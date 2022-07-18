using DataStructuresLibrary;
using NUnit.Framework;
using System;

namespace DataStructures.Tests
{
    public class MyArrayListTests
    {
        [TestCase(new[] { 1, 2, 3, 4, 5 }, 10, new[] { 1, 2, 3, 4, 5, 10 })]
        public void Test1(int[] sourceArray, int valueToAdd, int[] expectedArray)
        {
            var myArrayList = new MyArrayList(sourceArray);

            myArrayList.AddBack(valueToAdd);

            CollectionAssert.AreEqual(expectedArray, myArrayList.ToArray());
        }

        [TestCase(new[] { 1, 2, 3, 4, 5 }, 10, new[] { 1, 2, 3, 4, 5, 10, 10 })]
        public void Test2(int[] sourceArray, int valueToAdd, int[] expectedArray)
        {
            var myArrayList = new MyArrayList(sourceArray);

            myArrayList.AddBack(valueToAdd);
            myArrayList.AddBack(valueToAdd);

            CollectionAssert.AreEqual(expectedArray, myArrayList.ToArray());
        }

        [TestCase(new[] { 65 }, 0, 65)]
        [TestCase(new[] { 5, 21 }, 1, 21)]
        [TestCase(new[] { 5, 3, 10, -90, 5, 0 }, 3, -90)]
        [TestCase(new[] { 5, 3, 10, -90, 5, 0 }, 0, 5)]
        [TestCase(new[] { 5, 3, 10, -90, 5, 0 }, 5, 0)]
        public void IndexerGet_WhenValidIndexAndArrayFilled_ShouldReturnValueByIndex
            (int[] sourceArray, int index, int expected)
        {
            IMyList myList = new MyArrayList(sourceArray);

            int actual = myList[index];

            Assert.AreEqual(expected, actual);
        }

        [TestCase(new int[0])]
        public void IndexerGet_WhenEmptyArray_ShouldThrowIndexOutOfRange
            (int[] sourceArray)
        {
            IMyList myList = new MyArrayList(sourceArray);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                var item = myList[0];
            });
        }

        [TestCase(new[] { 1 }, 2)]
        [TestCase(new[] { 1 }, -1)]
        [TestCase(new[] { 1, 6, 3, 4, 1 }, 5)]
        [TestCase(new[] { 1, 6, 3, 4, 1 }, -10)]
        public void IndexerGet_WhenInvalidIndex_ShouldThrowIndexOutOfRange
            (int[] sourceArray, int index)
        {
            IMyList myList = new MyArrayList(sourceArray);

            Assert.Throws<IndexOutOfRangeException>(() =>
            {
                var item = myList[index];
            });
        }

        [Test]
        public void ArrayConstructor_WhenNullPassed_ShouldThrowArgumentException()
        {
            Assert.Throws<ArgumentException>(() =>
            {
                IMyList myList = new MyArrayList(null);
            });
        }
    }
}