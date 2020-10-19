using CSharp.Assignments.Tests.Library;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Versioning;

namespace CSharp.Assignments.Tests
{
    public partial class ArraySortTests
    {
        private dynamic _object;

        [SetUp]
        public void SetUp()
        {
            _object = new ArraySort();
        }

        [Test]
        [Category("Sort")]
        public void SortInts()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            CollectionAssert.AreEqual(null, _object.SortInts(null));
            CollectionAssert.AreEqual(new int[0], _object.SortInts(new int[0]));
            CollectionAssert.AreEqual(new int[1] { 1 }, _object.SortInts(new int[1] { 1 }));
            CollectionAssert.AreEqual(new[] { -1, 0, 1, 2, 3, 5, 8, 9 },
                _object.SortInts(new[] { 5, 9, 8, 2, 3, 1, -1, 0 }));
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Sort")]
        public void SortStrings()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            CollectionAssert.AreEqual(null, _object.SortStrings(null));
            CollectionAssert.AreEqual(new string[0], _object.SortStrings(new string[0]));
            CollectionAssert.AreEqual(new string[1] { "1" },
                _object.SortStrings(new string[1] { "1" }));
            CollectionAssert.AreEqual(new[] { "0", "1", "2", "3", "50", "8", "9" },
                _object.SortStrings(new[] { "50", "9", "8", "2", "3", "1", "0" }));
            CollectionAssert.AreEqual(new[] { "a", "g", "s", "y", "z" },
                _object.SortStrings(new[] { "z", "y", "a", "g", "s" }));
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Sort")]
        public void SortEvenOdds()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] expected = { 0, 9, 1, 8, 2, 7, 3, 6, 4, 5 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            expected = new[] { 0, 19, 1, 18, 2, 17, 3, 16, 4, 15, 5, 14, 6, 13, 7, 12, 8, 11, 9, 10 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));


            SortEvenOddsTests();
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Sort")]
        public void SortEvensOddsInPlace()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] actual, expected;
            actual = new[] { 9, 8, 7, 6, 5 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { 5, 6, 7, 8, 9 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 9, 8, 7, 6, 5, 4 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { 5, 4, 7, 6, 9, 8 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 8, 7, 6, 5, 4, 3 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { 4, 3, 6, 5, 8, 7 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { 1, 0, 3, 2, 5, 4, 7, 6, 9, 8 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 8, 7, 6, 5, 4, 3, 2, 1, 0, -1 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { 0, -1, 2, 1, 4, 3, 6, 5, 8, 7 };

            // Run longer tests
            SortEvensOddsInPlaceTests();
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Sort")]
        public void SortBackAndForth()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] actual = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            _object.SortBackAndForth(actual);
            int[] expected = { 0, 2, 4, 6, 8, 9, 7, 5, 3, 1 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19 };
            _object.SortBackAndForth(actual);
            expected = new[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 19, 17, 15, 13, 11, 9, 7, 5, 3, 1 };
            CollectionAssert.AreEqual(expected, actual);

            SortBackAndForthTests();
#if !DEBUG
            });
#endif
        }

        [Test]
        public void SortByUniqueCharCount()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            string[] actual = null;
            string[] expected = null;
            _object.SortByUniqueCharCount(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { "", null, "aaaa", "zz", "bbbb", "abbb", "abccc", "abccccd" };
            actual = new[] { "aaaa", "abccc", "abbb", "zz", "", "abccccd", "bbbb", null };
            _object.SortByUniqueCharCount(actual);
            CollectionAssert.AreEqual(expected, actual);
            SortByUniqueCharCount2();
#if !DEBUG
            });
#endif
        }

        [Test]
        public void SortByUniqueCharCountThenByString()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            string[] actual = null;
            string[] expected = null;
            _object.SortByUniqueCharCountThenByString(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { null, "", "aaaa", "bbbb", "zz", "abbb", "abccc", "abccccd" };
            actual = new[] { "aaaa", "abccc", "abbb", "zz", "", "abccccd", "bbbb", null };
            _object.SortByUniqueCharCountThenByString(actual);
            CollectionAssert.AreEqual(expected, actual);

            SortByUniqueCharCountThenByString2();
#if !DEBUG
            });
#endif
        }

        private string[] UniqueCharCountArray(int len, int repeated, int repeatedlength, char a = 'a', char z = 'z')
        {
            string[] actual = new string[len];
            for (int i = 0; i < len; i++)
            {
                char[] c = new char[repeated];

                int n = Utils.Random.Next(0, repeated);
                if (n == 0)
                {
                    actual[i] = Utils.Random.Next(0, 2) == 0 ? "" : null;
                }
                else
                {
                    for (int j = 0; j < c.Length; j++)
                    {
                        char chr;
                        do
                        {
                            chr = (char)Utils.Randomize(typeof(char), a, z);
                        } while (c.Contains(chr));
                        c[j] = chr;
                    }
                    StringBuilder sb = new StringBuilder();
                    int r = Utils.Random.Next(0, repeatedlength) + 1;
                    for (int j = 0; j < r; j++)
                    {
                        sb.Append(c[Utils.Random.Next(0, c.Length)]);
                    }
                    actual[i] = sb.ToString();
                }
            }
            return actual;

        }

        [Test]
        [Category("Sort")]
        public void SortAllColumns()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[,] matrix = {{ 20, 19, 18, 17 },
                             { 16, 15, 14, 13 },
                             { 12, 11, 10, 9 },
                             { 8,  7,  6,  5 },
                             { 4,  3,  2,  1 } };
            int[,] expected = {{  4,  3,  2,  1 },
                               {  8,  7,  6,  5 },
                               { 12, 11, 10,  9 },
                               { 16, 15, 14, 13 },
                               { 20, 19, 18, 17 }};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new[,] { { 12, 11, 10, 9 },
                              { 8, 7, 6, 5 },
                              {4, 3, 2, 1} };
            expected = new[,] { {  4,  3,  2,  1 },
                                {  8,  7,  6,  5 },
                                { 12, 11, 10,  9 } };
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            SortAllColumnsTests();
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Sort")]
        public void DiagonalSort()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[,] matrix = { { 12, 11, 10, 9 },
                              { 8, 7, 6, 5 },
                              { 4, 3, 2, 1 } };
            int[,] expected = { { 2, 1, 5, 9 },
                                { 3, 7, 6, 10 },
                                { 4, 8, 12, 11 }};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new[,] { { 20, 19, 18, 17 },
                              { 16, 15, 14, 13 },
                              { 12, 11, 10, 9 },
                              { 8,  7,  6,  5 },
                              { 4,  3,  2,  1 } };

            expected = new[,] { { 5, 9, 13, 17 },
                                { 1, 10, 14, 18 },
                                { 2, 6, 15, 19 },
                                { 3, 7, 11, 20 },
                                { 4, 8, 12, 16 } };
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            DiagonalSortTests(); // extra test cases
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Merge Sort")]
        public void Merge2()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] a, b, expected, actual;

            a = new int[0];
            b = new int[0];
            expected = new int[0];
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[0];
            b = new int[] { 2, 4, 6 };
            expected = new[] { 2, 4, 6 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 2, 4, 6 };
            b = new int[0];
            expected = new[] { 2, 4, 6 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 2 };
            b = new int[] { 1 };
            expected = new[] { 1, 2 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 1, 3, 5 };
            b = new int[] { 2, 4, 6 };
            expected = new[] { 1, 2, 3, 4, 5, 6 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 1, 3, 5, 7, 9, 11 };
            b = new int[] { 2, 4, 6 };
            expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 11 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 1, 3, 5 };
            b = new int[] { 2, 4, 6, 8, 10, 12 };
            expected = new[] { 1, 2, 3, 4, 5, 6, 8, 10, 12 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            b = new int[] { 1, 3, 5 };
            a = new int[] { 2, 4, 6 };
            expected = new[] { 1, 2, 3, 4, 5, 6 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            b = new int[] { 1, 3, 5, 7, 9, 11 };
            a = new int[] { 2, 4, 6 };
            expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 11 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            b = new int[] { 1, 3, 5 };
            a = new int[] { 2, 4, 6, 8, 10, 12 };
            expected = new[] { 1, 2, 3, 4, 5, 6, 8, 10, 12 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            a = new int[] { 1, 4, 7, 10, 11, 15, 16 };
            b = new int[] { 2, 4, 5, 6, 7, 8, 11, 12, 13 };
            expected = new[] { 1, 2, 4, 4, 5, 6, 7, 7, 8, 10, 11, 11, 12, 13, 15, 16 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            b = new int[] { 1, 4, 7, 10, 11, 15, 16 };
            a = new int[] { 2, 4, 5, 6, 7, 8, 11, 12, 13 };
            expected = new[] { 1, 2, 4, 4, 5, 6, 7, 7, 8, 10, 11, 11, 12, 13, 15, 16 };
            actual = _object.Merge2(a, b);
            CollectionAssert.AreEqual(expected, actual);

            // Longer test cases
            int[][] array = new int[2][]
            {
                new int[1000000], new int[1000000]
            };
            expected = Enumerable.Range(0, 2000000).ToArray();
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j < 2000000; j++)
                {
                    array[(i + j) % 2][j / 2] = j;
                }

                actual = _object.Merge2(array[0], array[1]);
                CollectionAssert.AreEqual(expected, actual);
            }
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Merge Sort")]
        public void Merge()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] expected, actual;

            actual = new int[] { 2, 1 };
            expected = new[] { 1, 2 };
            _object.Merge(actual, 0, 0, 1, 1);
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 3, 5, 2, 4, 6 };
            expected = new int[] { 1, 2, 3, 4, 5, 6 };
            _object.Merge(actual, 0, 2, 3, 5);
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 3, 5, 7, 9, 11, 2, 4, 6 };
            expected = new int[] { 1, 2, 3, 4, 5, 6, 7, 9, 11 };
            _object.Merge(actual, 0, 5, 6, 8);
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 3, 5, 2, 4, 6, 8, 10, 12 };
            expected = new[] { 1, 2, 3, 4, 5, 6, 8, 10, 12 };
            _object.Merge(actual, 0, 2, 3, 5);
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            expected = new int[] { 1, 2, 4, 4, 5, 6, 7, 7, 8, 10, 11, 11, 15 };
            _object.Merge(actual, 0, 5, 6, 12);
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 0, 4, 6, 11);
            expected = new[] { 1, 2, 4, 4, 5, 15, 6, 7, 7, 8, 10, 11, 11 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 0, 3, 6, 11);
            expected = new[] { 1, 2, 4, 4, 11, 15, 5, 6, 7, 7, 8, 10, 11 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 0, 3, 8, 11);
            expected = new[] { 1, 4, 5, 6, 11, 15, 2, 4, 7, 7, 8, 10, 11 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 1, 4, 8, 11);
            expected = new[] { 1, 4, 5, 6, 7, 15, 2, 4, 7, 8, 10, 11, 11 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 1, 5, 6, 11);
            expected = new[] { 1, 2, 4, 4, 5, 6, 7, 7, 8, 10, 11, 15, 11 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new int[] { 1, 4, 7, 10, 11, 15, 2, 4, 5, 6, 7, 8, 11 };
            _object.Merge(actual, 2, 5, 6, 10);
            expected = new[] { 1, 4, 2, 4, 5, 6, 7, 7, 10, 11, 15, 8, 11 };
            CollectionAssert.AreEqual(expected, actual);

            // bigger test cases
            expected = Enumerable.Range(0, 2000000).ToArray();
            actual = new int[2000000];
            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j < 2000000; j++)
                {
                    actual[j / 2 + ((j + i) % 2) * 1000000] = j;
                }
                _object.Merge(actual, 0, 999999, 1000000, 1999999);
                CollectionAssert.AreEqual(expected, actual);
            }

#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Merge Sort")]
        public void PartitionAndMerge()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] expected, actual;
            expected = new int[0];
            actual = new int[0];
            _object.PartitionAndMerge(actual, 0, -1);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 };
            _object.PartitionAndMerge(actual, 0, 0);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 0, 1, 2, 3, 8, 9, 50 };
            actual = new int[] { 50, 9, 8, 2, 3, 1, 0 };
            _object.PartitionAndMerge(actual, 0, 6);

            CollectionAssert.AreEqual(expected, actual);

            // Take a range from 1 to 1 million.
            expected = Enumerable.Range(1, 1000000).ToArray();
            actual = Enumerable.Range(1, 1000000).ToArray();
            // shuffle them
            for (int i = 0; i < actual.Length; i++)
            {
                int j = Utils.Random.Next(1000000);
                var t = actual[i];
                actual[i] = actual[j];
                actual[j] = t;
            }
            // sort them
            _object.PartitionAndMerge(actual, 0, 999999);
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Merge Sort")]
        public void MergeSort()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] expected = null;
            int[] actual = null;
            _object.MergeSort(actual);
            Assert.AreEqual(expected, actual);

            expected = new int[0];
            actual = new int[0];
            _object.MergeSort(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 };
            _object.MergeSort(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 0, 1, 2, 3, 8, 9, 50 };
            actual = new int[] { 50, 9, 8, 2, 3, 1, 0 };
            _object.MergeSort(actual);

            CollectionAssert.AreEqual(expected, actual);

            // Take a range from 1 to 1 million.
            expected = Enumerable.Range(1, 1000000).ToArray();
            actual = Enumerable.Range(1, 1000000).ToArray();
            // shuffle them
            for (int i = 0; i < actual.Length; i++)
            {
                int j = Utils.Random.Next(1000000);
                var t = actual[i];
                actual[i] = actual[j];
                actual[j] = t;
            }
            // sort them
            _object.MergeSort(actual);
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Quick Sort")]
        public void Pivot()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] array, expected;

            /*array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            int[] actual = new int[10];
            var sb = new StringBuilder();
            for (int i = 0; i < actual.Length - 1; i++)
            {
                for (int j = i + 1; j < actual.Length; j++)
                {
                    Array.Copy(array, actual, 10);
                    int p = _object.Pivot(actual, i, j);
                    sb.AppendLine("actual =   new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };");
                    sb.AppendLine($"expected = new[] {{ {string.Join(", ", actual)} }};");
                    sb.AppendLine($"AssertPivot({p}, expected, array, {i}, {j});");
                    sb.AppendLine();
                }
            }
            Assert.Fail(sb.ToString());*/

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 9, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(0, expected, array, 0, 1);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 0, 1, 9, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(0, expected, array, 0, 2);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 8, 9, 6, 2, 5, 4, 3, 7 };
            AssertPivot(2, expected, array, 0, 3);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 6, 8, 9, 2, 5, 4, 3, 7 };
            AssertPivot(2, expected, array, 0, 4);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 2, 8, 6, 9, 5, 4, 3, 7 };
            AssertPivot(2, expected, array, 0, 5);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 2, 5, 6, 9, 8, 4, 3, 7 };
            AssertPivot(3, expected, array, 0, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 2, 4, 6, 9, 5, 8, 3, 7 };
            AssertPivot(3, expected, array, 0, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 2, 3, 6, 9, 5, 4, 8, 7 };
            AssertPivot(3, expected, array, 0, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 1, 0, 6, 2, 5, 4, 3, 7, 9, 8 };
            AssertPivot(7, expected, array, 0, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 0, 1, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(1, expected, array, 1, 2);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 1, 3);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 8, 2, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 1, 4);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 6, 8, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 1, 5);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 5, 8, 6, 4, 3, 7 };
            AssertPivot(4, expected, array, 1, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 4, 8, 5, 6, 3, 7 };
            AssertPivot(4, expected, array, 1, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 3, 8, 5, 4, 6, 7 };
            AssertPivot(4, expected, array, 1, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 2, 5, 4, 3, 7, 8 };
            AssertPivot(8, expected, array, 1, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 2, 3);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 8, 2, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 2, 4);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 6, 8, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 2, 5);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 5, 8, 6, 4, 3, 7 };
            AssertPivot(4, expected, array, 2, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 4, 8, 5, 6, 3, 7 };
            AssertPivot(4, expected, array, 2, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 3, 8, 5, 4, 6, 7 };
            AssertPivot(4, expected, array, 2, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 2, 5, 4, 3, 7, 8 };
            AssertPivot(8, expected, array, 2, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 8, 2, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 3, 4);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 6, 8, 5, 4, 3, 7 };
            AssertPivot(3, expected, array, 3, 5);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 5, 8, 6, 4, 3, 7 };
            AssertPivot(4, expected, array, 3, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 4, 8, 5, 6, 3, 7 };
            AssertPivot(4, expected, array, 3, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 2, 3, 8, 5, 4, 6, 7 };
            AssertPivot(4, expected, array, 3, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 6, 2, 5, 4, 3, 7, 8 };
            AssertPivot(8, expected, array, 3, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 2, 6, 5, 4, 3, 7 };
            AssertPivot(4, expected, array, 4, 5);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 2, 5, 6, 4, 3, 7 };
            AssertPivot(5, expected, array, 4, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 2, 4, 5, 6, 3, 7 };
            AssertPivot(5, expected, array, 4, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 2, 3, 5, 4, 6, 7 };
            AssertPivot(5, expected, array, 4, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(9, expected, array, 4, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(6, expected, array, 5, 6);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 4, 5, 3, 7 };
            AssertPivot(6, expected, array, 5, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 3, 4, 5, 7 };
            AssertPivot(6, expected, array, 5, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(9, expected, array, 5, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 4, 5, 3, 7 };
            AssertPivot(6, expected, array, 6, 7);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 3, 4, 5, 7 };
            AssertPivot(6, expected, array, 6, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(9, expected, array, 6, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 3, 4, 7 };
            AssertPivot(7, expected, array, 7, 8);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(9, expected, array, 7, 9);

            array = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            expected = new[] { 9, 1, 0, 8, 6, 2, 5, 4, 3, 7 };
            AssertPivot(9, expected, array, 8, 9);
#if !DEBUG
            });
#endif
        }

        private void AssertPivot(int expectedPivotIndex, int[] expectedArray, int[] array, int firstIndex, int lastIndex)
        {
            int[] actualArray = array;
            int pivotValue = array[lastIndex];
            int actualPivotIndex = _object.Pivot(actualArray, firstIndex, lastIndex);

            Assert.AreEqual(expectedPivotIndex, actualPivotIndex);

            CollectionAssert.AreEqual(
                expectedArray.Select(x => x.CompareTo(pivotValue)),
                actualArray.Select(x => x.CompareTo(pivotValue))
            );
        }

        [Test]
        [Category("Quick Sort")]
        public void PartitionAndPivot()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] expected, actual;
            expected = new int[0];
            actual = new int[0];
            _object.PartitionAndPivot(actual, 0, -1);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 };
            _object.PartitionAndPivot(actual, 0, 0);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 0, 1, 2, 3, 8, 9, 50 };
            actual = new int[] { 50, 9, 8, 2, 3, 1, 0 };
            _object.PartitionAndPivot(actual, 0, 6);

            CollectionAssert.AreEqual(expected, actual);

            // Take a range from 1 to 1 million.
            expected = Enumerable.Range(1, 1000000).ToArray();
            actual = Enumerable.Range(1, 1000000).ToArray();
            // shuffle them
            for (int i = 0; i < actual.Length; i++)
            {
                int j = Utils.Random.Next(1000000);
                var t = actual[i];
                actual[i] = actual[j];
                actual[j] = t;
            }
            // sort them
            _object.PartitionAndPivot(actual, 0, 999999);
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
            });
