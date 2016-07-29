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

            Console.Write("Sorted Array: ");
            int[] sortedArray = SortArray(originalArray);
            Console.WriteLine(ArrayToString(sortedArray));
        }

        public static String ArrayToString(int[] array)
        {
            StringBuilder stringBuilder = new StringBuilder("[");
            foreach(int i in array)
            {
                stringBuilder.AppendFormat("{0}, ", i);
            }
            stringBuilder.Remove(stringBuilder.Length - 2, 2);
            stringBuilder.Append("]");
            return stringBuilder.ToString();
        }

        public static int[] SortArray(int[] array)
        {
            int[] sortedArray = (int[]) array.Clone();
            for (int i = 1; i < sortedArray.Length; i++)
            {
                int key = sortedArray[i];
                int j = i - 1;
                while (j > -1 && sortedArray[j] > key)
                {
                    sortedArray[j + 1] = sortedArray[j];
                    j = j - 1;
                }
                sortedArray[j + 1] = key;
            }
            return sortedArray;
        }
    }
}
