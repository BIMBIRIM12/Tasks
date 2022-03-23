using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace Program
{
    /// <summary>
    /// Сереализирует и десеализирует объект в JSON.
    /// </summary>
    public class Json
    {   
        /// <summary>
        /// Сереализирует объект Person в JSON и десереализирует его.
        /// </summary>       
        static void Main(string[] args)
        {
            var currentConfig = ConfigurationManager.AppSettings.Get("pathJsonDate");
   
            Person anton = new Person("Anton", "Nozdrin", 26, "man");
            var jsonFormatter = new DataContractJsonSerializer(typeof(Person));

            using (var file = new FileStream("person.json", FileMode.OpenOrCreate))
            {
               jsonFormatter.WriteObject(file, anton);
            }

            using (var file = new FileStream("person.json", FileMode.OpenOrCreate))
            {
               var newPerson = jsonFormatter.ReadObject(file) as Person;
            }
        }       
    }

    /// <summary>
    /// Создаёт объект Person с 3 параметрами - Name, Surname и Age.
    /// </summary>
    [DataContract]
    class Person
    {
        [DataMember]
        public string Name { get; set; }


        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public int Age { get; set; }

        [DataMember]
        public string Gender { get; set; }

        /// <summary>
        /// Присвавивает полям значения.
        /// </summary>
        /// <param name="name"> Имя </param>
        /// <param name="surname"> Фамилия </param>
        /// <param name="age"> Возраст </param>
        public Person (string name, string surname, int age, string gender)
        {
            CheckingParameters(name, surname, age, gender);
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
        public static void CheckingParameters(string name, string surname, int age, string gender)
        {
            if(name == null)
            {
                throw new ArgumentNullException(nameof(name), "Name is empty");
            }

            if(surname == null)
            {
                throw new ArgumentNullException(nameof(surname), "Surname is empty");
            }

            if(age <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(age), "Age equals null or less than null");
            }

            if(gender == null)
            {
                throw new ArgumentNullException(nameof(gender), "Gender is empty");
            }
        }
    }
}