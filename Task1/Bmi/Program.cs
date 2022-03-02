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
            BmiCalculator();
        }
        
        public static void BmiCalculator()
        {
            var weight = ToDouble(GetValueFromUser("Введите вес:"));
            var height = ToDouble(GetValueFromUser("Введите рост:"));
            var bmiCalc = new BmiCalc();
            var bmi = bmiCalc.Calculate(weight, height);
            var description = bmiCalc.GetDescription(bmi);
            Console.WriteLine(bmi);
            Console.WriteLine(description);
        }

        /// <summary>
        /// Конвертирует принимаемое от пользователя значение в тип Double и возвращет его 
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        private static double ToDouble(string value)
        {
            return double.Parse(value);
        }

        /// <summary>
        /// Запрашивает у пользователя значение роста и веса, и возвращает принятые значения
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        private static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
    }
}
