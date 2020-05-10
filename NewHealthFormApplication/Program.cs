using System;

namespace NewHealthFormApplication
{
    class Program
    {
        public static HealthDataHolder healthDataHolder;
        static void Main(string[] args)
        {
            MainMenu();
        }
        static void MainMenu()
        {
            int purpose;
            while (true)
            {
                MenuPrinter.PrintMainMenu();
                if (!int.TryParse(Console.ReadLine(), out purpose))
                {
                    Console.WriteLine("\nYou must input an integer.");
                    Console.WriteLine("Press any key to continue");
                    Console.ReadKey();
                    Console.Clear();
                    continue;
                }
                switch (purpose)
                {
                    case 1:
                        Program.healthDataHolder = new HealthDataHolder();
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    case 2:
                        AddEmployee();
                        continue;
                    case 3:
                        DataPrinterMenu();
                        continue;
                    case 4:
                        CSVFileOperator.SaveDataToFile();
                        continue;
                    case 5:
                        CSVFileOperator.LoadDataFromFile();
                        continue;
                    case 6:
                        DeleteEmployee();
                        continue;
                    case 7:
                        EditEmployee();
                        continue;
                    case 8:
                        break;
                    default:
                        Console.WriteLine("\nPlease select valid purpose.");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                }
                break;
            }

        }
        static void AddEmployee()
        {
            string ginNumber = InputHandler.GetGinNumber();
            string name = InputHandler.GetName();
            string temperature = InputHandler.GetTemperature();
            bool symptom = InputHandler.GetSymptom();
            bool hubeiExperience = InputHandler.GetHubeiExperience();
            healthDataHolder.AddEmployee(ginNumber, name, temperature, symptom, hubeiExperience);
            Console.WriteLine("\nYou have finished filling today's investigation.");
            DataPrinter.PrintHeader();
            DataPrinter.PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void DataPrinterMenu()
        {
            if (healthDataHolder == null || healthDataHolder.DataHolder.Count == 0)
            {
                Console.WriteLine("\nThere is no stored data.");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                while (true)
                {
                    MenuPrinter.PrintFilterMenu();
                    int selection;
                    if (!int.TryParse(Console.ReadLine(), out selection))
                    {
                        Console.WriteLine("\nPlease enter an integer.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        continue;
                    }
                    else
                    {
                        switch (selection)
                        {
                            case 1:
                                DataPrinter.PrintDataTable();
                                continue;
                            case 2:
                                DataPrinter.FilterByGinNumber();
                                continue;
                            case 3:
                                DataPrinter.FilterByName();
                                continue;
                            case 4:
                                DataPrinter.FilterByHavingFever();
                                continue;
                            case 5:
                                DataPrinter.FilterByHavingNoFever();
                                continue;
                            case 6:
                                DataPrinter.FilterByHavingSymptom();
                                continue;
                            case 7:
                                DataPrinter.FilterByHavingNoSymptom();
                                continue;
                            case 8:
                                DataPrinter.FilterByHavingHubeiExperience();
                                continue;
                            case 9:
                                DataPrinter.FilterByHavingNoHubeiExperience();
                                continue;
                            case 0:
                                return;
                            default:
                                Console.WriteLine("\nPlease enter valid selection.");
                                Console.WriteLine("Press any key to continue");
                                Console.ReadKey();
                                Console.Clear();
                                continue;
                        }
                    }
                }
            }
        }
        static void DeleteEmployee()
        {
            Console.WriteLine("\nPlease input the gin number of the employee you would like to delete.");
            string ginNumber = Console.ReadLine();
            if (healthDataHolder.DeleteEmployee(ginNumber))
            {
                Console.WriteLine($"\n{ginNumber}'s data have been deleted.");

            }
            else
            {
                Console.WriteLine($"\nGin number {ginNumber} is not existed.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        static void EditEmployee()
        {
            Console.WriteLine("Please input the gin number of the employee you would like to edit.");
            string ginNumber = Console.ReadLine();
            if (healthDataHolder.DataHolder.ContainsKey(ginNumber))
            {
                string name = InputHandler.GetName();
                string temperature = InputHandler.GetTemperature();
                bool symptom = InputHandler.GetSymptom();
                bool hubeiExperience = InputHandler.GetHubeiExperience();
                healthDataHolder.EditEmployee(healthDataHolder.DataHolder, ginNumber, name, temperature, symptom, hubeiExperience);
                DataPrinter.PrintHeader();
                DataPrinter.PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
            }
            else
            {
                Console.WriteLine($"\nGin number {ginNumber} is not existed.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}