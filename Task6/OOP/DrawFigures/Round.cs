using System;

namespace DrawFigures
{
    #region Delegates
    // Содержит ссылку на событие, уведомляющее пользователя о завершении формирования круга.
    public delegate void CompleteCalculatesRound(string message);
    #endregion

    /// <summary>
    /// Задаёт круг с определёнными пользователем параметрами.
    /// </summary>
    public class Round
    {
        #region Events
        // Уведомляет пользователя о завершении формирования круга.
        public event CompleteCalculatesRound? CalculatesRoundCompleted;
        #endregion

        #region Fields

        // Радиус круга.
        public readonly double Radius;

        // Х координата центра круга.
        private double CentrDx;

        // Y координата центра круга.
        private double CentrDy;
        #endregion

        #region Properies

        // Длина окружности.
        public double Length { get; set; }

        // Площадь круга.
        public double Area { get; set; }
        #endregion

        #region Constructors

        /// <summary>
        /// Задаёт круг с полученными параметрами, предварительно проверив их на корректность.
        /// </summary>
        /// <param name="radius"> Радиус </param>
        /// <param name="dx"> Х координата круга </param>
        /// <param name="dy"> Y координата круга </param>
        public Round(double radius, double dx, double dy)
        {
            CheckParameters(radius, dx, dy);
            this.CentrDy = dy;
            this.CentrDx = dx;
            this.Radius = radius;
            this.Area = GetArea();
            this.Length = GetLength();     
        }
        #endregion

        #region Methods

        /// <summary>
        /// Проверяет полученные параметры на корректность.
        /// </summary>
        /// <param name="radius"> Радиус круга </param>
        /// <param name="dx"> Х координата круга </param>
        /// <param name="dy"> Y координата круга </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void CheckParameters(double radius, double dx, double dy)
        {
            if (radius <= 0)
                throw new ArgumentNullException(nameof(radius), "Радиус должне быть больше 0");
            if (dx > 200 || dx < 0)
                throw new ArgumentOutOfRangeException( "Координаты должны находиться в диапозоне от 200 до -200");
            if(dy > 200 || dy < 0 )
                throw new ArgumentOutOfRangeException( "Координаты должны находиться в диапозоне от 200 до -200");
            if (200 - dy < radius || 200 - dx < radius)
                throw new ArgumentOutOfRangeException("Выход за границы плоскости");
        }
        /// <summary>
        /// Возвращает вычисленную длину окружности.
        /// </summary>
        /// <returns> Длину окружности </returns>
        public double GetLength()
        {
            return Math.Round(Math.PI * Math.Pow(Radius, 2),2);
        }

        /// <summary>
        /// Возвращает вычисленную площадь круга.
        /// </summary>
        /// <returns> Площадь круга </returns>
        public double GetArea()
        {
            return Math.Round(2 * (Math.PI * Radius),2);
        }  

        /// <summary>
        /// Передвигает круг на указанное расстояние, предварительно проверив параметры.
        /// </summary>
        /// <param name="moveToX"> Передвижение по координате Х </param>
        /// <param name="moveToY"> Передвижение по координате Y </param>
        public void Move(double moveToX, double moveToY)
        {
            TestMove(moveToX, moveToY);
            this.CentrDx += moveToX;
            this.CentrDy += moveToY;
            ShowMove();
        }

        /// <summary>
        /// Проверяет корректность параметров.
        /// </summary>
        /// <param name="moveToX"> Передвижение по координате Х </param>
        /// <param name="moveToY"> Передвижение по координате Y </param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public void TestMove(double moveToX, double moveToY)
        {
            if (moveToX + this.CentrDx + this.Radius > 200 || moveToY + this.CentrDy + this.Radius > 200)
                throw new ArgumentOutOfRangeException("Выход за пределы плоскости");
        }
        
        /// <summary>
        /// Выводит результаты вычислений на консоль.
        /// </summary>
        public virtual void Show()
        {
            CalculatesRoundCompleted?.Invoke("КРУГ СФОРМИРОВАН \n");
            Console.WriteLine("Длина круга = {0} mm \nПлощадь круга = {1} mm^2 ",Length, Area);
        }

        /// <summary>
        /// Выводит результаты передвижения на консоль.
        /// </summary>
        public void ShowMove()
        {
            Console.WriteLine("Координаты центра после измененния : X = {0} mm, Y = {1} mm", CentrDx, CentrDy);
        }
        #endregion
    }
}
