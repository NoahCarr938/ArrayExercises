using System;
using System.Collections.Generic;
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


        public void Run()
        {
            int[] ints = GetValues();

            PrintArray(ints);
            PrintReverse(ints);
            PrintSum(ints);
            PrintHighest(ints);
            PrintLowest(ints);
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
            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Here are the numbers printed from the array.");
            Console.WriteLine();

            for (int i = 0; i < playerValues.Length; ++i)
            {
                Console.Write(playerValues[i] + " ");
            }
            return playerValues;
        }

        int PrintSum(int[] array)
        {
            Console.WriteLine();
            Console.WriteLine("Here is the sum of the numbers in the array.");

            return 0;
        }

        int[] PrintHighest(int[] array)
        {
            Console.WriteLine("Here is the highest number from the array.");
            return playerValues;
        }

        int[] PrintLowest(int[] array)
        {
            Console.WriteLine("Here is the lowest number from the array.");
            return playerValues;
        }

        int[] PrintReverse(int[] array)
        {
            Console.WriteLine("Here is the array printed in reverse.");
            Console.WriteLine();
            
            return playerValues;
        }
        int GetInput(string description, string userinput1, string userinput2, string userinput3, string userinput4, string userinput5)
        {
            string input = "";
            int inputReceived = 0;

            while (inputReceived != 1 && inputReceived != 2)
            {
                Console.WriteLine(description);
                Console.WriteLine(userinput1);
                Console.WriteLine(userinput2);
                Console.WriteLine(userinput3);
                Console.WriteLine(userinput4);
                Console.WriteLine(userinput5);
                Console.Write("> ");

                input = Console.ReadLine();

                if (input == "" || input == userinput1)
                {
                    userinput1 = "";
                }
                else if (input == "" || input == userinput2)
                {
                    userinput2 = "";
                }
                else if (input == "" || input == userinput3)
                {
                    userinput3 = "";
                }
                else if (input == "" || input == userinput4)
                {
                    userinput4 = "";
                }
                else if (input == "" || input == userinput5)
                {
                    userinput5 = "";
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                    Console.ReadKey();
                }
                
            }
            Console.Clear();
            return inputReceived;
        }
    }
}
