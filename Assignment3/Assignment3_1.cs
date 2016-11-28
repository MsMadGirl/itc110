using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ITC110 FL16
 * Assignment 3_1
 * Rebecca Scott
 * This program will calculate a tip.*/

namespace Assignment3_1
{
    class Program
    {
        static void Main(string[] args)
        {
        	double meal;
        	double tipPercent;
        	double answerTip;

        	Console.WriteLine("Enter the amount for your meal.");
            meal = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the percent tip you want to pay.");
            tipPercent = double.Parse(Console.ReadLine());

            if (tipPercent > 1)
            {
            	answerTip = tipPercent / 100 * meal;

            	Console.WriteLine();

            	Console.WriteLine("The tip amount is {0}.", answerTip);
            }//end if

            else
            {
            	answerTip = tipPercent * meal;

            	Console.WriteLine();

            	Console.WriteLine("The tip amount is {0}.", answerTip);
            }//end else
            
            Console.WriteLine("Press any key to exit.");
        	Console.ReadKey();


        }//end static
    }//end Program
}//end Namespace
