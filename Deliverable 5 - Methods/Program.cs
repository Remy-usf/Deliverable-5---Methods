/* 
 Name: Jurami Cajigas
 Date: 2/14/2023
 Description: C# Application for Random Number Generation
 */

using System;

namespace Deliverable_5___Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer number between 5 and 15:");
            int userInput = 0;
            try
            {
                userInput = int.Parse(Console.ReadLine());
                if (userInput < 5 || userInput > 15)
                {
                    Console.WriteLine("The number must be between 5 and 15.");
                    return;
                }
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid input. Please enter an integer number.");
                return;
            }

            int[] array = Method1(userInput);
            Console.WriteLine("The elements of the array are:");
            foreach (int element in array)
            {
                Console.Write(element + " ");
            }
            Console.WriteLine();

            int sum = Method2(array);
            Console.WriteLine("The sum is: " + sum);

            Console.ReadLine();
        }

        static int[] Method1(int arrayLength)
        {
            int[] array = new int[arrayLength];
            Random random = new Random();
            for (int i = 0; i < arrayLength; i++)
            {
                array[i] = random.Next(10, 51);
            }
            return array;
        }

        static int Method2(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            return sum;
        }
    }
}