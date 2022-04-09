using System;

namespace ClassExample
{
    /// <summary>
    /// Это история про молодого парня Васю из города Кирова, который отправился за своей мечтой в Москву.
    /// </summary>
    public class Program
    {
        static void Main()
        {
            SetVasya();
            SetVasyaArrivedMoscow();
        }

        /// <summary>
        /// Задаёт параметры для Васи.
        /// </summary>
        public static void SetVasya()
        {
            var vasya = new Vasya();
            vasya.VasyaGoToMoscow();           
            vasya.VasyaFindJob();         
        }

        /// <summary>
        /// Задаёт параметры для Васи, переехавшего в Москву.
        /// </summary>
        public static void SetVasyaArrivedMoscow()
        {
            var vasyaArrivedMoscow = new VasyaArrivedMoscow();
            vasyaArrivedMoscow.VasyaGoToMoscow();
            vasyaArrivedMoscow.VasyaFindJob();
        }
    }
}