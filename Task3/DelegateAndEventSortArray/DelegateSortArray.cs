using System;

namespace Program
{
    #region Delegates
    public delegate int[] GetFinishSortingArray(int[] array);

    public delegate void StringMessage(string message);
    #endregion

    /// <summary>
    /// Создаёт неотсортированный массива значений, сортирует его по убыванию и возвращает.
    /// </summary>
    class DelegateSortArray
    {
        public event StringMessage? CompletedSorting;
        
        /// <summary>
        /// Создаёт неотсортированный массив значений, с помощью делегата передаёт его в метод сортировки
        /// и возвращает отсортированный по убыванию массив.
        /// </summary>
        /// <returns> Отсортированный массив </returns>
        public int[] GetSortArray()
        {
            int[] arrayUnsort = new int[5] { 1, 43, 5, 90, 2 };
            GetFinishSortingArray sortArray = new(SortArray);
            int[] value = sortArray(arrayUnsort);

            return value;
        }

        /// <summary>
        /// Сортирует принятый массив по возрастанию.
        /// </summary>
        /// <param name="arrayUnsort"> Неотсортированный массив </param>
        /// <returns> Отсортированный массив </returns>
        /// <exception cref="ArgumentNullException"> Проверка на пустоту массива </exception>
        public int[] SortArray(int[] arrayUnsort)
        {
            if (arrayUnsort == null)
            {
                throw new ArgumentNullException(nameof(arrayUnsort), "Array is null");
            }
            else
            {
                #region Sorting
                int[] arraySort = arrayUnsort;
                for (var i = 0; i < arraySort.Length - 1; i++)
                {
                    if (arraySort[i] < arraySort[i + 1])
                    {
                        for (var j = i + 1; j > 0; j--)
                        {
                            if (arraySort[j] > arraySort[j - 1])
                            {
                                var g = arraySort[j];
                                arraySort[j] = arraySort[j - 1];
                                arraySort[j - 1] = g;
                            }
                        }
                    }
                }
                #endregion
                
                foreach (var number in arraySort)
                {
                    Console.WriteLine(number);
                }
                CompletedSorting?.Invoke("Sorting completed");
                return arraySort;
            }
        }
    }
}   

