using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment4_3
*ITC 110 Fall 2016
*Rebecca Scott
*This program will display 
*the count of the loops and then asks the user 
*whether they want to continue or not*/

namespace Assignment4_3
{
    class Program
    {
        static void Main(string[] args)
        {

        	string continues="yes";
        	int loopCount=0;

            while (continues.Equals("yes"))
            	{
            		loopCount++;
            		Console.WriteLine("This is loop {0}.", loopCount);
            		Console.WriteLine("Do you want to continue? yes/no");
            		continues = Console.ReadLine();
                	continues = continues.ToLower();
				}//end while loop



        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
