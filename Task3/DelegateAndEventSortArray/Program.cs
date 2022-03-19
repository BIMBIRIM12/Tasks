using System;

namespace Program
{
    class DelegateAndEvents
    {
        #region Methods
        static void Main()
        {
            DemoDelegateAndEventSortArray();
        }

        private static void DemoDelegateAndEventSortArray()
        {
            var delegateSortArray = new DelegateSortArray();
            void DisplayMessage(string message) => Console.WriteLine(message);
            delegateSortArray.CompletedSorting += DisplayMessage;
            var getSortArray = delegateSortArray.SetUnsortArrayAndGetSortArray();
            delegateSortArray.CompletedSorting -= DisplayMessage;
        }
        #endregion
    }
}