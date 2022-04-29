using System;
using System.Collections.Generic;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // Create an int Array and populate numbers 1-10
            int[] numOfPlayers = new int[10];

            numOfPlayers[0] = 1;
            numOfPlayers[1] = 2;
            numOfPlayers[2] = 3;
            numOfPlayers[3] = 4;
            numOfPlayers[4] = 5;
            numOfPlayers[5] = 6;
            numOfPlayers[6] = 7;
            numOfPlayers[7] = 8;
            numOfPlayers[8] = 9;
            numOfPlayers[9] = 10;
            /* Create two Lists of type int.
             * Name one List "evens"
             * Name the other List "odds"
             */
            var evens = new List<int>();
            var odds = new List<int>();


            for (int i = 0; i < 10; i++)
            {
                if (i %2 == 0)
                { 
                    evens.Add(i);               
                }
                else
                {
                    odds.Add(i);
                }
            }

            foreach (var num in evens)
            {
                Console.WriteLine(num);
            }
            foreach(var number in odds)
            {
                Console.WriteLine(number);
            }

            /* Using either a foreach or for loop,
             * nest an if statement to check to see
             *  if a number is even or odd.
             * Then add those numbers to either the evens List
             * or the odds List
             */

            /* Now using foeach or for loops,
             * display each List of even and odd numbers
             *
             * Try to be creative in your display
             */
        }
    }
}
