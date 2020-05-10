﻿using System;
using System.Text.RegularExpressions;

namespace NewHealthFormApplication
{
    class InputHandler
    {
        public static string GetGinNumber()
        {
            Console.WriteLine("\nPlease enter your gin number.");
            string input = Console.ReadLine();
            int numberInput;
            if (input.Length == 0 || !int.TryParse(input, out numberInput))
            {
                Console.WriteLine("\nIt's not a valid gin number");
                return GetGinNumber();
            }
            else if (Program.healthDataHolder.DataHolder.ContainsKey(input))
            {
                Console.WriteLine("\nThe gin number is already existed.");
                return GetGinNumber();
            }
            else
            {
                return input;
            }
        }
        public static string GetName()
        {
            Console.WriteLine("\nPlease enter your name.");
            string input = Console.ReadLine();
            if (input.Length == 0 || !Regex.IsMatch(input, @"^([A-Za-z \-]{2,25})+"))
            {
                Console.WriteLine("\nIt's not a valid full name.");
                return GetName();
            }
            else
            {
                return input;
            }
        }
        public static string GetTemperature()
        {
            Console.WriteLine("\nPlease enter your today's temperature.");
            string input = Console.ReadLine();
            double numberInput;
            if (input.Length == 0 || !double.TryParse(input, out numberInput) || numberInput > 43 || numberInput < 34)
            {
                Console.WriteLine("\nIt's not a valid body temperature");
                return GetTemperature();
            }
            else
            {
                return input;
            }
        }
        public static string GetSymptom()
        {
            Console.WriteLine("\nDo you have any symptom? Enter 1 if you have and 2 if you have not.");
            string input = Console.ReadLine();
            if (input != "1" && input != "2")
            {
                Console.WriteLine("\nIt's not a valid input.");
                return GetSymptom();
            }
            else
            {
                string symptom = (input == "1") ? "Yes" : "No";
                return symptom;
            }
        }
        public static string GetHubeiExperience()
        {
            Console.WriteLine("\nHave you been to Hubei in the past 14 days? Enter 1 if you have and 2 if you have not.");
            string input = Console.ReadLine();
            if (input != "1" && input != "2")
            {
                Console.WriteLine("\nIt's not a valid input.");
                return GetHubeiExperience();
            }
            else
            {
                string hubeiExperience = (input == "1") ? "Yes" : "No";
                return hubeiExperience;
            }
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
    }
}
