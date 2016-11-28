using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 4_1
*ITC 110 Fall 2016
*Rebecca Scott
*This program will display ten random numbers*/

namespace Assignment4_1
{
    class Program
    {
        static void Main(string[] args)
        {
			

			for (int loopCount=1;loopCount<=10;loopCount++)
			{
				Random rand = new Random();
				
				Console.WriteLine("{0}", rand.Next(1,51));
			}//end for loop


        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace

