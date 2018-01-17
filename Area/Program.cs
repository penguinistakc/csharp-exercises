using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string announcement = "What is the radius of your circle: ";
                Console.WriteLine(announcement);
                string radius = Console.ReadLine();

                int doubleRadius = 0;
                if (int.TryParse(radius, out doubleRadius))
                {
                    double area = Math.PI * doubleRadius * doubleRadius;
                    Console.WriteLine(string.Format("The area of your circle is {0:0.00}", area));

                }
                else
                {
                    Console.WriteLine("you did not enter a valid number! ");
                }



                // Console.WriteLine("Your radius is: " + (Math.PI * radius * radius));

                
            }
        }
    }
}
