using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        string[] someArray = new string[5];
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

            string[] someArray = new string[5];
            // The player enters 5 numbers.
            Console.WriteLine("Enter 5 Numbers.");

            someArray[0] = Console.ReadLine();
            someArray[1] = Console.ReadLine();
            someArray[2] = Console.ReadLine();
            someArray[3] = Console.ReadLine();
            someArray[4] = Console.ReadLine();
            

            // Int32.Parse()
            string test = "";
            int x = 0;
            if (Int32.TryParse(test, out int num))
            {
                x = num;
            }
            return null;
        }

        int[] PrintArray(int[] array)
        {
            
            foreach(string num in someArray)
            {
                Console.WriteLine(num);
            }
            return null;
        }

        int PrintSum(int[] array)
        {

            return 0;
        }

        int[] PrintHighest(int[] array)
        {
            return null;
        }

        int[] PrintLowest(int[] array)
        {
            return null;
        }

        int[] PrintReverse(int[] array)
        {
            
            return null;
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
