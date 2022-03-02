using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /// <summary>
    /// Создаёт неотсортированный массив и заполняет его значениями
    /// Сортирует его, возвращает его и выводит в консоль
    /// Также вычисляет максимальное и минимальное значение массива и возвращает их
    /// </summary>
    public class ArraySet
    {
        /// <summary>
        /// Создаёт и заполняет значениями неотсортированный массив
        /// </summary>
        /// <returns>Неотстортированный массив</returns>
        public int[] ArraySetUnSort()
        {
            int[] nums = new int[15];
            Random a = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a.Next(1, 1000);
            }
            return nums;
        }

        /// <summary>
        /// Высчитывает и возвращает максимальное значение массива
        /// </summary>
        /// <param name="nums">Принимает неотсортированный массив значений</param>
        /// <returns>Возвращает максимальное значение массива</returns>
        public int ArrayMax(int[] nums)
        {
            int max = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        /// <summary>
        /// Высчитывает минимальное значение массива 
        /// </summary>
        /// <param name="nums">Принимает неотсортированный массив значений</param>
        /// <returns>Возвращает минимальное значение массива</returns>
        public int ArrayMin(int[] nums)
        {
            int min = 1000;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] < min)
                {
                    min = nums[i];
                }
            }
            return min;
        }

        /// <summary>
        /// Сортирует неотсортированный массив значений по возрастанию, выводит его в консоль и возвращает
        /// </summary>
        /// <param name="nums">Принимает неотсортированный массив значений</param>
        /// <returns>Возвращает сортированный массив значений</returns>
        public int[] ArraySetSort(int[] nums)
        {
            int point;
            for (int i = 0; i < nums.Length - 1; i++)
            {
                if (nums[i] > nums[i + 1])
                {
                    for (int l = i + 1; l > 0; l--)
                    {
                        if (nums[l] < nums[l - 1])
                        {
                            point = nums[l];
                            nums[l] = nums[l - 1];
                            nums[l - 1] = point;
                        }
                    }
                }
            }
            Console.WriteLine("Sorted");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.WriteLine(nums[i] + " ");
            }
            return nums;
        }
    }
}
