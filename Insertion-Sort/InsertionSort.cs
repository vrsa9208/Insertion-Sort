using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    class InsertionSort<T>
    {
        private IComparer<T> _comparer;

        public InsertionSort(IComparer<T> comparer)
        {
            this._comparer = comparer;
        }

        public T[] Sort(T[] array)
        {
            T[] sortedArray = (T[])array.Clone();
            for (int i = 1; i < sortedArray.Length; i++)
            {
                T key = sortedArray[i];
                int j = i - 1;
                while (j > -1 && this._comparer.Compare(sortedArray[j], key) > 0)
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
