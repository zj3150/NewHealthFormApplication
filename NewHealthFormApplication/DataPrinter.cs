using System;

namespace NewHealthFormApplication
{
    class DataPrinter
    {
        public static void PrintDataTable()
        {
            if (Program.healthDataHolder == null || Program.healthDataHolder.DataHolder.Count == 0)
            {
                Console.WriteLine("\nThere is no stored data.");
            }
            else
            {
                PrintHeader();
                foreach (Employee employee in Program.healthDataHolder.DataHolder.Values)
                {
                    PrintAnEmployee(employee.GinNumber, employee.Name, employee.Temperature, employee.Symptom.ToString(), employee.HubeiExperience.ToString());
                }
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByGinNumber()
        {
            Console.WriteLine("\nPlease enter the gin number.");
            string input = Console.ReadLine();
            if (!Program.healthDataHolder.DataHolder.ContainsKey(input))
            {
                Console.WriteLine("\nYour input is not an existed gin number.");
                FilterByGinNumber();
            }
            else
            {
                string ginNumber = input;
                string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                PrintHeader();
                PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        public static void FilterByName()
        {
            Console.WriteLine("\nPlease enter the name.");
            string input = Console.ReadLine();
            bool nameExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (Program.healthDataHolder.DataHolder[ginNumber].Name == input)
                {
                    nameExist = true;
                    string name = input;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                    Console.ReadKey();
                    Console.Clear();
                }
            }
            if (!nameExist)
            {
                Console.WriteLine("\nYour input is not an existed name.");
                FilterByName();
            }
        }
        public static void FilterByHavingFever()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (double.Parse(Program.healthDataHolder.DataHolder[ginNumber].Temperature) >= 37.3)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having a fever.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByHavingNoFever()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (double.Parse(Program.healthDataHolder.DataHolder[ginNumber].Temperature) < 37.3)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having not a fever.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByHavingSymptom()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (Program.healthDataHolder.DataHolder[ginNumber].Symptom == true)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having symptoms.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByHavingNoSymptom()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (Program.healthDataHolder.DataHolder[ginNumber].Symptom == false)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having no symptoms.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByHavingHubeiExperience()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience == true)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having been in Hubei in 14 days.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void FilterByHavingNoHubeiExperience()
        {
            bool filterExist = false;
            bool headerPrinted = false;
            foreach (string ginNumber in Program.healthDataHolder.DataHolder.Keys)
            {
                if (Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience == false)
                {
                    filterExist = true;
                    string name = Program.healthDataHolder.DataHolder[ginNumber].Name;
                    string temperature = Program.healthDataHolder.DataHolder[ginNumber].Temperature;
                    bool symptom = Program.healthDataHolder.DataHolder[ginNumber].Symptom;
                    bool hubeiExperience = Program.healthDataHolder.DataHolder[ginNumber].HubeiExperience;
                    if (headerPrinted == false)
                    {
                        PrintHeader();
                        headerPrinted = true;
                    }
                    PrintAnEmployee(ginNumber, name, temperature, symptom.ToString(), hubeiExperience.ToString());
                }
            }
            if (!filterExist)
            {
                Console.WriteLine("\nThere is no employee having not been in Hubei in 14 days.");
            }
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        public static void PrintHeader()
        {
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("| {0, -20}| {1, -20}| {2, -20}| {3, -20}| {4, -20}| ", "Gin Number", "Name", "Body Temperature", "Symptom", "Hubei Experience");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
        }
        public static void PrintAnEmployee(string ginNumber, string name, string temperature, string symptom, string hubeiExperience)
        {
            Console.WriteLine("| {0, -20}| {1, -20}| {2, -20}| {3, -20}| {4, -20}| ", ginNumber, name, temperature, symptom, hubeiExperience);
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
        }
    }
}
