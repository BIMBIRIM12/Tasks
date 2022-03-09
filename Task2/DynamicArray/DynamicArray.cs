using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    public class DynamicArray<T>
    {
        public T[] myArray { get; set; }

        public int Length => myArray.Length;

        public int Сapacity => myArray.Count();

        public int Index { get; set; }

        public T Item { get; set; }

        public T[] IEnumerable()
        {
            return myArray;
        }

        public T[] IEnumerable<String>()
        {
            return myArray;
        }
 
        public DynamicArray()
        {       
            myArray = new T[8];            
        }

        public DynamicArray(int size)
        {
            myArray = new T[size];
            return;
        }

        public DynamicArray(IEnumerable<T> yourArray)
        {
            this.myArray = new T[yourArray.Count()];
            yourArray.ToList().CopyTo(this.myArray, 0);
            return;
        }
       
        public T[] Add(T Item)
        {
            if (Item == null)
            {
                throw new ArgumentNullException(nameof(Item), "item is null");
            }
            else
            {
                if (Сapacity + 1 < Length)
                {
                    myArray.Append(Item);
                    return myArray;
                }
                else
                {
                    myArray = new T[myArray.Length * 2];
                    return myArray;
                }
            }
        }

        public T this[int Index]
        {
            get
            {
                return Item;
            }
            set
            {
                if (Index > Сapacity)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), "Incorrect index");
                }
                else
                {
                     item = myArray[Index];
                }
            }
        }
    }
}
