using System;
using System.Collections.Generic;
using System.Text;

namespace Exercises
{
    public class ArrayExercises
    {
        /// <summary>
        /// Given a size greater than zero, return a new array of ints
        // Given 3, return { 0, 0, 0 }
        // Given 1, return { 0 }
        // Given 5, return { 0, 0, 0, 0, 0 }
        public int[] CreateNewArray(int size)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array larger than 0, return the last element in the array
        // Given an array { 1, 2, 3 } return 3
        // Given an array  { 1, 3,7,11,5, 5 } return 5
        // Given an array  { 10 } return 10
        /// </summary>
        
        public int GetLastElement(int[] input)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Given an empty array, fill each element with the index + 1
        // Given an array { 0, 0, 0 }, return { 1, 2, 3 }
        // Given an array { 0 }, return { 1 }
        // Given an array { 0, 0, 0, 0, 0 }, return { 1, 2, 3, 4, 5 }
        /// </summary>
        public int[] FillArray(int[] input)
        {
            throw new NotImplementedException();
        }
        /// <summary>
        /// Given an array, and n. Add more slots to an array. eg. An array with 5 elements, and n = 2, return an array with 7 elements.
        // Given an array { 1, 2, 3 }, and 2, return { 1, 2, 3, 0, 0 }
        // Given an array { 1 }, and 3, return { 1, 0, 0, 0 }
        // Given an array { 1, 2, 3, 4, 5 }, and 1, return { 1, 2, 3, 4, 5, 0 }
        /// </summary>
        public int[] GrowArray(int[] input, int size)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array length greater than 1, reduce the array size in half rounded down.
        // Given an array { 1, 2, 3, 0, 0 }  return { 1, 2 }
        // Given an array { 1, 0, 0, 0 }, return { 1, 0 }
        // Given an array { 1, 2, 3, 4, 5, 0 } return { 1, 2, 3 }
        /// </summary>
        public int[] HalfArray(int[] input)
        {
            throw new NotImplementedException();
        }
    }
}
