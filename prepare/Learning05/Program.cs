using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Circle circle = new Circle("red", 7.6);
        Rectangle rangle = new Rectangle("green", 19.3, 20.4);
        Square square = new Square("yellow", 92.2);
        Console.WriteLine(circle.getColor());
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(rangle.getColor());
        Console.WriteLine(rangle.GetArea());
        Console.WriteLine(square.getColor());
        Console.WriteLine(square.GetArea());
    }
}