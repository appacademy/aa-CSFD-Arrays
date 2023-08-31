using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises.Tests
{
    [TestFixture]
    public class ArrayExercisesTest
    {
        ArrayExercises target = new ArrayExercises();
        /// <summary>
        /// Given a size greater than zero, return a new array of ints
        [TestCase(3, new int[3] { 0, 0, 0 })]
        [TestCase(1, new int[1] { 0 })]
        [TestCase(5, new int[5] { 0, 0, 0, 0, 0 })]
        public void CreateNewArrayTest(int size, int[] expected)
        {
            int[] actual = target.CreateNewArray(size);
            Assert.AreEqual(size, actual.Length);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given an array larger than 0, return the last element in the array
        /// </summary>
        [TestCase(new int[] { 1, 2, 3 }, 3)]
        [TestCase(new int[] { 1, 3,7,11,5, 5 }, 5)]
        [TestCase(new int[] { 10 }, 10)]
        public void GetLastElementTest(int[] input, int expected)
        {
            int actual = target.GetLastElement(input);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given an empty array, fill each element with the index + 1
        /// </summary>
        [TestCase(new int[3] { 0, 0, 0 }, new int[3] { 1, 2, 3 })]
        [TestCase(new int[1] { 0 }, new int[1] { 1 })]
        [TestCase(new int[5] { 0, 0, 0, 0, 0 }, new int[5] { 1, 2, 3, 4, 5 })]
        public void FillArrayTest(int[] input, int[] expected)
        {
            object actual = target.FillArray(input);
            Assert.AreEqual(expected, actual);
        }
        /// <summary>
        /// Given an array, and n. Add more slots to an array. eg. An array with 5 elements, and n = 2, return an array with 7 elements.
        /// </summary>
        [TestCase(new int[3] { 1, 2, 3 }, 2, new int[5] { 1, 2, 3, 0, 0 })]
        [TestCase(new int[1] { 1 }, 3, new int[4] { 1, 0, 0, 0 })]
        [TestCase(new int[5] { 1, 2, 3, 4, 5 }, 1, new int[6] { 1, 2, 3, 4, 5, 0 })]
        public void GrowArrayTest(int[] input, int size, int[] expected)
        {
            int[] actual = target.GrowArray(input, size);
            Assert.AreEqual(expected.Length, actual.Length);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        /// Given an array length greater than 1, reduce the array size in half rounded down.
        /// </summary>
        [TestCase(new int[5] { 1, 2, 3, 0, 0 }, new int[2] { 1, 2 })]
        [TestCase(new int[4] { 1, 0, 0, 0 }, new int[2] { 1, 0 })]
        [TestCase(new int[6] { 1, 2, 3, 4, 5, 0 }, new int[3] { 1, 2, 3 })]
        public void HalfArrayTest(int[] input, int[] expected)
        {
            int[] actual = target.HalfArray(input);
            Assert.AreEqual(expected, actual);
        }
    }
}
