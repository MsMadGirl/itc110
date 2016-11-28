using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Rebecca Scott
 * ITC110 FL 16
 * Peer While Loop Exercise
 * This program demonstrates while loops*/
namespace WhileLoopExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice=1;

            while (choice != 4)
            {
                Console.WriteLine("Hello\t :\t 1");
                Console.WriteLine("Hello2\t :\t 2");
                Console.WriteLine("Hello3\t :\t 3");
                Console.WriteLine("Goodbye\t :\t 4");
                //Console.WriteLine("Enter your choice.");

                bool goodChoice = false;

                while (goodChoice == false)
                {
                    Console.WriteLine("Enter your choice.");
                    goodChoice = int.TryParse(Console.ReadLine(), out choice);

                    if (!goodChoice)
                    {
                        Console.WriteLine("Enter an integer 1 to 4.");
                    }//end if loop
                }//end while loop; this set of loops makes it not crash is someone enters something other than an integer

                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Hello One");
                        break;
                    case 2:
                        Console.WriteLine("Hello Two");
                        break;
                    case 3:
                        Console.WriteLine("Hello Three");
                        break;
                    case 4:
                        Console.WriteLine("Goodbye");
                        break;
                    default:
                        Console.WriteLine("Invalid Choice.");
                        break;
                }//end switch


            }//end while loop

            string continues= "yes";

            do //use do loops when it's really important that it goes through the loop once
            {
                Console.WriteLine("Continue yes/no?");
                continues = Console.ReadLine();
                continues = continues.ToLower();
            }while(continues.Equals("yes"));//end do loop

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }//end main
    }//end class
}//namespace
