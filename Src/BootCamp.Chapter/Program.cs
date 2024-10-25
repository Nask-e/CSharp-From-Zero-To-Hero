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

            double ageDouble = ParseInput(age);
            double weightDouble = ParseInput(weight);
            double heightDouble = ParseInput(height);

            Console.WriteLine(InfoToString(firstName, lastName, age, height, weight));
            Console.WriteLine(BMI(weightDouble, heightDouble));
        }
        
        private static string TakeUserInput(string message)            
        {
            Console.Write($"Enter your {message}: ");       // ask user for info based on message given.
            string UserInput = Console.ReadLine();      // read user input.

            if(string.IsNullOrEmpty(UserInput))
            {
                Console.WriteLine($"invalid, {message} cannot be empty.");      // give feedback on invalid input.
                return "empty";     // return value to satisfy complier.
            } 
            else 
            {
                return UserInput;       // if not empty return the vaild string.
            }
        }

        private static double ParseInput(string message)
        {
            bool success = Double.TryParse(message, out double messageDouble);

            if (!success)
            {
                Console.WriteLine($"{message} is not a number.");
                return -1;
            }
            else
            {
                return messageDouble;
            }
        }

   

        private static string InfoToString(string firstName, string lastName, string age, string height, string weight)
        {
            return $"User's name is {firstName} {lastName}. They are {age} years old. User has a height of {height} cm and a weight of {weight} kg";
        }

        
        private static string BMI(double weight, double height)      // accepts to doubles as parameters to calculate BMI.
        {       
            double heightInMeters = height / 100;       // convert height in cm to height in meters
            double bmi = Math.Round(weight / Math.Pow(heightInMeters, 2), 3);

            if(bmi <= 0)
            {
                Console.WriteLine($"Height cannot be equal or less than zero, but was {height}.");

                Console.WriteLine($"Weight cannot be equal or less than zero, but was {weight}.");
                return "-1";
            } 
            else
            {
                return $"BMI is {bmi}";
            }
        } 
        
    }
}