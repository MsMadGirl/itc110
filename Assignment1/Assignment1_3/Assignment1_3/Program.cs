using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Assignment1_2
{
    class Program
    {
        /*Rebecca Scott 10/04/2016
        * This program will be a madlib*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a noun");
            string noun = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter a place");
            string place = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter a color");
            string color = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter a food");
            string food = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("There was a {0} from {1} who loved to eat {2} {3}.", noun, place, color, food);

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();

        }//end of main
    }//end of class
}//end of namespace
