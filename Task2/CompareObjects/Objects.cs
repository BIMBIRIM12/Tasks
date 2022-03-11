using System;
using System.Collections.Generic;

namespace Program
{

    /// <summary>
    /// Создаёт динамический массив с типом значения Т.
    /// </summary>
    /// <typeparam name="T"> Тип значений массива </typeparam>
    public class DynamicArray<T>
    {
        /// <summary>
        /// Динамический массив с типом значений Т.
        /// </summary>
        public T[] myArray { get; set; }

        /// <summary>
        /// Емкость массива - внутренняя длина.
        /// </summary>
        private int Capacity => myArray.Count();

        /// <summary>
        /// Длина массива.
        /// </summary>
        private int Length => myArray.Length;

        /// <summary>
        /// Создаёт массив с определённой емкостью.
        /// </summary>
        /// <param name="size"> Размер массива </param>
        /// <exception cref="ArgumentNullException"> Проверка длины массива на коррекстность </exception>
        public DynamicArray(int size)
        {
            if(size <= null)
            {
                throw new ArgumentNullException(nameof(size), "Size is null");
            }
            else
            {
                myArray = new T[size];
            }
        }
    }
}
