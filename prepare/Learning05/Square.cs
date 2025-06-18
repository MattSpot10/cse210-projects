using System.Drawing;

class Square : Shape
{
    double _size;
    
    public Square(string color, double size) : base(color)
    {
        _size = size;
    }

    public override double GetArea()
    {
        return _size * _size;
    }
}