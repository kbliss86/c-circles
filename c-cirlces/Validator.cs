using System;
using System.Collections.Generic;

namespace c_cirlces
{
    public class Validator
    {

        // Method to get a valid radius from the user
        public static double GetValidRadius()
        {
            double radius = 0;
            bool isValid = false;

            while (!isValid)
            {
                Console.Write("Enter the radius of the circle: ");
                string input = Console.ReadLine();

                if (double.TryParse(input, out radius) && radius > 0)//TryParse will try and parse the input as a double and return a true false, if it is a double it will set the radius to the input
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a positive number.");
                }
            }

            return radius;
        }

        //method to validate user input (y/n)
        public static string ContinueValidateYesNo()
        {
            string input2 = "";
            bool isValid = false;
            while (!isValid)
            {
                Console.WriteLine("Would You Like to Continue (y/n)");
                input2 =Console.ReadLine();
                if (input2.ToLower() == "y" || input2.ToLower() == "n")
                {
                    isValid = true;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter 'y' or 'n'.");
                    isValid = false;
                }
            }
            return input2;

        }
    }
}
