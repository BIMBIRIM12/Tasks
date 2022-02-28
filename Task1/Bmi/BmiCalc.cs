using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Вычисляет индекс массы тела человека и описание к нему.
    /// </summary>
    public class BmiCalc
    {
        /// <summary>
        /// Вычисляет ИМТ по входным параметрам роста и веса.
        /// </summary>
        /// <param name="weight">принимаемый параметр веса</param>
        /// <param name="height">принимаемый параметр роста</param>
        /// <returns></returns>
        public double Calculate(double weight, double height)
        {
            if (weight > 400 || weight < 10)
            {
                throw new ArgumentOutOfRangeException("Вес должен находиться в диапозоне от 5 до 400 кг");
            }
            if (height < 50 || height > 300)
            {
                throw new ArgumentOutOfRangeException("Рост должен быть в диапозоне от 50 до 300 см");
            }
            double bmi;
            bmi = (weight * 10000 / Math.Pow(height, 2));
            return bmi;
        }

        /// <summary>
        /// Возвращет описание ИМТ по вычисленному значению.
        /// </summary>
        /// <param name="bmi">вычисленный ИМТ</param>
        /// <returns>описание для человека</returns>
        public string GetDescription(double bmi)
        {
            string description;
            if (bmi < 16)
            {
                description = "Выраженный дефицит массы тела";
            }
            else if (bmi >= 16 && bmi <= 18.5)
            {
                description = "Недостаточная масса тела";

            }
            else if (bmi >= 18.5 && bmi <= 25)
            {
                description = "Всё в норме";
            }
            else if (bmi >= 25 && bmi <= 30)
            {
                description = "1-ая степень ожирения";
            }
            else if (bmi >= 30 && bmi <= 35)
            {
                description = "2-ая степень ожирения";
            }
            else
            {
                description = "3-ая степень ожирения";

            }
            return description;
        }

    }
}


