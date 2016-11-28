using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExample2
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] teams = new string [5]; works, too
            string[] teams = { "Seahawks", "Cardinals", "Rams", "Forty-Niners" }; //will figure out length of array on its own

            for(int i = 0; i<teams.Length; i++)
            {
                Console.WriteLine(teams[i]);
            }

            Console.WriteLine();
            Array.Sort(teams);//sorts alphabetically

            string[] foods;

            Console.WriteLine("How many foods do you want to list?");
            int number = int.Parse(Console.ReadLine());

            foods = new string[number];

            for (int i = 0; i<foods.Length; i++)//if you use <= instead of <, you'll get an out of bound error
                //because highest index number is always length - 1, due to starting count at 0
                {
                    Console.WriteLine("Add a food.");
                    foods[i] = Console.ReadLine();
                }

            foreach (string s in foods)//new kind of loop, can only work with array when it's populated
                {
                    Console.WriteLine(s);
                }

            string[,] Books = new string[3, 2];//comma makes it a 2D array
            Books[0, 0] = "Lord of the Rings";
            Books[0, 1] = "JRR Tolkein";
            Books[1, 0] = "Ulysses";
            Books[1, 1] = "James Joyce";
            Books[2, 0] = "Gravity's Rainbow";
            Books[2, 1] = "Thomas Pinchon";

            Console.WriteLine("Enter a title.");
            string title = Console.ReadLine();

            for (int i = 0; i<3; i++)
                {
                    if(title.Equals(Books[i,0]))
                    {
                        Console.WriteLine(Books[i, 1]);
                    }//end if loop


                }//end for loop



            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
