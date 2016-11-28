using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*ITC110 FL16
 * Assignment 3_3
 * Rebecca Scott
 * This program will return a letter grade when given a grade point.*/

namespace Assignment3_3
{
    class Program
    {
        static void Main(string[] args)
        {
        	double gradePoint;
        	string letterGrade;

        	Console.WriteLine("Please enter a grade between 0 and 4.");
        	gradePoint = double.Parse(Console.ReadLine());
        	Console.WriteLine();

        	if (gradePoint > 0 && gradePoint < 4)
        	{
        		if (gradePoint >= 3.5 && gradePoint <= 4)
        		{
        			Console.WriteLine("Your grade is an A.");
        		}//end if A

        		else if (gradePoint >= 3.0 && gradePoint <= 3.4)
        		{
        			Console.WriteLine("Your grade is a B.");
        		}//end else if B

        		else if (gradePoint >= 2.0 && gradePoint <= 2.9)
        		{
        			Console.WriteLine("Your grade is a C.");
        		}//end else if C

        		else if (gradePoint >= 1.0 && gradePoint <= 1.9)
        		{
        			Console.WriteLine("Your grade is a D.");
        		}//end else if D

        		else 
        		{
        			Console.WriteLine("Your grade is an F.");
        		}//end inner else

        	}//end outer if

        	else
        	{
        		Console.WriteLine("Invalid grade. Please exit and try again.");
        	}//end outer else

        	Console.WriteLine("Press any key to exit.");
        	Console.ReadKey();

        }//end static
    }//end Program
}//end Namespace
