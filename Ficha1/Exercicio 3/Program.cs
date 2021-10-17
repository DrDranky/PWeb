using System;
using System.Collections.Generic;

namespace Ex3
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            //just for test
            var flatFigures = new List<FlatFigure>
            {
                new Rectangle(5, 6),
                new Triangle(3, 4, 5),
                new Circle(7)
            };

            foreach (var figure in flatFigures)
            {
                Console.WriteLine(figure.ToString());
                Console.WriteLine("Area = " + Math.Round(figure.Area(),2) + " Perimeter = " +
                                  Math.Round(figure.Perimeter(),2) + "\n\n");
            }
        }
    }
}