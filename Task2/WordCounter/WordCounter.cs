using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    /// <summary>
    /// Подсчитывает частоту встречаемости каждого слова в строке
    /// </summary>
    public class WordCounter
    {

        /// <summary>
        /// Проверяет введённую пользователем строку и делит её на подстроки по слову 
        /// </summary>
        /// <param name="stringFromUser">Стрка введённая пользователем</param>
        /// <returns>Массив слов</returns>
        /// <exception cref="NullReferenceException">Если пользователь не ввёл строку</exception>
        /// <exception cref="ArgumentOutOfRangeException">Если пользователь вводит русские буквы</exception>
        public string[] SetWords(string stringFromUser)
        {
            if (String.IsNullOrEmpty(stringFromUser))
            {
                throw new NullReferenceException("String is empty");
            }
            for(var i = 0; i<stringFromUser.Length;i++)
            {
                if (stringFromUser[i] <= 'я' && stringFromUser[i] >= 'а')
                {
                    throw new ArgumentOutOfRangeException("Uncorrect value");
                }
            } 
            string[] setWords = stringFromUser.Split(' ', ',' , '.');
            return setWords;
        }

        /// <summary>
        /// Сравнивает элементы массива на встречаемость и заполняет массив, содержаший слово и частоту его встречаемости
        /// </summary>
        /// <param name="setWords">Массив слов</param>
        /// <returns>Массив частоты слов</returns>
        public object [,] CountWords (string[] setWords)
        {
            var quantity = new List<int>();
            var word = new List<string>();
            for (var i = 0; i < setWords.Length; i++)
            {
                word.Add(setWords[i]);
                quantity.Add(0);
                for (var j = 0; j < setWords.Length; j++)
                {
                   if( word[i].ToLower() == setWords[j].ToLower())
                   {
                        quantity[i]++;
                   }
                }
            }
            var wordQuantity = new object[setWords.Length, 2];
            for (var i = 0; i < setWords.Length; i++)
            {
                wordQuantity[i, 0] = word[i];
                wordQuantity[i, 1] = quantity[i];
                Console.WriteLine($"{ (wordQuantity[i, 0])} : {(wordQuantity[i, 1])}");
            }           
            return wordQuantity;                                                                            
        }
    }
}
