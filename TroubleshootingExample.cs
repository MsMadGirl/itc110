using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TroubleShootingExample
{
    class Program
    {
        /*******************************
        This program creates an array
        Populates it with random numbers
        outputs the contents of the array
        and then returns the average,
        the minimum and the maximum
        values in the array.
        Several errors have been built in.
        Steve Conger 11/5/2016
        ********************************/

        int size = 0;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Display();
            p.PauseIt();//added p.
        }//end main



        private int[] CreateArray()
        {
            Console.WriteLine("Enter the size of the Array");
            size = int.Parse(Console.ReadLine());
            int[] myRandomArray = new int[size];
            return myRandomArray;
        }

        private int[] PopulateArray()
        {
            int[] myArray = CreateArray();
            Random rand = new Random();
            for (int i = 0; i < myArray.Length; i++)
            {
                int number = rand.Next(1, 1001);
                myArray[i] = number;
            }

            return myArray;
        }

        private void DisplayArrayValues(int[] rArray)
        {
            foreach (int i in rArray)
            {
                Console.WriteLine(i);
            }
        }


        private int CalculateAverage(int[] rArray)
        {
            int total = 0;
            for (int i = 0; i < rArray.Length; i++)
            {
                total += rArray[i];
            }
            int average = total / size;//moved above return
            return average;
            

        }

        private int CalculateMaximum(int[] rArray)
        {
            int max = 0;
            foreach (int i in rArray)
            {
                if (max < i)
                    max = i;
            }
            return max;
        }

        private int CalculateMinimum(int[] rArray)
        {
            int min = rArray[0];
            foreach (int i in rArray)
            {
                if (min > i)
                    min = i;
            }
            return min;
        }

        private void Display()
        {
            int[] newArray = PopulateArray();
            DisplayArrayValues(newArray);
            Console.WriteLine();
            Console.WriteLine("The Average array value is {0}", CalculateAverage(newArray));
            Console.WriteLine("The maximum value is {0}", CalculateMaximum(newArray));//capitalized L in WriteLine
            Console.WriteLine("The minimum value is {0}", CalculateMinimum(newArray));

        }

        private void PauseIt()
        {
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }


    }

}
