using System;

namespace Ex3
{
    public class Triangle : FlatFigure
    {
        private readonly double _sideA, _sideB, _sideC, _semiPerimeter;

        public Triangle(double sideA, double sideB, double sideC)
        {
            _sideA = sideA;
            _sideB = sideB;
            _sideC = sideC;
            _semiPerimeter = (sideA + sideB + sideC) / 2;
        }

        //Area of Triangle Using Heron's Formula
        public override double Area() => Math.Sqrt(_semiPerimeter * (_semiPerimeter - _sideA) *
                                                   (_semiPerimeter - _sideB) * (_semiPerimeter - _sideC));

        public override double Perimeter() => _semiPerimeter * 2;

        public override string ToString() =>
            "Triangle: Side A = " + _sideA + " Side B = " + _sideB + " Side C = " + _sideC;
    }
}