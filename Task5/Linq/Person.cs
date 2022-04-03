using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinQExample
{
    /// <summary>
    /// Примеры работы с Linq.
    /// </summary>
    public class Person
    {
        #region Properties
        // Имя человека.
        private string Name { get; set; }

        // Фамилия человека.
        private string Surname { get; set; }

        // Возраст человека.
        private int Age { get; set; }
        #endregion

        /// <summary>
        /// Примеры работы с Linq с коллекцией.
        /// </summary>
        public static void GetListPerson()
        {
            // Массив, содержащий в себе 4 объекта типа Person.
            var persons = new Person[]
            {
                new Person {Name = "Artem", Surname = "Shibanov", Age = 21},
                new Person {Name = "Roman", Surname = "Nozdrin", Age = 21},
                new Person {Name = "Gleb", Surname = "Rodionov", Age = 19}, 
                new Person {Name = "Artem", Surname = "Koreskov", Age = 25}
            };
            #region LinqOperations
            // Доступ к массиву через фильтрацию.
            var selectedPersonAge = persons.Where(n => n.Age == 21);
            var selectedPersonName = from n in persons
                                     where n.Name == "Artem"
                                     select n;
            // Анонимный тип.
            var nikita = new[]
            {
                new {Name = "Nikita", Surname = "Kibardin", Age = 21},
                new {Name = "Oleg", Surname = "Kirieshkin", Age = 24}
            };

            // Доступ к массиву через группироку.
            var groupedPersonAge = persons.GroupBy(n => n.Age > 20);
            var groupedPersonName = from n in persons
                                    group n by (n.Name == "Artem") into groups
                                    select groups;

            // Упорядочивание массива по имени человека.
            var orderByName = persons.OrderBy(n => n.Name);          
            var orderByAge = from n in persons
                              orderby n.Age
                              select n;

            //Массив в обратном порядке.
            var reversePersons = from n in persons.Reverse()
                    select n;
            var reversePerson = persons.Reverse();
            #endregion



        }
    }
}
