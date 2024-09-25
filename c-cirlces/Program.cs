using GeneralPurposeFunctions;
using System;


namespace c_cirlces
{
    internal class Program
    {
        static CommonlyUsedFunctions myFuncs = new CommonlyUsedFunctions();
        static void Main(string[] args)
        {
            //Task:
            //Calculate a circle’s diameter, circumference, and area.Allow the user to grow the circle by doubling its radius and recalculate these values.


            /*
            Step 1: Create a class named Circle that has the following:
            - A private double radius property
            - A constructor that takes the radius as an argument
            - Methods to calculate the diameter, circumference, area, and grow the radius
            */
            //Created Circle.cs file and added the Circle class to it

            //Step 2: Write the Main program to:
            //- Prompt the user to enter a radius
            myFuncs.WriteSeparatorLine("Welcome to the Circle Tester!");
            double userInput = Validator.GetValidRadius();

            //- Create a Circle object using the input
            Circle myCircle = new Circle(userInput);

            //- Display the diameter, circumference, and area
            Console.WriteLine($"Diameter: {myCircle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}");
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");

            //- Ask the user if they want to grow the circle
            Console.WriteLine("Do you want to grow the circle? (y/n)");
            //use validator to validate user input
            string userResponse = Validator.ContinueValidateYesNo();//if the input is valid, set the userResponse to the input, else set it to "n"
            if (userResponse == "y")
            {
                myCircle.GrowCircle();
                Console.WriteLine($"Circle has been grown. New radius: {myCircle.GetRadius()}");
            }
            else 
            {
                Console.WriteLine("Circle has not been grown.");
            }
            //- Recalculate the circle's values if it grows, and loop if necessary
            Console.WriteLine($"Diameter: {myCircle.CalculateDiameter()}");
            Console.WriteLine($"Circumference: {myCircle.CalculateCircumference()}");
            Console.WriteLine($"Area: {myCircle.CalculateArea()}");
            //- End the program by displaying the final radius
            Console.WriteLine($"Final Circle Radius: {myCircle.GetRadius()}");

            //call classes




        }
    }
}
