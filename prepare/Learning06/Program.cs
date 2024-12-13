using System;

class Program
{
    static void Main(string[] args)
    {
        Square s = new Square("blue",5);
        Retangle r = new ("orange",5,2);
        Circle c = new ("green",5);

        List<Shape> shapes = [];
        shapes.Add(s);
        shapes.Add(r);
        shapes.Add(c);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"Color: {shape.GetColor()}\t & Area: {shape.GetArea():N2}");
        }


    }
}