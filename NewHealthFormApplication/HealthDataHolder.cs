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
        public void EditEmployee(string ginNumber, string name, string temperature, string symptom, string hubeiExperience)
        {
            DataHolder[ginNumber] = new Employee(ginNumber, name, temperature, symptom, hubeiExperience);
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
