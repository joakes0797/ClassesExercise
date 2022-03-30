using System;

namespace ClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Car
            {
                Make = "Toyota",
                Model = "Camry",
                Year = 2014
            };

            Console.WriteLine($"Would you like to drive a {myCar.Year} {myCar.Make} {myCar.Model}?  It's a decent car.");
        }
    }
}
