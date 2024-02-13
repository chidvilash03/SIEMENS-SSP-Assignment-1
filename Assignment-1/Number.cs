using System;

namespace NumberClass
{
    // number class
    class Number
    {
        double number;

        //constructor
        public Number(double x)
        {
            number = x;
        }

        //method to check whether the number is positive or negative or zero
        public void CheckNumber()
        {
            if (number > 0)
            {
                Console.WriteLine("The given number is Positive.");
            }
            else if (number < 0)
            {
                Console.WriteLine("The given number is Negative");
            }
            else
            {
                Console.WriteLine("The given number is Zero");
            }

        }

         
    }
}