using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Assignment5_2
*ITC 110 Fall 2016
*Rebecca Scott
*This program will randomly display a quote.*/

namespace Assignment5_2
{
    class Program
    {
        static void Main(string[] args)
        {

			string[] quotes = new string[10];//creates an array of strings
			quotes[0] = "I drink from the keg of glory, Donna!";
			quotes[1] = "The way out is the way in.";
			quotes[2] = "The sky above the port was the color of television, tuned to a dead channel.";
			quotes[3] = "Oy with the poodles already.";
			quotes[4] = "God, you're like a pop-up book from hell!";
			quotes[5] = "How many hit points does a gazebo have?";
			quotes[6] = "I'll just walk around some more and see if I can get into a pick-up meeting.";
			quotes[7] = "Andrew Jackson, in the main foyer of his White House had a big block of cheese.";
			quotes[8] = "Programming is a job where Lovecraft meets tradecraft, all the time";
			quotes[9] = "Circles, man. Circles.";
			
			Random quoteNum = new Random();//selects a random quote
			
			Console.WriteLine(quotes[quoteNum.Next(0,0)]);//prints the quote


        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
