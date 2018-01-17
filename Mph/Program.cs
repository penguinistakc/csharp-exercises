using System;

namespace Mph
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Miles Traveled: ");
            double milesPerHour = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Gallons Used: ");
            double gallonsUsed = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Your mileage is " + (milesPerHour / gallonsUsed));
            Console.ReadLine();
        }
    }
}
