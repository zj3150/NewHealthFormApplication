using System.Collections.Generic;

namespace NewHealthFormApplication
{
    class HealthDataHolder
    {
        public Dictionary<string, Employee> DataHolder { get; set; } = new Dictionary<string, Employee>();
        public void AddEmployee(string ginNumber, string name, string temperature, bool symptom, bool hubeiExperience)
        {
            Employee newEmployee = new Employee(ginNumber, name, temperature, symptom, hubeiExperience);
            DataHolder.Add(ginNumber, newEmployee);
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

        public void EditEmployee(Dictionary<string, Employee> DataHolder, string ginNumber, string name, string temperature, bool symptom, bool hubeiExperience)
        {
            DataHolder[ginNumber].Name = name;
            DataHolder[ginNumber].Temperature = temperature;
            DataHolder[ginNumber].Symptom = symptom;
            DataHolder[ginNumber].HubeiExperience = hubeiExperience;
        }

        public bool ContainsKey(string ginNumber)
        {
            return DataHolder.ContainsKey(ginNumber);
        }
    }
}
