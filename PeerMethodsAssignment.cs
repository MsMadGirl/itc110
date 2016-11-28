using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*PeerMethodsAssignment
*ITC 110 Fall 2016
*Rebecca Scott, Addissu Tamru
*This program will use methods to print out prime numbers*/

namespace PeerMethods
{
    class Program
    {
    	//Take in integer between 1 and 40
    	//Check that it is an integer
    	//Check that it is between 1 and 40
    	//Ask for valid number if not
    	//Apply equation
    	//Pause

    	static void Main(string[] args)
        {
			
        	Program p = new Program();
            int number=p.CheckNumber();
            p.Display(number);
            p.Pause();
        	
        }//end static Main

    	private int GetNumber()
        {
            Console.WriteLine("Enter an integer between 1 and 40");
            int number=0;
            bool good = false;
            
            while (!good)
            {
                good = int.TryParse(Console.ReadLine(), out number);
                if (!good)
                    Console.WriteLine("Enter a valid integer");
            }//end while; checks for valid integer

            return number;
        }//end GetNumber

        private int CheckNumber()
        {
            int num = GetNumber();
            //the while instead of an if
            //loops until they get it right
            while (num < 0 || num > 40)
            {
                num = GetNumber();
            }
            return num;
        }//end CheckNumber; checks for number between 1 and 40

        private int Calculate(int number)
        {
        	return number * number - number + 41;
        }//end Calculate

        private void Display(int number)
        {
        	Console.WriteLine("Your prime number is {0}.", Calculate(number));
        }//end Display

    	private void Pause()
    	{
    		Console.WriteLine("Press any key to continue");
            Console.ReadKey();
    	}//end Pause

    }//end class
}//end namespace
