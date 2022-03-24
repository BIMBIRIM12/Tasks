using System;
using System.Runtime.Serialization.Json;
using System.Configuration;

namespace Program
{
    /// <summary>
    /// Сереализирует и десеализирует объект в JSON.
    /// </summary>
    public class Json
    {   
        static void Main(string[] args)
        {
            ConvertJson();     
        }    

        /// <summary>
        /// Сереализирует объект Person в JSON, затем десереализирует его.
        /// </summary>
        private static void ConvertJson()
        {
            var currentConfig = ConfigurationManager.AppSettings["pathJsonDate"];

            var anton = new Person("Anton", "Kunin", 28, "man");
            var jsonFormatter = new DataContractJsonSerializer(typeof(Person));

            using (var file = new FileStream(currentConfig, FileMode.OpenOrCreate))
            {
                 jsonFormatter.WriteObject(file, anton);
            }

            using (var loadedData = new FileStream(currentConfig, FileMode.OpenOrCreate))
            {
                var newPerson = jsonFormatter.ReadObject(loadedData) as Person;
                ShowNewPerson(newPerson);
            }
        }

        /// <summary>
        /// Выводит значения всех свойств десерелизируемого объекта в консоль.
        /// </summary>
        /// <param name="newPerson"></param>
        private static void ShowNewPerson(Person newPerson)
        {
            var  properties = newPerson.GetType().GetProperties();
            for(var i = 0; i < properties.Length; i++)
            {
                Console.WriteLine(properties[i].GetValue(newPerson));
            }   
        }
    } 
}