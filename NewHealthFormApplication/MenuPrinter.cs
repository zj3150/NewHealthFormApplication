using System;

namespace NewHealthFormApplication
{
    class MenuPrinter
    {
        public static void PrintMainMenu()
        {
            Console.WriteLine("\nGood day! What would you like to do? Please enter a number.\n");
            Console.WriteLine("1. Create a new data table");
            Console.WriteLine("2. Fill in your form");
            Console.WriteLine("3. Display data table");
            Console.WriteLine("4. Save data table to file");
            Console.WriteLine("5. Load data from file");
            Console.WriteLine("6. Delete an employee");
            Console.WriteLine("7. Edit an employee");
            Console.WriteLine("8. Exit\n");
        }
        public static void PrintFilterMenu()
        {
            Console.WriteLine("\nPlease select the data you would like to display.");
            Console.WriteLine("1. Complete data table");
            Console.WriteLine("2. Filter by gin number");
            Console.WriteLine("3. Filter by name");
            Console.WriteLine("4. Employees with a fever");
            Console.WriteLine("5. Employees without fever");
            Console.WriteLine("6. Employees having symptoms");
            Console.WriteLine("7. Employees having no symptom");
            Console.WriteLine("8. Employees been in Hubei in 14 days");
            Console.WriteLine("9. Employees having not been in Hubei in 14 days");
            Console.WriteLine("0. Back");
        }
    }
}
