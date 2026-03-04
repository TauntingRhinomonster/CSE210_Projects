using System;
// Practice the principle of polymorphism by writing a program that computes the areas of different shapes cut out of pieces of paper.
// For all shapes, you need to keep track of the color of the paper and then have a method to compute the area. The area should not be stored as a member variable, but instead, you should store the length of the shapes sides and then compute the area as needed.
// Your program should include squares (which store a color and a single side), rectangles (which store a color and two sides), and a circle (which store a color and a radius). You should create several kinds of shapes and put them into a single list. Then, iterate through the list and display their areas.
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning05 World!");
        Square square = new Square("Red", 180.25);
        Rectangle rectangle = new Rectangle("Green", 180.25, 12);
        Circle circle = new Circle("Blue", 18.75);
        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.ReturnInfo());
        }

        // Console.WriteLine(square.ReturnInfo());
        // Console.WriteLine(rectangle.ReturnInfo());
        // Console.WriteLine(circle.ReturnInfo());
    }
}