using System;
using System.Security.Cryptography;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = [ 4, 6, 9, 2, 1 ];

            Console.WriteLine(array1.Length);
            Console.WriteLine();

            PrintArray(array1);

            int[] array2 = ArraySort(array1);

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

        public static int[] ArraySort(int[] array)
        {
            int[] array2 = new int[array.Length];

            for(int i =0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            for(int i = 0; i < array.Length; i++)
            {
              if(array[i] < array2[i])
              {
                array2[i] = array[i];
              }
            }

            return array2;
        }

        























    }
}
