using System;
using System.IO;

namespace NewHealthFormApplication
{
    class CSVFileOperator
    {
        public static void SaveDataToFile()
        {
            string[] fileLines = new string[Program.healthDataHolder.DataHolder.Count];
            int i = 0;
            foreach (Employee employee in Program.healthDataHolder.DataHolder.Values)
            {
                fileLines[i++] = employee.GinNumber + "," + employee.Name + "," + employee.Temperature + "," + employee.Symptom.ToString() + "," + employee.HubeiExperience.ToString();
            }
            File.WriteAllLines(@"D:\temp\NewHealthFormApplication.csv", fileLines);
            Console.WriteLine("\nData have been saved to the file");
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void LoadDataFromFile()
        {
            Program.healthDataHolder = new HealthDataHolder();
            if (!File.Exists(@"D:\temp\NewHealthFormApplication.csv"))
            {
                Console.WriteLine("The file is not existed.");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                foreach (string line in File.ReadLines(@"D:\temp\NewHealthFormApplication.csv"))
                {
                    if (line == "")
                    {
                        Console.WriteLine("The file is empty.");
                        Console.WriteLine("Press any key to continue");
                        Console.ReadKey();
                        Console.Clear();
                        return;
                    }
                    else
                    {
                        string[] employeeData = line.Split(',');
                        string ginNumber = employeeData[0];
                        string name = employeeData[1];
                        string temperature = employeeData[2];
                        bool symptom = employeeData[3] == "Yes";
                        bool hubeiExperience = employeeData[4] == "Yes";
                        Program.healthDataHolder.AddEmployee(ginNumber, name, temperature, symptom, hubeiExperience);
                    }
                }
                DataPrinter.PrintHeader();
                foreach (Employee employee in Program.healthDataHolder.DataHolder.Values)
                {
                    DataPrinter.PrintAnEmployee(employee.GinNumber, employee.Name, employee.Temperature, employee.Symptom.ToString(), employee.HubeiExperience.ToString());
                }
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
