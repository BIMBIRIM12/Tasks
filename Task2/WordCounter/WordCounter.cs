using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{

    /// <summary>
    /// Подсчитывает частоту встречаемости каждого слова в строке.
    /// </summary>
    public class WordCounter
    {

        /// <summary>
        /// Проверяет введённую пользователем строку и делит её на подстроки по слову. 
        /// </summary>
        /// <param name="stringFromUser">Стрка введённая пользователем</param>
        /// <returns>Массив слов</returns>
        /// <exception cref="NullReferenceException">Если пользователь не ввёл строку</exception>
        /// <exception cref="ArgumentOutOfRangeException">Если пользователь вводит русские буквы</exception>
        public string[] GetWords(string stringFromUser)
        {
            if (String.IsNullOrEmpty(stringFromUser))
            {
                throw new NullReferenceException("String is empty");
            }

            for(var i = 0; i<stringFromUser.Length;i++)
            {
                if (stringFromUser[i] <= 'я' && stringFromUser[i] >= 'а')
                {
                    throw new ArgumentOutOfRangeException("Incorrect value");
                }
            } 

            return stringFromUser.Split(' ', ',', '.');
        }

        /// <summary>
        /// Сравнивает элементы массива на встречаемость и заполняет массив, содержаший слово и частоту его встречаемости.
        /// </summary>
        /// <param name="getWords">Массив слов</param>
        /// <returns>Массив частоты слов</returns>
        public Dictionary< string, int> GetWordsQuantity (string[] getWords)
        {
            var wordQuantity = new Dictionary<string,int>();

            for(var i = 0; i < getWords.Length; i++)
            {
                if (wordQuantity.ContainsKey(getWords[i]))
                {
                    wordQuantity[getWords[i]]++;
                }
                else
                {
                    wordQuantity.Add(getWords[i], 1);
                }
            }

            return wordQuantity;                                                                            
        }
    }
}
