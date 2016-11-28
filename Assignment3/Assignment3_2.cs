using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ITC110 FL16
 * Assignment 3_2
 * Rebecca Scott
 * This program will tell if a number is odd or even*/

namespace Assignment3_2
{
    class Program
    {
        static void Main(string[] args)
        {

        	int number;

        	Console.WriteLine("Enter a number.");
        	number = int.Parse(Console.ReadLine());

        	Console.WriteLine();

        	if (number % 2 == 0)
        	{
        		Console.WriteLine("Your number is even.");
        	}//end if

        	else
        	{
        		Console.WriteLine("Your number is odd.");
        	}//end else

        	Console.WriteLine("Press any key to exit.");
        	Console.ReadKey();
        }//end static
    }//end Program
}//end Namespace
