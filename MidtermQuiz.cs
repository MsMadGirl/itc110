using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*MidtermQuiz
*ITC 110 Fall 2016
*Rebecca Scott
*This program will create an array of ten random integers and return the odd ones*/

namespace MidtermQuiz
{
    class Program
    {
        static void Main(string[] args)
        {
			Random rand = new Random();

            int[] randomNumbers = new int[10];


            
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                randomNumbers[i] = rand.Next(0, 10);//populates array with random numbers; works
            }//end for loop


			foreach(var i in randomNumbers)
			{
				if (randomNumbers[i] % 2 == 1)
				{
					Console.WriteLine(randomNumbers[i].ToString());
				
				}//end if
				
				    
			}//end foreach

				





        	Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }//end static
    }//end class
}//end namespace
