using System;
using System.Collections.Generic;

namespace Program
{
    class CompareObjects
    {
        static void Main()
        {
            ComparisObjects();
        }

        public static void ComparisObjects()
        {
            var objectFirst = new DynamicArray<int>(5);
            var objectSecond = new DynamicArray<string>(6);
            var objectThree = GetObjectThree();
            var objectFour = GetObjectFour();

            objectFirst.Equals(objectSecond);
            objectFirst.Equals(objectThree);
            objectSecond.Equals(objectThree);
            objectThree.Equals(objectFour); 
        }

        private static int[] GetObjectThree()
        {
            int[] objectThree = new int[5] { 1, 2, 3, 4, 5 };
            return objectThree;
        }

        private static double[] GetObjectFour()
        {
            double[] objectFour = new double[6] { 1.2, 12, 321, 2.2, 1221.2, 333.1 };
            return objectFour;
        }
    }
}