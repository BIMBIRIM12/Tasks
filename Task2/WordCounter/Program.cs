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
           // var checkingString = wordCounter.CheckString(stringFromUser);
            var setPunctuations = wordCounter.SetPunctuations(stringFromUser);
            var setWords = wordCounter.SetWords(setPunctuations, stringFromUser);
            var wordQuantity = wordCounter.CounterWords(setWords);
            for (int i = 0; i < wordQuantity.GetLength(0); i++)
            {
                Console.WriteLine($"{wordQuantity[i, 0]}: {wordQuantity[i, 1]}");
            }
            Console.ReadLine();
        }

        private static string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}