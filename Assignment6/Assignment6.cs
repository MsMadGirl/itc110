using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment6
*ITC 110 Fall 2016
*Rebecca Scott
*This program will take in grades and credits and output a weighted GPA using methods*/

namespace Assignment6
{
    class Program
    {

        //take input from user
        //populate grade array and credit array
        //calculates GPA and returns a double; use foreach loop...
        //...to multiple grade * credit, add them all together...
        //...and divide by the total number of credits
        //display method
        //pause method


        static void Main(string[] args)
        {
            //main method starts program and calls display
            Program p = new Program();
            p.Display();//calls Display
            p.Pause();//calls Pause

        }//end static

        //take input from user
        //get grades and populate array
        private double[] GetGrades()//use private, not static
        {
            double[] grades = new double[4];
            Console.WriteLine("Please input grades for four classes.");

            for (int i = 0; i < grades.Length; i++)
            {
            	
                Console.WriteLine("Class {0}:", (i+1));
                grades[i] = double.Parse(Console.ReadLine());
            }//end for loop

            return grades;

        }//end GetGrades

        //take input from user
        //get credits and populate array
        private double[] GetCredits()
        {
            double[] credits = new double[4];
            Console.WriteLine("Please input credits for four classes.");

            for (int i = 0; i < credits.Length; i++)
            {
            	
                Console.WriteLine("Class {0}:", (i+1));
                credits[i] = double.Parse(Console.ReadLine());
            }//end for

            return credits;

        }//end GetCredits

        private double Calculate()
        {
            double[] grades = GetGrades();
            double[] credits = GetCredits();
            double weight = 0;
            double sum = credits.Sum();
            double gpa = 0;

            for (int i = 0; i < grades.Length; i++)
            {
                weight += grades[i] * credits[i];

            }//end for

            gpa = weight / sum;

            return gpa;

        }//end Calculate

        private void Display()
        {
            double gpa = Calculate();
            Console.WriteLine("Your weighted GPA is {0}.", gpa);

        }//end Display

        private void Pause()
        {
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }//end Pause







    }//end class
}//end namespace
