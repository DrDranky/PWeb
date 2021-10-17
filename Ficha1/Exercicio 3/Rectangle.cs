namespace Ex3
{
    public class Rectangle : FlatFigure
    {
        private readonly double _length, _width;

        public Rectangle(double length, double height)
        {
            _length = length;
            _width = height;
        }
        
        public override double Area() => _width * _length;
        public override double Perimeter() => _width * 2 + _length * 2;
        
        public override string ToString() => "Rectangle: Length = " + _length + " Width = " + _width;
    }
}