using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using sortingApp;
namespace SortingUnitTests
{
    [TestClass]
    public class SortingUnitTests
    {
        /* Description == Function that takes an array and the expected 
        *                 value and makes an assertion to determine if they are equal or not
        *  (Arguments) > return type == (int[], int[]) > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == 
        *  int[] testArray = { 1, -5, -60, -100, 560 };
        *  int[] expected = { -100, -60, -5, 1, 560 };
        *  TestArray(testArray, expected); */
        private static void TestArray(int[] testArray, int[] expect, string sort)
        {
            var op = new Program();
            int[] actual;
            int[] expected = expect;
            if(sort == "bubble"){
                op.BubbleSort(ref testArray, testArray.Length - 1);
            }
            else if (sort == "insert"){
                op.InsertionSort(ref testArray, testArray.Length - 1);
            }
            else if(sort == "shell"){
                op.ShellSort(ref testArray, testArray.Length - 1);
            }
            
            actual = testArray;
            CollectionAssert.AreEqual(expected, actual);
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with two values successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void TwoElementTest()
        {
            int[] testArray = { 1, 0 };
            int[] expected = { 0, 1 };
            TestArray(testArray, expected, "insert");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with only repeated values successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void OnlyRepeatedValuesTest()
        {
            int[] testArray = { 10, 10, 10, 10, 10, 10, 10};
            TestArray(testArray, testArray, "insert");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with one element successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void OneElementTest()
        {
            int[] testArray = { 9 };
            TestArray(testArray, testArray, "insert");
        }
         /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with no elements successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void EmptyArrayTest()
        {
            int[] testArray = { };
            TestArray(testArray, testArray, "bubble");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with Max Int value successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void MaxIntValueTest()
        {
            int[] testArray = { int.MaxValue };
            TestArray(testArray, testArray, "bubble");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with Min Int value successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void MinIntValueTest()
        {
            int[] testArray = { int.MinValue };
            TestArray(testArray, testArray, "bubble");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with already sorted values successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void ArraySortedTest()
        {
            int[] testArray = { 1, 5, 60, 100, 560 };
            TestArray(testArray, testArray, "shell");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with positive and negative values successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void PositiveAndNegativeTest()
        {
            int[] testArray = { 1, -5, -60, -100, 560 };
            int[] expected = { -100, -60, -5, 1, 560 };
            TestArray(testArray, expected, "shell");
        }
        /* Description == Test that determine if the ShellSort Function will sort a Array 
        *                 with identical values successfully
        *  (Arguments) > return type == () > void
        *  Precondition ==  values must be in range of int32
        *  Postcondition == none
        *  Example == N/A */
        [TestMethod]
        public void IdenticalValuesTest()
        {
            int[] testArray = { 1, 10, 5, 5, 7, 5 };
            int[] expected = { 1, 5, 5, 5, 7, 10 };
            TestArray(testArray, expected, "shell");
        }
    }
}
