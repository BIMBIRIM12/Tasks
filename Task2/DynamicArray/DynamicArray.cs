using System;
using System.Collections;
using System.Collections.Generic;
namespace DynamicArray
{

    /// <summary>
    /// Создается динамически расширяемый массив на основе обычного, и проводяться операции с ним.
    /// </summary>
    /// <typeparam name="T">Тип значений массива</typeparam>
    public class DynamicArray<T>
    {
        private T[] myArray { get; set; }
        #region Parameters
        /// <summary>
        /// Длина массива
        /// </summary>
        private int Length => myArray.Length;

        /// <summary>
        /// Емкость массива - внутренняя длина массива.
        /// </summary>
        private int Capacity => myArray.Count();

        /// <summary>
        /// Длина массива.
        /// </summary>
        public const int Size = 19;
        #endregion
        /// <summary>
        /// Создаёт массив с длиной 8.
        /// </summary>
        public DynamicArray()
        {       
            myArray = new T[8];            
        }

        /// <summary>
        /// Создаёт массив фиксированной длины.
        /// </summary>
        /// <param name="Size"> Длина массива </param>
        /// <exception cref="ArgumentNullException"> Проверка длины на нулевое/отрицательное значение </exception>
        public DynamicArray(int Size)
        {
            if(Size <= 0)
            {
                throw new ArgumentNullException(nameof(Size), "Size is null or lass than zero ");
            }
            else
            {
                myArray = new T[Size];
            } 
        }

        /// <summary>
        /// Создаёт массив и передаёт в неё элементы коллекции.
        /// </summary>
        /// <param name="yourList"> Список, реализующий интерфейс IEnumerable </param>
        /// <exception cref="ArgumentNullException"> Проверка коллекции на наличие значений </exception>
        public DynamicArray(IEnumerable<T> yourList)
        {
            if (yourList == null)
            {
                throw new ArgumentNullException(nameof(yourList), "yourList is null");
            }
            else
            {
                var array = yourList.ToArray();
            } 
        }
        #region ChangesArray      
        /// <summary>
        /// Добавляет в конец массива элемент.
        /// </summary>
        /// <param name="item"> Элемент, который необходимо добавить </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"> Проверка элемента на нулевое значение </exception>
        public T[] Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item is null");
            }
            else
            {
                if (Capacity + 1 < Length)
                {
                    myArray.Append(item);
                    return myArray;
                }
                else
                {
                    myArray = new T[myArray.Length * 2];
                    myArray.Append(item);
                    return myArray;
                    
                }
            }
        }

        /// <summary>
        /// Добавляет в массив коллекцию.
        /// </summary>
        /// <param name="yourList"> Коллекция, реализующая интерфейс IEnumerable </param>
        /// <returns> Заполненный массив </returns>
        /// <exception cref="ArgumentNullException"> Проверка коллекции на наличие значений </exception>
        public T[] AddRange(IEnumerable<T> yourList)
        {
            if(yourList == null)
            {
                throw new ArgumentNullException(nameof(yourList), "yourList is null");
            }
            else
            {
                if (Capacity + yourList.Count() < Length)
                {
                    for (var i = Capacity; i < yourList.Count(); i++)
                    {
                        myArray[i] = yourList.ElementAt(i - Capacity);
                    }

                    return myArray;
                }
                else
                {
                    myArray = new T[myArray.Length * 2];
                    for(var i = Capacity; i< yourList.Count(); i++)
                    {
                        myArray[i] = yourList.ElementAt(i - Capacity);
                    }

                    return myArray;
                }
            }
        }

        /// <summary>
        /// Удаляет элемент из массива по указанному индексу.
        /// </summary>
        /// <param name="Index"> Индекс элемента </param>
        /// <returns> Результат удаления </returns>
        /// <exception cref="IndexOutOfRangeException"> Проверка индекса на наличие в массиве </exception>
        public bool Remove (int Index)
        {
            if(Index > Capacity | Index < Capacity)
            {
                throw new IndexOutOfRangeException(nameof(Index));
            }
            else
            {
                myArray[Index] = default(T);
                return true;
            }
        }

        /// <summary>
        /// Добавления элемента по указанному индексу в массив.
        /// </summary>
        /// <param name="item"> Добавляемый элемент </param>
        /// <param name="Index"> Индекс элемента </param>
        /// <returns> Результат добавления </returns>
        public bool Insert(T item, int Index)
        {
            if (Capacity + 1 >= Length)
            {
                myArray = new T[myArray.Length + 1];
                for(var i = Capacity - 1; i >=Index ; i--)
                {
                    myArray[i] = myArray[i + 1];
                    myArray[Index] = item;
                }
                return true;
            }
            else
            {
                for (var i = Capacity - 1; i >= Index; i--)
                {
                    myArray[i] = myArray[i + 1];
                    myArray[Index] = item;
                }
                return true;
            }
        }
        #endregion
        /// <summary>
        /// Индексатор, позволяющий работать с элементом массива по указанному индексу.
        /// </summary>
        /// <param name="Index"> Индекс элемента </param>
        /// <returns> Элемент </returns>
        /// <exception cref="IndexOutOfRangeException"> Проверка на наличие элемента с таким индексом в массиве </exception>
        public T this[int Index]
        {
            get
            {
                if (Index >= Length)
                {
                    throw new IndexOutOfRangeException(nameof(Index));
                }
                else
                {
                    var element = myArray[Index];
                    return element;
                }
            }
        }
    }  
}
