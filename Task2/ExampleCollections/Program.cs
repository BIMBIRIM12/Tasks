using System;
using System.Collections.Generic;

namespace Program
{
    public class ExampleCollections
    {
        static void Main()
        {
            var list = GetExampleList();
            var dictionary = GetExampleDictionary(list);
            var stack = GetExampleStack(list);
            var queue = GetExampleQueue(list);
        }

        public static List<string> GetExampleList()
        {
            var carsBrand = new List<string>();
            carsBrand.Add("Lada");
            carsBrand.Add("BMW");
            carsBrand.Add("Bugatti");
            carsBrand.Add("Aston Martin");
            carsBrand.Remove(carsBrand[0]);
            carsBrand.Sort();
            return carsBrand;
        }

        public static Dictionary<string, int> GetExampleDictionary(List<string> list)
        {
            var cars = new Dictionary<string, int>();
            for(var i = 0; i < list.Count; i++)
            {
                if (cars.ContainsKey(list[i]))
                {
                    cars[list[i]]++;
                }
                else
                {
                    cars.Add(list[i], 1);
                } 
            }

            cars.Add("Reanault", 1);
            cars.Remove("Renault");
            return cars;
        }

        public static Stack<string> GetExampleStack(List<string> list)
        {
            var stackCars = new Stack<string>();
            for(var i = 0; i < list.Count; i++)
            {
                stackCars.Push(list[i]);
            }

            stackCars.Pop();
            return stackCars;
        }

        public static Queue<string> GetExampleQueue (List<string> list)
        {
            var queueCars = new Queue<string>();
            for (var i = 0;i < list.Count; i++)
            {
                queueCars.Enqueue(list[i]);
            }

            queueCars.Dequeue();
            foreach(var car in queueCars)
            {
                Console.WriteLine(car);
            }

            return queueCars;
        }
    }
}
