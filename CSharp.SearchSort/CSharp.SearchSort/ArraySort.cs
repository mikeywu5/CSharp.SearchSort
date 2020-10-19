using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class ArraySort
    {
        /// <summary>
        /// Sort an array of integers; do not use built-in function
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SortInts(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort an array of strings; do not use built-in function; use string's compareTo function
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public string[] SortStrings(string[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort an array of integers, in which all the odd positions will be in an ascending order and all the even positions will be in a descending order. 
        /// </summary>
        /// <param name="a">an array of integers</param>
        /// <example>Input: {0, 1, 2, 3, 4, 5, 6, 7, 8, 9}.
        /// Sorted: {0, 9, 1, 8, 2, 7, 3, 6, 4, 5}.</example>
        /// <returns></returns>
        public int[] SortEvenOdds(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort the even values and odd values in place and in ascending order within the array. That is, do not change the positions of where the evens and odds are positioned originally in the array.
        /// </summary>
        /// <remarks>You may employ any sorting algorithm you've desired.</remarks>
        /// <param name="a">The alpha component.</param>
        public void SortEvensOddsInPlace(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array, sort the array by moving from the front and then moving from the back until the array is sorted to the center position.
        /// </summary>
        /// <example>for an array from 0 to 9, the "sorted" array goes like this: {0, 2, 4, 6, 8, 9, 7, 5, 3, 1}.</example>
        /// <param name="a"></param>
        public void SortBackAndForth(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort an array with both strings and integers. Keep both types at the same positions without changing these types' positions. You may use built-in conversions.
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public object[] SortIntStrings(object[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort an array of strings from the least to the greatest number of unique characters. The sorting of the strings with the same number of unique characters will remain unchanged. You may use any sorting algorithm you’ve desire, but do not use a built-in sorting method. You must also treat null strings and arrays.
        /// </summary>
        /// <seealso cref="CountUniqueCharacters"/>
        /// <param name="a">The array component.</param>
        public void SortByUniqueCharCount(string[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Sort an array of strings from the least to the greatest number of unique characters. 
        /// Then, if there are multiple strings with the same number of unique characters, 
        /// then sort by the string value using string's CompareTo function.
        /// You may use any sorting algorithm you’ve desire, but do not use a built-in sorting method. You must also treat null strings and arrays.
        /// </summary>
        /// <remarks>Please note that null always comes before an empty string "".</remarks>
        /// 
        /// <seealso cref="CountUniqueCharacters"/>
        /// <param name="a">The array component.</param>
        public void SortByUniqueCharCountThenByString(string[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a rectangular array, perform a sort on each and every column in the array. This is like a table in your spreadsheet, where you are sorting each and every column.
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public int[,] SortAllColumns(int[,] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a rectangular array, perform an insertion sort on each and every diagonal segment that go in the south-east direction (i.e., rightwards and downwards) without crossing other diagonal segments. See examples.
        /// </summary>
        /// <param name="r">a non-null rectangular array</param>
        /// <example>
        ///     Input               Sorted
        /// 12  11  10  9       2   1   5   9
        /// 8    7   6  5	 	3   7   6  10
        /// 4    3   2  1	 	4   8  12  11
        /// You are sorting the following segments:
        /// 4, 8 3, 12 7 2, 11 6 1, 10 5, and 9.
        /// </example>
        /// <example>
        ///      Input                Sorted
        /// 20  19  18  17       5    9  13  17
        /// 16  15  14  13       1   10  14  18
        /// 12  11  10   9       2    6  15  19
        /// 8    7   6   5       3    7  11  20
        /// 4    3   2   1       4    8  12  16
        /// You are sorting the following segments:
        /// 4, 8 3, 12 7 2, 16 11 6 1, 20 15 10 5, 19 14 9, 18 13, and 17.
        /// </example>
        /// <returns>the reference to the original array</returns>
        public int[,] DiagonalSort(int[,] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given two sorted arrays, merge the two arrays into one bigger array that is sorted. Please note that this should be accomplished in linear time (O(n)).
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <remarks>This is required to understand how merge sort works.</remarks>
        /// <returns>a sorted array with elements from a and b</returns>
        public int[] Merge2(int[] a, int[] b)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given two separate subarrays that are both sorted in an array, merge the two subarrays together so that the elements in these two subarrays are sorted. We will assume that subarrays a and b will not overlap and that subarray a always comes before subarray b.
        /// </summary>
        /// <param name="array">The array</param>
        /// <param name="aFirst">first index of the subarray a</param>
        /// <param name="aLast">last index of the subarray a</param>
        /// <param name="bFirst">first index of the subarray b</param>
        /// <param name="bLast">last index of the subarray b</param>
        /// <see cref="Merge2(int[], int[])"/>
        public void Merge(int[] array, int aFirst, int aLast, int bFirst, int bLast)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merge Sort - Partition and then merge: This will divide the subarray from the first index to the last index into half, and then recursively partition and merge the halves until only one element remains. You will need to call the Merge method.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        /// <see cref="Merge(int[], int, int, int, int)"/>
        public void PartitionAndMerge(int[] array, int firstIndex, int lastIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Merge sort. This will call the PartitionAndMerge method on the entire array rather than the subarray. Make sure you've checked for null references.
        /// </summary>
        /// <param name="array"></param>
        /// <see cref="PartitionAndMerge(int[], int, int)"/>
        public void MergeSort(int[] array)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a subarray (between first index and last index), swap all the elements (from first to last - 1) that are smaller than the last element to before a specific position. We will call this position the pivot because it is a fixed position. Finally, we need to move the last element to the pivot.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        /// <example> A subarray: [1, 3,2, 6, 9,4, 8, 7,5]
        /// </example>
        /// <remarks>Ordering doesn't matter. You will need to swap the elements so that you are moving all the elements that are smaller than the pivot value to the beginning of the subarray. However, unit tests require to move your elements in a specific way such that the elements are swapped from the beginning to end. </remarks>
        /// <remarks>That is, when the subarray is sorted, the pivot index of that element will remain unchanged and will be the exact position of that value.</remarks>
        /// <returns>the index of the pivot</returns>
        public int Pivot(int[] array, int firstIndex, int lastIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// We will first pivot our subarray to get the pivot index. Since the pivot will be fixed even after the array is sorted, we will partition the subarray into two halves: before the pivot and after the pivot. This will call recursively.
        /// </summary>
        /// <param name="array"></param>
        /// <param name="firstIndex"></param>
        /// <param name="lastIndex"></param>
        /// <see cref="Pivot(int[], int, int)"/>
        public void PartitionAndPivot(int[] array, int firstIndex, int lastIndex)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Quick sort an array by invoking the PartitionAndPivot method on the entire array.
        /// </summary>
        /// <param name="array"></param>
        /// <see cref="PartitionAndPivot(int[], int, int)"/>
        public void QuickSort(int[] array)
        {
            throw new NotImplementedException();
        }
    }
}
