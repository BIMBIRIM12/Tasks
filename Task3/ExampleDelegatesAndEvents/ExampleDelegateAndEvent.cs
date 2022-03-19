using System;

namespace Program
{
    #region Delegates
    // Содержит ссылку на метод, уведомляющий пользователя о завершении сравнения.
    public delegate void CompleteComparesMessage(string message);

    ///Содержит ссылку на метод, сравнивающий введённое пользователем число с 10.
    public delegate bool CompareNumberAndTen(int number);

    ///Содержит ссылку на метод, сравнивающий введённое пользователем число с 100.
    public delegate bool CompareNumberAndOneHundred(int number);

    ///Содержит ссылку на метод, сравнивающий введённое пользователем число с 1000.
    public delegate bool ComparingNumbersAndOneThousand(int number);
    #endregion

    /// <summary>
    /// Представляет сравнение введённого пользователем числа с 10, 100 и 1000 и возвращает результат.
    /// </summary>
    public class ExampleDelegateAndEvent
    {
        #region Events
        //Уведомляет пользователя о завершении сортировки. 
        public event CompleteComparesMessage? ComparedCompleted;

        ///Содержит ссылку на метод, сравнивающий введённое пользователем число с 1000.
        public event ComparingNumbersAndOneThousand? ComparingWithOneThousand;
        #endregion
        #region Methods
        /// <summary>
        /// Принимает число от пользователя и передаёт для сравнения в методы.
        /// </summary>
        /// <param name="number"> число от пользователя </param>
        public void CompareNumbers(int number)
        {
            CompareNumberAndTen compareTen = new(CompareNumbersAndTen);
            var value = compareTen(number);

            CompareNumberAndOneHundred(number);

            ComparingWithOneThousand += CompareNumbersAndOneThousand;
            ComparingWithOneThousand(number);

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
            return (number > 10);       
        }

        /// <summary>
        /// Принимает число через событие и сравнивает его с 1000.
        /// </summary>
        /// <param name="number"> Число от пользователя </param>
        /// <returns> Резуьтат сравнения </returns>
        public bool CompareNumbersAndOneThousand(int number)
        {
            return (number > 1000);
        }

        /// <summary>
        /// Сравнивает число от пользователя с 1000 через лямбду-выражение.
        /// </summary>
        /// <param name="number"> Число от пользователя </param>
        /// <returns> Результат сравнения </returns>
        public bool CompareNumberAndOneHundred(int number)
        {
            CompareNumberAndOneHundred compareNumberAndOneHundred = (number) => number > 100;
            return compareNumberAndOneHundred(number);     
        }
        #endregion
        #endregion
    }
}
