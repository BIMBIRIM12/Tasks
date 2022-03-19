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
        #region Parameters
        private T[] array;
     
        /// <summary>
        /// Длина массива
        /// </summary>
        private int Length => array.Length;

        /// <summary>
        /// Емкость массива - внутренняя длина массива.
        /// </summary>
        private int Capacity { get; set; }
        

        #region Constants
        // Задаёт размер массива
        private const int DefaultSize = 8;
        #endregion
        /// <summary>
        /// Получить внутреннюю длину массива.
        /// </summary>
        /// <param name="array"> Массив </param>
        /// <returns></returns>
        public int GetCapacity(T[] array)
        {
            for(var i = 0; i < array.Length; i++)
            {
                if(array[i] != null)
                {
                    Capacity++;
                }
            }

            return Capacity;
        }
        #endregion
        #region CreateArray
        /// <summary>
        /// Создаёт массив с длиной 8.
        /// </summary>
        /// 
        public DynamicArray()
        {
            if (DefaultSize <= 0)
            {
                throw new ArgumentNullException(nameof(DefaultSize), "Size is null or lass than zero ");
            }

            array = new T[DefaultSize];            
        }

        /// <summary>
        /// Создаёт массив фиксированной длины.
        /// </summary>
        /// <param name="size"> Длина массива </param>
        /// <exception cref="ArgumentNullException"> Проверка длины на нулевое/отрицательное значение </exception>
        public DynamicArray(int size)
        {
            if(size <= 0)
            {
                throw new ArgumentNullException(nameof(size), "Size is null or lass than zero ");
            }

            array = new T[size];                        
        }

        /// <summary>
        /// Создаёт массив и передаёт в неё элементы коллекции.
        /// </summary>
        /// <param name="yourList"> Список, реализующий интерфейс IEnumerable </param>
        /// <exception cref="ArgumentNullException"> Проверка коллекции на наличие значений </exception>
        public DynamicArray(IEnumerable<T> numbers)
        {
            if (numbers == null)
            {
                throw new ArgumentNullException(nameof(numbers), "yourList is null");
            }

            array = numbers.ToArray();  
            foreach(var number in array)
            {
                Console.WriteLine(number);
            }
        }
        #endregion
        #region ChangeArray      
        /// <summary>
        /// Добавляет в конец массива элемент.
        /// </summary>
        /// <param name="item"> Элемент, который необходимо добавить </param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"> Проверка элемента на нулевое значение </exception>
        public void Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item is null");
            }

            AddRange(new List <T> { item });          
        }

        /// <summary>
        /// Добавляет в массив коллекцию.
        /// </summary>
        /// <param name="list"> Коллекция, реализующая интерфейс IEnumerable </param>
        /// <returns> Заполненный массив </returns>
        /// <exception cref="ArgumentNullException"> Проверка коллекции на наличие значений </exception>
        public void AddRange(IEnumerable<T> list)
        {
            if (Capacity + list.Count() <= Length)
            {
                 for (var i = Capacity; i < list.Count(); i++)
                 {
                      array[i] = list.ElementAt(i - Capacity);
                 }
            }
            else
            {
                 array = new T[array.Length * 2];
                 for(var i = Capacity; i< list.Count(); i++)
                 {
                      array[i] = list.ElementAt(i - Capacity);
                 }
            }           
            
        }

        /// <summary>
        /// Удаляет элемент из массива по указанному индексу.
        /// </summary>
        /// <param name="index"> Индекс элемента </param>
        /// <returns> Результат удаления </returns>
        /// <exception cref="IndexOutOfRangeException"> Проверка индекса на наличие в массиве </exception>
        public bool Remove (int index)
        {
            if(index > Length -1 )
            {
                throw new IndexOutOfRangeException(nameof(index));
            }

            for(var i = index; i < Length-1; i++)
            {
                array[i] = array[i+1]; 
            }

            array[Length - 1] = default(T);          
            return true;
        }

        /// <summary>
        /// Добавления элемента по указанному индексу в массив.
        /// </summary>
        /// <param name="item"> Добавляемый элемент </param>
        /// <param name="index"> Индекс элемента </param>
        /// <returns> Результат добавления </returns>
        public bool Insert(T item, int index)
        {
            if(item == null )
            {
                throw new ArgumentNullException(nameof(item), "Item is null");
            }

            if (index < 0)
            {
                throw new IndexOutOfRangeException();
            }

            if (Capacity + 1 > Length)
            {
                array = new T[array.Length + 1];
                for(var i = Capacity - 1; i >=index ; i--)
                {
                    array[i] = array[i + 1];                  
                }

                array[index] = item;               
                return true;
            }
            else
            {
                for (var i = Capacity - 1; i >= index; i--)
                {
                    array[i] = array[i + 1];                  
                }

                array[index] = item;               
                return true;
            }
          

        }
        #endregion
        #region Indexer
        /// <summary>
        /// Индексатор, позволяющий работать с элементом массива по указанному индексу.
        /// </summary>
        /// <param name="index"> Индекс элемента </param>
        /// <returns> Элемент </returns>
        /// <exception cref="IndexOutOfRangeException"> Проверка на наличие элемента с таким индексом в массиве </exception>
        public T this[int index]
        {
            get
            {
                if (index >= Length)
                {
                    throw new IndexOutOfRangeException(nameof(index));
                }
                Console.WriteLine(array[index]);
                return array[index];
                                                            
            }
        }
        #endregion
    }
}
