using System;

namespace ArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO:

            // DONE Create an int Array and populate numbers 1-10
            int[] myArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var evens = new List<int>();
            var odds = new List<int>();

            for (int i = 0; i < myArray.Length; i++)
			{
                if (myArray[i] % 2 == 0)
                {
                    evens.Add(myArray[i]);
                }
               
			}

            foreach (int i in myArray)
			{
                if (myArray [i]) % 2 != 0)
                    {
                    odds.Add(myArray[i]);
				}
			}
			{
                Console.WriteLine(odds);
                Console.WriteLine(evens);
			}
            /* DONE Create two Lists of type int.
            
             * DONE Name one List "evens"
             * DONE Name the other List "odds"
             */

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
