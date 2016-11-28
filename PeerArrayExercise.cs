using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeerArrayExercise
{
    class Program
    {

        /*Peer Exercise Arrays
         * ITC110 FL 16
         * Rebecca Scott*/
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] randomNumbers = new int[20];
            
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(0, 40);
				Console.WriteLine(randomNumbers);
            }

            Console.WriteLine("The lowest number is {0}.", randomNumbers.Min());
            Console.WriteLine("The highest number is {0}.", randomNumbers.Max());

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
