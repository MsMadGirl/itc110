using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This exercise will ask for and validate a 
 * customer name and password
 * Peer Exercise Ifs
 * ITC 110 FL 16
 * Group 2
 * Rebecca Scott
 * Addissu Tamru*/

namespace PeerExerciseIfs
{
    class Program
    {
        static void Main(string[] args)
        {
            string customer;
            string password;

            Console.WriteLine("Enter username.");
            customer = Console.ReadLine();

            if (customer.Equals("customer"))
            {
                Console.WriteLine("Please enter your password.");
                password = Console.ReadLine();

                if (password.Equals("P@ssw0rd1"))
                    {
                        Console.WriteLine("Thank you, you are now logged in.");
                    }//end inner if password

                else
                    {
                    Console.WriteLine("Please restart and enter a valid password.");
                    Console.WriteLine("Please press any key to continue.");
                    Console.ReadKey();
                    return;
                }//end inner else password

            }//end outter if customer

            else
            {
                Console.WriteLine("Please restart and enter a valid username.");
                Console.WriteLine("Please press any key to continue.");
                Console.ReadKey();
                return;
            }//end else

            Console.WriteLine("Please press any key to continue.");
            Console.ReadKey();
        }//end main
    }//end program class
}//end namespace
