using System;

namespace Ex3
{
    public class Circle : FlatFigure
    {
        private readonly double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public override double Area() => Math.PI * Math.Pow(_radius,2);

        public override double Perimeter() => 2 * Math.PI * _radius;

        public override string ToString() => "Circle: Radius = " + _radius;
    }
}