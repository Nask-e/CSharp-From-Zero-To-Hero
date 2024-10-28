using System;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.Marshalling;
using System.Web;
using Microsoft.VisualBasic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< Updated upstream
            /* Homework 1/2 

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
            */         

            // Homework 3: Refactor old code using functions
        
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
                
            

            string BMI(string weight, string height, string age)
            {
                int intAge = int.Parse(age);                // convert revelant inputs to int and double for further calculation
                double doubleWeight = double.Parse(weight); 
                double doubleHeight = double.Parse(height);
                double heightInMeters = doubleHeight / 100; // convert height in cm to m
                double bmi = Math.Round((doubleWeight / Math.Pow(heightInMeters, 2)), 3);    

                return $"{firstName} {lastName} is {age} years old, they have a weight of {weight}kg and a height of {height}cm. Making there BMI: {bmi}";      
            }

            
            Console.WriteLine(BMI(weight, height, age));





        } 
=======
            int[] array1 = [1, 2, 3, 4, 5, 6, 7, 8, 9];

            Console.WriteLine(array1.Length);
            Console.WriteLine();
             
          // PrintArray(array1);

            Array.Sort(array1);
            Console.WriteLine();
            Array.Reverse(array1);

          //  PrintArray(array1);

            PrintArray(array1);

            int[] array2 = RemoveAtIndex(array1, 4);

            PrintArray(array2);
        }
        public static void PrintArray(int[] array)
        {
            // cycle through array printing all elements
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine(); // Create space
        }

        public static void ChangeAtIndex(int[] array, int indexToChange, int number)
        {
            array[indexToChange] = number;
        }

        public static int[] AddToStartArray(int[] array, int numberToAdd)
        {
            // create new array 1 longer than given array
            int[] array2 = new int[array.Length + 1];

            // iterate through array copying elements
            for(int i = 0; i < array.Length; i++)
            {
                array2[i+1] = array[i];
            }
            // change first element to given number
            array2[0] = numberToAdd;
            
            // return new array
            return array2;
        }

        public static int[] AddToEndArray(int[] array, int numberToAdd)
        {
            // delcare new array 1 longer than given array
            int[] array2 = new int[array.Length + 1];

            // iterate through old array copying elements to new array
            for(int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            // append to number to last spot on array
            array2[^1] = numberToAdd;
            // returbn new array
            return array2;
        }

        public static int[] RemoveLast(int[] array)
        {
            // create new array with 1 less element than given array
            int[] array2 = new int[array.Length -1];

            // loop to clone elements to new array
            for(int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i];
            }
            
            // return new reduced array
            return array2;
        }

        public static int[] RemoveFirst(int[] array)
        {
            // create new array 1 less than given array
            int[] array2 = new int[array.Length -1];

            // iterate through array copying elements skipping first index
            for(int i = 0; i < array2.Length; i++)
            {
                array2[i] = array[i+1];
            }
            // return new array without first index number
            return array2;
        }

        public static int[] RemoveAtIndex(int[] array, int indexToRemove)
        {
            int[] array2 = new int[array.Length -1];

            for(int i = 0; i < indexToRemove; i++)
            {
                array2[i] = array[i];
            }

            for(int i = indexToRemove; i < array2.Length; i++)
            {
                array2[i] = array[i+1];
            }

            return array2;
        }

        

        

        

       

       


                  
            
>>>>>>> Stashed changes
    }
}
