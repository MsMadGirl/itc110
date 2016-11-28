using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExample
{
    class Program
    {
        //int number; this would make available everwhere 
        //in the class
        static void Main(string[] args)
        {
            Program p = new Program();
            p.GetNumber();
            p.Pause();
        }

        private void GetNumber()
        {
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            Display(number);
        }

        private void Display(int numb)
        {
            int result = Cube(numb);
            Console.WriteLine("The cube of {0} is {1}", numb, result);
        }
           

        private int Cube(int num)
        {
            int cube = num * num * num;
            return cube;
        }

        private void Pause()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}