using System;

class Rectangle : Shape
{
    // Variables
    double _length;
    double _width;
    // Constructors
    public Rectangle(string color, double length, double width) : base(color)
    {
        SetShape("rectangle");
        _length = length;
        _width = width;
    }
    // Methods
    public override double GetArea()
    {
        return _length * _width;
    }
    public double GetLength()
    {
        return _length;
    }
    public void SetLength(double length)
    {
        _length = length;
    }
    public double GetWidth()
    {
        return _width;
    }
    public void SetWidth(double width)
    {
        _width = width;
    }
}