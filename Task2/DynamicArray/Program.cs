using System;

namespace DynamicArray
{
	class Program
	{
		static void Main()
		{
			WorkDynamicArray();
		}	
		
		private static void WorkDynamicArray()
		{ 
			var numbers = new List<int> { 365, 366, 367 };			
			var array = new DynamicArray<int>(numbers);
			array.Add(12);
			array.AddRange(numbers);
			var removeItem = array.Remove(1);
			var insertItem = array.Insert(12, 2);
        }
	}
}