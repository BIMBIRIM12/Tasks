using System;
using System.Collections.Generic;

namespace Program
{

    /// <summary>
    /// Представляет примеры работ с разными видами коллекций.
    /// </summary>
    public class ExampleCollections
    {
        static void Main()
        {
            var list = GetExampleList();
            var dictionary = GetExampleDictionary(list);
            var stack = GetExampleStack(list);
            var queue = GetExampleQueue(list);
        }

        /// <summary>
        /// Представляет пример создания, добавление, удаления, сортировки элементов списка.
        /// </summary>
        /// <returns> Список с названиями автомобилей </returns>
        public static List<string> GetExampleList()
        {
            var carsBrand = new List<string>();
            carsBrand.Add("Lada");
            carsBrand.Add("BMW");
            carsBrand.Add("Bugatti");
            carsBrand.Add("Aston Martin");
            carsBrand.Remove(carsBrand[0]);
            carsBrand.Sort();
            return carsBrand;
        }

        /// <summary>
        /// Представляет пример создания, заполнения, добавления и удаления элементов словаря. 
        /// </summary>
        /// <param name="list"> Список с марками автомобилей </param>
        /// <returns> Словарь, содержащий список марок автомобилей и частоту их встречаемости </returns>
        /// <exception cref="ArgumentNullException"> Проверка входящего списка на наличие элементов </exception>
        public static Dictionary<string, int> GetExampleDictionary(List<string> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "List is null");
            }
            else
            {
                var cars = new Dictionary<string, int>();
                for (var i = 0; i < list.Count; i++)
                {
                    if (cars.ContainsKey(list[i]))
                    {
                        cars[list[i]]++;
                    }
                    else
                    {
                        cars.Add(list[i], 1);
                    }
                }

                cars.Add("Reanault", 1);
                cars.Remove("Renault");
                return cars;
            }

        }

        /// <summary>
        /// Представляет пример создания, заполнения и удаления элементов стэка.
        /// </summary>
        /// <param name="list"> Список с марками автомобилей </param>
        /// <returns> Стэк с марками автомобилей </returns>
        /// <exception cref="ArgumentNullException"> Проверка входящего списка на наличие элементов </exception>
        public static Stack<string> GetExampleStack(List<string> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "List is null");
            }
            else
            {
                var stackCars = new Stack<string>();
                for (var i = 0; i < list.Count; i++)
                {
                    stackCars.Push(list[i]);
                }

                stackCars.Pop();
                return stackCars;
            }
        }

        /// <summary>
        /// Представляет пример создания, заполнения, добавления и удаления элементов очереди.
        /// </summary>
        /// <param name="list"> Список с марками автомобилей </param>
        /// <returns> Очередь с марками автомобилей </returns>
        /// <exception cref="ArgumentNullException"> Проверка входящего списка на наличие значений </exception>
        public static Queue<string> GetExampleQueue (List<string> list)
        {
            if (list == null)
            {
                throw new ArgumentNullException(nameof(list), "List is null");
            }
            else
            {
                var queueCars = new Queue<string>();
                for (var i = 0; i < list.Count; i++)
                {
                    queueCars.Enqueue(list[i]);
                }

                queueCars.Dequeue();
                return queueCars;
            }
        }
    }
}
