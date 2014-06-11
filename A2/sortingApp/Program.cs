/* 
 * Assignment 2 : Profiling of Sorting Algorithms
 * Team: 
 * Peter Lyn 26100068
 * Shane Mclean 18100714
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sortingApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program op = new Program();
            int Min = 1;
            int Max = 5000;
            int[] test2 = new int[10000];

            Random randNum = new Random();
            for (int i = 0; i < test2.Length; i++)
            {
                test2[i] = randNum.Next(Min, Max);
            }
            op.ShellSort(ref test2, test2.Length - 1);
            //op.InsertionSort(ref test2, test2.Length - 1);
            //op.BubbleSort(ref test2, test2.Length - 1);
            for (int i = 0; i < test2.Length; i++)
            {
                Console.Write(test2[i] + "\n");
            }
        }

/* Description == Function to sort a integer Array using Shell Sort Algorithm
*  (Arguments) > return type == (int[], int) > void
*  Precondition ==  values must be in range of int32
*  Postcondition == none
*  Example == 
*  var op = new Program();
*  int[] testArray = {1, 2, 3};
*  op.ShellSort(ref testArray, testArray.Length - 1); */
        public void ShellSort(ref int[] arr, int size)
        {
            int i = size / 2;
            while (i != 0) 
            {
                int c = 0;
                c = i;
                while (c <= size) 
                {
                    int hold = 0;
                    int walker = 0;
                    hold = arr[c];
                    walker = c - i;
                    while (walker >= 0 && hold < arr[walker]) 
                    {
                        arr[walker + i] = arr[walker];
                        walker = walker - i;
                    }

                    arr[walker + i] = hold;
                    c = c + 1;
                }
                i = i / 2;
            }
     
        }
/* Description == Function to sort a integer Array using Bubble Sort Algorithm
*  (Arguments) > return type == (int[], int) > void
*  Precondition ==  values must be in range of int32
*  Postcondition == none
*  Example == 
*  var op = new Program();
*  int[] testArray = {1, 2, 3};
*  op.BubbleSort(ref testArray, testArray.Length - 1); */
        public void BubbleSort(ref int[] arr, int size)
        {
            int temp = 0;
            for (var x = 1; x <= size; x++)
            {
                for (var y = size; y > 0; y--)
                {
                    if (arr[y] < arr[y - 1])
                    {
                        temp = arr[y];
                        arr[y] = arr[y - 1];
                        arr[y - 1] = temp;
                    }
                }
            }
        }
/* Description == Function to sort a integer Array using Insertion Sort Algorithm
*  (Arguments) > return type == (int[], int) > void
*  Precondition ==  values must be in range of int32
*  Postcondition == none
*  Example == 
*  var op = new Program();
*  int[] testArray = {1, 2, 3};
*  op.InsertionSort(ref testArray, testArray.Length - 1); */
        public void InsertionSort(ref int[] arr, int size)
        {
            int current = 1;
            int j = 0;
            int hold = 0;
            int walker = 0;
            for (j = current; j <= size; j++)
            {
                hold = arr[j];
                walker = j - 1;

                while (walker >= 0 && arr[walker] > hold)
                {
                    arr[walker + 1] = arr[walker];
                    walker = walker-1;
                }
                arr[walker + 1] = hold;
            }

        }
    }
}
