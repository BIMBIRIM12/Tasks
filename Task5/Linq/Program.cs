using System;
using System.Collections.Generic;
using System.Linq;

namespace LinQExample
{
    class Program
    {
        static void Main()
        {
            GetListInt();
            Person.GetListPerson();
        }

        /// <summary>
        /// Создаётся список целых чисел от 1 до 10 и демонстрируются некоторые Linq операции для работы с ним.
        /// </summary>
        public static void GetListInt()
        {
            var numbers = new List<int>();
            for(var i = 1; i < 11; i++)
            {
                numbers.Add(i);
            }
            #region LinqOperations
            var castListIntToStringArary = numbers.Cast<int>();// Преобразует список чисел в простой массив чисел.
            var listToArray = numbers.ToArray(); // Преобразование списка int значений в массив.         
            var arrayToList = listToArray.ToList<int>(); // Преобразование массива в список int значений.
            var listTake8 = numbers.Take(8); // Взять только первые 8 элементов списка.
            var listSkip5 = numbers.Skip(5); // Пропустить первые 5 элементов списка.
            var listOrderBy = numbers.OrderByDescending(n => n); // Сортировка списка по убыванию.
            var listAny = numbers.Any(n => n==5); // Проверка на наличие элемента 5 в списке.
            var lisAll = numbers.All(n => n == 4); // Проверка на то, все ли элементы списка это 4.
            var firstElement = numbers.First(); // Первый элемент списка.
            var firstElementMultipleThree = numbers.First(n => n % 3 == 0); // Первый элемент списка, кратный 3.
            var agregatedNumbers = numbers.Aggregate((a, b) => (a * b));// Произведение всех элементов списка.
            #endregion


        }
    }
}