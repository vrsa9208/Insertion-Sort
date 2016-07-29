using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();
            int[] originalArray = { 34, 23, 12, 45, 7, 13 };

            Console.Write("Original Array: ");
            Console.WriteLine(ArrayToString(originalArray));

            InsertionSort<int> nonDecreasingsorter = new InsertionSort<int>(new NonDecreasingIntegerComparer());
            int[] nonDecreasingSortedArray = nonDecreasingsorter.Sort(originalArray);

            Console.Write("Non Decreasing Sorted Array: ");
            Console.WriteLine(ArrayToString(nonDecreasingSortedArray));

            InsertionSort<int> nonIncreasingsorter = new InsertionSort<int>(new NonIncreasingIntegerComparer());
            int[] nonIncreasingSortedArray = nonIncreasingsorter.Sort(originalArray);

            Console.Write("Non Increasing Sorted Array: ");
            Console.WriteLine(ArrayToString(nonIncreasingSortedArray));
        }

        public static String ArrayToString(int[] array)
        {
            StringBuilder stringBuilder = new StringBuilder("[");
            foreach(int i in array)
            {
                stringBuilder.AppendFormat("{0}, ", i.ToString());
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

    }

    class NonDecreasingIntegerComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x == y ? 0 : x > y ? 1 : -1;
        }
    }

    class NonIncreasingIntegerComparer : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            return x == y ? 0 : x < y ? 1 : -1;
        }
    }
}
