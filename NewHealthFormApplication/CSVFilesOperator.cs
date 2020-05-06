using System.IO;

namespace NewHealthFormApplication
{
    class CSVFilesOperator
    {
        private string _path;

        private string Path
        {
            get
            {
                return _path;
            }
            set
            {
                _path = @"D:\temp\NewHealthFormApplication.csv";
            }
        }
        public bool FileIsEmpty
        {
            get;
            set;
        }
        public void SaveDataToFile()
        {
            HealthDataHolder healthDataHolder = new HealthDataHolder();
            string[] fileLines = new string[healthDataHolder.DataHolder.Count];
            int i = 0;
            foreach (Employee employee in healthDataHolder.DataHolder.Values)
            {
                fileLines[++i] = employee.GinNumber + "," + employee.Name + "," + employee.Temperature + "," + employee.Symptom + "," + employee.HubeiExperience;
            }
            File.WriteAllLines(Path, fileLines);
        }
        public void LoadDataFromFile()
        {
            HealthDataHolder healthDataHolder = new HealthDataHolder();
            FileIsEmpty = true;
            string[] fileLines = File.ReadAllLines(Path);
            for (int i = 0; i < fileLines.Length; i++)
            {
                string[] dataValues = fileLines[i].Split(',');
                string ginNumber = dataValues[0];
                string name = dataValues[1];
                string temperature = dataValues[2];
                string symptom = dataValues[3];
                string hubeiExperience = dataValues[4];
                healthDataHolder.AddEmployee(ginNumber, name, temperature, symptom, hubeiExperience);
            }
            if (healthDataHolder.DataHolder.Count == 0)
            {
                FileIsEmpty = false;
            }
        }
    }
}
