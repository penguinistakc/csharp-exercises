using System;

namespace RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please specify width of rectangle: ");
            double inputWidth = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please specify height of rectangle: ");
            double inputHeight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The area of your triangle is " + (inputWidth * inputHeight));
            Console.ReadLine();

           

        }

        static void ForClass(int var1, int var2)
        {
            //variable = condition ? ifTrue : ifFalse;
            int someNumber = var1 < var2 ? var1 : var2;
        }
    }
}
