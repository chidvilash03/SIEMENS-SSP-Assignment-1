using System;

namespace FibonacciClass
{
    class Fibonacci
    {
        public int limit;

        public Fibonacci(int x)
        {
            limit = x;
        }

        public void DisplaySeries()
        {
            int firstNumber = 0;
            int secondNumber = 1;

            Console.WriteLine("Fibonacci Series up to " + limit + ":");

            // Print the first two numbers of the Fibonacci series
            Console.Write(firstNumber + " " + secondNumber + " ");
            limit -= 2;
            // Generate Fibonacci series using a while loop
            while (limit > 0)
            {
                int nextNumber = firstNumber + secondNumber;
                Console.Write(nextNumber + " ");

                // Update the values for the next iteration
                firstNumber = secondNumber;
                secondNumber = nextNumber;
                limit--;
            }

        }
    }
}