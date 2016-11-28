using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    public class Mileage //make classes public; classes do nothing until called in main
    {
        //fields -- class level variables 
        //that describes the class
        private double miles; //private because internal members of the class should be hidden 
        private double gallons; //these are fields
        private double pricePerGallon;
        public double Miles//properties expose private fields to other classes; no parens indicates property
        {
            set {
                    miles = value;
                }//lets the variable be changed

            get {
                    return miles;
                }//returns the value of the variable
        }//end Miles property

        public double Gallons//properties capitalized
        {
            get//get and set order does not matter
            {
                return gallons;
            }

            set
            {
                gallons = value;
            }
        }//end Gallons

        public double PricePerGallon
        {
            get
            {
                return pricePerGallon;
            }

            set
            {
                pricePerGallon = value;
            }
        }//end PricePerGallon

        //public methods
        public double GetMilesPerGallon()//method
        {
            return Miles / Gallons;//would work with fields or properties
        }//end GetMilesPerGallon

        public double PricePerMiles()
        {
            double total = PricePerGallon * Gallons;
            return total / Miles;
        }//end PricePerMiles

        public double GetRange(int gasTankSize)
        {
            return GetMilesPerGallon() * gasTankSize;
        }

        //constructor special methods that initializes class and sets variables
        //if you don't make a constructor, default constructor runs
        public Mileage()//constructor, always public, always has same name as class, has no return
        {
            Miles = 0;
            Gallons = 0;
            PricePerGallon = 0;
        }//end Mileage constructor

        public Mileage(double totalMiles, double totalGallons, double gallonPrice)
            //program uses the constructor with same number of args as called in program; arguments must be different from other constructors
        {
            Miles = totalMiles;
            Gallons = totalGallons;
            PricePerGallon = gallonPrice;
        }//end second Mileage constructor


        //complete class contains objects, properties, methods, constructor(s)

    }//end class
}//end namespace
