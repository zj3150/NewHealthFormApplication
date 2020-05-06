using System;

namespace NewHealthFormApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        static void MainMenu()
        {
            int purpose;
            while (true)
            {
                Console.WriteLine("\nGood day! What would you like to do? Please enter a number.\n");
                Console.WriteLine("1. Fill in your form");
                Console.WriteLine("2. Display data table");
                Console.WriteLine("3. Save data table to file");
                Console.WriteLine("4. Load data from file");
                Console.WriteLine("5. Exit\n");
                if (!int.TryParse(Console.ReadLine(), out purpose))
                {
                    Console.WriteLine("You must input an integer.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (purpose)
                {
                    case 1:
                        continue;
                    case 2:
                        continue;
                    case 3:
                        continue;
                    case 4:
                        continue;
                    case 5:
                        break;
                    default:
                        Console.WriteLine("Please select valid purpose.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }
                break;
            }

        }
    }
}
