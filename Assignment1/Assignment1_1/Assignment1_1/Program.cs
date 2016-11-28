using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_1
{
    /*Rebecca Scott 10/04/2016
     * This program will take in a user's 
     * name and email and display them.*/
    class Program
    {
        //starting point of the program
        static void Main(string[] args)
        {
            string firstName;
            string lastName;
            string email;

            Console.WriteLine("Enter Your First Name");
            firstName = Console.ReadLine();

            Console.WriteLine("Enter Your Last Name");
            lastName = Console.ReadLine();

            Console.WriteLine("Enter Your Email");
            email = Console.ReadLine();

            Console.WriteLine("{0}, {1} -- {2}", lastName, firstName, email);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }//end of main
    }//end of class program
}//end of namespace
