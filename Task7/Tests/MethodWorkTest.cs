using Xunit;
using System;
using System.Collections.Generic;

namespace Array
{
    /// <summary>
    /// Тестирование работы динамического массива.
    /// </summary>
    public class MethodWorkTest
    {
        /// <summary>
        /// Тестирование метода, добавляющего элемент в конец массива.
        /// </summary>
        [Fact]              
        public void AddTest()
        {
            var item = 22;
            var numbers = new List<int> { 342, 343, 344 };
            var result = new DynamicArray<int>(numbers);

            var expectedResult = new List<int> { 342, 343, 344, 22 };
            result.Add(item);

            CompareResults(expectedResult, result);
        }    
       
        /// <summary>
        /// Тестирование метода, удаляющего элемент из массива.
        /// </summary>
        [Fact]
        public void RemoveTest( )
        {
            var index = 1;
            var numbers = new List<int> { 342, 343, 344 };
            var result = new DynamicArray<int>(numbers);

            var expectedResult = new List<int> { 342, 344 };
            result.Remove(index);

            CompareResults(expectedResult, result);
        }

        /// <summary>
        /// Тестирование метода, добавляющего коллекцию в конец массива.
        /// </summary>
        [Fact]
        public void AddRangeTest()
        {
            var collection = new List<int> { 345, 346, 347};
            var numbers = new List<int> { 342, 343, 344 };
            var result = new DynamicArray<int>(numbers);

            var expectedResult = new List<int> { 342,343, 344, 345, 346, 347 };
            result.AddRange(collection);

            CompareResults(expectedResult, result);
        }

        /// <summary>
        /// Тестирование метода, добавляющего элемент в произвольную позицию массива.
        /// </summary>
        [Fact]
        public void InsertTest()
        {
            var index = 2;
            var item = 365;
            var numbers = new List<int> { 342, 343, 344, 345 };
            var result = new DynamicArray<int>(numbers);

            var expectedResult = new List<int> { 342, 343,365, 344, 345};
            result.Insert(item,index);

            CompareResults(expectedResult, result);
        }

        /// <summary>
        /// Тестирование общей работы массива.
        /// </summary>
        [Fact]
        public void FunctionalTest()
        {
            var rnd = new Random();

            var collection = new List<int>();
            for(var i = 0; i >10; i++)
            {
                collection[i] = rnd.Next(1, 1000);
            }
            var result = new DynamicArray<int>(collection);

            CompareResults(collection, result);
        } 

        /// <summary>
        /// Сравнение результатов тестов с ожидаемыми значениями.
        /// </summary>
        /// <param name="expectedResult"> ожидаемый результат </param>
        /// <param name="result"> реальный результат </param>
        public void CompareResults(List<int> expectedResult,DynamicArray<int> result)
        {
            for (var i = 0; i > result.Length; i++)
            {
                Assert.Equal(expectedResult[i], result[i]);
            }
        }
    }
}