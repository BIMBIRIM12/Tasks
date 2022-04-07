using System;

namespace DrawFigures
{
    public class WorkFigures
    {
        #region Methods
        static void Main()
        {
            SetRound();           
        }

        /// <summary>
        /// Передаёт кругу параметры, выводит на консоль результаты вычислений и вызывает метод построения кольца.
        /// </summary>
        public static void SetRound()
        {
            var dx = ToDouble(GetValueFromUser("Введите X координату центра"));
            var dy = ToDouble(GetValueFromUser("Введите Y координату центра"));
            var radius = ToDouble(GetValueFromUser("Введите внешний радиус "));
            CheckParameters(dx, dy, radius);

            var round = new Round(radius, dx, dy);

            void DisplayMessage(string message) => Console.WriteLine(message);
            round.CalculatesRoundCompleted += DisplayMessage;
            round.Show();
            round.CalculatesRoundCompleted -= DisplayMessage;

            SetRing(radius, dx, dy);
            MoveRound(round);
        }

        /// <summary>
        /// Передаёт круга параметры и выводит результаты вычислений на консоль.
        /// </summary>
        /// <param name="radius"> Радиус круга </param>
        /// <param name="dx"> Х координата центра круга </param>
        /// <param name="dy"> Y координата центра кргуа </param>
        public static void SetRing(double radius, double dx, double dy)
        {
            var internalRadius = (ToDouble(GetValueFromUser("Введите внутренний радиус кольца")));
            var ring = new Ring(internalRadius, radius, dx, dy);
            void DisplayMessage(string message) => Console.WriteLine(message);
            ring.CalculatesRingCompleted += DisplayMessage;
            ring.Show();
            ring.CalculatesRingCompleted -= DisplayMessage;
        }

        /// <summary>
        /// Передаёт методу передвижения круга необходимые параметры и выводит результат на консоль.
        /// </summary>
        /// <param name="round"> Экземпляр круга </param>
        public static void MoveRound(Round round)
        {
            var moveToX = ToDouble(GetValueFromUser("На сколько миллиметров по X хотите передвинуть круг"));
            var moveToY = ToDouble(GetValueFromUser("На сколько миллиметров по Y хотите передвинуть круг"));
            round.Move(moveToX, moveToY);
        }

        /// <summary>
        /// Конвертирует параметры, введённые пользователем в числовой формат.
        /// </summary>
        /// <param name="value"> Параметры от пользователя </param>
        /// <returns> Параметры от пользователя в цифровом формате </returns>
        /// <exception cref="ArgumentNullException"> Проверка на пустое значение от пользователя </exception>
        public static double ToDouble(string value)
        {
            if (String.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException();
            return double.Parse(value);
        }

        /// <summary>
        /// Запрашивает и принимает от пользователя параметры.
        /// </summary>
        /// <param name="message"> Сообщение для пользователя </param>
        /// <returns></returns>
        public static string GetValueFromUser(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        /// <summary>
        /// Проверяет параметры на корректность значений.
        /// </summary>
        /// <param name="dx"> Х координата центра </param>
        /// <param name="dy"> Y координата центра </param>
        /// <param name="radius"> Радиус  </param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckParameters(double dx, double dy,double radius)
        {
            if (dx < 0 || dx > 200)
                throw new ArgumentOutOfRangeException("Координата X должна быть в пределах от 0 до 200");
            if (dy < 0 || dy > 200)
                throw new ArgumentOutOfRangeException("Координата Y должна быть в пределах от 0 до 200");
            if (radius > 100 || radius < 0)
                throw new ArgumentOutOfRangeException("Длина радиуса должна быть в пределах от 0 до 100");
        }
        #endregion
    }
}