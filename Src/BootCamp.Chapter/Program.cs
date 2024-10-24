using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = TakeUserInput("first name");
            string lastName = TakeUserInput("last name");
            string age = TakeUserInput("age");
            string weight = TakeUserInput("weight in kg");
            string height = TakeUserInput("height in cm");

            Console.WriteLine(InfoToString(firstName, lastName, age, weight, height));

            Console.WriteLine(BMI(weight, height));
        }
            private static string TakeUserInput(string info)
            {
                Console.Write($"Enter your {info}: "); // ask user for a type of info
                string UserInput = Console.ReadLine();
                return UserInput;
            }

            private static string InfoToString(string firstName, string lastName, string age, string height, string weight)
            {
                return $"User's name is {firstName} {lastName}. They are {age} years old. User has a height of {height}cm and a weight of {weight}kg";
            }
            private static string BMI(string weight, string height)
            {              // convert revelant inputs to int and double for further calculation
                double doubleWeight = double.Parse(weight); 
                double doubleHeight = double.Parse(height);
                double heightInMeters = doubleHeight / 100; // convert height in cm to m
                double bmi = Math.Round((doubleWeight / Math.Pow(heightInMeters, 2)), 3);
                return $"User has a bmi of {bmi}.";
            } 
    }
}