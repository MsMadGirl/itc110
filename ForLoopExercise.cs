using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoopExercise
{
    class Program
    {/*This program will explore repetition
        *with for loops
        * Rebecca Scott
        * ITC 110 FL 16
        * 10/18/16*/
        static void Main(string[] args)
        {
            int number = 0;
            long number2 = 0;
            Console.WriteLine("How many times do you want to loop?");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number to get exponent.");
            number2 = long.Parse(Console.ReadLine());

            for(int i=1; i<=number; i++)
            {
                number2 *= number2; //number=number*number
                Console.WriteLine(number2);
            }//end for loop

            for(int i=0; i<=10; i++) //i is just a counter, ++ incrememnts by 1, +=2 would increment by 2
            {
                Console.WriteLine(i);
            }//end for loop

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
               

        }//end main
    }//end class
}//end namespace
