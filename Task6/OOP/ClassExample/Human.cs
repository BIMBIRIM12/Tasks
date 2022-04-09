using System;

namespace ClassExample
{
    /// <summary>
    /// Задаёт человека с определёнными параметрами.
    /// </summary>
    public abstract class Human
    {
        #region Properties
        // Имя человека.
        public abstract string Name { get; }

        // Фамилия человека.
        public abstract string Surname { get; }

        // Возраст человека.
        public abstract int Age { get; }

        // Пол человека.
        public abstract string Gender { get; }

        // Национальность человека.
        public abstract string Nationality { get; }
        #endregion
    }
}
