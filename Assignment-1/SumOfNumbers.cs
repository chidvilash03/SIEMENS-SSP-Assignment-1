using System;

namespace SumOFNumbersClass
{
    // SumOfNumbers class
    class SumOfNumbers
    {

        public void CalculateSumOfNumbers()
        {
            // initializing total to 0
            int total = 0;

            //for loop to iterate and add the value
            for (int i = 1; i <= 10; i++)
            {
                //in every iteration i value is added up to total
                total += i;
            }
            //displaying the total
            Console.WriteLine("The Sum of all numbers from 1 to 10 is : " + total);
        }

    }
}