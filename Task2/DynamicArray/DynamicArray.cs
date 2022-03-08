using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T>
    {
        public T[] array { get; set; }

        public int Length => array.Length;

        public int Сapacity => array.Count();
       

        public DynamicArray()
        {       
            array = new T[8];            
        }

        public DynamicArray(int capacity)
        {
            array = new T[capacity];
            return;
        }

        public DynamicArray(IEnumerable<T> myArray)
        {
            array = new T[myArray.Count()];
            myArray.ToList().CopyTo(array, 0);
            return;
        }
       
        public T[] Add(T item)
        {
            if (item == null)
            {
                throw new ArgumentNullException(nameof(item), "item is null");
            }
            else
            {
                if (Сapacity + 1 == Length)
                {
                    array = new T[array.Length * 2];
                    return array;
                }
                else
                {
                    array.Append(item);
                    return array;
                }
            }
        }
    }
}
