using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerWhileLoop
{
    /*Rebecca Scott
     * ITC110 FL16
     * This program will offer the user three choices*/
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 1;
            while (choice != 3)
            {
                Console.WriteLine("1:\t Choice 1");
                Console.WriteLine("2:\t Choice 2");
                Console.WriteLine("3:\t Exit");
                choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("You have chosen option one");
                        break;

                    case 2:
                        Console.WriteLine("You have chosen option two");
                        break;

                    case 3:
                        Console.WriteLine("Goodbye");
                        break;

                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }//end switch

            }//end while loop

            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
