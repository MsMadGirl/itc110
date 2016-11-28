using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 5_1
*ITC 110 Fall 2016
*Rebecca Scott
*This program will create an array of 50 random integers
*and output a count of how many are even*/

namespace Assignment5_1
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rand = new Random();
			int evenNum = 0;

            int[] randomNumbers = new int[50];
            
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(0, 200);
				
				if (randomNumbers[i] %2 == 0)//tests if number is even
				{
					evenNum ++;//increments the count of even numbers
				}//end if
				
				else
				{
					evenNum = evenNum;//says if it's odd, don't do anything
				}//end else
				
				Console.WriteLine("There are {0} even numbers in this array.", evenNum);
				
            }//end for loop




        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
