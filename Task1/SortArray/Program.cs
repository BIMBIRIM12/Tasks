using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    public class Array
    {
        static void Main(string[] args)
        {
            ArrayCalc();
        }

        public static void ArrayCalc()
        {
            var arraySet = new ArraySet();
            int[] nums = arraySet.ArraySetUnSort();
            int[] numsort = arraySet.ArraySetSort(nums);
            var max = arraySet.ArrayMax(nums);
            var min = arraySet.ArrayMin(nums);
            Console.WriteLine("Max " + max);
            Console.WriteLine("Min " + min);
        }
    }
}