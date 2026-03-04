using System;

class Square : Shape
{
    // Variables
    double _side;
    // Constructors
    public Square(string color, double side) : base(color)
    {
        SetShape("square");
        _side = side;
    }
    // Methods
    public override double GetArea()
    {
        return _side * _side;
    }
    public double GetSide()
    {
        return _side;
    }
    public void SetSide(double side)
    {
        _side = side;
    }
}