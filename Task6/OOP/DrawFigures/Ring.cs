using System;

namespace DrawFigures
{
    #region Delgates
    // Содержит ссылку на событие, уведомляющее пользователя о том, что формирование кольца завершено.
    public delegate void CompleteCalculatesRing (string message);
    #endregion 

    public class Ring : Round
    {
        #region Events
        // Уведомляет пользователя о завершении формировния кольца.
        public event CompleteCalculatesRing CalculatesRingCompleted;
        #endregion

        #region Properties

        // Внутренний радиус круга.
        private double InternalRadius { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Задаёт параметры кольца, переопределяет нахождение площади для кольца, проверяет параметры на корректность.
        /// </summary>
        /// <param name="internalRadius"> Внутренний радиус кольца </param>
        /// <param name="radius"> Внешний радиус кольца </param>
        /// <param name="dx"> Х координата центра </param>
        /// <param name="dy"> Y координата центра </param>
        public Ring(double internalRadius, double radius, double dx, double dy) : base(radius, dx, dy)
        {
            CheckRing(internalRadius);
            this.InternalRadius = internalRadius;
            this.Area = Math.Round(GetRingArea(),2);
        }
        #endregion

        #region Methods

        /// <summary>
        /// Проверяет внутренний радиус на корректность.
        /// </summary>
        /// <param name="internalRadius"> Внутренний радиус кольца </param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void CheckRing(double internalRadius)
        {
            if (internalRadius >= this.Radius)
                throw new ArgumentOutOfRangeException("Внешний радиус не может быть больше или равен внетреннему");
        }

        /// <summary>
        /// Возвращает вычисленную площадь кольца.
        /// </summary>
        /// <returns> Площадь кольца </returns>
        public double GetRingArea()
        {
            return (Math.PI * Math.Pow(this.Radius, 2)) - (Math.PI * Math.Pow(this.InternalRadius, 2));            
        }

        /// <summary>
        /// Выводит результаты вычислений на консоль.
        /// </summary>
        public override void Show()
        {
            CalculatesRingCompleted?.Invoke("КОЛЬЦО СФОРМИРОВАНО \n");
            Console.WriteLine("Площадь кольца  = {0} mm^2", Area);
        }
        #endregion
    }
}
