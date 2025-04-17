using System;

namespace BootCamp.Chapter1
{
    public static class ArrayOperations
    {
        /// <summary>
        /// Sort the array in ascending order.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Sort(int[] array)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return;

            var isArraySorted = IsSorted(array);
            if (isArraySorted is false)
                SortArray(array);
        }

        private static bool IsSorted(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    return true;
            }
            return false;
        }

        private static void SortArray(int[] array)
        {
            var length = array.Length;
            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                        (array[j + 1], array[j]) = (array[j], array[j + 1]);
                }
            }
        }

        /// <summary>
        /// Reverse the array elements, first being last and so on.
        /// If array empty or null- don't do anything.
        /// </summary>
        /// <param name="array">Input array in a random order.</param>
        public static void Reverse(int[] array)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return;
            for (int i = 0; i < array.Length / 2; i++)
            {
                (array[i], array[^(i + 1)]) = (array[^(i + 1)], array[i]);
            }
        }

        /// <summary>
        /// Remove last element in array.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <returns>A new array with the last element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveLast(int[] array)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return array;
            var newArray = new int[array.Length - 1];
            Array.Copy(array, newArray, newArray.Length);
            return newArray;
        }

        /// <summary>
        /// Remove first element in array.
        /// </summary>
        /// <returns>A new array with the first element removed. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveFirst(int[] array)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return array;
            var newArray = new int[array.Length - 1];
            array.CopyTo(newArray, 1);
            return newArray;
        }

        /// <summary>
        /// Removes array element at given index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="index">Index at which array element should be removed.</param>
        /// <returns>A new array with element removed at a given index. If an array is empty or null, returns input array.</returns>
        public static int[] RemoveAt(int[] array, int index)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return array;
            if (index > array.Length - 1 || index < 0)
                return array;
            var newArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i == index) continue;
                newArray[j++] = array[i];
            }
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the start.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertFirst(int[] array, int number)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return new int[] { 0 };

            var newArray = new int[array.Length];
            newArray[0] = number;
            Array.Copy(array, 0, newArray, 1, array.Length);
            return array;
        }

        /// <summary>
        /// Inserts a new array element at the end.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <returns>A new array with element added in the end of array. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertLast(int[] array, int number)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return new int[] { 0 };
            var newArray = new int[array.Length];
            array.CopyTo(newArray, 0);
            newArray[^1] = number;
            return newArray;
        }

        /// <summary>
        /// Inserts a new array element at the specified index.
        /// </summary>
        /// <param name="array">Input array.</param>
        /// <param name="number">Number to be added.</param>
        /// <param name="index">Index at which array element should be added.</param>
        /// <returns>A new array with element inserted at a given index. If an array is empty or null, returns new array with number in it.</returns>
        public static int[] InsertAt(int[] array, int number, int index)
        {
            // ToDo: implement.
            if (array is null || array.Length == 0)
                return new int[] { 0 };

            var newArray = new int[array.Length];

            if (index > newArray.Length - 1 || index < 0)
                return array;

            newArray[index] = number;
            for (int i = 0, j = 0; i < newArray.Length; i++)
            {
                if (i == index)
                    continue;
                newArray[i] = array[j++];
            }
            return newArray;
        }
    }
}
