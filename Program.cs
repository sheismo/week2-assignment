using System;

namespace LabAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // My Lab 1 Assignment
            Console.WriteLine("Hello I am Zainab, I am in Backend track of Wella Schools");
            Console.WriteLine("I am learning Backend development in order to become a software engineer and learn how to use code to provide solutions to business problems.");

            // My Lab 2 Assignment

            // 1. Integer Data Type:
            int myAge = 20;
            // 2. String Data Type:
            string myName = "Zainab Ajumobi";
            // 3. Float Data Type:
            float myFloat = 618.54F;
            // 4. Double Data Type:
            double myDouble = 1.054;
            // 5. Anonymous Data Types:
            var Employee1 = new {
                                name = "John Doe",
                                age = "25",
                                role = "Software Developer"
                            };
            // 6. Nullable Data Type:
            Nullable<int> myInt = null;
            // 7. Dynamic Data Type:
            dynamic myDynamicVariable = 10;
            // 8. Enum Data Type:
            // enum Cities 
            // {
            //     Lagos,
            //     Nairobi,
            //     Paris,
            //     Berlin
            // };
            // 9. Array Data Type:
            var myArray = new[] { 1, 2, 3, 4, 5 };
            // 10. Boolean Data Type:
            var isActive = false;

            //Implicit Type Conversion
            int myInteger = 90;
            double myNewDouble = myInteger;

            //Explicit Type Conversion
            float myNewFloat = 8.97F;
            int myNewInteger = (int) myNewFloat;
        }
    }
}
