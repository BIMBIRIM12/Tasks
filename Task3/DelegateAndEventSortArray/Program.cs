using System;

namespace Program
{
    class DelegateAndEvents
    {
        static void Main()
        {
            MoveDelegateAndEvent();
        }

        private static void MoveDelegateAndEvent()
        {
            var sortingArray = new DelegateSortArray();
            void DisplayMessage(string message) => Console.WriteLine(message);
            sortingArray.CompletedSorting += DisplayMessage;
            int[] sortArray = sortingArray.GetSortArray();          
        }
    }
}