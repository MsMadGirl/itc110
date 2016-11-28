using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment5_3
*ITC 110 Fall 2016
*Rebecca Scott
*This program will create an array of ten doubles, prompt user to submit numbers,
*display the array, the total, and the average.*/

namespace Assignment5_3
{
    class Program
    {
        static void Main(string[] args)
        {
			double[] thingie = new double[10];

			
			Console.WriteLine("Please input ten numbers. They may be decimals.");
			
			for (int i=0; i<thingie.Length; i++)
			{
				thingie[i] = double.Parse(Console.ReadLine());
			}//end for loop

			Console.WriteLine();
		
			foreach(var i in thingie)
			{
			    Console.WriteLine(i.ToString());
			}//end foreach; required to print a damn array, why is there no easier way?
		
			Console.WriteLine();
			double sum= thingie.Sum();
			Console.WriteLine("The total is {0}.", sum);
			double average = sum / thingie.Length;
			Console.WriteLine("The average is {0}.", average);


        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
