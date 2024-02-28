using System;

interface IFurniture
{
    string Material { get; set; }
    decimal Price { get; set; }
}

interface ITable
{
    int Height { get; set; }
    double SurfaceArea { get; set; }
}

class Table : IFurniture, ITable
{
    public string Material { get; set; }
    public decimal Price { get; set; }
    public int Height { get; set; }
    public double SurfaceArea { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Table table = new Table();

        Console.Write("Enter the material: ");
        table.Material = Console.ReadLine();

        Console.Write("Enter the price: ");
        table.Price = decimal.Parse(Console.ReadLine());

        Console.Write("Enter the height: ");
        table.Height = int.Parse(Console.ReadLine());

        Console.Write("Enter the surface area: ");
        table.SurfaceArea = double.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("-------------------------------------");
        Console.WriteLine();

        Console.WriteLine("Table Information:");
        Console.WriteLine($"Material: {table.Material}");
        Console.WriteLine($"Price: {table.Price}");
        Console.WriteLine($"Height: {table.Height}");
        Console.WriteLine($"Surface Area: {table.SurfaceArea}");

        Console.ReadLine();
    }
}