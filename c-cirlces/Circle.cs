using System;
using System.Collections.Generic;

namespace c_cirlces
{
    public class Circle
    {

        /*
        Step 1: Create a class named Circle that has the following:
        - A private double radius property
        - A constructor that takes the radius as an argument
        - Methods to calculate the diameter, circumference, area, and grow the radius
        - Use System.Math.PI for the value of pi.
        */

        /*
        Circle Class Definition
        */

        // Step 1: Define the private radius variable
        public double Radius { get; set; }

        // Constructor that sets the radius
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Method to calculate the diameter
        public double CalculateDiameter()
        {
            return 2 * Radius;
        }

        // Method to calculate the circumference
        public double CalculateCircumference()
        {
            return 2 * Math.PI * Radius;
        }
        // Method to calculate the area
        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
        // Method to grow the circle by doubling the radius
        public void GrowCircle()
        {
            Radius *= 2;
        }

        // Method to get the current radius
        public double GetRadius()
        {
            return Radius;
        }
    }
}
