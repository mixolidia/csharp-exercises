using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RectangleAreaNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            double w;
            double l;
            double ra;
            string input;

            Console.WriteLine("To get the area of a rectangle we need the width and length." +
                "\n What is the width?");
            input = Console.ReadLine();
            w = double.Parse(input);
            Console.WriteLine("What is the lenght?");
            input = Console.ReadLine();
            l = double.Parse(input);

            ra = w * l;
            Console.WriteLine("A rectangle with the width of " + w + " and the length of "
                + l + " has an area of " + ra + ".");
            Console.ReadLine();
        }
    }
}
