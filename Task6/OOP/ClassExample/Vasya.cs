using System;

namespace ClassExample
{
    /// <summary>
    /// Задаёт параметры для Васи.
    /// </summary>
    public class Vasya : Human, IVasyaFindJob
    {
        #region Properties

        // Имя человека.
        public override string Name { get; }

        // Фамилия человека.
        public override string Surname { get; }

        // Возраст человека.
        public override int Age { get; }

        // Профессия человека.
        public string Profession { get; set; }

        // Город обитания человека.
        public string Place  { get; set; }

        // Пол человека.
        public override string Gender { get; }

        // Национальность человека.
        public override string Nationality { get; }

        #endregion

        #region Constructors
        /// <summary>
        /// Конструктор Васи.
        /// </summary>
        public Vasya()
        {
            this.Name = "Vasya";
            this.Surname = "Kibardin";
            this.Age = 21;
            this.Nationality = "Russian";
            this.Gender = "Male";
        }
        #endregion

        #region Methods
        /// <summary>
        /// Вася уезжает в Москву, местом его жизни пока является Киров.
        /// </summary>
        public virtual void VasyaGoToMoscow()
        {
            this.Place = "Kirov";          
        }

        /// <summary>
        /// До отъезда в Москву Вася был безработным.
        /// </summary>
        public void VasyaFindJob()
        {
            this.Profession = "Unemployed";
        }
        #endregion
    }
}
