using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapeList = new List<Shape>();

        shapeList.Add(new Square("blue", 5));
        shapeList.Add(new Rectangle ("red", 4, 3));
        shapeList.Add(new Circle ("yellow", 2.4));

        foreach (var thing in shapeList)
        {
            Console.WriteLine(thing.getColor());
            Console.WriteLine(thing.GetArea() + "\n");
        }
        

    }
}