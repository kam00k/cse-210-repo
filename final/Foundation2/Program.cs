using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Paul Bunyun", "65 Exeter Road", "Brentwood", "NH", "USA");
        order1.AddProduct("Bananas", "6014", 0.59, 6);
        order1.AddProduct("Nutmeg", "3022", 6.99, 2);
        order1.AddProduct("Bread flour, 25lb", "502", 11.65, 6);

        Console.WriteLine("\n--Order 1--");
        Console.WriteLine(order1.PrintPackingLabel());
        Console.WriteLine(order1.PrintShippingLabel());
        Console.WriteLine($"Total Price: ${order1.CalcTotalPrice():F2}");

        Order order2 = new Order("Antoine Lavoisier", "12-32 Fromage Road", "Montreal", "Quebec", "Canada");
        order2.AddProduct("Croissant", "1032", 3.47, 20);
        order2.AddProduct("Garlic, each", "1228", 2.49, 5);
        order2.AddProduct("Hat, Fedora", "1346", 12.88, 2);

        Console.WriteLine("\n--Order 2--");
        Console.WriteLine(order2.PrintPackingLabel());
        Console.WriteLine(order2.PrintShippingLabel());
        Console.WriteLine($"Total Price: ${order2.CalcTotalPrice():F2}");

    }
}