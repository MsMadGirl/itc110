using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 2, part 2
*ITC 110 Fall 2016
*Rebecca Scott
*This program will take in two integers and ouput 
*the quotient and modulus.*/

namespace assignment2_2
{
    class Program
    {
        static void Main(string[] args)
        {
        	int zeroeth;
        	int first;
        	int answer1;
        	int answer2;

        	Console.WriteLine("Enter an integer.");
        	zeroeth = int.Parse(Console.ReadLine());
			
        	Console.WriteLine("Enter another integer.");
        	first = int.Parse(Console.ReadLine());
			

        	Console.WriteLine();

        	answer1 = zeroeth / first;
        	answer2 = zeroeth % first;

        	Console.WriteLine("The quotient of {0} / {1} = {2} remainder {3}", zeroeth, first, answer1, answer2);

        	Console.WriteLine();

        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();




        }//close statc
    }//close class
}//close namespace
