using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp.Assignments
{
    public class BinarySearch
    {
        /// <summary>
        /// Given an array of sorted integers, find a number and return its index. If the number cannot be located, return -1.
        /// </summary>
        /// <param name="haystack">a sorted array</param>
        /// <param name="needle">an item</param>
        /// <returns>either the index or -1</returns>
        public int Find(int[] haystack, int needle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given an array of sorted strings, locate a string and return its index. If the string cannot be found, return a -1. This will require to use a string.CompareTo(anotherString) method, which returns negative (less than), zero (equal), or positive (greater than).
        /// </summary>
        /// <param name="haystack">a sorted array</param>
        /// <param name="needle">an item</param>
        /// <returns></returns>
        public int Search(string[] haystack, string needle)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a positive number, use binary search to determine its cube root without using any of the built-in Math functions. As you know, result * result * result must equal to n. The error must be less than 1E-14.
        /// </summary>
        /// <param name="n">a double number</param>
        /// <returns></returns>
        public double CubeRoot(double n)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a sorted array of positive integers, count the number of occurrences for each element in the array. That is, the values of this array can only contain between 0 and the value of the last element, which is bounded. The method will produce a new array representing the frequencies, which will include all positive values even if they do not appear in the array a. This will require recursions.
        /// </summary>
        /// <param name="a">a sorted array of positive integers</param>
        /// <returns>this array contains the frequencies corresponding to each number as the index, starting from 0.</returns>
        public int[] CountNumbers(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a sorted array with all the elements appearing twice (one after another) but only one element appearing once. Locate that element with a complexity of O(log(n)) using the binary search technique.
        /// </summary>
        /// <param name="a">a sorted array with all the elements appearing twice except for one</param>
        /// <returns>the value of the element</returns>
        public int AppearOnce(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given two sorted arrays, determine the index of the extra element in the first array. The first array has one extra element somewhere on top of the second array. That is, first array's length is always one plus the second array's length.
        /// </summary>
        /// <param name="first">first sorted array with only a single difference from the second array.</param>
        /// <param name="second">second sorted array</param>
        /// <returns>the index of the extra element</returns>
        public int ExtraElement(int[] first, int[] second)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a sorted array of n elements containing elements in the range from 1 to n - 1 with only one element occurring twice so that the element will be consecutive unless the element is repeating. The task is to find the repeat element in the array.
        /// </summary>
        /// <param name="a">an array with consecutive numbers from 1 to n-1 with one repeated value.</param>
        /// <returns>repeated element</returns>
        public int RepeatingElement(int[] a)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Given a sorted array and an x value, the floor of x is the largest element in the array that is smaller than or equal to the value of x. Identify the floor of x. If a floor cannot be determined (e.g. there are no values in a that are smaller than x), simply return the first element of the array a. 
        /// </summary>
        /// <param name="a"></param>
        /// <param name="x"></param>
        /// <returns>Floor of x</returns>
        public int Floor(int[] a, int x)
        {
            throw new NotImplementedException();
        }

    }
}
