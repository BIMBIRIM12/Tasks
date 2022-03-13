using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public delegate int[] GetFinishSortingArray(int[] array);

    public delegate void StringMessage(string message);

    class DelegateSortArray
    {
        public event StringMessage? CompletedSorting;
   
        public int[] GetSortArray()
        {
            int[] arrayUnsort = new int[5] { 1, 43, 5, 90, 2 };
            GetFinishSortingArray sortArray = new(SortArray);
            int[] value = sortArray(arrayUnsort);

            return value;
        }

        public int[] SortArray(int[] arrayUnsort)
        {
            #region Sorting
            int[] arraySort = arrayUnsort;
            for (var i = 0; i < arraySort.Length - 1; i++)
            {
                if (arraySort[i] > arraySort[i + 1])
                {
                    for (var j = i + 1; j > 0; j--)
                    {
                        if (arraySort[j] < arraySort[j - 1])
                        {
                            var g = arraySort[j];
                            arraySort[j] = arraySort[j - 1];
                            arraySort[j - 1] = g;
                        }
                    }
                }
            }
            #endregion
            CompletedSorting?.Invoke("Sorting completed");
            foreach (var number in arraySort)
            {
                Console.WriteLine(number);
            }

            return arraySort;
        }
    }
}   

