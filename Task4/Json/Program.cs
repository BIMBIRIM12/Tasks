using System;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace Program
{
    public class XmlAndJason
    {     
        static void Main(string[] args)
        {
            var currentConfig = ConfigurationManager.AppSettings.Get("pathJsonDate");
   
            Person anton = new Person("Anton", "Nozdrin", 26);  
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

    [DataContract]
    class Person
    {
        [DataMember]
        public string Name { get; set; }


        [DataMember]
        public string Surname { get; set; }

        [DataMember]
        public int Age { get; set; }

        public Person (string name, string surname, int age)
        {
            CheckingParameters(name, surname, age);
            Name = name;
            Surname = surname;
            Age = age;
        }
       
        public static void CheckingParameters(string name, string surname, int age)
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
        }
    }
}