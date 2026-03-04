using System;
// Practice the principle of polymorphism by writing a program that computes the areas of different shapes cut out of pieces of paper.
// For all shapes, you need to keep track of the color of the paper and then have a method to compute the area. The area should not be stored as a member variable, but instead, you should store the length of the shapes sides and then compute the area as needed.
// Your program should include squares (which store a color and a single side), rectangles (which store a color and two sides), and a circle (which store a color and a radius). You should create several kinds of shapes and put them into a single list. Then, iterate through the list and display their areas.
abstract class Shape
{
    // Variables
    private string _shape;
    private string _color;
    // Constructor
    public Shape(string color)
    {
        _color = color;
    }
    // Methods
    // Here is my method for getting the area. It does nothing on its own...
    public abstract double GetArea();
    public string GetShape()
    {
        return _shape;
    }
    public void SetShape(string shape)
    {
        _shape = shape;
    }
    public string GetColor()
    {
        return _color;
    }
    public void SetColor(string color)
    {
        _color = color;
    }
    public string ReturnInfo()
    {
        string info = $"\nThis is a {GetShape()}.\nIt is {GetColor()}.\nIt has an area of {GetArea()} units squared.\n";
        return info;
    }
}