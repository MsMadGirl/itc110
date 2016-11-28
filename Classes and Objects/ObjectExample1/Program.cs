using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectExample1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mileage m = new ObjectExample1.Mileage();
            double miles = 300;
            double gallons = 12;
            double pricePerGallon = 2.50;

            Mileage m = new Mileage(miles, gallons, pricePerGallon);

            Console.WriteLine("Your miles per gallon: {0}", m.GetMilesPerGallon());
            //can assign variable or can call property from within
            Console.WriteLine("It cost you: {0}", m.PricePerMiles());

            Console.ReadKey();
        }//end main
    }//end class
}//end namespace
