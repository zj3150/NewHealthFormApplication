namespace NewHealthFormApplication
{
    public class Employee
    {
        public string GinNumber
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Temperature
        {
            get;
            set;
        }
        public bool Symptom
        {
            get;
            set;
        }
        public bool HubeiExperience
        {
            get;
            set;
        }
        public Employee(string ginNumber, string name, string temperature, bool symptom, bool hubeiExperience)
        {
            GinNumber = ginNumber;
            Name = name;
            Temperature = temperature;
            Symptom = symptom;
            HubeiExperience = hubeiExperience;
        }
    }
}
