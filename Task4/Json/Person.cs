using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace Program
{
   [DataContract]
    internal class Person
    {
        /// <summary>
        /// Имя человека.
        /// </summary>
        [DataMember]
        public string Name { get; set; }

        /// <summary>
        /// Фамилия человека
        /// </summary>
        [DataMember]
        public string Surname { get; set; }

        /// <summary>
        /// Возраст человека
        /// </summary>
        [DataMember]
        public int Age { get; set; }

        /// <summary>
        /// Пол человека
        /// </summary>
        [DataMember]
        public string Gender { get; set; }

        /// <summary>
        /// Присвавивает полям значения.
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        public Person(string name, string surname, int age, string gender)
        {
            CheckParameters(name, surname, age, gender);
            Name = name;
            Surname = surname;
            Age = age;
            Gender = gender;
        }

        /// <summary>
        /// Проверяет входящие значение
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        public static void CheckParameters(string name, string surname, int age, string gender)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException(nameof(name), "Name is empty");
            }

            if (string.IsNullOrEmpty(surname))
            {
                throw new ArgumentNullException(nameof(surname), "Surname is empty");
            }

            if ( age <= 0 | age> 90 )
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age is incorrect");
            }

            if (string.IsNullOrEmpty(gender))
            {
                throw new ArgumentNullException(nameof(gender), "Gender is empty");
            }
        }
    }
}

