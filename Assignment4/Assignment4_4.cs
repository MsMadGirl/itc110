using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment4_4
*ITC 110 Fall 2016
*Rebecca Scott
*This program will loop until the user types stop.*/

namespace Assignment4_4
{
    class Program
    {
        static void Main(string[] args)
        {
        	string continues = "go";
        	
        	 do 
            {
                Console.WriteLine("Stop?");
                continues = Console.ReadLine();
                continues = continues.ToLower();
            }while(continues!="stop");//end do loop



        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
