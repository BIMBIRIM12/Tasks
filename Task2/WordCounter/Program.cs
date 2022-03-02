using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{   
    class Program
    {
        static void Main()
        {
            StringOperations();
        }

        public static void StringOperations()
        {
            var stringFromUser = GetStringFromUser("Please enter English string");
            var wordCounter = new WordCounter();                     
            var setWords = wordCounter.SetWords( stringFromUser);
            var wordQuantity = wordCounter.CountWords(setWords);                                  
        }

        /// <summary>
        /// Запрашивает у пользователя строку, принимает её и переводит в нижний регистр
        /// </summary>
        /// <param name="message">Сообщение для пользователя</param>
        /// <returns>Строку от пользователя в нижнем регистре</returns>
        private static string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine().ToLower();
        }
    }
}