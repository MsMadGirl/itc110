using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 2, part 1
*ITC 110 Fall 2016
*Rebecca Scott
*This program will take in two integers and ouput the sum, 
*the difference and the product.*/

namespace assignment2_1
{
    class Program
    {
        static void Main(string[] args)
        {
        	int zeroeth;
        	int first;
        	int answer;
        	int answer1;
        	int answer2;

        	Console.WriteLine("Enter an integer.");
        	zeroeth = int.Parse(Console.ReadLine());
			
        	Console.WriteLine("Enter another integer.");
        	first = int.Parse(Console.ReadLine());
			

        	Console.WriteLine();

        	answer = zeroeth + first;

        	Console.WriteLine("The sum of {0} + {1} = {2}.", zeroeth, first, answer);

			answer = zeroeth - first;

        	Console.WriteLine("The difference of {0} - {1} = {2}.", zeroeth, first, answer);

        	answer = zeroeth * first;

        	Console.WriteLine("The product of {0} * {1} = {2}.", zeroeth, first, answer);

        	answer1 = zeroeth / first;
        	answer2 = zeroeth % first;

        	Console.WriteLine("The quotient of {0} / {1} = {2} remainder {3}", zeroeth, first, answer1, answer2);

        	Console.WriteLine();

        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();




        }//close statc
    }//close class
}//close namespace
