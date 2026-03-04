using System;

class Circle : Shape
{
    // Variables
    double _radius;
    // Constructors
    public Circle(string color, double radius) : base(color)
    {
        SetShape("circle");
        _radius = radius;
    }
    // Methods
    public override double GetArea()
    {
        return Math.PI * _radius * _radius;
    }
    public double GetRadius()
    {
        return _radius;
    }
    public void SetRadius(double radius)
    {
        _radius = radius;
    }
}