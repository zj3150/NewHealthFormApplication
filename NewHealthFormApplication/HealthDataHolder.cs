using System.Collections.Generic;

namespace NewHealthFormApplication
{
    class HealthDataHolder
    {
        public Dictionary<string, Employee> DataHolder { get; set; } = new Dictionary<string, Employee>();
        public void AddEmployee(string ginNumber, string name, string temperature, string symptom, string hubeiExperience)
        {
            Employee newEmployee = new Employee(ginNumber, name, temperature, symptom, hubeiExperience);
            DataHolder.Add(ginNumber, newEmployee);
        }
        public bool EditEmployee(string ginNumber)
        {
            if (DataHolder.ContainsKey(ginNumber))
            {
                string name = InputHandler.GetName();
                string temperature = InputHandler.GetTemperature();
                string symptom = InputHandler.GetSymptom();
                string hubeiExperience = InputHandler.GetHubeiExperience();
                DataHolder[ginNumber] = new Employee(ginNumber, name, temperature, symptom, hubeiExperience);
                return true;
            }
            return false;
        }
        public bool DeleteEmployee(string ginNumber)
        {
            if (DataHolder.ContainsKey(ginNumber))
            {
                DataHolder.Remove(ginNumber);
                return true;
            }
            return false;
        }

    }
}