#endif
        }

        [Test]
        [Category("Quick Sort")]
        public void QuickSort()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            int[] expected = null;
            int[] actual = null;
            _object.QuickSort(actual);
            Assert.AreEqual(expected, actual);

            expected = new int[0];
            actual = new int[0];
            _object.QuickSort(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 1 };
            actual = new[] { 1 };
            _object.QuickSort(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new[] { 0, 1, 2, 3, 8, 9, 50 };
            actual = new int[] { 50, 9, 8, 2, 3, 1, 0 };
            _object.QuickSort(actual);

            CollectionAssert.AreEqual(expected, actual);

            // Take a range from 1 to 1 million.
            expected = Enumerable.Range(1, 1000000).ToArray();
            actual = Enumerable.Range(1, 1000000).ToArray();
            // shuffle them
            for (int i = 0; i < actual.Length; i++)
            {
                int j = Utils.Random.Next(1000000);
                var t = actual[i];
                actual[i] = actual[j];
                actual[j] = t;
            }
            // sort them
            _object.QuickSort(actual);
            CollectionAssert.AreEqual(expected, actual);
#if !DEBUG
            });
#endif
        }


        [Test]
        [Category("Sort")]
        public void SortIntStrings()
        {
#if !DEBUG
            Assert.Multiple(() =>
            {
#endif
            object[] actual = null;
            object[] expected = null;
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new object[0];
            actual = new object[0];
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(expected, actual);

            expected = new object[] { "1" };
            actual = new object[] { "1" };
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(actual, expected);

            expected = new object[] { 1 };
            actual = new object[] { 1 };
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(actual, expected);

            expected = new object[] { "0", 1 };
            actual = new object[] { "0", 1 };
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(actual, expected);

            expected = new object[] { 1, "0" };
            actual = new object[] { 1, "0" };
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(actual, expected);

            expected = new object[]
                {
                    6, "CC", "CD", "CV", "EO", "HI", "NP", 44, 54, "OD", 74, "PJ", "QX", "SQ", "YW", 76, 77, "ZO", 93,
                    98
            };
            actual = new object[]
                {
                    6, "SQ", "ZO", "QX", "CD", "PJ", "YW", 74, 77, "CC", 98, "HI", "CV", "NP", "EO", 93, 54, "OD",
                    44, 76
            };
            _object.SortIntStrings(actual);
            CollectionAssert.AreEqual(actual, expected);
#if !DEBUG
            });
#endif
        }

        #region longer test cases
        public void SortEvenOddsTests()
        {
            int[] array, expected;
            array = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            expected = new[] { 0, 99, 1, 98, 2, 97, 3, 96, 4, 95, 5, 94, 6, 93, 7, 92, 8, 91, 9, 90, 10, 89, 11, 88, 12, 87, 13, 86, 14, 85, 15, 84, 16, 83, 17, 82, 18, 81, 19, 80, 20, 79, 21, 78, 22, 77, 23, 76, 24, 75, 25, 74, 26, 73, 27, 72, 28, 71, 29, 70, 30, 69, 31, 68, 32, 67, 33, 66, 34, 65, 35, 64, 36, 63, 37, 62, 38, 61, 39, 60, 40, 59, 41, 58, 42, 57, 43, 56, 44, 55, 45, 54, 46, 53, 47, 52, 48, 51, 49, 50 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 2278, 5684, 3271, 5199, 9576, 9868, 641, 3961, 961, 2043, 1397, 2423, 9426, 9249, 4540, 3852, 6364, 5290, 7849, 8603, 8638, 8388, 7095, 4224, 3676, 3735, 7679, 7225, 377, 4622, 3892, 1260, 3416, 424, 4395, 2860, 364, 7443, 4372, 9585, 3283, 5611, 202, 7053, 9314, 9809, 7990, 959, 8479, 3745, 3608, 2279, 5457, 6381, 484, 3889, 8589, 9047, 1522, 5840, 2189, 3416, 3584, 6338, 8150, 137, 9006, 9001, 4854, 1679, 3488, 8921, 918, 8264, 5319, 3027, 8185, 41, 4909, 3867, 5745, 6719, 8745, 6631, 1014, 1613, 5802, 7035, 9939, 505, 4271, 1316, 5920, 8531, 7396, 9867, 2027, 3863, 8903, 9177 };
            expected = new[] { 41, 9939, 137, 9868, 202, 9867, 364, 9809, 377, 9585, 424, 9576, 484, 9426, 505, 9314, 641, 9249, 918, 9177, 959, 9047, 961, 9006, 1014, 9001, 1260, 8921, 1316, 8903, 1397, 8745, 1522, 8638, 1613, 8603, 1679, 8589, 2027, 8531, 2043, 8479, 2189, 8388, 2278, 8264, 2279, 8185, 2423, 8150, 2860, 7990, 3027, 7849, 3271, 7679, 3283, 7443, 3416, 7396, 3416, 7225, 3488, 7095, 3584, 7053, 3608, 7035, 3676, 6719, 3735, 6631, 3745, 6381, 3852, 6364, 3863, 6338, 3867, 5920, 3889, 5840, 3892, 5802, 3961, 5745, 4224, 5684, 4271, 5611, 4372, 5457, 4395, 5319, 4540, 5290, 4622, 5199, 4854, 4909 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 803, 8988, 6105, 6799, 257, 4687, 1360, 7193, 1061, 7457, 5703, 8548, 4137, 7655, 95, 5469, 4670, 6953, 5324, 6537, 4334, 1970, 9062, 4348, 7408, 2171, 3000, 2387, 867, 5452, 1000, 4322, 1137, 5732, 3063, 6757, 613, 1946, 6373, 6327, 252, 8609, 5974, 2482, 4801, 5722, 7178, 8265, 8436, 1926, 5196, 5073, 8538, 2366, 4842, 8833, 9925, 1757, 9391, 8086, 1687, 8973, 6325, 5608, 6457, 1381, 7410, 8405, 4591, 3338, 4856, 2724, 579, 8997, 6284, 5725, 5996, 6580, 9546, 1685, 4992, 4734, 3951, 8940, 256, 5926, 5784, 8771, 890, 4230, 6831, 8856, 2554, 8286, 4640, 1279, 2283, 365, 6024, 3420 };
            expected = new[] { 95, 9925, 252, 9546, 256, 9391, 257, 9062, 365, 8997, 579, 8988, 613, 8973, 803, 8940, 867, 8856, 890, 8833, 1000, 8771, 1061, 8609, 1137, 8548, 1279, 8538, 1360, 8436, 1381, 8405, 1685, 8286, 1687, 8265, 1757, 8086, 1926, 7655, 1946, 7457, 1970, 7410, 2171, 7408, 2283, 7193, 2366, 7178, 2387, 6953, 2482, 6831, 2554, 6799, 2724, 6757, 3000, 6580, 3063, 6537, 3338, 6457, 3420, 6373, 3951, 6327, 4137, 6325, 4230, 6284, 4322, 6105, 4334, 6024, 4348, 5996, 4591, 5974, 4640, 5926, 4670, 5784, 4687, 5732, 4734, 5725, 4801, 5722, 4842, 5703, 4856, 5608, 4992, 5469, 5073, 5452, 5196, 5324 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 8311, 8773, 3673, 5097, 7070, 2472, 4493, 9541, 6082, 9116, 2837, 3345, 2210, 7705, 3094, 6952, 5022, 7385, 5352, 530, 5597, 8639, 7514, 361, 6506, 5999, 169, 2292, 4357, 5004, 3442, 5630, 555, 6125, 3373, 6218, 1060, 8853, 1870, 7783, 1432, 6242, 2689, 1774, 1393, 3485, 6645, 4848, 5192, 7687, 6256, 4898, 5013, 5493, 7823, 9672, 1258, 3312, 8591, 1070, 2302, 2201, 5184, 1077, 5673, 7206, 2790, 6084, 4332, 6875, 5891, 6169, 5514, 7568, 9098, 9354, 5950, 5740, 8968, 3020, 9354, 5321, 7100, 6669, 8748, 8544, 616, 5061, 8302, 3700, 4960, 7748, 261, 799, 5480, 9231, 1058, 1611, 6100, 4186 };
            expected = new[] { 169, 9672, 261, 9541, 361, 9354, 530, 9354, 555, 9231, 616, 9116, 799, 9098, 1058, 8968, 1060, 8853, 1070, 8773, 1077, 8748, 1258, 8639, 1393, 8591, 1432, 8544, 1611, 8311, 1774, 8302, 1870, 7823, 2201, 7783, 2210, 7748, 2292, 7705, 2302, 7687, 2472, 7568, 2689, 7514, 2790, 7385, 2837, 7206, 3020, 7100, 3094, 7070, 3312, 6952, 3345, 6875, 3373, 6669, 3442, 6645, 3485, 6506, 3673, 6256, 3700, 6242, 4186, 6218, 4332, 6169, 4357, 6125, 4493, 6100, 4848, 6084, 4898, 6082, 4960, 5999, 5004, 5950, 5013, 5891, 5022, 5740, 5061, 5673, 5097, 5630, 5184, 5597, 5192, 5514, 5321, 5493, 5352, 5480 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 695, 560, 516, 8317, 1796, 87, 9383, 7444, 6395, 8469, 3722, 5517, 4343, 5571, 1716, 6981, 5100, 8514, 2329, 7129, 6590, 7728, 7782, 631, 1915, 8142, 5907, 4715, 2088, 9867, 8295, 4338, 9640, 4782, 2324, 8794, 4804, 8783, 4873, 8660, 9161, 3172, 8666, 9833, 9978, 9442, 3404, 4690, 9083, 8499, 4130, 2543, 9282, 8971, 7595, 2967, 2777, 9885, 6401, 3653, 4179, 4668, 5356, 6528, 173, 9384, 5877, 9561, 3246, 2921, 2177, 6317, 3641, 3668, 7968, 3418, 9061, 7949, 653, 2473, 4737, 1217, 5631, 3588, 5736, 5751, 5055, 669, 7186, 9357, 6016, 4919, 2381, 1220, 4480, 4492, 7815, 2138, 9659, 593 };
            expected = new[] { 87, 9978, 173, 9885, 516, 9867, 560, 9833, 593, 9659, 631, 9640, 653, 9561, 669, 9442, 695, 9384, 1217, 9383, 1220, 9357, 1716, 9282, 1796, 9161, 1915, 9083, 2088, 9061, 2138, 8971, 2177, 8794, 2324, 8783, 2329, 8666, 2381, 8660, 2473, 8514, 2543, 8499, 2777, 8469, 2921, 8317, 2967, 8295, 3172, 8142, 3246, 7968, 3404, 7949, 3418, 7815, 3588, 7782, 3641, 7728, 3653, 7595, 3668, 7444, 3722, 7186, 4130, 7129, 4179, 6981, 4338, 6590, 4343, 6528, 4480, 6401, 4492, 6395, 4668, 6317, 4690, 6016, 4715, 5907, 4737, 5877, 4782, 5751, 4804, 5736, 4873, 5631, 4919, 5571, 5055, 5517, 5100, 5356 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 3564, 3843, 1444, 6161, 6322, 7812, 8902, 5613, 1002, 4177, 3905, 4828, 9232, 3928, 8915, 2962, 9036, 1767, 791, 4421, 4328, 5207, 2375, 3888, 6905, 7257, 3936, 2421, 9187, 3475, 5602, 6923, 8289, 59, 8908, 894, 9772, 9470, 7266, 7923, 6848, 9442, 9666, 3008, 5451, 1187, 5686, 8452, 2304, 1518, 5456, 6047, 1346, 5237, 6265, 8357, 1468, 7555, 9255, 9064, 3876, 6481, 6425, 7527, 8574, 6982, 6539, 9172, 5020, 8020, 3189, 9565, 4500, 2868, 7572, 4886, 5541, 9366, 8436, 5718, 1571, 5484, 116, 7669, 8018, 9554, 5576, 3051, 3794, 551, 9426, 2217, 214, 8202, 4047, 367, 3016, 2139, 4434, 8469 };
            expected = new[] { 59, 9772, 116, 9666, 214, 9565, 367, 9554, 551, 9470, 791, 9442, 894, 9426, 1002, 9366, 1187, 9255, 1346, 9232, 1444, 9187, 1468, 9172, 1518, 9064, 1571, 9036, 1767, 8915, 2139, 8908, 2217, 8902, 2304, 8574, 2375, 8469, 2421, 8452, 2868, 8436, 2962, 8357, 3008, 8289, 3016, 8202, 3051, 8020, 3189, 8018, 3475, 7923, 3564, 7812, 3794, 7669, 3843, 7572, 3876, 7555, 3888, 7527, 3905, 7266, 3928, 7257, 3936, 6982, 4047, 6923, 4177, 6905, 4328, 6848, 4421, 6539, 4434, 6481, 4500, 6425, 4828, 6322, 4886, 6265, 5020, 6161, 5207, 6047, 5237, 5718, 5451, 5686, 5456, 5613, 5484, 5602, 5541, 5576 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 4648, 6513, 3431, 4283, 8329, 5890, 1546, 8478, 7665, 1379, 2815, 2102, 9118, 3537, 7492, 8392, 6365, 8756, 9508, 9019, 1405, 3487, 5378, 4469, 8594, 972, 9351, 6298, 8820, 7205, 1869, 3401, 4932, 9966, 1069, 5057, 2052, 5832, 9339, 2127, 8007, 7097, 5386, 2415, 7735, 7323, 3098, 6676, 709, 5654, 4001, 4260, 2630, 5414, 7064, 1160, 1135, 8961, 5689, 7357, 6539, 5248, 9657, 459, 9509, 9413, 7169, 9152, 2467, 2435, 6339, 533, 9416, 7381, 1012, 4307, 8101, 2963, 6734, 1270, 7873, 2674, 5588, 3165, 3203, 7608, 771, 9518, 2902, 9909, 3921, 3091, 143, 1982, 5588, 2759, 7440, 4926, 2905, 8321 };
            expected = new[] { 143, 9966, 459, 9909, 533, 9657, 709, 9518, 771, 9509, 972, 9508, 1012, 9416, 1069, 9413, 1135, 9351, 1160, 9339, 1270, 9152, 1379, 9118, 1405, 9019, 1546, 8961, 1869, 8820, 1982, 8756, 2052, 8594, 2102, 8478, 2127, 8392, 2415, 8329, 2435, 8321, 2467, 8101, 2630, 8007, 2674, 7873, 2759, 7735, 2815, 7665, 2902, 7608, 2905, 7492, 2963, 7440, 3091, 7381, 3098, 7357, 3165, 7323, 3203, 7205, 3401, 7169, 3431, 7097, 3487, 7064, 3537, 6734, 3921, 6676, 4001, 6539, 4260, 6513, 4283, 6365, 4307, 6339, 4469, 6298, 4648, 5890, 4926, 5832, 4932, 5689, 5057, 5654, 5248, 5588, 5378, 5588, 5386, 5414 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 153, 3946, 4209, 8273, 9315, 3468, 4843, 5249, 4402, 2757, 3058, 8171, 2227, 4418, 9483, 3865, 9659, 6491, 7255, 1900, 8642, 7651, 6249, 2558, 8513, 3248, 390, 7433, 1792, 8252, 6867, 3174, 58, 8413, 1117, 3926, 8465, 7315, 3850, 9735, 2764, 5522, 5116, 145, 6851, 5750, 864, 5724, 2498, 1723, 3099, 948, 7671, 1004, 9678, 2501, 7696, 1650, 9759, 6067, 3078, 7410, 3456, 6149, 5889, 9883, 8113, 3813, 3301, 5556, 5399, 2344, 2641, 7520, 9135, 3120, 2535, 6104, 5706, 2763, 2383, 4665, 4934, 69, 5152, 5919, 5503, 9054, 8734, 8615, 6230, 6814, 7555, 7782, 6657, 5354, 2065, 8966, 4255, 6967 };
            expected = new[] { 58, 9883, 69, 9759, 145, 9735, 153, 9678, 390, 9659, 864, 9483, 948, 9315, 1004, 9135, 1117, 9054, 1650, 8966, 1723, 8734, 1792, 8642, 1900, 8615, 2065, 8513, 2227, 8465, 2344, 8413, 2383, 8273, 2498, 8252, 2501, 8171, 2535, 8113, 2558, 7782, 2641, 7696, 2757, 7671, 2763, 7651, 2764, 7555, 3058, 7520, 3078, 7433, 3099, 7410, 3120, 7315, 3174, 7255, 3248, 6967, 3301, 6867, 3456, 6851, 3468, 6814, 3813, 6657, 3850, 6491, 3865, 6249, 3926, 6230, 3946, 6149, 4209, 6104, 4255, 6067, 4402, 5919, 4418, 5889, 4665, 5750, 4843, 5724, 4934, 5706, 5116, 5556, 5152, 5522, 5249, 5503, 5354, 5399 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 7637, 7050, 2423, 6941, 6323, 755, 8306, 151, 1868, 6558, 9966, 1591, 5943, 6996, 3683, 8412, 2475, 3387, 996, 9970, 4379, 9058, 5078, 4686, 9326, 8584, 4789, 4858, 862, 3781, 1055, 3569, 1849, 8739, 5126, 5333, 2241, 7992, 3745, 4397, 7612, 5352, 7185, 2176, 8648, 4638, 870, 558, 4098, 8244, 2879, 8678, 7970, 4284, 2587, 8578, 1971, 7737, 7615, 7738, 5965, 3447, 9288, 8086, 5503, 6396, 9742, 7204, 1870, 8350, 6170, 4482, 9641, 6598, 2358, 9026, 1872, 2902, 6037, 4688, 7714, 4230, 760, 2617, 902, 2376, 5599, 7565, 6151, 6547, 3361, 4504, 377, 6007, 8432, 4164, 6064, 9099, 6673, 2252 };
            expected = new[] { 151, 9970, 377, 9966, 558, 9742, 755, 9641, 760, 9326, 862, 9288, 870, 9099, 902, 9058, 996, 9026, 1055, 8739, 1591, 8678, 1849, 8648, 1868, 8584, 1870, 8578, 1872, 8432, 1971, 8412, 2176, 8350, 2241, 8306, 2252, 8244, 2358, 8086, 2376, 7992, 2423, 7970, 2475, 7738, 2587, 7737, 2617, 7714, 2879, 7637, 2902, 7615, 3361, 7612, 3387, 7565, 3447, 7204, 3569, 7185, 3683, 7050, 3745, 6996, 3781, 6941, 4098, 6673, 4164, 6598, 4230, 6558, 4284, 6547, 4379, 6396, 4397, 6323, 4482, 6170, 4504, 6151, 4638, 6064, 4686, 6037, 4688, 6007, 4789, 5965, 4858, 5943, 5078, 5599, 5126, 5503, 5333, 5352 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 4895, 3666, 8688, 5748, 2074, 8396, 9036, 1371, 1925, 3560, 6705, 9069, 1700, 2926, 24, 1734, 2687, 6671, 7184, 3126, 797, 2177, 1052, 5322, 4988, 1666, 4105, 3634, 8166, 8194, 2962, 2773, 6228, 3785, 9792, 4048, 5542, 5011, 543, 2505, 3340, 4227, 5639, 2590, 9842, 4292, 2803, 7451, 5982, 6697, 1476, 9393, 1914, 3547, 1454, 2718, 2613, 3365, 760, 407, 4291, 5402, 3205, 3731, 598, 3931, 2840, 7915, 3133, 5976, 6191, 7676, 6127, 4679, 9785, 6570, 6538, 8461, 5480, 695, 8863, 6654, 7651, 1468, 6717, 3569, 859, 2681, 2330, 7073, 1434, 2177, 4251, 136, 8214, 7938, 1021, 1907, 1992, 5910 };
            expected = new[] { 24, 9842, 136, 9792, 407, 9785, 543, 9393, 598, 9069, 695, 9036, 760, 8863, 797, 8688, 859, 8461, 1021, 8396, 1052, 8214, 1371, 8194, 1434, 8166, 1454, 7938, 1468, 7915, 1476, 7676, 1666, 7651, 1700, 7451, 1734, 7184, 1907, 7073, 1914, 6717, 1925, 6705, 1992, 6697, 2074, 6671, 2177, 6654, 2177, 6570, 2330, 6538, 2505, 6228, 2590, 6191, 2613, 6127, 2681, 5982, 2687, 5976, 2718, 5910, 2773, 5748, 2803, 5639, 2840, 5542, 2926, 5480, 2962, 5402, 3126, 5322, 3133, 5011, 3205, 4988, 3340, 4895, 3365, 4679, 3547, 4292, 3560, 4291, 3569, 4251, 3634, 4227, 3666, 4105, 3731, 4048, 3785, 3931 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));

            array = new[] { 1452, 4888, 4317, 6, 505, 3800, 3265, 7235, 3761, 4883, 6180, 4151, 7885, 64, 1544, 7637, 7750, 1737, 7013, 7028, 3072, 158, 5584, 6059, 4541, 4014, 3424, 5991, 6464, 1847, 5548, 4630, 6468, 9570, 9242, 3974, 2337, 7645, 962, 2917, 304, 3624, 8919, 7447, 893, 7282, 4291, 4187, 8591, 577, 187, 9284, 4893, 4964, 2838, 1293, 9303, 8257, 5464, 6491, 375, 7273, 770, 1913, 9334, 1550, 7682, 8315, 821, 7569, 5300, 104, 774, 4095, 6723, 9447, 1239, 8137, 5166, 7258, 9722, 9237, 7400, 5887, 1660, 6264, 9736, 1504, 6731, 7949, 4670, 4079, 2180, 4471, 2542, 3030, 2853, 7005, 8112, 9343 };
            expected = new[] { 6, 9736, 64, 9722, 104, 9570, 158, 9447, 187, 9343, 304, 9334, 375, 9303, 505, 9284, 577, 9242, 770, 9237, 774, 8919, 821, 8591, 893, 8315, 962, 8257, 1239, 8137, 1293, 8112, 1452, 7949, 1504, 7885, 1544, 7750, 1550, 7682, 1660, 7645, 1737, 7637, 1847, 7569, 1913, 7447, 2180, 7400, 2337, 7282, 2542, 7273, 2838, 7258, 2853, 7235, 2917, 7028, 3030, 7013, 3072, 7005, 3265, 6731, 3424, 6723, 3624, 6491, 3761, 6468, 3800, 6464, 3974, 6264, 4014, 6180, 4079, 6059, 4095, 5991, 4151, 5887, 4187, 5584, 4291, 5548, 4317, 5464, 4471, 5300, 4541, 5166, 4630, 4964, 4670, 4893, 4883, 4888 };
            CollectionAssert.AreEqual(expected, _object.SortEvenOdds(array));
        }

        private void SortEvensOddsInPlaceTests()
        {
            int[] actual, expected;
            actual = new[] { -61, -61, -28, -87, 71, -19, -45, -99, 84, -21, 67, 32, 64, -72, -34, 56, 34, -76, -26, -3 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { -99, -87, -76, -61, -61, -45, -21, -19, -72, -3, 67, -34, -28, -26, 32, 34, 56, 64, 84, 71 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 626, -342, 20, -690, -188, 30, 520, 358, -765, 719, 409, 646, 639, -363, -535, -378, 183, 75, 65, 312, -990, -13, 591, -591, 945, 877, 252, 297, -337, -498, 978, -774, 771, -71, -483, -738, -5, 908, 171, 539, 329, -575, 40, 574, -603, 437, -924, 102, 454, 129, 507, -347, 654, 961, -641, -360, 66, -388, -636, -67, 776, -776, -305, 732, 740, 183, 873, -290, -879, -796, 626, 274, 902, 524, 981, 583, 946, -983, -987, -491, 802, -850, 841, 532, -6, 326, -429, 809, -430, 876, 194, -617, 545, -761, 761, 106, 729, 307, 832, 212, 562, 364, -18, 251, 501, -767, -251, -870, 978, -226, -308, 49, -400, 853, 129, 626, -619, 161, -262, -585, -387, -935, -859, -757, 8, 243, 727, 664, 762, -124, 853, -360, -816, -201, -55, -561, 167, -410, -968, -239, -423, -559, 830, 795, 185, -854, 782, 690, 108, -865, -275, -432, -431, 418, -401, 498, 224, -260, -756, -742, -495, 83, -633, 102, -81, -947, -134, 799, -91, -310, -540, 789, 130, 976, 836, -827, -767, -656, 57, -137, 460, -962, -444, 627, -848, 286, -928, -236, -800, 446, 214, -572, -653, 772, -743, 492, -926, -272, -124, 133 };
            _object.SortEvensOddsInPlace(actual);
            expected = new[] { -990, -968, -962, -928, -926, -924, -870, -854, -987, -983, -947, -850, -935, -879, -865, -848, -859, -827, -767, -816, -800, -767, -765, -761, -757, -743, -796, -653, -641, -776, -774, -756, -633, -619, -617, -742, -603, -738, -591, -585, -575, -561, -690, -656, -559, -535, -636, -572, -540, -495, -491, -483, -498, -431, -429, -444, -432, -430, -410, -423, -400, -388, -401, -378, -360, -387, -363, -360, -347, -342, -310, -308, -290, -272, -337, -305, -262, -275, -251, -239, -260, -236, -201, -226, -188, -134, -137, -91, -124, -124, -18, -81, -71, -67, -55, -6, -13, -5, 8, 20, 30, 40, 66, 49, 57, 65, 75, 102, 102, 106, 108, 83, 130, 129, 129, 194, 133, 161, 212, 167, 171, 183, 183, 185, 214, 243, 251, 224, 252, 274, 297, 286, 312, 307, 329, 409, 437, 326, 358, 501, 507, 539, 364, 545, 583, 418, 446, 454, 460, 591, 627, 492, 639, 498, 719, 520, 524, 532, 562, 574, 727, 729, 761, 626, 771, 789, 626, 795, 799, 626, 646, 809, 654, 664, 690, 841, 853, 732, 853, 873, 740, 762, 772, 877, 776, 782, 802, 830, 832, 836, 876, 902, 945, 908, 961, 946, 976, 978, 978, 981 };
            CollectionAssert.AreEqual(expected, actual);
        }

        private void SortAllColumnsTests()
        {
            int[,] matrix, expected;
            matrix = new int[0, 0];
            expected = new int[0, 0];
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[0, 20];
            expected = new int[0, 20];
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[5, 5] {
    { 53, 72, 96, 95, 47 },
    { 93, 85, 37, 51, 91 },
    { 53, 78, 20, 33, 94 },
    { 71, 42, 12, 47, 75 },
    { 45, 96, 18, 29, 71 }
};
            expected = new int[5, 5] {
    { 45, 42, 12, 29, 47 },
    { 53, 72, 18, 33, 71 },
    { 53, 78, 20, 47, 75 },
    { 71, 85, 37, 51, 91 },
    { 93, 96, 96, 95, 94 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[5, 10] {
    { 69, 35, 65, 40, 33, 59, 62, 70, 26, 22 },
    { 51, 19, 66, 88, 32, 86, 36, 12, 60, 10 },
    { 54, 82, 92, 49, 43, 51, 64, 20, 30, 54 },
    { 56, 64, 77, 34, 78, 68, 30, 96, 27, 42 },
    { 91, 18, 93, 21, 53, 61, 76, 24, 24, 89 }
};
            expected = new int[5, 10] {
    { 51, 18, 65, 21, 32, 51, 30, 12, 24, 10 },
    { 54, 19, 66, 34, 33, 59, 36, 20, 26, 22 },
    { 56, 35, 77, 40, 43, 61, 62, 24, 27, 42 },
    { 69, 64, 92, 49, 53, 68, 64, 70, 30, 54 },
    { 91, 82, 93, 88, 78, 86, 76, 96, 60, 89 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[5, 15] {
    { 18, 94, 57, 28, 26, 86, 42, 26, 97, 82, 95, 52, 49, 71, 66 },
    { 86, 42, 42, 19, 64, 66, 40, 84, 28, 19, 46, 88, 81, 95, 82 },
    { 75, 49, 95, 41, 46, 62, 17, 59, 17, 92, 36, 13, 99, 45, 47 },
    { 48, 68, 32, 54, 66, 29, 43, 14, 60, 33, 78, 20, 38, 18, 80 },
    { 97, 60, 30, 24, 17, 55, 56, 18, 35, 14, 79, 83, 35, 27, 38 }
};
            expected = new int[5, 15] {
    { 18, 42, 30, 19, 17, 29, 17, 14, 17, 14, 36, 13, 35, 18, 38 },
    { 48, 49, 32, 24, 26, 55, 40, 18, 28, 19, 46, 20, 38, 27, 47 },
    { 75, 60, 42, 28, 46, 62, 42, 26, 35, 33, 78, 52, 49, 45, 66 },
    { 86, 68, 57, 41, 64, 66, 43, 59, 60, 82, 79, 83, 81, 71, 80 },
    { 97, 94, 95, 54, 66, 86, 56, 84, 97, 92, 95, 88, 99, 95, 82 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[5, 20] {
    { 62, 40, 48, 81, 71, 78, 66, 37, 39, 63, 41, 44, 45, 18, 67, 52, 78, 50, 37, 94 },
    { 75, 83, 84, 38, 91, 92, 60, 96, 50, 86, 45, 18, 87, 32, 70, 47, 71, 57, 47, 12 },
    { 40, 33, 91, 61, 75, 20, 21, 10, 68, 61, 11, 42, 97, 33, 62, 79, 56, 20, 89, 78 },
    { 27, 69, 86, 52, 27, 33, 57, 22, 47, 29, 81, 30, 13, 35, 63, 52, 91, 32, 62, 81 },
    { 80, 59, 38, 88, 85, 13, 20, 64, 70, 91, 91, 60, 67, 68, 84, 70, 46, 48, 44, 52 }
};
            expected = new int[5, 20] {
    { 27, 33, 38, 38, 27, 13, 20, 10, 39, 29, 11, 18, 13, 18, 62, 47, 46, 20, 37, 12 },
    { 40, 40, 48, 52, 71, 20, 21, 22, 47, 61, 41, 30, 45, 32, 63, 52, 56, 32, 44, 52 },
    { 62, 59, 84, 61, 75, 33, 57, 37, 50, 63, 45, 42, 67, 33, 67, 52, 71, 48, 47, 78 },
    { 75, 69, 86, 81, 85, 78, 60, 64, 68, 86, 81, 44, 87, 35, 70, 70, 78, 50, 62, 81 },
    { 80, 83, 91, 88, 91, 92, 66, 96, 70, 91, 91, 60, 97, 68, 84, 79, 91, 57, 89, 94 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[10, 5] {
    { 63, 99, 62, 48, 80 },
    { 80, 39, 72, 69, 19 },
    { 87, 33, 57, 18, 98 },
    { 68, 41, 97, 67, 24 },
    { 22, 93, 51, 55, 38 },
    { 30, 63, 44, 50, 93 },
    { 16, 53, 88, 20, 28 },
    { 81, 96, 89, 18, 14 },
    { 74, 47, 94, 61, 13 },
    { 67, 12, 59, 70, 26 }
};
            expected = new int[10, 5] {
    { 16, 12, 44, 18, 13 },
    { 22, 33, 51, 18, 14 },
    { 30, 39, 57, 20, 19 },
    { 63, 41, 59, 48, 24 },
    { 67, 47, 62, 50, 26 },
    { 68, 53, 72, 55, 28 },
    { 74, 63, 88, 61, 38 },
    { 80, 93, 89, 67, 80 },
    { 81, 96, 94, 69, 93 },
    { 87, 99, 97, 70, 98 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[10, 10] {
    { 39, 49, 80, 30, 40, 69, 57, 16, 20, 60 },
    { 27, 94, 31, 76, 12, 44, 45, 47, 90, 26 },
    { 71, 51, 89, 63, 49, 74, 98, 90, 52, 70 },
    { 28, 13, 74, 34, 63, 66, 72, 67, 79, 58 },
    { 34, 89, 79, 57, 87, 79, 25, 28, 58, 69 },
    { 31, 64, 68, 53, 55, 88, 60, 27, 80, 65 },
    { 71, 66, 64, 49, 42, 23, 29, 97, 22, 46 },
    { 71, 77, 68, 42, 92, 81, 71, 41, 75, 69 },
    { 58, 79, 42, 83, 48, 63, 45, 31, 79, 75 },
    { 16, 54, 87, 24, 86, 67, 35, 39, 25, 73 }
};
            expected = new int[10, 10] {
    { 16, 13, 31, 24, 12, 23, 25, 16, 20, 26 },
    { 27, 49, 42, 30, 40, 44, 29, 27, 22, 46 },
    { 28, 51, 64, 34, 42, 63, 35, 28, 25, 58 },
    { 31, 54, 68, 42, 48, 66, 45, 31, 52, 60 },
    { 34, 64, 68, 49, 49, 67, 45, 39, 58, 65 },
    { 39, 66, 74, 53, 55, 69, 57, 41, 75, 69 },
    { 58, 77, 79, 57, 63, 74, 60, 47, 79, 69 },
    { 71, 79, 80, 63, 86, 79, 71, 67, 79, 70 },
    { 71, 89, 87, 76, 87, 81, 72, 90, 80, 73 },
    { 71, 94, 89, 83, 92, 88, 98, 97, 90, 75 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[10, 15] {
    { 60, 28, 16, 22, 97, 53, 96, 36, 60, 73, 26, 29, 51, 20, 17 },
    { 91, 34, 81, 10, 78, 78, 97, 27, 47, 40, 27, 90, 54, 55, 34 },
    { 55, 42, 25, 12, 19, 39, 73, 30, 86, 95, 66, 18, 71, 15, 59 },
    { 86, 12, 76, 16, 95, 43, 54, 38, 46, 95, 63, 10, 69, 81, 79 },
    { 63, 52, 81, 35, 27, 84, 13, 49, 11, 77, 28, 14, 94, 15, 21 },
    { 69, 35, 21, 87, 53, 24, 23, 47, 60, 91, 11, 13, 78, 16, 55 },
    { 39, 14, 48, 16, 41, 24, 37, 45, 87, 75, 83, 62, 75, 39, 76 },
    { 38, 59, 32, 35, 35, 37, 88, 81, 38, 65, 49, 15, 31, 44, 26 },
    { 80, 34, 43, 55, 48, 24, 66, 88, 74, 97, 42, 90, 33, 22, 70 },
    { 61, 48, 17, 83, 62, 52, 80, 53, 80, 28, 50, 32, 20, 50, 92 }
};
            expected = new int[10, 15] {
    { 38, 12, 16, 10, 19, 24, 13, 27, 11, 28, 11, 10, 20, 15, 17 },
    { 39, 14, 17, 12, 27, 24, 23, 30, 38, 40, 26, 13, 31, 15, 21 },
    { 55, 28, 21, 16, 35, 24, 37, 36, 46, 65, 27, 14, 33, 16, 26 },
    { 60, 34, 25, 16, 41, 37, 54, 38, 47, 73, 28, 15, 51, 20, 34 },
    { 61, 34, 32, 22, 48, 39, 66, 45, 60, 75, 42, 18, 54, 22, 55 },
    { 63, 35, 43, 35, 53, 43, 73, 47, 60, 77, 49, 29, 69, 39, 59 },
    { 69, 42, 48, 35, 62, 52, 80, 49, 74, 91, 50, 32, 71, 44, 70 },
    { 80, 48, 76, 55, 78, 53, 88, 53, 80, 95, 63, 62, 75, 50, 76 },
    { 86, 52, 81, 83, 95, 78, 96, 81, 86, 95, 66, 90, 78, 55, 79 },
    { 91, 59, 81, 87, 97, 84, 97, 88, 87, 97, 83, 90, 94, 81, 92 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[10, 20] {
    { 19, 16, 11, 71, 94, 58, 29, 29, 91, 62, 72, 70, 58, 37, 93, 47, 64, 68, 67, 13 },
    { 11, 97, 47, 81, 74, 10, 81, 62, 37, 97, 91, 55, 47, 81, 88, 36, 88, 62, 28, 22 },
    { 42, 28, 25, 30, 89, 81, 31, 26, 86, 81, 85, 64, 52, 47, 91, 21, 68, 30, 97, 93 },
    { 76, 66, 92, 93, 71, 27, 32, 76, 49, 67, 58, 12, 49, 55, 71, 82, 82, 27, 92, 92 },
    { 78, 65, 76, 55, 22, 36, 13, 10, 90, 77, 67, 68, 64, 34, 45, 75, 35, 32, 59, 72 },
    { 58, 54, 76, 29, 32, 82, 24, 97, 75, 18, 39, 50, 37, 14, 25, 21, 90, 46, 81, 44 },
    { 24, 32, 86, 72, 99, 90, 47, 25, 19, 95, 56, 59, 68, 29, 44, 33, 88, 56, 33, 40 },
    { 22, 15, 34, 82, 47, 26, 40, 59, 19, 33, 85, 88, 51, 24, 58, 36, 68, 14, 29, 41 },
    { 44, 99, 87, 80, 61, 79, 82, 18, 70, 91, 33, 43, 23, 50, 31, 18, 97, 13, 34, 83 },
    { 59, 87, 15, 86, 19, 67, 18, 53, 71, 17, 64, 83, 37, 91, 95, 23, 28, 54, 30, 68 }
};
            expected = new int[10, 20] {
    { 11, 15, 11, 29, 19, 10, 13, 10, 19, 17, 33, 12, 23, 14, 25, 18, 28, 13, 28, 13 },
    { 19, 16, 15, 30, 22, 26, 18, 18, 19, 18, 39, 43, 37, 24, 31, 21, 35, 14, 29, 22 },
    { 22, 28, 25, 55, 32, 27, 24, 25, 37, 33, 56, 50, 37, 29, 44, 21, 64, 27, 30, 40 },
    { 24, 32, 34, 71, 47, 36, 29, 26, 49, 62, 58, 55, 47, 34, 45, 23, 68, 30, 33, 41 },
    { 42, 54, 47, 72, 61, 58, 31, 29, 70, 67, 64, 59, 49, 37, 58, 33, 68, 32, 34, 44 },
    { 44, 65, 76, 80, 71, 67, 32, 53, 71, 77, 67, 64, 51, 47, 71, 36, 82, 46, 59, 68 },
    { 58, 66, 76, 81, 74, 79, 40, 59, 75, 81, 72, 68, 52, 50, 88, 36, 88, 54, 67, 72 },
    { 59, 87, 86, 82, 89, 81, 47, 62, 86, 91, 85, 70, 58, 55, 91, 47, 88, 56, 81, 83 },
    { 76, 97, 87, 86, 94, 82, 81, 76, 90, 95, 85, 83, 64, 81, 93, 75, 90, 62, 92, 92 },
    { 78, 99, 92, 93, 99, 90, 82, 97, 91, 97, 91, 88, 68, 91, 95, 82, 97, 68, 97, 93 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[15, 5] {
    { 44, 32, 89, 27, 10 },
    { 52, 75, 10, 92, 50 },
    { 38, 64, 80, 46, 81 },
    { 57, 93, 10, 70, 93 },
    { 70, 39, 46, 62, 36 },
    { 49, 16, 31, 55, 18 },
    { 89, 52, 83, 65, 49 },
    { 37, 98, 88, 86, 67 },
    { 92, 18, 60, 31, 78 },
    { 10, 13, 90, 19, 48 },
    { 29, 27, 83, 36, 98 },
    { 15, 85, 36, 90, 60 },
    { 46, 54, 54, 84, 60 },
    { 86, 81, 24, 97, 54 },
    { 58, 15, 24, 13, 11 }
};
            expected = new int[15, 5] {
    { 10, 13, 10, 13, 10 },
    { 15, 15, 10, 19, 11 },
    { 29, 16, 24, 27, 18 },
    { 37, 18, 24, 31, 36 },
    { 38, 27, 31, 36, 48 },
    { 44, 32, 36, 46, 49 },
    { 46, 39, 46, 55, 50 },
    { 49, 52, 54, 62, 54 },
    { 52, 54, 60, 65, 60 },
    { 57, 64, 80, 70, 60 },
    { 58, 75, 83, 84, 67 },
    { 70, 81, 83, 86, 78 },
    { 86, 85, 88, 90, 81 },
    { 89, 93, 89, 92, 93 },
    { 92, 98, 90, 97, 98 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[15, 10] {
    { 62, 78, 25, 83, 36, 45, 25, 21, 17, 88 },
    { 71, 68, 56, 67, 44, 51, 72, 97, 35, 31 },
    { 48, 63, 76, 70, 92, 28, 89, 93, 65, 89 },
    { 24, 13, 80, 35, 45, 37, 70, 52, 63, 24 },
    { 30, 42, 47, 95, 89, 27, 34, 56, 63, 12 },
    { 86, 18, 88, 81, 63, 98, 11, 54, 91, 18 },
    { 56, 31, 56, 27, 74, 68, 87, 31, 31, 17 },
    { 81, 29, 43, 21, 10, 15, 26, 81, 81, 75 },
    { 94, 42, 40, 62, 13, 15, 24, 98, 72, 47 },
    { 35, 25, 61, 55, 68, 99, 85, 29, 30, 31 },
    { 39, 13, 34, 56, 31, 66, 74, 77, 81, 57 },
    { 81, 29, 73, 26, 24, 23, 91, 94, 24, 68 },
    { 53, 88, 59, 84, 81, 65, 68, 87, 52, 10 },
    { 30, 97, 60, 59, 45, 90, 17, 84, 40, 46 },
    { 40, 47, 27, 24, 66, 16, 51, 45, 41, 54 }
};
            expected = new int[15, 10] {
    { 24, 13, 25, 21, 10, 15, 11, 21, 17, 10 },
    { 30, 13, 27, 24, 13, 15, 17, 29, 24, 12 },
    { 30, 18, 34, 26, 24, 16, 24, 31, 30, 17 },
    { 35, 25, 40, 27, 31, 23, 25, 45, 31, 18 },
    { 39, 29, 43, 35, 36, 27, 26, 52, 35, 24 },
    { 40, 29, 47, 55, 44, 28, 34, 54, 40, 31 },
    { 48, 31, 56, 56, 45, 37, 51, 56, 41, 31 },
    { 53, 42, 56, 59, 45, 45, 68, 77, 52, 46 },
    { 56, 42, 59, 62, 63, 51, 70, 81, 63, 47 },
    { 62, 47, 60, 67, 66, 65, 72, 84, 63, 54 },
    { 71, 63, 61, 70, 68, 66, 74, 87, 65, 57 },
    { 81, 68, 73, 81, 74, 68, 85, 93, 72, 68 },
    { 81, 78, 76, 83, 81, 90, 87, 94, 81, 75 },
    { 86, 88, 80, 84, 89, 98, 89, 97, 81, 88 },
    { 94, 97, 88, 95, 92, 99, 91, 98, 91, 89 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[15, 15] {
    { 18, 91, 14, 62, 77, 50, 53, 50, 75, 66, 98, 87, 34, 80, 37 },
    { 84, 69, 24, 80, 33, 16, 17, 63, 78, 37, 15, 71, 44, 28, 75 },
    { 23, 32, 56, 98, 92, 38, 92, 98, 82, 94, 47, 66, 18, 73, 47 },
    { 53, 23, 46, 87, 81, 47, 37, 64, 18, 48, 11, 37, 36, 34, 72 },
    { 79, 19, 32, 99, 52, 76, 40, 36, 88, 98, 91, 70, 41, 86, 86 },
    { 49, 98, 90, 40, 84, 92, 34, 56, 46, 38, 86, 67, 48, 59, 91 },
    { 11, 65, 74, 19, 24, 37, 44, 19, 31, 71, 23, 86, 58, 89, 89 },
    { 76, 95, 78, 32, 99, 13, 47, 96, 50, 79, 55, 62, 86, 71, 66 },
    { 18, 92, 77, 97, 96, 36, 95, 32, 71, 58, 14, 88, 69, 68, 70 },
    { 15, 75, 66, 56, 61, 90, 89, 25, 59, 87, 64, 68, 34, 39, 69 },
    { 75, 58, 47, 64, 63, 30, 19, 61, 93, 63, 80, 73, 17, 74, 94 },
    { 24, 78, 37, 79, 74, 79, 95, 39, 20, 76, 29, 76, 27, 19, 42 },
    { 67, 71, 92, 11, 82, 56, 51, 14, 15, 50, 95, 23, 73, 93, 80 },
    { 26, 81, 51, 65, 73, 86, 41, 55, 65, 89, 79, 28, 36, 87, 44 },
    { 53, 92, 52, 61, 95, 19, 80, 15, 91, 47, 72, 73, 31, 38, 78 }
};
            expected = new int[15, 15] {
    { 11, 19, 14, 11, 24, 13, 17, 14, 15, 37, 11, 23, 17, 19, 37 },
    { 15, 23, 24, 19, 33, 16, 19, 15, 18, 38, 14, 28, 18, 28, 42 },
    { 18, 32, 32, 32, 52, 19, 34, 19, 20, 47, 15, 37, 27, 34, 44 },
    { 18, 58, 37, 40, 61, 30, 37, 25, 31, 48, 23, 62, 31, 38, 47 },
    { 23, 65, 46, 56, 63, 36, 40, 32, 46, 50, 29, 66, 34, 39, 66 },
    { 24, 69, 47, 61, 73, 37, 41, 36, 50, 58, 47, 67, 34, 59, 69 },
    { 26, 71, 51, 62, 74, 38, 44, 39, 59, 63, 55, 68, 36, 68, 70 },
    { 49, 75, 52, 64, 77, 47, 47, 50, 65, 66, 64, 70, 36, 71, 72 },
    { 53, 78, 56, 65, 81, 50, 51, 55, 71, 71, 72, 71, 41, 73, 75 },
    { 53, 81, 66, 79, 82, 56, 53, 56, 75, 76, 79, 73, 44, 74, 78 },
    { 67, 91, 74, 80, 84, 76, 80, 61, 78, 79, 80, 73, 48, 80, 80 },
    { 75, 92, 77, 87, 92, 79, 89, 63, 82, 87, 86, 76, 58, 86, 86 },
    { 76, 92, 78, 97, 95, 86, 92, 64, 88, 89, 91, 86, 69, 87, 89 },
    { 79, 95, 90, 98, 96, 90, 95, 96, 91, 94, 95, 87, 73, 89, 91 },
    { 84, 98, 92, 99, 99, 92, 95, 98, 93, 98, 98, 88, 86, 93, 94 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[15, 20] {
    { 65, 31, 46, 39, 59, 47, 35, 61, 46, 55, 36, 26, 37, 21, 13, 38, 24, 26, 71, 97 },
    { 13, 71, 22, 97, 71, 45, 75, 60, 27, 10, 22, 19, 26, 87, 33, 57, 81, 97, 38, 96 },
    { 28, 40, 15, 15, 69, 93, 53, 94, 87, 19, 57, 56, 60, 41, 74, 94, 19, 49, 68, 23 },
    { 71, 74, 44, 45, 43, 27, 99, 49, 87, 55, 56, 27, 88, 74, 79, 73, 65, 17, 37, 78 },
    { 91, 81, 72, 18, 52, 66, 58, 85, 22, 39, 48, 42, 38, 25, 35, 53, 96, 70, 72, 52 },
    { 93, 14, 16, 41, 62, 39, 68, 85, 62, 11, 38, 11, 21, 90, 31, 89, 11, 35, 92, 76 },
    { 68, 24, 37, 58, 17, 24, 89, 73, 48, 35, 77, 95, 45, 85, 84, 87, 74, 40, 56, 22 },
    { 97, 72, 32, 20, 10, 46, 30, 47, 93, 45, 51, 70, 77, 95, 83, 78, 76, 58, 34, 47 },
    { 50, 95, 47, 36, 34, 43, 65, 36, 15, 43, 25, 71, 79, 79, 78, 95, 91, 26, 57, 70 },
    { 94, 51, 79, 13, 83, 17, 27, 50, 11, 16, 21, 26, 16, 18, 72, 12, 35, 96, 86, 67 },
    { 81, 94, 42, 59, 30, 80, 90, 98, 26, 87, 87, 59, 11, 64, 53, 98, 25, 43, 53, 27 },
    { 26, 25, 34, 99, 32, 98, 64, 71, 17, 76, 70, 95, 40, 89, 89, 99, 19, 29, 82, 13 },
    { 26, 29, 33, 24, 29, 62, 24, 51, 64, 73, 87, 91, 53, 68, 51, 65, 70, 42, 37, 31 },
    { 25, 29, 90, 50, 27, 91, 28, 21, 75, 54, 89, 95, 61, 50, 10, 97, 91, 19, 80, 69 },
    { 84, 23, 16, 43, 88, 78, 52, 71, 48, 33, 39, 77, 92, 60, 87, 97, 38, 83, 96, 37 }
};
            expected = new int[15, 20] {
    { 13, 14, 15, 13, 10, 17, 24, 21, 11, 10, 21, 11, 11, 18, 10, 12, 11, 17, 34, 13 },
    { 25, 23, 16, 15, 17, 24, 27, 36, 15, 11, 22, 19, 16, 21, 13, 38, 19, 19, 37, 22 },
    { 26, 24, 16, 18, 27, 27, 28, 47, 17, 16, 25, 26, 21, 25, 31, 53, 19, 26, 37, 23 },
    { 26, 25, 22, 20, 29, 39, 30, 49, 22, 19, 36, 26, 26, 41, 33, 57, 24, 26, 38, 27 },
    { 28, 29, 32, 24, 30, 43, 35, 50, 26, 33, 38, 27, 37, 50, 35, 65, 25, 29, 53, 31 },
    { 50, 29, 33, 36, 32, 45, 52, 51, 27, 35, 39, 42, 38, 60, 51, 73, 35, 35, 56, 37 },
    { 65, 31, 34, 39, 34, 46, 53, 60, 46, 39, 48, 56, 40, 64, 53, 78, 38, 40, 57, 47 },
    { 68, 40, 37, 41, 43, 47, 58, 61, 48, 43, 51, 59, 45, 68, 72, 87, 65, 42, 68, 52 },
    { 71, 51, 42, 43, 52, 62, 64, 71, 48, 45, 56, 70, 53, 74, 74, 89, 70, 43, 71, 67 },
    { 81, 71, 44, 45, 59, 66, 65, 71, 62, 54, 57, 71, 60, 79, 78, 94, 74, 49, 72, 69 },
    { 84, 72, 46, 50, 62, 78, 68, 73, 64, 55, 70, 77, 61, 85, 79, 95, 76, 58, 80, 70 },
    { 91, 74, 47, 58, 69, 80, 75, 85, 75, 55, 77, 91, 77, 87, 83, 97, 81, 70, 82, 76 },
    { 93, 81, 72, 59, 71, 91, 89, 85, 87, 73, 87, 95, 79, 89, 84, 97, 91, 83, 86, 78 },
    { 94, 94, 79, 97, 83, 93, 90, 94, 87, 76, 87, 95, 88, 90, 87, 98, 91, 96, 92, 96 },
    { 97, 95, 90, 99, 88, 98, 99, 98, 93, 87, 89, 95, 92, 95, 89, 99, 96, 97, 96, 97 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[20, 0];
            expected = new int[20, 0];
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[20, 5] {
    { 43, 13, 76, 20, 84 },
    { 91, 40, 12, 68, 53 },
    { 74, 60, 62, 67, 47 },
    { 12, 22, 57, 61, 49 },
    { 49, 56, 72, 51, 24 },
    { 22, 13, 10, 62, 12 },
    { 68, 18, 23, 52, 36 },
    { 81, 46, 95, 59, 97 },
    { 47, 49, 13, 94, 59 },
    { 78, 25, 34, 23, 84 },
    { 85, 80, 31, 56, 88 },
    { 86, 40, 34, 95, 72 },
    { 88, 40, 49, 65, 84 },
    { 66, 46, 19, 41, 66 },
    { 66, 26, 97, 64, 12 },
    { 99, 53, 77, 92, 46 },
    { 96, 78, 87, 78, 27 },
    { 87, 86, 67, 64, 49 },
    { 50, 21, 99, 87, 18 },
    { 17, 99, 47, 19, 92 }
};
            expected = new int[20, 5] {
    { 12, 13, 10, 19, 12 },
    { 17, 13, 12, 20, 12 },
    { 22, 18, 13, 23, 18 },
    { 43, 21, 19, 41, 24 },
    { 47, 22, 23, 51, 27 },
    { 49, 25, 31, 52, 36 },
    { 50, 26, 34, 56, 46 },
    { 66, 40, 34, 59, 47 },
    { 66, 40, 47, 61, 49 },
    { 68, 40, 49, 62, 49 },
    { 74, 46, 57, 64, 53 },
    { 78, 46, 62, 64, 59 },
    { 81, 49, 67, 65, 66 },
    { 85, 53, 72, 67, 72 },
    { 86, 56, 76, 68, 84 },
    { 87, 60, 77, 78, 84 },
    { 88, 78, 87, 87, 84 },
    { 91, 80, 95, 92, 88 },
    { 96, 86, 97, 94, 92 },
    { 99, 99, 99, 95, 97 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[20, 10] {
    { 42, 16, 93, 56, 28, 68, 83, 67, 53, 88 },
    { 43, 62, 42, 59, 75, 19, 53, 71, 47, 97 },
    { 79, 79, 54, 91, 25, 54, 27, 20, 55, 95 },
    { 10, 15, 67, 99, 14, 90, 85, 40, 60, 59 },
    { 14, 28, 23, 75, 16, 88, 78, 49, 21, 98 },
    { 63, 38, 10, 22, 23, 63, 61, 12, 40, 73 },
    { 50, 72, 21, 58, 88, 37, 94, 42, 55, 84 },
    { 34, 22, 20, 87, 92, 61, 65, 78, 84, 37 },
    { 75, 77, 98, 56, 41, 71, 15, 54, 86, 50 },
    { 39, 83, 99, 87, 19, 42, 17, 65, 86, 79 },
    { 93, 46, 94, 37, 74, 51, 27, 22, 30, 61 },
    { 97, 82, 27, 12, 97, 73, 74, 64, 26, 26 },
    { 32, 49, 56, 14, 55, 51, 22, 33, 78, 60 },
    { 53, 10, 91, 15, 44, 39, 83, 70, 82, 90 },
    { 54, 92, 34, 34, 53, 56, 65, 96, 90, 45 },
    { 68, 52, 48, 70, 56, 53, 89, 89, 82, 32 },
    { 38, 93, 44, 70, 17, 97, 90, 22, 68, 67 },
    { 89, 13, 82, 36, 72, 40, 25, 31, 61, 98 },
    { 86, 25, 43, 42, 92, 11, 61, 31, 58, 90 },
    { 50, 94, 88, 59, 61, 61, 57, 63, 26, 55 }
};
            expected = new int[20, 10] {
    { 10, 10, 10, 12, 14, 11, 15, 12, 21, 26 },
    { 14, 13, 20, 14, 16, 19, 17, 20, 26, 32 },
    { 32, 15, 21, 15, 17, 37, 22, 22, 26, 37 },
    { 34, 16, 23, 22, 19, 39, 25, 22, 30, 45 },
    { 38, 22, 27, 34, 23, 40, 27, 31, 40, 50 },
    { 39, 25, 34, 36, 25, 42, 27, 31, 47, 55 },
    { 42, 28, 42, 37, 28, 51, 53, 33, 53, 59 },
    { 43, 38, 43, 42, 41, 51, 57, 40, 55, 60 },
    { 50, 46, 44, 56, 44, 53, 61, 42, 55, 61 },
    { 50, 49, 48, 56, 53, 54, 61, 49, 58, 67 },
    { 53, 52, 54, 58, 55, 56, 65, 54, 60, 73 },
    { 54, 62, 56, 59, 56, 61, 65, 63, 61, 79 },
    { 63, 72, 67, 59, 61, 61, 74, 64, 68, 84 },
    { 68, 77, 82, 70, 72, 63, 78, 65, 78, 88 },
    { 75, 79, 88, 70, 74, 68, 83, 67, 82, 90 },
    { 79, 82, 91, 75, 75, 71, 83, 70, 82, 90 },
    { 86, 83, 93, 87, 88, 73, 85, 71, 84, 95 },
    { 89, 92, 94, 87, 92, 88, 89, 78, 86, 97 },
    { 93, 93, 98, 91, 92, 90, 90, 89, 86, 98 },
    { 97, 94, 99, 99, 97, 97, 94, 96, 90, 98 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[20, 15] {
    { 65, 53, 38, 33, 55, 64, 69, 22, 98, 26, 38, 67, 37, 84, 46 },
    { 22, 60, 11, 78, 16, 46, 68, 63, 78, 26, 95, 24, 32, 74, 20 },
    { 82, 61, 15, 15, 42, 43, 87, 20, 86, 37, 42, 49, 33, 42, 61 },
    { 82, 66, 14, 23, 48, 11, 55, 85, 20, 19, 97, 89, 60, 16, 60 },
    { 50, 46, 47, 87, 43, 76, 62, 32, 51, 13, 35, 49, 24, 51, 74 },
    { 96, 44, 31, 26, 44, 39, 20, 19, 35, 19, 36, 76, 94, 95, 45 },
    { 53, 37, 13, 36, 86, 95, 11, 46, 98, 84, 29, 44, 62, 20, 23 },
    { 61, 40, 43, 46, 23, 62, 67, 43, 71, 30, 39, 37, 21, 77, 16 },
    { 10, 67, 36, 16, 59, 97, 46, 88, 64, 78, 95, 98, 32, 41, 24 },
    { 95, 57, 99, 21, 58, 96, 42, 58, 82, 83, 85, 93, 42, 16, 57 },
    { 67, 89, 69, 92, 84, 62, 17, 56, 60, 26, 25, 52, 79, 67, 28 },
    { 63, 45, 12, 57, 35, 81, 38, 10, 28, 20, 68, 19, 53, 33, 73 },
    { 13, 13, 82, 17, 21, 15, 39, 39, 57, 62, 87, 11, 48, 95, 43 },
    { 53, 63, 91, 64, 29, 50, 91, 84, 80, 75, 39, 89, 50, 82, 26 },
    { 53, 64, 33, 86, 22, 21, 70, 71, 56, 22, 34, 15, 55, 94, 48 },
    { 80, 89, 14, 85, 67, 14, 27, 88, 13, 33, 22, 29, 11, 42, 81 },
    { 25, 88, 57, 40, 19, 32, 78, 62, 82, 32, 82, 91, 45, 51, 94 },
    { 44, 45, 90, 42, 94, 50, 85, 64, 24, 21, 35, 75, 29, 62, 10 },
    { 92, 69, 39, 74, 97, 45, 57, 24, 85, 25, 11, 36, 31, 62, 84 },
    { 22, 82, 46, 18, 89, 76, 38, 69, 47, 40, 40, 34, 43, 29, 84 }
};
            expected = new int[20, 15] {
    { 10, 13, 11, 15, 16, 11, 11, 10, 13, 13, 11, 11, 11, 16, 10 },
    { 13, 37, 12, 16, 19, 14, 17, 19, 20, 19, 22, 15, 21, 16, 16 },
    { 22, 40, 13, 17, 21, 15, 20, 20, 24, 19, 25, 19, 24, 20, 20 },
    { 22, 44, 14, 18, 22, 21, 27, 22, 28, 20, 29, 24, 29, 29, 23 },
    { 25, 45, 14, 21, 23, 32, 38, 24, 35, 21, 34, 29, 31, 33, 24 },
    { 44, 45, 15, 23, 29, 39, 38, 32, 47, 22, 35, 34, 32, 41, 26 },
    { 50, 46, 31, 26, 35, 43, 39, 39, 51, 25, 35, 36, 32, 42, 28 },
    { 53, 53, 33, 33, 42, 45, 42, 43, 56, 26, 36, 37, 33, 42, 43 },
    { 53, 57, 36, 36, 43, 46, 46, 46, 57, 26, 38, 44, 37, 51, 45 },
    { 53, 60, 38, 40, 44, 50, 55, 56, 60, 26, 39, 49, 42, 51, 46 },
    { 61, 61, 39, 42, 48, 50, 57, 58, 64, 30, 39, 49, 43, 62, 48 },
    { 63, 63, 43, 46, 55, 62, 62, 62, 71, 32, 40, 52, 45, 62, 57 },
    { 65, 64, 46, 57, 58, 62, 67, 63, 78, 33, 42, 67, 48, 67, 60 },
    { 67, 66, 47, 64, 59, 64, 68, 64, 80, 37, 68, 75, 50, 74, 61 },
    { 80, 67, 57, 74, 67, 76, 69, 69, 82, 40, 82, 76, 53, 77, 73 },
    { 82, 69, 69, 78, 84, 76, 70, 71, 82, 62, 85, 89, 55, 82, 74 },
    { 82, 82, 82, 85, 86, 81, 78, 84, 85, 75, 87, 89, 60, 84, 81 },
    { 92, 88, 90, 86, 89, 95, 85, 85, 86, 78, 95, 91, 62, 94, 84 },
    { 95, 89, 91, 87, 94, 96, 87, 88, 98, 83, 95, 93, 79, 95, 84 },
    { 96, 89, 99, 92, 97, 97, 91, 88, 98, 84, 97, 98, 94, 95, 94 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));

            matrix = new int[20, 20] {
    { 57, 58, 99, 82, 40, 23, 62, 70, 54, 59, 87, 31, 14, 26, 92, 24, 63, 11, 40, 98 },
    { 53, 38, 21, 73, 33, 63, 99, 91, 44, 67, 21, 24, 95, 11, 67, 53, 37, 48, 32, 71 },
    { 60, 21, 92, 59, 12, 55, 34, 52, 54, 26, 76, 32, 12, 30, 40, 29, 47, 35, 59, 76 },
    { 23, 70, 36, 87, 47, 72, 35, 13, 58, 49, 87, 25, 79, 68, 48, 41, 45, 61, 71, 78 },
    { 38, 57, 47, 27, 90, 89, 21, 74, 70, 48, 15, 11, 89, 55, 58, 89, 85, 14, 21, 39 },
    { 29, 31, 94, 14, 39, 61, 53, 44, 82, 99, 83, 85, 63, 81, 47, 66, 33, 18, 96, 58 },
    { 60, 61, 42, 19, 43, 85, 35, 33, 20, 58, 55, 41, 49, 42, 58, 17, 62, 42, 88, 39 },
    { 46, 77, 91, 70, 65, 30, 47, 17, 17, 91, 66, 76, 17, 63, 78, 67, 88, 84, 70, 53 },
    { 35, 30, 33, 34, 53, 52, 45, 31, 32, 40, 13, 90, 30, 67, 21, 83, 69, 71, 54, 23 },
    { 48, 27, 25, 28, 91, 79, 33, 86, 63, 90, 29, 78, 71, 44, 13, 26, 53, 67, 27, 23 },
    { 84, 25, 85, 77, 88, 76, 55, 49, 51, 95, 98, 26, 40, 57, 15, 18, 14, 14, 42, 74 },
    { 28, 59, 68, 42, 20, 34, 28, 85, 64, 95, 39, 12, 54, 40, 39, 32, 42, 47, 40, 25 },
    { 33, 83, 44, 67, 92, 13, 48, 24, 39, 95, 21, 48, 35, 52, 94, 34, 57, 52, 67, 63 },
    { 57, 69, 85, 56, 66, 96, 71, 99, 27, 82, 75, 67, 74, 26, 50, 45, 24, 10, 49, 17 },
    { 86, 13, 56, 69, 84, 90, 76, 12, 46, 14, 75, 89, 80, 76, 67, 63, 97, 88, 11, 96 },
    { 41, 48, 96, 57, 29, 54, 74, 19, 11, 58, 20, 56, 13, 59, 77, 54, 23, 25, 72, 75 },
    { 29, 69, 63, 23, 17, 85, 86, 97, 58, 87, 47, 36, 98, 53, 75, 47, 16, 99, 49, 39 },
    { 26, 67, 10, 87, 94, 28, 86, 31, 99, 23, 50, 82, 26, 36, 76, 72, 85, 83, 49, 44 },
    { 67, 76, 60, 24, 21, 84, 57, 60, 83, 39, 47, 24, 76, 42, 58, 62, 68, 76, 28, 88 },
    { 98, 65, 98, 45, 47, 65, 19, 72, 76, 13, 61, 32, 59, 15, 72, 50, 16, 86, 76, 20 }
};
            expected = new int[20, 20] {
    { 23, 13, 10, 14, 12, 13, 19, 12, 11, 13, 13, 11, 12, 11, 13, 17, 14, 10, 11, 17 },
    { 26, 21, 21, 19, 17, 23, 21, 13, 17, 14, 15, 12, 13, 15, 15, 18, 16, 11, 21, 20 },
    { 28, 25, 25, 23, 20, 28, 28, 17, 20, 23, 20, 24, 14, 26, 21, 24, 16, 14, 27, 23 },
    { 29, 27, 33, 24, 21, 30, 33, 19, 27, 26, 21, 24, 17, 26, 39, 26, 23, 14, 28, 23 },
    { 29, 30, 36, 27, 29, 34, 34, 24, 32, 39, 21, 25, 26, 30, 40, 29, 24, 18, 32, 25 },
    { 33, 31, 42, 28, 33, 52, 35, 31, 39, 40, 29, 26, 30, 36, 47, 32, 33, 25, 40, 39 },
    { 35, 38, 44, 34, 39, 54, 35, 31, 44, 48, 39, 31, 35, 40, 48, 34, 37, 35, 40, 39 },
    { 38, 48, 47, 42, 40, 55, 45, 33, 46, 49, 47, 32, 40, 42, 50, 41, 42, 42, 42, 39 },
    { 41, 57, 56, 45, 43, 61, 47, 44, 51, 58, 47, 32, 49, 42, 58, 45, 45, 47, 49, 44 },
    { 46, 58, 60, 56, 47, 63, 48, 49, 54, 58, 50, 36, 54, 44, 58, 47, 47, 48, 49, 53 },
    { 48, 59, 63, 57, 47, 65, 53, 52, 54, 59, 55, 41, 59, 52, 58, 50, 53, 52, 49, 58 },
    { 53, 61, 68, 59, 53, 72, 55, 60, 58, 67, 61, 48, 63, 53, 67, 53, 57, 61, 54, 63 },
    { 57, 65, 85, 67, 65, 76, 57, 70, 58, 82, 66, 56, 71, 55, 67, 54, 62, 67, 59, 71 },
    { 57, 67, 85, 69, 66, 79, 62, 72, 63, 87, 75, 67, 74, 57, 72, 62, 63, 71, 67, 74 },
    { 60, 69, 91, 70, 84, 84, 71, 74, 64, 90, 75, 76, 76, 59, 75, 63, 68, 76, 70, 75 },
    { 60, 69, 92, 73, 88, 85, 74, 85, 70, 91, 76, 78, 79, 63, 76, 66, 69, 83, 71, 76 },
    { 67, 70, 94, 77, 90, 85, 76, 86, 76, 95, 83, 82, 80, 67, 77, 67, 85, 84, 72, 78 },
    { 84, 76, 96, 82, 91, 89, 86, 91, 82, 95, 87, 85, 89, 68, 78, 72, 85, 86, 76, 88 },
    { 86, 77, 98, 87, 92, 90, 86, 97, 83, 95, 87, 89, 95, 76, 92, 83, 88, 88, 88, 96 },
    { 98, 83, 99, 87, 94, 96, 99, 99, 99, 99, 98, 90, 98, 81, 94, 89, 97, 99, 96, 98 }
};
            CollectionAssert.AreEqual(expected, _object.SortAllColumns(matrix));
        }

        public void DiagonalSortTests()
        {
            int[,] matrix, expected;
            matrix = new int[0, 0];
            expected = new int[0, 0];
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[0, 20];
            expected = new int[0, 20];
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[5, 5] {
    { 90, 84, 32, 11, 46 },
    { 34, 42, 67, 88, 82 },
    { 77, 76, 40, 66, 72 },
    { 30, 10, 98, 34, 38 },
    { 83, 60, 31, 59, 67 }
};
            expected = new int[5, 5] {
    { 34, 38, 32, 11, 46 },
    { 34, 40, 66, 72, 82 },
    { 10, 59, 42, 67, 88 },
    { 30, 31, 76, 67, 84 },
    { 83, 60, 77, 98, 90 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[5, 10] {
    { 55, 58, 41, 39, 72, 52, 35, 15, 60, 22 },
    { 70, 97, 24, 28, 58, 63, 77, 74, 45, 17 },
    { 57, 51, 34, 55, 89, 78, 97, 12, 50, 83 },
    { 40, 63, 73, 44, 91, 76, 10, 37, 25, 40 },
    { 51, 71, 79, 53, 12, 33, 85, 79, 75, 74 }
};
            expected = new int[5, 10] {
    { 12, 24, 28, 10, 37, 12, 35, 15, 17, 22 },
    { 51, 34, 33, 41, 39, 63, 25, 40, 45, 60 },
    { 57, 53, 44, 55, 76, 58, 72, 52, 50, 83 },
    { 40, 63, 70, 55, 58, 85, 78, 75, 74, 74 },
    { 51, 71, 79, 73, 97, 91, 89, 79, 97, 77 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[5, 15] {
    { 16, 85, 86, 52, 19, 13, 33, 86, 50, 93, 55, 32, 64, 77, 82 },
    { 16, 33, 79, 37, 82, 62, 49, 59, 15, 65, 86, 72, 81, 53, 66 },
    { 93, 27, 36, 75, 76, 54, 76, 31, 35, 87, 53, 24, 87, 32, 84 },
    { 29, 16, 11, 71, 95, 99, 15, 51, 93, 21, 66, 36, 80, 86, 33 },
    { 41, 51, 43, 83, 10, 38, 95, 88, 10, 37, 39, 11, 54, 50, 38 }
};
            expected = new int[5, 15] {
    { 10, 38, 37, 15, 10, 13, 21, 11, 36, 24, 38, 32, 53, 66, 82 },
    { 11, 16, 75, 76, 52, 19, 31, 33, 15, 50, 50, 55, 32, 64, 77 },
    { 16, 16, 33, 79, 86, 54, 51, 37, 35, 66, 53, 80, 72, 33, 84 },
    { 29, 43, 27, 36, 85, 95, 82, 62, 49, 39, 86, 54, 86, 86, 81 },
    { 41, 51, 93, 83, 71, 95, 99, 88, 76, 93, 59, 87, 65, 93, 87 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[5, 20] {
    { 48, 62, 36, 31, 45, 79, 70, 19, 57, 66, 87, 75, 43, 63, 20, 28, 96, 44, 12, 55 },
    { 11, 81, 13, 32, 55, 33, 28, 11, 43, 66, 98, 61, 11, 64, 73, 14, 99, 59, 51, 53 },
    { 71, 42, 85, 27, 23, 62, 62, 34, 90, 19, 43, 67, 52, 94, 37, 66, 59, 14, 75, 22 },
    { 61, 69, 76, 91, 68, 35, 74, 78, 90, 15, 28, 46, 93, 58, 84, 69, 95, 85, 19, 93 },
    { 70, 93, 20, 34, 32, 41, 19, 17, 37, 17, 55, 95, 84, 38, 91, 12, 65, 94, 58, 87 }
};
            expected = new int[5, 20] {
    { 32, 13, 19, 17, 33, 17, 11, 19, 43, 38, 52, 11, 37, 63, 14, 14, 59, 22, 12, 55 },
    { 11, 48, 27, 23, 31, 37, 28, 15, 19, 46, 66, 58, 12, 43, 66, 20, 19, 75, 44, 53 },
    { 20, 34, 81, 41, 32, 55, 45, 34, 55, 28, 57, 67, 61, 75, 64, 73, 58, 28, 93, 51 },
    { 61, 69, 42, 85, 62, 35, 62, 62, 79, 70, 43, 66, 93, 87, 84, 65, 94, 59, 87, 96 },
    { 70, 93, 71, 76, 91, 68, 36, 74, 78, 90, 90, 95, 84, 98, 91, 94, 69, 95, 85, 99 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[10, 5] {
    { 88, 84, 44, 85, 91 },
    { 97, 73, 93, 20, 67 },
    { 70, 73, 95, 81, 51 },
    { 68, 58, 51, 68, 37 },
    { 26, 66, 50, 82, 60 },
    { 32, 62, 64, 67, 81 },
    { 13, 11, 36, 31, 15 },
    { 86, 59, 35, 42, 34 },
    { 67, 25, 96, 70, 47 },
    { 81, 10, 12, 87, 33 }
};
            expected = new int[10, 5] {
    { 60, 37, 20, 67, 91 },
    { 51, 68, 81, 44, 85 },
    { 15, 73, 73, 84, 51 },
    { 31, 50, 81, 88, 93 },
    { 26, 34, 58, 82, 95 },
    { 11, 36, 64, 67, 97 },
    { 13, 32, 42, 66, 70 },
    { 12, 59, 33, 47, 68 },
    { 10, 25, 87, 35, 62 },
    { 81, 67, 86, 96, 70 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[10, 10] {
    { 53, 23, 36, 31, 70, 31, 43, 61, 34, 68 },
    { 44, 18, 36, 38, 63, 69, 46, 73, 76, 65 },
    { 19, 33, 19, 43, 69, 11, 69, 80, 45, 79 },
    { 32, 59, 77, 43, 37, 89, 74, 15, 60, 83 },
    { 52, 97, 10, 73, 90, 58, 88, 68, 16, 78 },
    { 44, 36, 36, 31, 24, 29, 14, 92, 61, 69 },
    { 62, 63, 26, 55, 46, 85, 41, 93, 11, 74 },
    { 94, 41, 22, 92, 23, 21, 33, 45, 53, 21 },
    { 22, 11, 73, 67, 44, 95, 33, 55, 29, 18 },
    { 85, 82, 53, 91, 31, 88, 80, 55, 36, 14 }
};
            expected = new int[10, 10] {
    { 14, 14, 11, 11, 15, 31, 43, 61, 34, 68 },
    { 24, 18, 18, 21, 31, 16, 46, 45, 76, 65 },
    { 10, 33, 19, 23, 36, 61, 69, 60, 73, 79 },
    { 23, 19, 33, 29, 36, 38, 63, 69, 78, 83 },
    { 26, 32, 21, 36, 29, 37, 69, 68, 69, 80 },
    { 22, 36, 36, 31, 44, 41, 43, 88, 74, 70 },
    { 41, 31, 44, 55, 33, 55, 43, 53, 89, 74 },
    { 11, 62, 44, 52, 80, 46, 73, 45, 58, 92 },
    { 22, 53, 73, 63, 88, 95, 55, 77, 53, 93 },
    { 85, 82, 94, 91, 67, 92, 97, 59, 85, 90 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[10, 15] {
    { 27, 95, 66, 42, 83, 13, 24, 43, 18, 12, 96, 68, 48, 50, 57 },
    { 60, 90, 59, 21, 51, 62, 85, 74, 93, 89, 21, 87, 31, 71, 34 },
    { 41, 78, 18, 49, 93, 26, 44, 41, 83, 40, 80, 89, 46, 26, 21 },
    { 26, 44, 13, 43, 71, 98, 30, 43, 85, 52, 42, 31, 73, 53, 72 },
    { 26, 93, 72, 84, 70, 28, 59, 99, 57, 40, 25, 58, 76, 80, 70 },
    { 72, 48, 57, 81, 72, 77, 84, 87, 10, 36, 20, 44, 33, 96, 60 },
    { 94, 70, 87, 21, 24, 87, 27, 62, 55, 93, 66, 44, 55, 13, 55 },
    { 49, 54, 63, 24, 80, 94, 74, 92, 80, 94, 41, 16, 71, 58, 60 },
    { 83, 36, 13, 96, 45, 55, 71, 65, 65, 83, 54, 85, 11, 88, 16 },
    { 43, 38, 84, 55, 86, 65, 80, 18, 25, 66, 30, 78, 17, 26, 82 }
};
            expected = new int[10, 15] {
    { 18, 28, 21, 10, 11, 13, 16, 13, 18, 12, 46, 26, 21, 34, 57 },
    { 13, 27, 30, 54, 17, 16, 20, 24, 33, 31, 21, 53, 31, 48, 50 },
    { 18, 25, 27, 49, 55, 26, 26, 40, 25, 40, 55, 60, 70, 68, 71 },
    { 21, 24, 60, 43, 59, 59, 30, 36, 41, 44, 42, 76, 73, 87, 72 },
    { 24, 26, 41, 65, 65, 62, 66, 41, 43, 44, 52, 43, 80, 80, 96 },
    { 63, 26, 55, 44, 72, 66, 71, 78, 42, 44, 71, 55, 58, 89, 89 },
    { 13, 70, 45, 57, 71, 74, 70, 80, 87, 51, 57, 82, 58, 60, 96 },
    { 36, 54, 72, 48, 80, 72, 78, 77, 83, 93, 85, 62, 85, 74, 93 },
    { 38, 49, 55, 86, 65, 80, 81, 84, 90, 84, 94, 93, 66, 85, 83 },
    { 43, 83, 84, 94, 96, 87, 93, 94, 87, 92, 95, 98, 99, 83, 88 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[10, 20] {
    { 81, 55, 14, 95, 19, 39, 41, 59, 67, 99, 78, 89, 97, 41, 35, 18, 72, 14, 74, 61 },
    { 13, 31, 26, 71, 94, 13, 28, 87, 39, 25, 77, 63, 48, 82, 11, 99, 81, 16, 78, 76 },
    { 11, 78, 26, 55, 18, 75, 82, 76, 90, 58, 58, 73, 43, 65, 79, 59, 38, 42, 10, 16 },
    { 21, 54, 29, 52, 32, 24, 51, 25, 40, 36, 37, 66, 35, 97, 59, 34, 14, 71, 63, 28 },
    { 30, 51, 97, 81, 66, 13, 30, 82, 13, 51, 70, 48, 16, 72, 65, 57, 59, 74, 32, 94 },
    { 34, 67, 46, 63, 30, 92, 47, 45, 16, 54, 54, 67, 79, 81, 85, 69, 56, 47, 85, 28 },
    { 93, 69, 22, 88, 66, 89, 60, 63, 41, 11, 75, 40, 48, 69, 94, 62, 15, 44, 60, 74 },
    { 66, 85, 76, 58, 97, 12, 68, 34, 86, 95, 10, 21, 89, 13, 10, 65, 55, 57, 96, 41 },
    { 41, 83, 13, 14, 79, 24, 28, 20, 87, 33, 63, 22, 86, 20, 62, 18, 93, 63, 91, 63 },
    { 30, 35, 77, 46, 10, 64, 50, 44, 68, 39, 17, 58, 47, 29, 43, 82, 81, 71, 79, 82 }
};
            expected = new int[10, 20] {
    { 26, 13, 14, 10, 13, 20, 13, 10, 16, 35, 15, 44, 34, 11, 28, 18, 10, 14, 74, 61 },
    { 13, 31, 17, 18, 11, 13, 28, 36, 18, 25, 55, 43, 48, 41, 14, 32, 42, 16, 16, 76 },
    { 11, 20, 34, 26, 24, 16, 19, 39, 41, 37, 58, 62, 57, 56, 47, 41, 35, 63, 28, 78 },
    { 21, 12, 29, 39, 32, 30, 22, 21, 40, 48, 39, 65, 63, 63, 57, 59, 59, 38, 81, 72 },
    { 22, 24, 28, 30, 52, 33, 41, 47, 25, 40, 62, 48, 66, 72, 65, 59, 60, 74, 71, 94 },
    { 10, 30, 46, 44, 68, 60, 47, 45, 51, 29, 43, 67, 58, 67, 73, 69, 63, 79, 74, 99 },
    { 13, 14, 58, 50, 54, 68, 66, 55, 58, 75, 54, 51, 70, 59, 71, 77, 78, 65, 82, 85 },
    { 66, 46, 34, 64, 51, 63, 78, 81, 55, 63, 82, 75, 54, 82, 69, 81, 79, 82, 89, 97 },
    { 35, 77, 85, 69, 67, 88, 66, 81, 87, 63, 71, 94, 82, 76, 87, 79, 93, 85, 91, 96 },
    { 30, 41, 83, 93, 76, 79, 97, 97, 89, 92, 86, 95, 95, 86, 89, 90, 81, 94, 99, 97 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[15, 5] {
    { 84, 57, 47, 63, 42 },
    { 88, 34, 79, 51, 92 },
    { 72, 91, 66, 43, 20 },
    { 16, 16, 67, 13, 24 },
    { 74, 83, 51, 57, 25 },
    { 15, 75, 67, 77, 80 },
    { 37, 31, 84, 18, 79 },
    { 72, 88, 24, 13, 22 },
    { 39, 71, 93, 76, 67 },
    { 25, 91, 14, 18, 36 },
    { 76, 23, 68, 64, 18 },
    { 10, 15, 89, 47, 36 },
    { 22, 66, 12, 71, 65 },
    { 50, 17, 57, 63, 47 },
    { 27, 92, 63, 91, 84 }
};
            expected = new int[15, 5] {
    { 13, 24, 20, 63, 42 },
    { 57, 25, 43, 47, 92 },
    { 16, 67, 34, 57, 51 },
    { 16, 51, 80, 66, 79 },
    { 13, 18, 72, 88, 84 },
    { 15, 67, 22, 77, 91 },
    { 18, 24, 74, 67, 79 },
    { 14, 18, 31, 75, 83 },
    { 39, 36, 37, 36, 84 },
    { 23, 47, 64, 88, 76 },
    { 12, 25, 65, 71, 93 },
    { 10, 15, 47, 68, 72 },
    { 17, 57, 63, 71, 91 },
    { 50, 22, 66, 76, 89 },
    { 27, 92, 63, 91, 84 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[15, 10] {
    { 13, 90, 75, 90, 10, 23, 70, 58, 50, 14 },
    { 23, 63, 29, 99, 79, 67, 98, 76, 77, 99 },
    { 73, 68, 32, 21, 26, 17, 43, 50, 71, 18 },
    { 83, 59, 77, 79, 15, 19, 40, 98, 46, 22 },
    { 52, 18, 62, 67, 51, 87, 88, 58, 84, 80 },
    { 29, 25, 86, 91, 21, 44, 68, 64, 74, 93 },
    { 80, 30, 87, 41, 30, 64, 85, 49, 94, 69 },
    { 36, 99, 40, 65, 57, 64, 16, 64, 69, 38 },
    { 28, 85, 66, 90, 89, 68, 73, 85, 68, 71 },
    { 51, 76, 34, 53, 42, 31, 30, 30, 47, 87 },
    { 12, 49, 63, 25, 54, 29, 85, 31, 43, 56 },
    { 37, 13, 94, 45, 74, 94, 63, 97, 51, 61 },
    { 90, 10, 80, 33, 28, 60, 75, 86, 32, 35 },
    { 44, 85, 27, 82, 36, 79, 31, 51, 46, 70 },
    { 83, 51, 51, 21, 43, 47, 81, 88, 79, 47 }
};
            expected = new int[15, 10] {
    { 13, 15, 19, 17, 10, 23, 22, 18, 50, 14 },
    { 16, 32, 21, 26, 40, 43, 46, 70, 58, 99 },
    { 30, 21, 44, 29, 38, 58, 67, 50, 71, 77 },
    { 18, 30, 23, 51, 49, 64, 69, 84, 80, 76 },
    { 25, 30, 43, 47, 63, 68, 75, 74, 93, 98 },
    { 29, 31, 31, 59, 56, 64, 69, 88, 79, 98 },
    { 51, 29, 32, 35, 61, 64, 68, 71, 94, 90 },
    { 25, 53, 30, 52, 41, 62, 67, 79, 87, 99 },
    { 28, 31, 54, 40, 65, 51, 64, 68, 85, 90 },
    { 33, 28, 34, 66, 42, 70, 57, 73, 77, 87 },
    { 12, 36, 45, 36, 75, 46, 85, 68, 73, 85 },
    { 10, 13, 47, 63, 60, 79, 47, 87, 83, 91 },
    { 51, 21, 43, 49, 76, 74, 80, 63, 89, 86 },
    { 44, 85, 27, 80, 51, 79, 85, 94, 86, 97 },
    { 83, 51, 90, 37, 82, 94, 81, 88, 99, 90 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[15, 15] {
    { 68, 33, 78, 85, 96, 12, 68, 40, 96, 93, 54, 98, 98, 18, 22 },
    { 52, 86, 22, 19, 95, 72, 22, 60, 81, 78, 49, 58, 69, 90, 80 },
    { 78, 86, 17, 84, 67, 20, 17, 42, 85, 34, 21, 91, 54, 52, 25 },
    { 84, 53, 43, 99, 91, 61, 69, 79, 83, 75, 55, 72, 96, 16, 57 },
    { 53, 99, 50, 26, 24, 67, 91, 23, 51, 11, 44, 53, 37, 85, 83 },
    { 81, 68, 17, 65, 94, 96, 24, 69, 98, 29, 19, 17, 33, 19, 21 },
    { 47, 20, 35, 38, 80, 21, 50, 38, 38, 57, 93, 39, 92, 98, 56 },
    { 17, 41, 94, 10, 94, 87, 65, 40, 22, 61, 39, 39, 51, 96, 15 },
    { 60, 67, 13, 39, 63, 34, 28, 99, 14, 71, 40, 40, 79, 17, 10 },
    { 66, 32, 71, 52, 22, 77, 23, 33, 25, 34, 82, 79, 22, 76, 51 },
    { 82, 99, 41, 32, 97, 35, 35, 63, 44, 31, 88, 42, 89, 38, 63 },
    { 56, 85, 32, 21, 94, 16, 67, 99, 83, 37, 47, 44, 88, 14, 80 },
    { 55, 15, 32, 63, 89, 40, 98, 56, 20, 75, 41, 69, 37, 30, 33 },
    { 44, 33, 95, 61, 78, 97, 56, 10, 82, 44, 24, 10, 57, 95, 59 },
    { 91, 46, 58, 63, 76, 83, 20, 35, 48, 33, 58, 38, 22, 46, 62 }
};
            expected = new int[15, 15] {
    { 14, 22, 14, 20, 17, 11, 10, 15, 19, 21, 16, 52, 25, 18, 22 },
    { 21, 17, 22, 19, 22, 29, 12, 17, 33, 21, 49, 54, 57, 90, 80 },
    { 10, 25, 24, 24, 33, 23, 39, 17, 44, 34, 37, 85, 54, 69, 98 },
    { 17, 22, 26, 34, 30, 38, 38, 51, 19, 60, 40, 56, 91, 58, 98 },
    { 10, 23, 28, 31, 37, 33, 40, 39, 63, 22, 68, 53, 72, 93, 83 },
    { 20, 20, 24, 33, 43, 40, 38, 61, 40, 72, 39, 75, 55, 78, 96 },
    { 10, 22, 35, 34, 37, 46, 44, 42, 61, 57, 76, 42, 85, 81, 96 },
    { 17, 13, 33, 35, 38, 41, 47, 50, 59, 67, 69, 79, 51, 92, 98 },
    { 20, 32, 16, 35, 44, 38, 44, 52, 62, 67, 69, 80, 79, 51, 96 },
    { 32, 21, 35, 41, 39, 53, 63, 50, 57, 68, 71, 78, 85, 93, 83 },
    { 32, 63, 32, 40, 47, 56, 58, 75, 53, 65, 86, 82, 79, 95, 96 },
    { 15, 61, 66, 41, 56, 48, 67, 63, 83, 65, 69, 88, 84, 89, 98 },
    { 33, 56, 76, 78, 60, 67, 52, 81, 68, 84, 78, 86, 95, 88, 91 },
    { 44, 55, 63, 82, 83, 89, 71, 97, 82, 77, 94, 80, 94, 96, 91 },
    { 91, 46, 58, 95, 85, 99, 97, 94, 98, 94, 99, 99, 87, 99, 99 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[15, 20] {
    { 47, 40, 78, 60, 92, 23, 48, 36, 36, 83, 98, 14, 49, 28, 74, 40, 50, 61, 60, 83 },
    { 94, 20, 73, 54, 50, 34, 97, 56, 38, 30, 68, 44, 63, 30, 97, 84, 31, 97, 13, 46 },
    { 52, 20, 32, 80, 77, 78, 71, 17, 74, 92, 17, 77, 61, 63, 67, 37, 66, 34, 19, 68 },
    { 25, 91, 98, 16, 25, 64, 50, 29, 31, 89, 18, 52, 58, 24, 40, 84, 87, 93, 76, 72 },
    { 62, 90, 82, 46, 22, 91, 82, 10, 62, 70, 27, 97, 88, 44, 30, 60, 21, 26, 65, 23 },
    { 37, 52, 86, 84, 83, 64, 29, 46, 32, 83, 49, 73, 57, 47, 15, 35, 19, 62, 93, 33 },
    { 81, 50, 66, 60, 72, 21, 64, 23, 94, 79, 72, 70, 38, 63, 44, 20, 14, 98, 62, 58 },
    { 71, 46, 77, 79, 30, 54, 49, 50, 39, 94, 51, 59, 33, 41, 41, 87, 85, 35, 22, 72 },
    { 99, 16, 52, 53, 20, 79, 45, 94, 13, 95, 30, 21, 99, 45, 62, 45, 72, 87, 40, 28 },
    { 71, 24, 83, 99, 38, 23, 47, 97, 31, 57, 34, 79, 86, 90, 58, 65, 94, 34, 68, 51 },
    { 19, 54, 47, 44, 73, 40, 60, 87, 78, 95, 24, 98, 94, 93, 11, 85, 32, 52, 24, 97 },
    { 41, 48, 73, 56, 70, 51, 35, 19, 86, 97, 51, 47, 28, 89, 19, 26, 77, 49, 35, 98 },
    { 63, 59, 28, 36, 42, 35, 84, 92, 89, 73, 42, 51, 19, 71, 19, 70, 81, 91, 73, 32 },
    { 14, 50, 11, 81, 53, 77, 79, 15, 84, 84, 17, 82, 26, 26, 44, 82, 29, 46, 23, 45 },
    { 67, 43, 30, 23, 64, 10, 37, 57, 79, 48, 44, 86, 76, 13, 93, 22, 58, 46, 82, 65 }
};
            expected = new int[15, 20] {
    { 13, 22, 19, 10, 11, 17, 27, 18, 17, 15, 14, 14, 21, 26, 33, 23, 19, 13, 46, 83 },
    { 13, 16, 23, 30, 19, 26, 23, 32, 32, 24, 20, 24, 19, 30, 28, 65, 31, 50, 61, 60 },
    { 42, 20, 19, 25, 46, 21, 29, 23, 38, 35, 30, 44, 30, 22, 49, 37, 66, 34, 72, 68 },
    { 17, 45, 21, 20, 28, 54, 29, 34, 31, 41, 36, 34, 58, 35, 28, 62, 58, 74, 40, 97 },
    { 19, 25, 52, 26, 22, 29, 58, 32, 46, 33, 45, 38, 36, 68, 35, 40, 62, 87, 84, 76 },
    { 35, 20, 30, 54, 31, 24, 34, 64, 46, 59, 45, 48, 41, 44, 68, 40, 60, 67, 93, 93 },
    { 15, 37, 23, 47, 72, 46, 26, 39, 77, 50, 62, 49, 49, 45, 47, 77, 44, 63, 72, 97 },
    { 16, 46, 38, 44, 60, 76, 49, 32, 40, 78, 50, 71, 58, 56, 52, 52, 83, 51, 63, 84 },
    { 24, 35, 51, 40, 52, 73, 78, 51, 47, 44, 79, 51, 72, 65, 62, 57, 72, 85, 61, 98 },
    { 10, 37, 44, 52, 48, 60, 79, 82, 51, 47, 71, 82, 60, 81, 70, 65, 63, 87, 87, 98 },
    { 19, 36, 42, 57, 73, 50, 62, 86, 82, 83, 50, 73, 82, 70, 82, 70, 73, 92, 88, 97 },
    { 11, 28, 53, 47, 70, 79, 53, 66, 86, 84, 94, 57, 80, 89, 78, 83, 77, 73, 94, 98 },
    { 30, 23, 48, 54, 56, 71, 81, 77, 79, 86, 91, 94, 64, 91, 94, 79, 90, 85, 74, 97 },
    { 14, 50, 41, 64, 71, 77, 79, 84, 84, 84, 87, 97, 95, 64, 95, 94, 86, 92, 91, 89 },
    { 67, 43, 63, 59, 81, 73, 99, 83, 99, 92, 89, 90, 97, 98, 93, 98, 94, 93, 99, 97 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[20, 0];
            expected = new int[20, 0];
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[20, 5] {
    { 56, 78, 17, 14, 65 },
    { 59, 34, 93, 36, 36 },
    { 51, 44, 77, 38, 64 },
    { 71, 30, 87, 26, 53 },
    { 49, 32, 36, 46, 49 },
    { 31, 16, 23, 33, 32 },
    { 34, 82, 64, 58, 89 },
    { 89, 35, 25, 57, 14 },
    { 75, 44, 31, 53, 96 },
    { 99, 18, 48, 49, 31 },
    { 92, 70, 29, 39, 26 },
    { 33, 52, 70, 64, 44 },
    { 53, 21, 69, 14, 11 },
    { 68, 80, 29, 49, 75 },
    { 45, 14, 40, 21, 78 },
    { 14, 10, 82, 50, 50 },
    { 23, 67, 74, 12, 39 },
    { 64, 62, 35, 42, 65 },
    { 46, 65, 61, 23, 61 },
    { 63, 75, 26, 51, 38 }
};
            expected = new int[20, 5] {
    { 26, 38, 17, 14, 65 },
    { 32, 34, 53, 36, 36 },
    { 30, 44, 49, 78, 64 },
    { 14, 33, 46, 56, 93 },
    { 16, 23, 36, 59, 77 },
    { 25, 49, 32, 51, 87 },
    { 26, 31, 57, 58, 89 },
    { 39, 31, 31, 64, 71 },
    { 11, 44, 34, 53, 96 },
    { 14, 18, 44, 35, 82 },
    { 49, 70, 29, 48, 49 },
    { 21, 52, 70, 64, 89 },
    { 39, 21, 69, 75, 75 },
    { 12, 40, 29, 78, 99 },
    { 10, 14, 50, 33, 92 },
    { 14, 42, 65, 53, 50 },
    { 23, 23, 45, 68, 80 },
    { 26, 51, 35, 61, 82 },
    { 46, 64, 61, 38, 74 },
    { 63, 75, 65, 62, 67 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[20, 10] {
    { 29, 89, 99, 73, 85, 87, 39, 18, 60, 21 },
    { 32, 69, 30, 24, 30, 85, 47, 67, 74, 47 },
    { 15, 55, 87, 83, 38, 80, 53, 27, 60, 24 },
    { 39, 84, 41, 21, 31, 34, 68, 10, 26, 51 },
    { 34, 54, 74, 30, 42, 77, 45, 47, 92, 76 },
    { 26, 17, 51, 13, 32, 73, 12, 25, 45, 14 },
    { 44, 22, 57, 46, 82, 48, 37, 18, 93, 96 },
    { 27, 47, 50, 32, 22, 60, 80, 66, 51, 60 },
    { 45, 15, 34, 84, 97, 31, 42, 37, 88, 57 },
    { 31, 52, 64, 21, 16, 22, 96, 37, 47, 93 },
    { 49, 36, 54, 96, 59, 79, 66, 29, 91, 72 },
    { 93, 45, 73, 84, 69, 39, 88, 73, 48, 60 },
    { 16, 99, 29, 45, 74, 74, 82, 39, 26, 10 },
    { 63, 53, 28, 58, 21, 18, 61, 38, 34, 28 },
    { 65, 23, 46, 26, 64, 86, 79, 79, 52, 77 },
    { 34, 32, 88, 87, 86, 49, 16, 18, 31, 85 },
    { 96, 37, 12, 91, 18, 49, 26, 25, 73, 61 },
    { 77, 59, 48, 30, 95, 93, 63, 13, 81, 88 },
    { 94, 12, 87, 48, 76, 40, 64, 41, 71, 71 },
    { 12, 53, 17, 49, 31, 37, 20, 55, 18, 24 }
};
            expected = new int[20, 10] {
    { 21, 12, 24, 30, 10, 26, 39, 18, 47, 21 },
    { 30, 29, 18, 25, 45, 14, 27, 51, 24, 60 },
    { 13, 32, 37, 30, 34, 47, 53, 47, 60, 74 },
    { 10, 15, 32, 42, 31, 38, 68, 85, 76, 67 },
    { 17, 22, 37, 37, 66, 51, 45, 73, 85, 87 },
    { 16, 22, 29, 42, 41, 69, 57, 60, 80, 92 },
    { 21, 22, 26, 31, 60, 47, 73, 77, 93, 96 },
    { 15, 34, 26, 28, 39, 60, 48, 87, 83, 99 },
    { 18, 27, 38, 34, 32, 46, 74, 55, 88, 89 },
    { 16, 18, 31, 39, 39, 34, 48, 82, 72, 93 },
    { 13, 21, 45, 61, 44, 50, 57, 51, 84, 80 },
    { 18, 24, 25, 52, 61, 47, 77, 66, 54, 91 },
    { 16, 26, 26, 31, 54, 64, 52, 79, 73, 96 },
    { 20, 18, 28, 29, 36, 73, 69, 59, 84, 97 },
    { 12, 23, 46, 41, 45, 45, 74, 74, 82, 88 },
    { 31, 30, 40, 53, 49, 49, 71, 79, 79, 85 },
    { 49, 34, 32, 63, 55, 63, 49, 73, 84, 96 },
    { 12, 59, 37, 37, 88, 64, 86, 58, 81, 88 },
    { 53, 17, 87, 48, 65, 91, 87, 93, 64, 86 },
    { 12, 94, 77, 96, 48, 76, 95, 93, 99, 71 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[20, 15] {
    { 69, 64, 16, 91, 10, 74, 84, 68, 91, 93, 86, 13, 36, 42, 90 },
    { 94, 50, 64, 25, 77, 85, 84, 53, 12, 58, 33, 52, 98, 98, 67 },
    { 83, 18, 95, 67, 28, 40, 96, 96, 47, 11, 56, 95, 50, 78, 84 },
    { 98, 26, 74, 59, 37, 87, 55, 40, 41, 38, 84, 21, 13, 42, 76 },
    { 31, 85, 70, 34, 20, 78, 18, 69, 23, 60, 97, 54, 27, 23, 30 },
    { 89, 44, 75, 27, 60, 17, 77, 49, 70, 80, 37, 77, 63, 38, 43 },
    { 29, 93, 63, 70, 79, 71, 35, 26, 67, 16, 90, 56, 60, 99, 40 },
    { 43, 38, 26, 20, 48, 50, 45, 85, 81, 69, 54, 45, 99, 53, 82 },
    { 10, 54, 41, 79, 40, 14, 90, 56, 43, 58, 64, 28, 17, 21, 69 },
    { 60, 26, 49, 40, 47, 98, 61, 53, 89, 93, 83, 17, 82, 11, 35 },
    { 35, 35, 72, 84, 16, 46, 24, 81, 68, 35, 52, 82, 83, 62, 84 },
    { 32, 38, 74, 22, 18, 37, 96, 69, 16, 84, 49, 11, 52, 86, 57 },
    { 97, 18, 55, 18, 32, 39, 55, 32, 14, 32, 45, 45, 81, 14, 94 },
    { 26, 78, 90, 15, 71, 54, 42, 69, 92, 98, 39, 65, 65, 10, 67 },
    { 45, 72, 94, 20, 38, 44, 36, 74, 39, 54, 76, 15, 70, 89, 73 },
    { 91, 25, 65, 22, 67, 70, 20, 47, 24, 13, 64, 48, 63, 19, 93 },
    { 74, 90, 32, 47, 87, 73, 51, 70, 76, 59, 89, 13, 61, 60, 95 },
    { 49, 72, 80, 29, 17, 24, 10, 52, 43, 96, 35, 35, 79, 17, 73 },
    { 95, 73, 65, 46, 80, 85, 83, 33, 12, 99, 50, 54, 88, 62, 77 },
    { 67, 58, 86, 29, 63, 91, 68, 44, 12, 78, 73, 47, 88, 50, 62 }
};
            expected = new int[20, 15] {
    { 10, 14, 16, 16, 10, 21, 38, 11, 21, 13, 30, 13, 36, 42, 90 },
    { 18, 11, 26, 17, 28, 11, 35, 47, 12, 27, 23, 42, 76, 84, 67 },
    { 19, 34, 17, 37, 18, 40, 17, 37, 53, 54, 38, 33, 50, 78, 98 },
    { 14, 26, 35, 20, 52, 25, 54, 23, 41, 53, 63, 40, 43, 52, 98 },
    { 14, 15, 27, 45, 35, 58, 28, 55, 40, 56, 60, 68, 56, 93, 86 },
    { 13, 17, 16, 45, 45, 43, 64, 49, 57, 45, 60, 69, 82, 58, 95 },
    { 13, 26, 20, 32, 50, 49, 50, 64, 64, 62, 80, 74, 77, 84, 91 },
    { 18, 16, 32, 24, 39, 53, 56, 52, 67, 67, 69, 84, 84, 84, 99 },
    { 10, 24, 29, 46, 31, 48, 65, 60, 59, 67, 69, 70, 85, 96, 97 },
    { 18, 22, 35, 35, 47, 40, 60, 68, 65, 69, 77, 83, 77, 90, 99 },
    { 12, 20, 26, 39, 37, 54, 44, 61, 70, 71, 73, 78, 86, 82, 96 },
    { 10, 15, 35, 32, 42, 38, 62, 48, 63, 70, 74, 81, 81, 87, 91 },
    { 22, 12, 35, 43, 36, 43, 39, 62, 61, 70, 79, 89, 85, 82, 94 },
    { 17, 24, 18, 38, 44, 47, 49, 40, 64, 63, 73, 83, 89, 93, 83 },
    { 25, 26, 44, 20, 38, 60, 47, 54, 41, 79, 69, 75, 84, 93, 95 },
    { 46, 29, 47, 78, 32, 51, 70, 50, 54, 50, 79, 76, 81, 90, 94 },
    { 29, 63, 32, 65, 83, 33, 52, 71, 54, 59, 55, 89, 77, 85, 95 },
    { 49, 65, 80, 45, 68, 87, 67, 55, 73, 72, 74, 69, 92, 98, 98 },
    { 58, 73, 72, 90, 80, 72, 94, 73, 70, 74, 76, 84, 88, 93, 98 },
    { 67, 95, 86, 74, 91, 91, 85, 97, 90, 78, 99, 96, 88, 89, 96 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));

            matrix = new int[20, 20] {
    { 47, 71, 62, 12, 64, 25, 48, 25, 80, 19, 65, 49, 78, 29, 66, 69, 21, 90, 65, 38 },
    { 76, 49, 60, 53, 81, 37, 39, 62, 67, 16, 48, 94, 82, 49, 61, 79, 92, 86, 98, 61 },
    { 29, 43, 15, 20, 98, 52, 90, 24, 45, 18, 62, 57, 32, 21, 85, 98, 20, 18, 30, 37 },
    { 85, 85, 57, 73, 71, 70, 66, 38, 67, 87, 77, 34, 91, 14, 19, 42, 43, 49, 55, 39 },
    { 46, 25, 26, 58, 53, 90, 71, 70, 63, 62, 68, 83, 66, 71, 75, 43, 85, 42, 48, 37 },
    { 85, 62, 57, 58, 41, 37, 65, 28, 12, 52, 65, 70, 62, 90, 90, 70, 69, 98, 29, 80 },
    { 99, 95, 74, 14, 29, 93, 68, 30, 38, 75, 57, 11, 11, 28, 54, 84, 68, 68, 27, 26 },
    { 35, 53, 68, 21, 97, 97, 30, 75, 80, 14, 74, 86, 22, 68, 38, 89, 87, 52, 39, 47 },
    { 69, 44, 89, 37, 95, 64, 69, 44, 46, 15, 12, 11, 81, 13, 55, 55, 37, 63, 17, 31 },
    { 73, 93, 49, 33, 10, 70, 88, 42, 90, 64, 96, 25, 39, 80, 56, 90, 63, 41, 25, 43 },
    { 37, 86, 38, 74, 12, 73, 15, 18, 22, 82, 61, 34, 45, 17, 74, 76, 94, 65, 36, 35 },
    { 75, 36, 54, 82, 18, 86, 71, 10, 57, 65, 91, 96, 47, 74, 93, 86, 64, 75, 31, 37 },
    { 64, 80, 30, 17, 12, 72, 80, 31, 16, 80, 95, 98, 14, 90, 67, 10, 42, 56, 65, 25 },
    { 11, 14, 61, 56, 90, 65, 86, 70, 23, 87, 21, 29, 44, 99, 70, 95, 16, 46, 79, 46 },
    { 16, 49, 94, 76, 70, 93, 91, 57, 16, 92, 54, 18, 19, 16, 35, 59, 28, 73, 26, 47 },
    { 85, 19, 18, 28, 68, 75, 63, 15, 29, 72, 94, 95, 76, 29, 19, 61, 20, 84, 86, 96 },
    { 73, 38, 64, 30, 43, 13, 20, 37, 73, 20, 76, 43, 29, 42, 60, 96, 41, 76, 18, 95 },
    { 39, 85, 38, 44, 98, 58, 41, 89, 97, 73, 49, 43, 87, 29, 73, 57, 55, 87, 85, 64 },
    { 64, 36, 42, 18, 96, 60, 76, 44, 69, 22, 29, 43, 76, 91, 67, 87, 10, 29, 32, 84 },
    { 71, 31, 40, 99, 71, 42, 56, 99, 69, 13, 51, 54, 91, 53, 40, 13, 53, 30, 48, 47 }
};
            expected = new int[20, 20] {
    { 14, 15, 12, 10, 26, 11, 11, 18, 16, 19, 14, 19, 27, 26, 20, 18, 21, 37, 61, 38 },
    { 16, 15, 20, 14, 11, 37, 13, 45, 25, 34, 25, 17, 21, 42, 29, 48, 37, 30, 90, 65 },
    { 10, 19, 32, 20, 18, 12, 38, 22, 46, 25, 36, 35, 32, 31, 47, 29, 49, 55, 39, 98 },
    { 14, 19, 29, 35, 30, 25, 12, 42, 24, 48, 28, 37, 48, 43, 39, 49, 42, 66, 69, 86 },
    { 10, 18, 22, 30, 37, 34, 28, 16, 46, 25, 55, 31, 37, 57, 52, 43, 78, 43, 79, 92 },
    { 10, 13, 18, 26, 41, 41, 47, 28, 17, 52, 39, 62, 38, 41, 63, 65, 49, 85, 61, 80 },
    { 12, 23, 15, 21, 29, 43, 46, 59, 38, 39, 57, 47, 65, 55, 54, 71, 68, 68, 85, 98 },
    { 18, 16, 31, 16, 25, 29, 44, 47, 60, 45, 52, 63, 56, 68, 62, 62, 84, 70, 69, 98 },
    { 12, 20, 33, 37, 21, 42, 29, 44, 47, 65, 53, 66, 64, 56, 68, 63, 66, 87, 75, 82 },
    { 17, 15, 29, 43, 40, 29, 53, 29, 48, 49, 70, 62, 70, 74, 62, 70, 65, 80, 90, 94 },
    { 13, 22, 29, 35, 53, 43, 29, 57, 30, 55, 53, 71, 64, 73, 80, 64, 75, 67, 89, 91 },
    { 13, 20, 37, 38, 43, 53, 68, 46, 57, 42, 57, 61, 71, 67, 74, 81, 65, 87, 77, 90 },
    { 14, 41, 30, 51, 54, 44, 70, 71, 54, 64, 57, 58, 61, 76, 70, 75, 86, 67, 90, 83 },
    { 11, 28, 44, 36, 54, 65, 49, 72, 73, 62, 73, 58, 76, 64, 80, 71, 81, 86, 76, 94 },
    { 16, 18, 43, 61, 37, 63, 69, 49, 76, 85, 67, 76, 60, 82, 68, 84, 74, 86, 90, 79 },
    { 18, 19, 30, 58, 68, 56, 73, 73, 57, 76, 87, 70, 80, 65, 90, 73, 85, 84, 93, 96 },
    { 42, 38, 42, 49, 64, 69, 69, 86, 73, 72, 80, 91, 74, 85, 69, 91, 75, 90, 95, 95 },
    { 36, 73, 38, 44, 56, 76, 75, 70, 90, 82, 74, 86, 92, 87, 87, 85, 93, 87, 90, 98 },
    { 31, 39, 85, 71, 64, 60, 94, 76, 75, 93, 91, 86, 89, 94, 95, 88, 95, 96, 96, 96 },
    { 71, 64, 40, 99, 85, 96, 98, 99, 80, 89, 97, 93, 91, 99, 95, 95, 97, 97, 98, 99 }
};
            CollectionAssert.AreEqual(expected, _object.DiagonalSort(matrix));
        }

        public void SortBackAndForthTests()
        {
            var sb = new StringBuilder();
            int[] actual, expected;
            actual = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99 };
            _object.SortBackAndForth(actual);
            expected = new[] { 0, 2, 4, 6, 8, 10, 12, 14, 16, 18, 20, 22, 24, 26, 28, 30, 32, 34, 36, 38, 40, 42, 44, 46, 48, 50, 52, 54, 56, 58, 60, 62, 64, 66, 68, 70, 72, 74, 76, 78, 80, 82, 84, 86, 88, 90, 92, 94, 96, 98, 99, 97, 95, 93, 91, 89, 87, 85, 83, 81, 79, 77, 75, 73, 71, 69, 67, 65, 63, 61, 59, 57, 55, 53, 51, 49, 47, 45, 43, 41, 39, 37, 35, 33, 31, 29, 27, 25, 23, 21, 19, 17, 15, 13, 11, 9, 7, 5, 3, 1 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 2278, 5684, 3271, 5199, 9576, 9868, 641, 3961, 961, 2043, 1397, 2423, 9426, 9249, 4540, 3852, 6364, 5290, 7849, 8603, 8638, 8388, 7095, 4224, 3676, 3735, 7679, 7225, 377, 4622, 3892, 1260, 3416, 424, 4395, 2860, 364, 7443, 4372, 9585, 3283, 5611, 202, 7053, 9314, 9809, 7990, 959, 8479, 3745, 3608, 2279, 5457, 6381, 484, 3889, 8589, 9047, 1522, 5840, 2189, 3416, 3584, 6338, 8150, 137, 9006, 9001, 4854, 1679, 3488, 8921, 918, 8264, 5319, 3027, 8185, 41, 4909, 3867, 5745, 6719, 8745, 6631, 1014, 1613, 5802, 7035, 9939, 505, 4271, 1316, 5920, 8531, 7396, 9867, 2027, 3863, 8903, 9177 };
            _object.SortBackAndForth(actual);
            expected = new[] { 41, 202, 377, 484, 641, 959, 1014, 1316, 1522, 1679, 2043, 2278, 2423, 3027, 3283, 3416, 3584, 3676, 3745, 3863, 3889, 3961, 4271, 4395, 4622, 4909, 5290, 5457, 5684, 5802, 5920, 6364, 6631, 7035, 7095, 7396, 7679, 7990, 8185, 8388, 8531, 8603, 8745, 8921, 9006, 9177, 9314, 9576, 9809, 9868, 9939, 9867, 9585, 9426, 9249, 9047, 9001, 8903, 8638, 8589, 8479, 8264, 8150, 7849, 7443, 7225, 7053, 6719, 6381, 6338, 5840, 5745, 5611, 5319, 5199, 4854, 4540, 4372, 4224, 3892, 3867, 3852, 3735, 3608, 3488, 3416, 3271, 2860, 2279, 2189, 2027, 1613, 1397, 1260, 961, 918, 505, 424, 364, 137 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 803, 8988, 6105, 6799, 257, 4687, 1360, 7193, 1061, 7457, 5703, 8548, 4137, 7655, 95, 5469, 4670, 6953, 5324, 6537, 4334, 1970, 9062, 4348, 7408, 2171, 3000, 2387, 867, 5452, 1000, 4322, 1137, 5732, 3063, 6757, 613, 1946, 6373, 6327, 252, 8609, 5974, 2482, 4801, 5722, 7178, 8265, 8436, 1926, 5196, 5073, 8538, 2366, 4842, 8833, 9925, 1757, 9391, 8086, 1687, 8973, 6325, 5608, 6457, 1381, 7410, 8405, 4591, 3338, 4856, 2724, 579, 8997, 6284, 5725, 5996, 6580, 9546, 1685, 4992, 4734, 3951, 8940, 256, 5926, 5784, 8771, 890, 4230, 6831, 8856, 2554, 8286, 4640, 1279, 2283, 365, 6024, 3420 };
            _object.SortBackAndForth(actual);
            expected = new[] { 95, 256, 365, 613, 867, 1000, 1137, 1360, 1685, 1757, 1946, 2171, 2366, 2482, 2724, 3063, 3420, 4137, 4322, 4348, 4640, 4687, 4801, 4856, 5073, 5324, 5469, 5703, 5725, 5784, 5974, 6024, 6284, 6327, 6457, 6580, 6799, 6953, 7193, 7410, 7655, 8265, 8405, 8538, 8609, 8833, 8940, 8988, 9062, 9546, 9925, 9391, 8997, 8973, 8856, 8771, 8548, 8436, 8286, 8086, 7457, 7408, 7178, 6831, 6757, 6537, 6373, 6325, 6105, 5996, 5926, 5732, 5722, 5608, 5452, 5196, 4992, 4842, 4734, 4670, 4591, 4334, 4230, 3951, 3338, 3000, 2554, 2387, 2283, 1970, 1926, 1687, 1381, 1279, 1061, 890, 803, 579, 257, 252 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 8311, 8773, 3673, 5097, 7070, 2472, 4493, 9541, 6082, 9116, 2837, 3345, 2210, 7705, 3094, 6952, 5022, 7385, 5352, 530, 5597, 8639, 7514, 361, 6506, 5999, 169, 2292, 4357, 5004, 3442, 5630, 555, 6125, 3373, 6218, 1060, 8853, 1870, 7783, 1432, 6242, 2689, 1774, 1393, 3485, 6645, 4848, 5192, 7687, 6256, 4898, 5013, 5493, 7823, 9672, 1258, 3312, 8591, 1070, 2302, 2201, 5184, 1077, 5673, 7206, 2790, 6084, 4332, 6875, 5891, 6169, 5514, 7568, 9098, 9354, 5950, 5740, 8968, 3020, 9354, 5321, 7100, 6669, 8748, 8544, 616, 5061, 8302, 3700, 4960, 7748, 261, 799, 5480, 9231, 1058, 1611, 6100, 4186 };
            _object.SortBackAndForth(actual);
            expected = new[] { 169, 361, 555, 799, 1060, 1077, 1393, 1611, 1870, 2210, 2302, 2689, 2837, 3094, 3345, 3442, 3673, 4186, 4357, 4848, 4960, 5013, 5061, 5184, 5321, 5480, 5514, 5630, 5740, 5950, 6082, 6100, 6169, 6242, 6506, 6669, 6952, 7100, 7385, 7568, 7705, 7783, 8302, 8544, 8639, 8773, 8968, 9116, 9354, 9541, 9672, 9354, 9231, 9098, 8853, 8748, 8591, 8311, 7823, 7748, 7687, 7514, 7206, 7070, 6875, 6645, 6256, 6218, 6125, 6084, 5999, 5891, 5673, 5597, 5493, 5352, 5192, 5097, 5022, 5004, 4898, 4493, 4332, 3700, 3485, 3373, 3312, 3020, 2790, 2472, 2292, 2201, 1774, 1432, 1258, 1070, 1058, 616, 530, 261 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 695, 560, 516, 8317, 1796, 87, 9383, 7444, 6395, 8469, 3722, 5517, 4343, 5571, 1716, 6981, 5100, 8514, 2329, 7129, 6590, 7728, 7782, 631, 1915, 8142, 5907, 4715, 2088, 9867, 8295, 4338, 9640, 4782, 2324, 8794, 4804, 8783, 4873, 8660, 9161, 3172, 8666, 9833, 9978, 9442, 3404, 4690, 9083, 8499, 4130, 2543, 9282, 8971, 7595, 2967, 2777, 9885, 6401, 3653, 4179, 4668, 5356, 6528, 173, 9384, 5877, 9561, 3246, 2921, 2177, 6317, 3641, 3668, 7968, 3418, 9061, 7949, 653, 2473, 4737, 1217, 5631, 3588, 5736, 5751, 5055, 669, 7186, 9357, 6016, 4919, 2381, 1220, 4480, 4492, 7815, 2138, 9659, 593 };
            _object.SortBackAndForth(actual);
            expected = new[] { 87, 516, 593, 653, 695, 1220, 1796, 2088, 2177, 2329, 2473, 2777, 2967, 3246, 3418, 3641, 3668, 4130, 4338, 4480, 4668, 4715, 4782, 4873, 5055, 5356, 5571, 5736, 5877, 6016, 6395, 6528, 6981, 7186, 7595, 7782, 7949, 8142, 8317, 8499, 8660, 8783, 8971, 9083, 9282, 9383, 9442, 9640, 9833, 9885, 9978, 9867, 9659, 9561, 9384, 9357, 9161, 9061, 8794, 8666, 8514, 8469, 8295, 7968, 7815, 7728, 7444, 7129, 6590, 6401, 6317, 5907, 5751, 5631, 5517, 5100, 4919, 4804, 4737, 4690, 4492, 4343, 4179, 3722, 3653, 3588, 3404, 3172, 2921, 2543, 2381, 2324, 2138, 1915, 1716, 1217, 669, 631, 560, 173 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 3564, 3843, 1444, 6161, 6322, 7812, 8902, 5613, 1002, 4177, 3905, 4828, 9232, 3928, 8915, 2962, 9036, 1767, 791, 4421, 4328, 5207, 2375, 3888, 6905, 7257, 3936, 2421, 9187, 3475, 5602, 6923, 8289, 59, 8908, 894, 9772, 9470, 7266, 7923, 6848, 9442, 9666, 3008, 5451, 1187, 5686, 8452, 2304, 1518, 5456, 6047, 1346, 5237, 6265, 8357, 1468, 7555, 9255, 9064, 3876, 6481, 6425, 7527, 8574, 6982, 6539, 9172, 5020, 8020, 3189, 9565, 4500, 2868, 7572, 4886, 5541, 9366, 8436, 5718, 1571, 5484, 116, 7669, 8018, 9554, 5576, 3051, 3794, 551, 9426, 2217, 214, 8202, 4047, 367, 3016, 2139, 4434, 8469 };
            _object.SortBackAndForth(actual);
            expected = new[] { 59, 214, 551, 894, 1187, 1444, 1518, 1767, 2217, 2375, 2868, 3008, 3051, 3475, 3794, 3876, 3905, 3936, 4177, 4421, 4500, 4886, 5207, 5451, 5484, 5576, 5613, 5718, 6161, 6322, 6481, 6848, 6923, 7257, 7527, 7572, 7812, 8018, 8202, 8357, 8452, 8574, 8908, 9036, 9172, 9232, 9366, 9442, 9554, 9666, 9772, 9565, 9470, 9426, 9255, 9187, 9064, 8915, 8902, 8469, 8436, 8289, 8020, 7923, 7669, 7555, 7266, 6982, 6905, 6539, 6425, 6265, 6047, 5686, 5602, 5541, 5456, 5237, 5020, 4828, 4434, 4328, 4047, 3928, 3888, 3843, 3564, 3189, 3016, 2962, 2421, 2304, 2139, 1571, 1468, 1346, 1002, 791, 367, 116 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 4648, 6513, 3431, 4283, 8329, 5890, 1546, 8478, 7665, 1379, 2815, 2102, 9118, 3537, 7492, 8392, 6365, 8756, 9508, 9019, 1405, 3487, 5378, 4469, 8594, 972, 9351, 6298, 8820, 7205, 1869, 3401, 4932, 9966, 1069, 5057, 2052, 5832, 9339, 2127, 8007, 7097, 5386, 2415, 7735, 7323, 3098, 6676, 709, 5654, 4001, 4260, 2630, 5414, 7064, 1160, 1135, 8961, 5689, 7357, 6539, 5248, 9657, 459, 9509, 9413, 7169, 9152, 2467, 2435, 6339, 533, 9416, 7381, 1012, 4307, 8101, 2963, 6734, 1270, 7873, 2674, 5588, 3165, 3203, 7608, 771, 9518, 2902, 9909, 3921, 3091, 143, 1982, 5588, 2759, 7440, 4926, 2905, 8321 };
            _object.SortBackAndForth(actual);
            expected = new[] { 143, 533, 771, 1012, 1135, 1270, 1405, 1869, 2052, 2127, 2435, 2630, 2759, 2902, 2963, 3098, 3203, 3431, 3537, 4001, 4283, 4469, 4926, 5057, 5378, 5414, 5588, 5689, 5890, 6339, 6513, 6676, 7064, 7169, 7323, 7381, 7492, 7665, 7873, 8101, 8329, 8478, 8756, 8961, 9118, 9339, 9413, 9508, 9518, 9909, 9966, 9657, 9509, 9416, 9351, 9152, 9019, 8820, 8594, 8392, 8321, 8007, 7735, 7608, 7440, 7357, 7205, 7097, 6734, 6539, 6365, 6298, 5832, 5654, 5588, 5386, 5248, 4932, 4648, 4307, 4260, 3921, 3487, 3401, 3165, 3091, 2905, 2815, 2674, 2467, 2415, 2102, 1982, 1546, 1379, 1160, 1069, 972, 709, 459 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 153, 3946, 4209, 8273, 9315, 3468, 4843, 5249, 4402, 2757, 3058, 8171, 2227, 4418, 9483, 3865, 9659, 6491, 7255, 1900, 8642, 7651, 6249, 2558, 8513, 3248, 390, 7433, 1792, 8252, 6867, 3174, 58, 8413, 1117, 3926, 8465, 7315, 3850, 9735, 2764, 5522, 5116, 145, 6851, 5750, 864, 5724, 2498, 1723, 3099, 948, 7671, 1004, 9678, 2501, 7696, 1650, 9759, 6067, 3078, 7410, 3456, 6149, 5889, 9883, 8113, 3813, 3301, 5556, 5399, 2344, 2641, 7520, 9135, 3120, 2535, 6104, 5706, 2763, 2383, 4665, 4934, 69, 5152, 5919, 5503, 9054, 8734, 8615, 6230, 6814, 7555, 7782, 6657, 5354, 2065, 8966, 4255, 6967 };
            _object.SortBackAndForth(actual);
            expected = new[] { 58, 145, 390, 948, 1117, 1723, 1900, 2227, 2383, 2501, 2558, 2757, 2764, 3078, 3120, 3248, 3456, 3813, 3865, 3946, 4255, 4418, 4843, 5116, 5249, 5399, 5522, 5706, 5750, 5919, 6104, 6230, 6491, 6814, 6867, 7255, 7410, 7520, 7651, 7696, 8113, 8252, 8413, 8513, 8642, 8966, 9135, 9483, 9678, 9759, 9883, 9735, 9659, 9315, 9054, 8734, 8615, 8465, 8273, 8171, 7782, 7671, 7555, 7433, 7315, 6967, 6851, 6657, 6249, 6149, 6067, 5889, 5724, 5556, 5503, 5354, 5152, 4934, 4665, 4402, 4209, 3926, 3850, 3468, 3301, 3174, 3099, 3058, 2763, 2641, 2535, 2498, 2344, 2065, 1792, 1650, 1004, 864, 153, 69 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 7637, 7050, 2423, 6941, 6323, 755, 8306, 151, 1868, 6558, 9966, 1591, 5943, 6996, 3683, 8412, 2475, 3387, 996, 9970, 4379, 9058, 5078, 4686, 9326, 8584, 4789, 4858, 862, 3781, 1055, 3569, 1849, 8739, 5126, 5333, 2241, 7992, 3745, 4397, 7612, 5352, 7185, 2176, 8648, 4638, 870, 558, 4098, 8244, 2879, 8678, 7970, 4284, 2587, 8578, 1971, 7737, 7615, 7738, 5965, 3447, 9288, 8086, 5503, 6396, 9742, 7204, 1870, 8350, 6170, 4482, 9641, 6598, 2358, 9026, 1872, 2902, 6037, 4688, 7714, 4230, 760, 2617, 902, 2376, 5599, 7565, 6151, 6547, 3361, 4504, 377, 6007, 8432, 4164, 6064, 9099, 6673, 2252 };
            _object.SortBackAndForth(actual);
            expected = new[] { 151, 558, 760, 870, 996, 1591, 1868, 1872, 2176, 2252, 2376, 2475, 2617, 2902, 3387, 3569, 3745, 4098, 4230, 4379, 4482, 4638, 4688, 4858, 5126, 5352, 5599, 5965, 6037, 6151, 6323, 6547, 6598, 6941, 7050, 7204, 7612, 7637, 7737, 7970, 8086, 8306, 8412, 8578, 8648, 8739, 9058, 9288, 9641, 9966, 9970, 9742, 9326, 9099, 9026, 8678, 8584, 8432, 8350, 8244, 7992, 7738, 7714, 7615, 7565, 7185, 6996, 6673, 6558, 6396, 6170, 6064, 6007, 5943, 5503, 5333, 5078, 4789, 4686, 4504, 4397, 4284, 4164, 3781, 3683, 3447, 3361, 2879, 2587, 2423, 2358, 2241, 1971, 1870, 1849, 1055, 902, 862, 755, 377 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 4895, 3666, 8688, 5748, 2074, 8396, 9036, 1371, 1925, 3560, 6705, 9069, 1700, 2926, 24, 1734, 2687, 6671, 7184, 3126, 797, 2177, 1052, 5322, 4988, 1666, 4105, 3634, 8166, 8194, 2962, 2773, 6228, 3785, 9792, 4048, 5542, 5011, 543, 2505, 3340, 4227, 5639, 2590, 9842, 4292, 2803, 7451, 5982, 6697, 1476, 9393, 1914, 3547, 1454, 2718, 2613, 3365, 760, 407, 4291, 5402, 3205, 3731, 598, 3931, 2840, 7915, 3133, 5976, 6191, 7676, 6127, 4679, 9785, 6570, 6538, 8461, 5480, 695, 8863, 6654, 7651, 1468, 6717, 3569, 859, 2681, 2330, 7073, 1434, 2177, 4251, 136, 8214, 7938, 1021, 1907, 1992, 5910 };
            _object.SortBackAndForth(actual);
            expected = new[] { 24, 407, 598, 760, 859, 1052, 1434, 1468, 1666, 1734, 1914, 1992, 2177, 2330, 2590, 2681, 2718, 2803, 2926, 3126, 3205, 3365, 3560, 3634, 3731, 3931, 4105, 4251, 4292, 4895, 5011, 5402, 5542, 5748, 5976, 6127, 6228, 6570, 6671, 6705, 7073, 7451, 7676, 7938, 8194, 8396, 8688, 9036, 9393, 9792, 9842, 9785, 9069, 8863, 8461, 8214, 8166, 7915, 7651, 7184, 6717, 6697, 6654, 6538, 6191, 5982, 5910, 5639, 5480, 5322, 4988, 4679, 4291, 4227, 4048, 3785, 3666, 3569, 3547, 3340, 3133, 2962, 2840, 2773, 2687, 2613, 2505, 2177, 2074, 1925, 1907, 1700, 1476, 1454, 1371, 1021, 797, 695, 543, 136 };
            CollectionAssert.AreEqual(expected, actual);

            actual = new[] { 1452, 4888, 4317, 6, 505, 3800, 3265, 7235, 3761, 4883, 6180, 4151, 7885, 64, 1544, 7637, 7750, 1737, 7013, 7028, 3072, 158, 5584, 6059, 4541, 4014, 3424, 5991, 6464, 1847, 5548, 4630, 6468, 9570, 9242, 3974, 2337, 7645, 962, 2917, 304, 3624, 8919, 7447, 893, 7282, 4291, 4187, 8591, 577, 187, 9284, 4893, 4964, 2838, 1293, 9303, 8257, 5464, 6491, 375, 7273, 770, 1913, 9334, 1550, 7682, 8315, 821, 7569, 5300, 104, 774, 4095, 6723, 9447, 1239, 8137, 5166, 7258, 9722, 9237, 7400, 5887, 1660, 6264, 9736, 1504, 6731, 7949, 4670, 4079, 2180, 4471, 2542, 3030, 2853, 7005, 8112, 9343 };
            _object.SortBackAndForth(actual); expected = new[] { 6, 104, 187, 375, 577, 774, 893, 1239, 1452, 1544, 1660, 1847, 2180, 2542, 2853, 3030, 3265, 3624, 3800, 4014, 4095, 4187, 4317, 4541, 4670, 4888, 4964, 5300, 5548, 5887, 6059, 6264, 6468, 6723, 7005, 7028, 7258, 7282, 7447, 7637, 7682, 7885, 8112, 8257, 8591, 9237, 9284, 9334, 9447, 9722, 9736, 9570, 9343, 9303, 9242, 8919, 8315, 8137, 7949, 7750, 7645, 7569, 7400, 7273, 7235, 7013, 6731, 6491, 6464, 6180, 5991, 5584, 5464, 5166, 4893, 4883, 4630, 4471, 4291, 4151, 4079, 3974, 3761, 3424, 3072, 2917, 2838, 2337, 1913, 1737, 1550, 1504, 1293, 962, 821, 770, 505, 304, 158, 64 };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion
    }
}
