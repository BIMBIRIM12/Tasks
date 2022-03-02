using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{

    /// <summary>
    /// высчитывается среднее значение длины слова в строке без учёта знаков препинания
    /// </summary>    
    public class StringAvg
    {
        public string CheckString(string stringFromUser)
        {
            if (stringFromUser == null)
            {
                throw new ArgumentException("Введена пустая строка");
            }
            return stringFromUser;
        }

        /// <summary>
        /// создаётся массив символов, который включает в себя все пробелы и знаки препинания между словами
        /// </summary>
        /// <param name="stringFromUser"> принимается введённую пользователем строка </param>
        /// <returns> возвращает массив с пробелами и знаками препинания, содержащимся во введённой пользователем строке </returns>        
        public char[] SetPunctuations(string stringFromUser)
        {
            var arraySize = stringFromUser.Length;
            char[] punctuationsArray = new char[arraySize];
            for (var i = 0; i < stringFromUser.Length; i++)
            {
                if (char.IsWhiteSpace(stringFromUser[i]) || char.IsPunctuation(stringFromUser[i]) || char.IsNumber(stringFromUser[i]))
                {
                    punctuationsArray[i] = stringFromUser[i];
                }
            }
            return punctuationsArray;
        }

        /// <summary>
        /// разбивает введённую пользователем строку на подстроки по одному слову и заносит это в массив
        /// </summary>
        /// <param name="stringFromUser"> принимает введённую пользователем строку </param>
        /// <param name="punctuation"> принимает массив с разделительными знаками, по которым будет делиться строка</param>
        /// <returns> возвращается массив слов </returns>
        public string[] SetWords(string stringFromUser, char[] punctuation)
        {
            string[] wordsArray = stringFromUser.Split(punctuation);
            return wordsArray;
        }

        /// <summary>
        /// Создаёт массив, содержащий в себе длину каждого из слов, исключая нулевые значения длины
        /// </summary>
        /// <param name="words"> принимает массив слов </param>
        /// <returns> возвращает массив длин слов </returns>
        public int[] SetLengthWords(string[] words)
        {
            var lengthWord = 0;
            int[] lengths = new int[words.Length];
            for (var i = 0; i < words.Length; i++)
            {
                if (words[i].Length != 0)
                {
                    lengthWord = words[i].Length;
                    lengths[i] = lengthWord;
                }
            }
            return lengths;
        }
    }
}

