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
        * This program will take in name and address
        * and display them as
        * name
        * address
        * city, state zip*/
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your full name");
            string fullName = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter your street address");
            string address = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter your city");
            string city = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter your state");
            string state = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("Enter your zip code");
            string zip = Console.ReadLine();

            Console.WriteLine();

            Console.WriteLine("{0}", fullName);
            Console.WriteLine("{0}", address);
            Console.WriteLine("{0}, {1} {2}", city, state, zip);

            Console.WriteLine();

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        
        }//end of main
    }//end of class
}//end of namespace
