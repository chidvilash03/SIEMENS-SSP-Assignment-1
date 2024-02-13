using System;

namespace CarNameSpace
{
    //Define the Car class
    class Car
    {
        //Properties
        public string Make;
        public string Model;
        public int Year;
        public double Mileage;

        //Constructor to initialize the Car object
        public Car(string make, string model, int year, double mileage)
        {
            Make = make;
            Model = model;
            Year = year;
            Mileage = mileage;
        }
        //Method to display Car information
        public void DisplayInfo()
        {
            Console.WriteLine("Car Information...");
            Console.WriteLine("The car make is: " + Make);
            Console.WriteLine("The car model is: " + Model);
            Console.WriteLine("The car was manfactured in the year: " + Year);
            Console.WriteLine("The car has been driven for: " + Mileage + " KMPL\n");
        }

    }

}