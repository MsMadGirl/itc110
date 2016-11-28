using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        /*Rebecca Scott, Addissu Tamru, and Muletu Kalil*/ 
        private const double PI = 3.14159;//added three more digits to pi, not an error, just a preference
        private double radius = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetMeasurements();//missing ;
            p.DisplayMeasurements();
            Console.ReadKey();//remove p.
        }//end main

        private double CalculateArea()//first letter of calculate not capitalized
        {
            return radius * radius * PI;
        }//end CalculateArea

        private double CalculateCircumference()//first letter of calculate not capitalized
        {
            return radius * 2 * PI;
        }//end CalculateCircumference

        private double GetMeasurements()//made double not void
        {
            Console.WriteLine("Enter the radius of the circle");
            radius = double.Parse(Console.ReadLine());//removed double
            return radius;//added return radius
        }//end GetMeasurements

        private void DisplayMeasurements()
        {
            Console.WriteLine("the circumference is {0}", CalculateCircumference());//added () after CalculateCircumference
            Console.WriteLine("the area is {0}", CalculateArea());//had {1} should be {0}, capitalize Calculate
        }//end DisplayMeasurements


    }//end class
}//end namespace