using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter your first name: "); // ask user for first name
            string firstName = Console.ReadLine(); // store inputed first name as string variable 
            Console.Write("Enter your last name: "); // repeat above with last name
            string lastName = Console.ReadLine(); 
            Console.Write("Enter your age: "); // repeat with age
            string age = Console.ReadLine();
            Console.Write("Enter your weight in kg: "); // repeat with weight
            string weight = Console.ReadLine();
            Console.Write("Enter your height in cm: "); // repeat with height
            string height = Console.ReadLine();

            // write out given data in string using either concatenation or interpolated string
            Console.WriteLine(firstName + " " + lastName + " is " + age + " years old, they have a weight of " + weight + "kg and a height of " + height + "cm." ); // concatenation
            Console.WriteLine($"{firstName} {lastName} is {age} years old, they have a weight of {weight}kg and a height of {height}cm."); // interpolation

            int intAge = int.Parse(age);                // convert revelant inputs to int and double for further calculation
            double doubleWeight = double.Parse(weight); 
            double doubleHeight = double.Parse(height);


            double heightInMeters = doubleHeight / 100; // convert height in cm to m
            double bmi = Math.Round((doubleWeight / Math.Pow(heightInMeters, 2)), 3); // use formula to calculate BMI kg/(m*m) m being height in meters rounds it to 3 decimal places

            Console.WriteLine($"{firstName} {lastName} has a BMI of {bmi}");
            Console.WriteLine("Hello"); // Zzz

            Console.WriteLine("New Branch Gone");
        }
    }
}
