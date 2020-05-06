namespace NewHealthFormApplication
{
    class Employee
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
        public string Symptom
        {
            get;
            set;
        }
        public string HubeiExperience
        {
            get;
            set;
        }
        public Employee(string ginNumber, string name, string temperature, string symptom, string hubeiExperience)
        {
            GinNumber = ginNumber;
            Name = name;
            Temperature = temperature;
            Symptom = symptom;
            HubeiExperience = hubeiExperience;
        }
    }
}
