using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 4_2
*ITC 110 Fall 2016
*Rebecca Scott
*This program will count down from 10 to 0*/

namespace Assignment4_2
{
    class Program
    {
        static void Main(string[] args)
        {

        	for (int i=10; i>=0; i--)
        		{
        			Console.WriteLine(i);
        		}//end for loop


        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
