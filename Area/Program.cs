using System;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            //double r = -1;
            double r;
            double a;
            string input;

            Console.WriteLine("Enter a radius: ");
            input = Console.ReadLine();
            r = double.Parse(input);

            while (r < 0)
            {
                Console.WriteLine("Please enter a number larger than 0.\nEnter a radius: ");
                input = Console.ReadLine();
                r = double.Parse(input);
            }

            a = Math.PI * r * r;
            Console.WriteLine("The are of a circle with radius " + r + " is: " + a);
            Console.ReadLine();
        }
    }
}
