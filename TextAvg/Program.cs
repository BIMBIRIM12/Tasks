using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class AvgString
    {
        static void Main(string[] args)
        {
            StringOperations();
        }

        public static void StringOperations()
        {
            var stringFromUser = GetValueFromUser("Please enter string");
            var stringAvg = new StringAvg();
            var checkingString = stringAvg.CheckString(stringFromUser);
            char[] punctuation = stringAvg.SetPunctuations(stringFromUser);
            string[] words = stringAvg.SetWords(stringFromUser, punctuation);
            int[] lengths = stringAvg.SetLengthWords(words);
            var avg = lengths.Average();
            Console.WriteLine("Среднее количество букв в слове по строке = " + avg);
        }

        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}