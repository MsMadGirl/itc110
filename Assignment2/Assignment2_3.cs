using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment 2, part 3
*ITC 110 Fall 2016
*Rebecca Scott
*This program will take in a meal amount and output tax and tip.*/

namespace assignment2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int meal;
            double tipPercent;
            double tax;
            double answerTip;
            double answerTax;
            double total;

            tax = .092;

            Console.WriteLine("Enter the amount for your meal.");
            meal = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the percent tip you want to pay.");
            tipPercent = int.Parse(Console.ReadLine());
            

            Console.WriteLine();

            answerTip = tipPercent / 100 * meal;

            Console.WriteLine("The tip amount is {0}.", answerTip);

            answerTax = meal * tax;

            Console.WriteLine("The tax amount is {0}.", answerTax);

            total = meal + answerTip + answerTax;

            Console.WriteLine("Your total for your meal is {0}.", total);

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();




        }//close statc
    }//close class
}//close namespace
