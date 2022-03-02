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
           // var stringChecking = wordCounter.CheckString(stringFromUser);
            var wordQuantity = wordCounter.CounterWords(setWords);
            
            
           
        }

        private static string GetStringFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}