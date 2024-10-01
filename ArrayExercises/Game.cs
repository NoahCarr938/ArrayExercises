using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

/* 
 * Array Exercises
 * - Write a function that lets the user enter 5 values into an array
 * - Add a function that prints the array
 * - Write a function that prints the sum of the elments in an integer array
 * - Write a function that prints the highest integer in an array
 * - Write a function that prints the lowest integer in an array
 * - Write a function that prints the array in reverse order
 */
namespace ArrayExercises
{
    internal class Game
    {
        int[] playerValues = new int[5];
        int max = 0;
        int min = 0;


        public void Run()
        {
            int[] ints = GetValues();

            PrintArray(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
            PrintReverse(ints);
        }

        int[] GetValues()
        {

            // The player enters 5 numbers.
            Console.WriteLine("Enter 5 Numbers.");
            int[] playerValues = new int[5];
            string input;

            
            for (int i = 0; i < playerValues.Length; ++i)
            {
                input = Console.ReadLine();

                //Console.Write(someArray[i]);
                if (Int32.TryParse(input, out int num))
                {
                    playerValues[i] = num;
                }
            }
            return playerValues;
        }

        int[] PrintArray(int[] array)
        {
            Console.WriteLine("Here are the numbers printed from the array.");
            Console.WriteLine();

            // for loop to read the playervalues and print them to the screen.
            for (int i = 0; i < playerValues.Length; ++i)
            {

                Console.WriteLine(array[i] + " ");
            }
            return playerValues;
        }

        int PrintSum(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the sum of the numbers in the array.");

            int sum = 0;
            for (int i = 0; i < playerValues.Length; ++i)
            {
                // Adds the sum of the array values.
                sum = sum + array[i];
            }
            Console.WriteLine(sum);

            return sum;
        }

        int PrintHighest(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the highest number from the array.");


            int max = array[0];
            for (int i = 0; i < playerValues.Length; ++i)
            {
                // Finds the max number out of the array.
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            Console.WriteLine(max);

            return max;
        }

        int[] PrintLowest(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the lowest number from the array.");

            int min = array[0];
            for (int i = 0; i < playerValues.Length; ++i)
            {
                // Finds the lowest number out of the array.
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            Console.WriteLine(min);


            return playerValues;
        }

        int[] PrintReverse(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the array printed in reverse.");

            // Prints the array in reverse order.
            for (int i = playerValues.Length - 1; i < playerValues.Length; --i)
            {
                if (i == -1)
                    break;

                Console.WriteLine(array[i]);


            }
            
            return array;
        }

    }
}
