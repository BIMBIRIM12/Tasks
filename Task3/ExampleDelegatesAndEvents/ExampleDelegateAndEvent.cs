using System;

namespace Program
{
    #region Delegates
    public delegate void CompleteComparesMessage(string message);

    public delegate bool CompareNumberAndTen(int number);

    public delegate bool CompareNumberAndOneHundred(int number);

    public delegate bool ComparingNumbersAndOneThousand(int number);
    #endregion

    public class ExampleDelegateAndEvent
    {
        /// <summary>
        /// Представляет сравнение введённого пользователем числа с 10, 100 и 1000 и возвращает результат.
        /// </summary>
        #region Events
        public event CompleteComparesMessage? ComparedCompleted;

        public event ComparingNumbersAndOneThousand? ComparingWithOneThousand;
        #endregion

        /// <summary>
        /// Принимает число от пользователя и передаёт для сравнения в методы.
        /// </summary>
        /// <param name="number"> число от пользователя </param>
        public void CompareNumbers(int number)
        {
            CompareNumberAndTen compareTen = new(CompareNumbersAndTen);
            var value = compareTen(number);
            Console.WriteLine($"{number} > 10 = {value}");

            CompareNumberAndOneHundred(number);

            ComparingWithOneThousand += CompareNumbersAndOneThousand;
            Console.WriteLine($"{number} > 1000 = {ComparingWithOneThousand(number)}");
            ComparedCompleted?.Invoke("Compare complete");
        }
        #region Compare

        /// <summary>
        /// Принимает число через делегат и сравнивает его с 10.
        /// </summary>
        /// <param name="number"> Число от пользователя </param>
        /// <returns> Результат сравнения </returns>
        public bool CompareNumbersAndTen(int number)
        {
            if (number > 10)
            {               
                return true; 
            }
            else
            {
                return false;              
            }
        }

        /// <summary>
        /// Принимает число через событие и сравнивает его с 1000.
        /// </summary>
        /// <param name="number"> Число от пользователя </param>
        /// <returns> Резуьтат сравнения </returns>
        public bool CompareNumbersAndOneThousand(int number)
        { 
            if (number > 1000)
            {               
                return true;
            }
            else
            {               
                return false;
            }           
        }

        /// <summary>
        /// Сравнивает число от пользователя с 1000 через лямбду-выражение.
        /// </summary>
        /// <param name="number"> Число от пользователя </param>
        /// <returns> Результат сравнения </returns>
        public bool CompareNumberAndOneHundred(int number)
        {
            CompareNumberAndOneHundred compareNumberAndOneHundred = (number) => number > 100;
            bool result = compareNumberAndOneHundred(number);
            Console.WriteLine($"{number} > 100 = {result}");
            return result;
        }
        #endregion
    }
}
