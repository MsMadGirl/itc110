using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipMethodExample
{
    /*Rebecca Scott
     * This program will demonstrate methods via a tip calculator*/
    class Program
    {
        //determine amount of meal
        //determine percent of tip
        //calculate tax amount
        //calculate tip amount
        //display amount, tax, tip and total
        private const double TAXPERCENT = .092;
        private const double PERCENTDIVISOR = 100;
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Calculate();//calls Calculate, which calls GetMealAmount, GetTipPercent, and Display
            p.Pause();
        }//end main

        private Double GetMealAmount()
        {
            Console.WriteLine("Enter the meal amount.");
            double amount = double.Parse(Console.ReadLine());
            return amount;
        }//end GetMealAmount

        private Double GetTipPercent()
        {
            Console.WriteLine("Enter the tip percent as a whole number.");
            double tipPercent = double.Parse(Console.ReadLine());//in real life do a tryParse and if to check if it's a valid number
            return tipPercent;
        }//end GetTipPercent

        private void Calculate()
        {
            double mealAmount = GetMealAmount();
            double tipP = GetTipPercent();
            double taxAmount = mealAmount * TAXPERCENT;
            double tipAmount = mealAmount * (tipP/PERCENTDIVISOR);
            double total = mealAmount + taxAmount + tipAmount;
            Math.Round(total, 2);//rounds total to 2 decimal places; affects underlying number
            Display(mealAmount, taxAmount, tipAmount, total);//necessary to pass multiple numbers to Display method
        }//end Calculate

        private void Display(double meal, double tax, double tip, double total)//passes numbers from Calculate method
        {
            Console.WriteLine("Meal:\t\t{0:C}", meal);//:C expresses it as currency; affects display, not underlying number
            Console.WriteLine("Tax:\t\t{0:C}", tax);
            Console.WriteLine("Tip:\t\t{0:C}", tip);
            Console.WriteLine("Total:\t\t{0:C}", total);
        }//end Display

        private void Pause()
        {
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
        }//end Pause

    }//end class
}//end namespace
