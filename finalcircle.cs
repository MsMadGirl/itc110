using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Create a class called "Circle." The class has a private 
constant PI with a value of 3.14. It has a field called 
"radius" that can be entered through a constructor or a 
property. (You should also have an empty constructor). 
The class should have three public methods. One that 
returns the diameter (radius * 2), one that returns the 
circumference (2 * PI * radius) and one that returns the 
Area (PI * (radius * radius)). You do not have to show the 
class being implemented though you may want to try it 
before uploading it to be sure it works as intended.*/


namespace FinalCircle
{
    public class Circle
    {
        private double pi = 3.14159;
        private double radius;
		
        public double Radius
        {
            set
            {
                radius = value;
            }

            get
            {
                return radius;
            }
        }

        public double Diameter(double radius)
        {
            double diameter = 2 * radius;
            return diameter;
        }

        public double Circumference(double radius)
        {
            double circum = 2 * pi * radius;
            return circum;
        }

        public double Area(double radius)
        {
            double area = pi * radius * radius;
            return area;
        }

        public Circle()
        {

        }

        

    }//end Circle
}//end namespace