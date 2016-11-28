using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*This program will intake a birthdate 
 * and output whethere or not the person 
 * is old enough to buy alcohol
 * ITC110 FL16
 * Rebecca Scott
 * 10/11/2016*/

namespace Birthdate
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime birthday;
            DateTime today = DateTime.Now;
            int age;
            int years;
            int months;

            Console.WriteLine("Enter your birthdate.");
            bool goodDate = DateTime.TryParse(Console.ReadLine(), out birthday);

            if (!goodDate)
            {
                Console.WriteLine("Enter a valid birth date.");
                bool good = DateTime.TryParse(Console.ReadLine(), out birthday);
                if(!good)
                {
                    Console.WriteLine("Sorry still not valid.");
                    Console.WriteLine("Press any key to exit.");
                    Console.ReadKey();
                    return;
                }//end inner if !good

            }//end outer if !goodDate

            age = today.Year - birthday.Year;
            Console.WriteLine("You are {0} years old.", age);


            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();

        }//end main
    }//end program class
}//end namespace
