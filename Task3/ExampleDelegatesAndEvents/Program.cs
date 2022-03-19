using System;

namespace Program
{
    public class DelegateAndEvents
    {
        #region Methods
        static void Main()
        {
            DemoExample();
        }

        public static void DemoExample()
        {
            var numberFromUser = ToInt(GetStringFromUser());
            var example = new ExampleDelegateAndEvent();
            void DisplayMessage(string message) => Console.WriteLine(message);
            example.ComparedCompleted += DisplayMessage;
            example.CompareNumbers(numberFromUser);
            example.ComparedCompleted -= DisplayMessage;
        }
        #region GetNumberFromUser
        public static int ToInt(string stringFromUser)
        {
            if (String.IsNullOrEmpty(stringFromUser))
            {
                throw new ArgumentNullException(nameof(stringFromUser), "String is empty");
            } 
            
            return int.Parse(stringFromUser);                 
        }

        private static string GetStringFromUser()
        {
            Console.WriteLine("Enter number");
            return Console.ReadLine();
        }
        #endregion
        #endregion
    }
}