using System;

namespace DynamicArray
{
	class Program
	{
		static void Main()
		{
			WorkWithDynamicArray();
		}	
		
		private static void WorkWithDynamicArray()
        {
			var yourList = new List<int> { 365, 366, 367 };
			var myArray = new DynamicArray<int>();
			var addItem = myArray.Add(12);
			var addRangeYourList = myArray.AddRange(yourList);
			var removeIndex = myArray.Remove(5);
			var insertItem = myArray.Insert(12, 6);

        }
	}
}